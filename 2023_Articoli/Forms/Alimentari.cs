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
    public partial class Alimentari : Form
    {
        public Alimentari()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Alimentari_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leggi l'input dall'utente e crea un nuovo articolo fresco
            int codice = int.Parse(Codice.Text);
            string descrizione = Descrizione.Text;
            double prezzo = double.Parse(Prezzo.Text);
            int giorniConsumo = int.Parse(Anno.Text);
            bool haTessera = checkBox1.Checked;
            

           // Crea l'articolo fresco
           Articolo articolo = new ArticoloAlimentare(codice, descrizione, prezzo, giorniConsumo, haTessera);
            
        }
    }
}
