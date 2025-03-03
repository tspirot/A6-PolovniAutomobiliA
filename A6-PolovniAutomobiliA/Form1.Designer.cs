namespace A6_PolovniAutomobiliA
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonIzadji = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.textBoxSifra = new System.Windows.Forms.TextBox();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.comboBoxProizvodjac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.buttonIzadji);
            this.tabPage1.Controls.Add(this.buttonIzmeni);
            this.tabPage1.Controls.Add(this.textBoxSifra);
            this.tabPage1.Controls.Add(this.textBoxNaziv);
            this.tabPage1.Controls.Add(this.comboBoxProizvodjac);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modeli automobila";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::A6_PolovniAutomobiliA.Properties.Resources.search;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.Location = new System.Drawing.Point(721, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(49, 48);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(400, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 308);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonIzadji
            // 
            this.buttonIzadji.Location = new System.Drawing.Point(148, 221);
            this.buttonIzadji.Name = "buttonIzadji";
            this.buttonIzadji.Size = new System.Drawing.Size(151, 36);
            this.buttonIzadji.TabIndex = 19;
            this.buttonIzadji.Text = "Izadji";
            this.buttonIzadji.UseVisualStyleBackColor = true;
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(148, 163);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(151, 36);
            this.buttonIzmeni.TabIndex = 18;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // textBoxSifra
            // 
            this.textBoxSifra.Location = new System.Drawing.Point(606, 37);
            this.textBoxSifra.Name = "textBoxSifra";
            this.textBoxSifra.Size = new System.Drawing.Size(100, 22);
            this.textBoxSifra.TabIndex = 17;
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(121, 78);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(178, 22);
            this.textBoxNaziv.TabIndex = 16;
            // 
            // comboBoxProizvodjac
            // 
            this.comboBoxProizvodjac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProizvodjac.FormattingEnabled = true;
            this.comboBoxProizvodjac.Location = new System.Drawing.Point(121, 37);
            this.comboBoxProizvodjac.Name = "comboBoxProizvodjac";
            this.comboBoxProizvodjac.Size = new System.Drawing.Size(178, 24);
            this.comboBoxProizvodjac.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Proizvodjac";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Uputstvo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Godište";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "od:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "do:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kilometraža (max)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Broj raspolozivih vozila";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonIzadji;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.TextBox textBoxSifra;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.ComboBox comboBoxProizvodjac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

