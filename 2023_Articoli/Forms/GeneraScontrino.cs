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
    public partial class GeneraScontrino : Form
    {
        public GeneraScontrino()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Articolo articolo= new Articolo();
            
            MessageBox.Show(articolo.GeneraScontrino());

        }

        private void GeneraScontrino_Load(object sender, EventArgs e)
        {
          
           


        }
    }
}
