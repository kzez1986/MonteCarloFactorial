namespace CałkaMonteCarlo
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
            this.tbPoczątek = new System.Windows.Forms.TextBox();
            this.tbKoniec = new System.Windows.Forms.TextBox();
            this.laPoczątek = new System.Windows.Forms.Label();
            this.laKoniec = new System.Windows.Forms.Label();
            this.laFunkcja = new System.Windows.Forms.Label();
            this.cbWybierzFunkcję = new System.Windows.Forms.ComboBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.laA = new System.Windows.Forms.Label();
            this.laB = new System.Windows.Forms.Label();
            this.laC = new System.Windows.Forms.Label();
            this.buObliczCałkę = new System.Windows.Forms.Button();
            this.lbWyniki = new System.Windows.Forms.ListBox();
            this.laWyniki = new System.Windows.Forms.Label();
            this.laIleLosowań = new System.Windows.Forms.Label();
            this.tbIleLosowań = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPoczątek
            // 
            this.tbPoczątek.Location = new System.Drawing.Point(13, 28);
            this.tbPoczątek.Name = "tbPoczątek";
            this.tbPoczątek.Size = new System.Drawing.Size(123, 20);
            this.tbPoczątek.TabIndex = 0;
            // 
            // tbKoniec
            // 
            this.tbKoniec.Location = new System.Drawing.Point(146, 28);
            this.tbKoniec.Name = "tbKoniec";
            this.tbKoniec.Size = new System.Drawing.Size(100, 20);
            this.tbKoniec.TabIndex = 1;
            // 
            // laPoczątek
            // 
            this.laPoczątek.AutoSize = true;
            this.laPoczątek.Location = new System.Drawing.Point(13, 9);
            this.laPoczątek.Name = "laPoczątek";
            this.laPoczątek.Size = new System.Drawing.Size(107, 13);
            this.laPoczątek.TabIndex = 2;
            this.laPoczątek.Text = "Początek przedziału:";
            // 
            // laKoniec
            // 
            this.laKoniec.AutoSize = true;
            this.laKoniec.Location = new System.Drawing.Point(143, 9);
            this.laKoniec.Name = "laKoniec";
            this.laKoniec.Size = new System.Drawing.Size(95, 13);
            this.laKoniec.TabIndex = 3;
            this.laKoniec.Text = "Koniec przedziału:";
            // 
            // laFunkcja
            // 
            this.laFunkcja.AutoSize = true;
            this.laFunkcja.Location = new System.Drawing.Point(13, 67);
            this.laFunkcja.Name = "laFunkcja";
            this.laFunkcja.Size = new System.Drawing.Size(86, 13);
            this.laFunkcja.TabIndex = 4;
            this.laFunkcja.Text = "Wybierz funkcję:";
            // 
            // cbWybierzFunkcję
            // 
            this.cbWybierzFunkcję.FormattingEnabled = true;
            this.cbWybierzFunkcję.Items.AddRange(new object[] {
            "ax + b",
            "ax ^ 2 + bx + c",
            "1 / x"});
            this.cbWybierzFunkcję.Location = new System.Drawing.Point(13, 97);
            this.cbWybierzFunkcję.Name = "cbWybierzFunkcję";
            this.cbWybierzFunkcję.Size = new System.Drawing.Size(121, 21);
            this.cbWybierzFunkcję.TabIndex = 5;
            this.cbWybierzFunkcję.SelectedIndexChanged += new System.EventHandler(this.cbWybierzFunkcję_SelectedIndexChanged);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(20, 141);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 6;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(146, 141);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 7;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(20, 181);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 20);
            this.tbC.TabIndex = 8;
            // 
            // laA
            // 
            this.laA.AutoSize = true;
            this.laA.Location = new System.Drawing.Point(-3, 148);
            this.laA.Name = "laA";
            this.laA.Size = new System.Drawing.Size(17, 13);
            this.laA.TabIndex = 9;
            this.laA.Text = "A:";
            // 
            // laB
            // 
            this.laB.AutoSize = true;
            this.laB.Location = new System.Drawing.Point(127, 147);
            this.laB.Name = "laB";
            this.laB.Size = new System.Drawing.Size(17, 13);
            this.laB.TabIndex = 10;
            this.laB.Text = "B:";
            // 
            // laC
            // 
            this.laC.AutoSize = true;
            this.laC.Location = new System.Drawing.Point(-3, 188);
            this.laC.Name = "laC";
            this.laC.Size = new System.Drawing.Size(17, 13);
            this.laC.TabIndex = 11;
            this.laC.Text = "C:";
            // 
            // buObliczCałkę
            // 
            this.buObliczCałkę.Location = new System.Drawing.Point(115, 227);
            this.buObliczCałkę.Name = "buObliczCałkę";
            this.buObliczCałkę.Size = new System.Drawing.Size(75, 23);
            this.buObliczCałkę.TabIndex = 12;
            this.buObliczCałkę.Text = "Oblicz całkę";
            this.buObliczCałkę.UseVisualStyleBackColor = true;
            this.buObliczCałkę.Click += new System.EventHandler(this.buObliczCałkę_Click);
            // 
            // lbWyniki
            // 
            this.lbWyniki.FormattingEnabled = true;
            this.lbWyniki.Location = new System.Drawing.Point(288, 28);
            this.lbWyniki.Name = "lbWyniki";
            this.lbWyniki.Size = new System.Drawing.Size(294, 225);
            this.lbWyniki.TabIndex = 13;
            // 
            // laWyniki
            // 
            this.laWyniki.AutoSize = true;
            this.laWyniki.Location = new System.Drawing.Point(288, 8);
            this.laWyniki.Name = "laWyniki";
            this.laWyniki.Size = new System.Drawing.Size(42, 13);
            this.laWyniki.TabIndex = 14;
            this.laWyniki.Text = "Wyniki:";
            // 
            // laIleLosowań
            // 
            this.laIleLosowań.AutoSize = true;
            this.laIleLosowań.Location = new System.Drawing.Point(143, 67);
            this.laIleLosowań.Name = "laIleLosowań";
            this.laIleLosowań.Size = new System.Drawing.Size(60, 13);
            this.laIleLosowań.TabIndex = 15;
            this.laIleLosowań.Text = "Ile losowań";
            // 
            // tbIleLosowań
            // 
            this.tbIleLosowań.Location = new System.Drawing.Point(146, 97);
            this.tbIleLosowań.Name = "tbIleLosowań";
            this.tbIleLosowań.Size = new System.Drawing.Size(100, 20);
            this.tbIleLosowań.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 270);
            this.Controls.Add(this.tbIleLosowań);
            this.Controls.Add(this.laIleLosowań);
            this.Controls.Add(this.laWyniki);
            this.Controls.Add(this.lbWyniki);
            this.Controls.Add(this.buObliczCałkę);
            this.Controls.Add(this.laC);
            this.Controls.Add(this.laB);
            this.Controls.Add(this.laA);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.cbWybierzFunkcję);
            this.Controls.Add(this.laFunkcja);
            this.Controls.Add(this.laKoniec);
            this.Controls.Add(this.laPoczątek);
            this.Controls.Add(this.tbKoniec);
            this.Controls.Add(this.tbPoczątek);
            this.Name = "Form1";
            this.Text = "Całka oznaczona";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPoczątek;
        private System.Windows.Forms.TextBox tbKoniec;
        private System.Windows.Forms.Label laPoczątek;
        private System.Windows.Forms.Label laKoniec;
        private System.Windows.Forms.Label laFunkcja;
        private System.Windows.Forms.ComboBox cbWybierzFunkcję;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label laA;
        private System.Windows.Forms.Label laB;
        private System.Windows.Forms.Label laC;
        private System.Windows.Forms.Button buObliczCałkę;
        private System.Windows.Forms.ListBox lbWyniki;
        private System.Windows.Forms.Label laWyniki;
        private System.Windows.Forms.Label laIleLosowań;
        private System.Windows.Forms.TextBox tbIleLosowań;
    }
}

