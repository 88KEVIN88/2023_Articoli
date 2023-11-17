namespace _2023_Articoli.Forms
{
    partial class Alimentari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Codice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Descrizione = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prezzo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Anno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Codice
            // 
            this.Codice.Location = new System.Drawing.Point(12, 15);
            this.Codice.Name = "Codice";
            this.Codice.Size = new System.Drawing.Size(100, 20);
            this.Codice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codice";
            // 
            // Descrizione
            // 
            this.Descrizione.Location = new System.Drawing.Point(12, 53);
            this.Descrizione.Name = "Descrizione";
            this.Descrizione.Size = new System.Drawing.Size(100, 20);
            this.Descrizione.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrizione";
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(13, 96);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(100, 20);
            this.Prezzo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezzo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 165);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Tesserato";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(269, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(317, 316);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Anno
            // 
            this.Anno.Location = new System.Drawing.Point(13, 129);
            this.Anno.Name = "Anno";
            this.Anno.Size = new System.Drawing.Size(100, 20);
            this.Anno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Anno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alimentari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Anno);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Descrizione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Codice);
            this.Name = "Alimentari";
            this.Text = "Alimentari";
            this.Load += new System.EventHandler(this.Alimentari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Codice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Descrizione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Prezzo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox Anno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}