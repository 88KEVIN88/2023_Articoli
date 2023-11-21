using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_Articoli.Forms
{
    public partial class Nalimentari : Form
    {
        public Nalimentari()
        {
            InitializeComponent();
        }

        private void Nalimentari_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Leggi l'input dall'utente e crea un nuovo articolo fresco
            int codice = int.Parse(Codice.Text);
            string descrizione = Descrizione.Text;
            double prezzo = double.Parse(Prezzo.Text);
           
            bool haTessera = checkBox1.Checked;
            bool riciclabile = checkBox2.Checked;

            // Crea l'articolo fresco
            Articolo articolo = new ArticoloNonAlimentare(codice, descrizione, prezzo, haTessera, riciclabile);
            listView1.Items.Add($"Codice:{codice},Descrizione:{descrizione},Prezzo:{prezzo},Tessera:{haTessera},Riciclabile:{riciclabile}");
        }
    }
}
