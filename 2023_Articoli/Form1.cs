using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_Articoli
{
    public partial class Form1 : Form
    {
        //fields
        private Button currentbutton;
        private Random random;
        private int tempindex;
        private Form activeform;


        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //methods
        private Color SelectThemeColor()
        {
            int index=random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private  void ActivateButton(object btnsender)
        {
            if(btnsender != null) 
            { 
                if(currentbutton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentbutton = (Button)btnsender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.White;
                    currentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitlebar.BackColor = color;
                    panel1Logo.BackColor = ThemeColor.ChangeColorBrightness(color ,-0.3);

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previusBtn in panelMenu.Controls)
            {
                if(previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(51,51,76);
                    previusBtn.ForeColor = Color.Gainsboro;
                    previusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childform, object btnsender)
        {
            if(activeform != null)
            {
                activeform.Close();
            }
            ActivateButton(btnsender);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelDekstopPanel.Controls.Add(childform);
            this.panelDekstopPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTitle.Text = childform.Text;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Alimentari(),sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Nalimentari(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Alimentari(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GeneraScontrino(), sender);
        }

        private void panelDekstopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
