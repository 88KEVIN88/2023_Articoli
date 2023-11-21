using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Schema;

namespace _2023_Articoli
{
    internal class Articolo
    {
        private int _codice;
        private string _descrizione;
        private double _prezzo;
        private bool _tessera;
       
        public Articolo(int codice, string descrizione, double prezzo, bool tessera)
        {
            Codice = codice; 
            Descrizione = descrizione; 
            Prezzo = prezzo; 
            Tessera = tessera; 
        }
        public Articolo()
        {
            Codice = 1;
            Descrizione = "";
            Prezzo = 1;
            Tessera = false;
        }
        public int Codice
        {
            get { return _codice; } 
            set
            {
                if(_codice >= 0)
                {
                   _codice = value;
                }
                else
                {
                    throw new ArgumentException("Valore del codice prodotto invalido");
                }
            }
        }
        public string Descrizione
        {
            get { return _descrizione; }
            set
            {
                if(value != null)
                {
                    _descrizione = value;
                }
                else
                {
                    throw new ArgumentException("Input non valido riprovare");
                }
            }
        }
        public double Prezzo
        {
            get { return _prezzo; }
            set
            {
                _prezzo = value;
                if(_prezzo > 0)
                {
                    _prezzo = value;
                }
                else
                {
                    throw new ArgumentException("Il prezzo deve essere > 0");
                }
            }
        }
        public bool Tessera
        {
            get { return _tessera; }
            set { _tessera = value; }
        }
        //Metodi
        public virtual double Sconta(bool tessera)
        {
            
            double prezzoScontato = _prezzo;
            if (tessera == true)
            {
                prezzoScontato *= 0.95;
            }
            return prezzoScontato;
        }
        //public string GeneraScontrino()
        //{
        //    double totale = 0;
        //    StringBuilder scontrino = new StringBuilder();
        //    foreach(var articolo in listaArticoli){
        //        articolo.Sconta(Tessera);
        //        scontrino.AppendLine($"Nome:{articolo.Descrizione}");
        //        scontrino.AppendLine($"Prezzo Unitario:{articolo.Prezzo}");
        //        totale += articolo.Prezzo;
        //        scontrino.AppendLine($"Totale:{totale}");
               
        //    }
        //    return scontrino.ToString();
        //}
        //public string OttieniElementi()
        //{
        //    StringBuilder s = new StringBuilder();
        //    foreach(var articolo in listaArticoli)
        //    {
        //        s.AppendLine($"Codice:{Codice},Descrizione:{Descrizione},Prezzo:{Prezzo}");
        //    }
        //    return s.ToString();
        //}
       
        class Cassa
        {
            public List<Articolo> listaArticoli { get; private set; } = new List<Articolo>();
            public void Aggiungi(Articolo articolo)
            {

                listaArticoli.Add(articolo);
            }
            public void Caricalistview(ListView listview)
            {
                listview.Items.Clear();
                foreach (var articolo in listaArticoli)
                {
                    ListViewItem item = new ListViewItem(articolo.Codice.ToString());
                    item.SubItems.Add(articolo.Descrizione);
                    item.SubItems.Add(articolo.Prezzo.ToString());
                    listview.Items.Add(item);
                }
            }
        }
    }
}
