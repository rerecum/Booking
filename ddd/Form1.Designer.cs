
namespace ddd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataDzisiaj = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KosztLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataPrzyjazdu = new System.Windows.Forms.DateTimePicker();
            this.dataWyjazdu = new System.Windows.Forms.DateTimePicker();
            this.DoWyjazduPozostaloLabel = new System.Windows.Forms.TextBox();
            this.WyjazdTrwaLabel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CenaZaDobe = new System.Windows.Forms.NumericUpDown();
            this.GRAMOFON = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CenaZaDobe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDzisiaj
            // 
            this.dataDzisiaj.Enabled = false;
            this.dataDzisiaj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataDzisiaj.Location = new System.Drawing.Point(300, 12);
            this.dataDzisiaj.Name = "dataDzisiaj";
            this.dataDzisiaj.Size = new System.Drawing.Size(200, 23);
            this.dataDzisiaj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data przyjazdu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data wyjazdu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "cena za 24h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Do wyjazdu pozostalo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dlugosc wyjazdu to";
            // 
            // KosztLabel
            // 
            this.KosztLabel.AutoSize = true;
            this.KosztLabel.ForeColor = System.Drawing.Color.Peru;
            this.KosztLabel.Location = new System.Drawing.Point(291, 476);
            this.KosztLabel.Name = "KosztLabel";
            this.KosztLabel.Size = new System.Drawing.Size(13, 15);
            this.KosztLabel.TabIndex = 9;
            this.KosztLabel.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(111, 153);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 23);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dataPrzyjazdu
            // 
            this.dataPrzyjazdu.Location = new System.Drawing.Point(111, 202);
            this.dataPrzyjazdu.Name = "dataPrzyjazdu";
            this.dataPrzyjazdu.Size = new System.Drawing.Size(218, 23);
            this.dataPrzyjazdu.TabIndex = 16;
            // 
            // dataWyjazdu
            // 
            this.dataWyjazdu.Location = new System.Drawing.Point(111, 248);
            this.dataWyjazdu.Name = "dataWyjazdu";
            this.dataWyjazdu.Size = new System.Drawing.Size(218, 23);
            this.dataWyjazdu.TabIndex = 17;
            // 
            // DoWyjazduPozostaloLabel
            // 
            this.DoWyjazduPozostaloLabel.Location = new System.Drawing.Point(145, 375);
            this.DoWyjazduPozostaloLabel.Name = "DoWyjazduPozostaloLabel";
            this.DoWyjazduPozostaloLabel.Size = new System.Drawing.Size(219, 23);
            this.DoWyjazduPozostaloLabel.TabIndex = 18;
            // 
            // WyjazdTrwaLabel
            // 
            this.WyjazdTrwaLabel.Location = new System.Drawing.Point(145, 424);
            this.WyjazdTrwaLabel.Name = "WyjazdTrwaLabel";
            this.WyjazdTrwaLabel.Size = new System.Drawing.Size(219, 23);
            this.WyjazdTrwaLabel.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "oblicz kosztorys";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CenaZaDobe
            // 
            this.CenaZaDobe.Location = new System.Drawing.Point(111, 296);
            this.CenaZaDobe.Name = "CenaZaDobe";
            this.CenaZaDobe.Size = new System.Drawing.Size(120, 23);
            this.CenaZaDobe.TabIndex = 21;
            // 
            // GRAMOFON
            // 
            this.GRAMOFON.AutoSize = true;
            this.GRAMOFON.Location = new System.Drawing.Point(327, 38);
            this.GRAMOFON.Name = "GRAMOFON";
            this.GRAMOFON.Size = new System.Drawing.Size(146, 15);
            this.GRAMOFON.TabIndex = 22;
            this.GRAMOFON.Text = "GRAMOFON FORMULARZ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.GRAMOFON);
            this.Controls.Add(this.CenaZaDobe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WyjazdTrwaLabel);
            this.Controls.Add(this.DoWyjazduPozostaloLabel);
            this.Controls.Add(this.dataWyjazdu);
            this.Controls.Add(this.dataPrzyjazdu);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.KosztLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataDzisiaj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CenaZaDobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataDzisiaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label KosztLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dataPrzyjazdu;
        private System.Windows.Forms.DateTimePicker dataWyjazdu;
        private System.Windows.Forms.TextBox DoWyjazduPozostaloLabel;
        private System.Windows.Forms.TextBox WyjazdTrwaLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown CenaZaDobe;
        private System.Windows.Forms.Label GRAMOFON;
    }
}

