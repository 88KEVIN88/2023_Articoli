using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_Articoli
{
    internal class ArticoloNonAlimentare:Articolo
    {
        public string Materiale;
        public string mat
        {
            get { return Materiale; }
            set
            {
                if(Materiale != null)
                { 
                   Materiale = value;
                }
                else
                {
                    throw new ArgumentException("Il materiale deve essere scritto");
                }
            }
        }
        public bool Riciclabile { get; set; }

        public ArticoloNonAlimentare(int codice, string descrizione, double prezzo, string materiale, bool riciclabile,bool tessera)
            : base(codice, descrizione, prezzo,tessera)
        {
            Materiale = materiale;
            Riciclabile = riciclabile;
        }

        public override double Sconta(bool tessera)
        {
            base.Sconta(tessera);

            // Sconto aggiuntivo del 10% se il materiale è riciclabile
            if (Riciclabile)
            {
                Prezzo *= 0.9;
            }
            return Prezzo;
        }
    }
}
