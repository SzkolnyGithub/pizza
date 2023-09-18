
namespace pizzaBadowski4c
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.salata = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ser = new System.Windows.Forms.CheckBox();
            this.szynka = new System.Windows.Forms.CheckBox();
            this.pomidory = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.duza = new System.Windows.Forms.RadioButton();
            this.srednia = new System.Windows.Forms.RadioButton();
            this.mala = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cienkie = new System.Windows.Forms.RadioButton();
            this.grube = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cena = new System.Windows.Forms.Label();
            this.oblicz = new System.Windows.Forms.Button();
            this.rodzaj = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // salata
            // 
            this.salata.AutoSize = true;
            this.salata.Location = new System.Drawing.Point(6, 19);
            this.salata.Name = "salata";
            this.salata.Size = new System.Drawing.Size(58, 17);
            this.salata.TabIndex = 0;
            this.salata.Text = "Sałata";
            this.salata.UseVisualStyleBackColor = true;
            this.salata.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ser);
            this.groupBox1.Controls.Add(this.szynka);
            this.groupBox1.Controls.Add(this.pomidory);
            this.groupBox1.Controls.Add(this.salata);
            this.groupBox1.Location = new System.Drawing.Point(283, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodatki";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ser
            // 
            this.ser.AutoSize = true;
            this.ser.Location = new System.Drawing.Point(6, 87);
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(42, 17);
            this.ser.TabIndex = 3;
            this.ser.Text = "Ser";
            this.ser.UseVisualStyleBackColor = true;
            this.ser.CheckedChanged += new System.EventHandler(this.ser_CheckedChanged);
            // 
            // szynka
            // 
            this.szynka.AutoSize = true;
            this.szynka.Location = new System.Drawing.Point(6, 64);
            this.szynka.Name = "szynka";
            this.szynka.Size = new System.Drawing.Size(61, 17);
            this.szynka.TabIndex = 2;
            this.szynka.Text = "Szynka";
            this.szynka.UseVisualStyleBackColor = true;
            this.szynka.CheckedChanged += new System.EventHandler(this.szynka_CheckedChanged);
            // 
            // pomidory
            // 
            this.pomidory.AutoSize = true;
            this.pomidory.Location = new System.Drawing.Point(6, 41);
            this.pomidory.Name = "pomidory";
            this.pomidory.Size = new System.Drawing.Size(69, 17);
            this.pomidory.TabIndex = 1;
            this.pomidory.Text = "Pomidory";
            this.pomidory.UseVisualStyleBackColor = true;
            this.pomidory.CheckedChanged += new System.EventHandler(this.pomidory_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.duza);
            this.groupBox2.Controls.Add(this.srednia);
            this.groupBox2.Controls.Add(this.mala);
            this.groupBox2.Location = new System.Drawing.Point(36, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rozmiar";
            // 
            // duza
            // 
            this.duza.AutoSize = true;
            this.duza.Location = new System.Drawing.Point(6, 65);
            this.duza.Name = "duza";
            this.duza.Size = new System.Drawing.Size(50, 17);
            this.duza.TabIndex = 2;
            this.duza.TabStop = true;
            this.duza.Text = "Duża";
            this.duza.UseVisualStyleBackColor = true;
            this.duza.CheckedChanged += new System.EventHandler(this.duza_CheckedChanged);
            // 
            // srednia
            // 
            this.srednia.AutoSize = true;
            this.srednia.Location = new System.Drawing.Point(6, 42);
            this.srednia.Name = "srednia";
            this.srednia.Size = new System.Drawing.Size(61, 17);
            this.srednia.TabIndex = 1;
            this.srednia.TabStop = true;
            this.srednia.Text = "Średnia";
            this.srednia.UseVisualStyleBackColor = true;
            this.srednia.CheckedChanged += new System.EventHandler(this.srednia_CheckedChanged);
            // 
            // mala
            // 
            this.mala.AutoSize = true;
            this.mala.Location = new System.Drawing.Point(6, 19);
            this.mala.Name = "mala";
            this.mala.Size = new System.Drawing.Size(50, 17);
            this.mala.TabIndex = 0;
            this.mala.TabStop = true;
            this.mala.Text = "Mała";
            this.mala.UseVisualStyleBackColor = true;
            this.mala.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cienkie);
            this.groupBox3.Controls.Add(this.grube);
            this.groupBox3.Location = new System.Drawing.Point(283, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 72);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ciasto";
            // 
            // cienkie
            // 
            this.cienkie.AutoSize = true;
            this.cienkie.Location = new System.Drawing.Point(6, 42);
            this.cienkie.Name = "cienkie";
            this.cienkie.Size = new System.Drawing.Size(60, 17);
            this.cienkie.TabIndex = 1;
            this.cienkie.TabStop = true;
            this.cienkie.Text = "Cienkie";
            this.cienkie.UseVisualStyleBackColor = true;
            this.cienkie.CheckedChanged += new System.EventHandler(this.cienkie_CheckedChanged);
            // 
            // grube
            // 
            this.grube.AutoSize = true;
            this.grube.Location = new System.Drawing.Point(6, 19);
            this.grube.Name = "grube";
            this.grube.Size = new System.Drawing.Size(54, 17);
            this.grube.TabIndex = 0;
            this.grube.TabStop = true;
            this.grube.Text = "Grube";
            this.grube.UseVisualStyleBackColor = true;
            this.grube.CheckedChanged += new System.EventHandler(this.grube_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(36, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cena";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cena
            // 
            this.cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cena.Location = new System.Drawing.Point(280, 382);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(238, 24);
            this.cena.TabIndex = 6;
            this.cena.Text = "cenaTu";
            this.cena.Click += new System.EventHandler(this.cena_Click);
            // 
            // oblicz
            // 
            this.oblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.oblicz.Location = new System.Drawing.Point(36, 309);
            this.oblicz.Name = "oblicz";
            this.oblicz.Size = new System.Drawing.Size(100, 50);
            this.oblicz.TabIndex = 7;
            this.oblicz.Text = "Oblicz cenę";
            this.oblicz.UseVisualStyleBackColor = true;
            this.oblicz.Click += new System.EventHandler(this.oblicz_Click);
            // 
            // rodzaj
            // 
            this.rodzaj.FormattingEnabled = true;
            this.rodzaj.Items.AddRange(new object[] {
            "Margherita",
            "Pepperoni",
            "New Yorker",
            "Hawajska",
            "Jalapeno"});
            this.rodzaj.Location = new System.Drawing.Point(36, 206);
            this.rodzaj.Name = "rodzaj";
            this.rodzaj.Size = new System.Drawing.Size(121, 21);
            this.rodzaj.TabIndex = 8;
            this.rodzaj.Text = "Rodzaj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 478);
            this.Controls.Add(this.rodzaj);
            this.Controls.Add(this.oblicz);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox salata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ser;
        private System.Windows.Forms.CheckBox szynka;
        private System.Windows.Forms.CheckBox pomidory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton duza;
        private System.Windows.Forms.RadioButton srednia;
        private System.Windows.Forms.RadioButton mala;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton cienkie;
        private System.Windows.Forms.RadioButton grube;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.Button oblicz;
        private System.Windows.Forms.ComboBox rodzaj;
    }
}

