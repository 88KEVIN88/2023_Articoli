using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_Articoli
{
    internal class AlimentareFresco : ArticoloAlimentare
    {
        public int _GiorniConsumo;
        public int Giorni
        {
            get { return _GiorniConsumo;}
            set
            {
                if(_GiorniConsumo > 0 && _GiorniConsumo < 6)
                {
                    _GiorniConsumo = value;
                }
                else
                {
                    throw new ArgumentException("Il numero di giorni deve essere compreso fra 1 e 5");
                }
            }
        }

        public AlimentareFresco(int codice, string descrizione, double prezzo, int annoScadenza, int giorniConsumo,bool tessera)
            : base(codice, descrizione, prezzo, annoScadenza,tessera)
        {
            _GiorniConsumo = giorniConsumo;
        }

        public override double Sconta(bool tessera)
        {
            base.Sconta(tessera);

            // Sconto aggiuntivo in base ai giorni di consumo
            double percentualeSconto = _GiorniConsumo * 2.0;
            Prezzo *= (1.0 - (percentualeSconto / 100));
            return Prezzo;
        }
    }
}
