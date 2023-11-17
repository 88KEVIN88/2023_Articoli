using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Articoli
{
    internal class ArticoloAlimentare : Articolo
    {
        private int _anno;
        public int AnnoScadenza
        {
            get { return _anno; }
            set 
            {
                _anno = value;
                if(_anno != 0 )
                {
                    _anno = value;
                }
                else
                {
                    throw new ArgumentException("L'anno di scadenza non puó essere 0");
                }
            }
        }
        public ArticoloAlimentare(int codice, string descrizione, double prezzo, int annoScadenza,bool tessera)
            : base(codice, descrizione, prezzo,tessera)
        {
            AnnoScadenza = annoScadenza;
        }
        public override double Sconta(bool tessera)
        {
            base.Sconta(tessera);

            // Sconto aggiuntivo del 20% se l'anno di scadenza coincide con quello attuale
            if (DateTime.Now.Year == AnnoScadenza)
            {
                Prezzo *= 0.8;
            }
            return Prezzo;
        }

    }
}
