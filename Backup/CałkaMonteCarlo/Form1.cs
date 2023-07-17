using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CałkaMonteCarlo
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbWybierzFunkcję.SelectedIndex = 0;
            laC.Enabled = false;
        }

        private void cbWybierzFunkcję_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbWybierzFunkcję.SelectedIndex)
            {
                case 0: tbA.Enabled = true; tbB.Enabled = true; tbC.Enabled = false; break;
                case 1: tbA.Enabled = true; tbB.Enabled = true; tbC.Enabled = true; break;
                case 2: tbA.Enabled = false; tbB.Enabled = false; tbC.Enabled = false; break;
            }
        }

        public double FunkcjaLiniowa(double a, double b, double x)
        {
            return a * x + b;
        }

        public double FunkcjaKwadratowa(double a, double b, double c, double x)
        {
            return a * a * x + b * x + c;
        }

        public double FunkcjaWykładnicza(double x)
        {
            if (x == 0) x = 0.001;
            return 1 / x;
        }

        private void buObliczCałkę_Click(object sender, EventArgs e)
        {
            Random los = new Random();
            long ile_losowań;
            double xp, xk, a, b, c;
            if (!long.TryParse(tbIleLosowań.Text, out ile_losowań))
            {
                MessageBox.Show("Zła ilość losowań");
                return;
            }
            if (!double.TryParse(tbPoczątek.Text, out xp))
            {
                MessageBox.Show("Zły początek przedziału");
                return;
            }
            if (!double.TryParse(tbKoniec.Text, out xk))
            {
                MessageBox.Show("Zły koniec przedziału");
                return;
            }
            if (xp == xk)
            {
                MessageBox.Show("Początek = koniec. Całka wynosi 0.");
                return;
            }
            if (xp > xk)
            {
                MessageBox.Show("Początek przedziału nie może być większy od końca.");
                return;
            }
            if (!double.TryParse(tbA.Text, out a) && tbA.Enabled == true)
            {
                MessageBox.Show("Zły parametr a");
                return;
            }
            if (!double.TryParse(tbB.Text, out b) && tbB.Enabled == true)
            {
                MessageBox.Show("Zły parametr b");
                return;
            }
            if (!double.TryParse(tbC.Text, out c) && tbC.Enabled == true)
            {
                MessageBox.Show("Zły parametr c");
                return;
            }
            double wylosowana, suma = 0;
            for (int i = 0; i < ile_losowań; i++)
            {
                wylosowana = los.NextDouble() * (xk - xp) + xp;
                switch (cbWybierzFunkcję.SelectedIndex)
                {
                    case 0: suma += FunkcjaLiniowa(a, b, wylosowana); break;
                    case 1: suma += FunkcjaKwadratowa(a, b, c, wylosowana); break;
                    case 2: suma += FunkcjaWykładnicza(wylosowana); break;
                }
            }
            suma = suma / (double)ile_losowań;
            suma = suma * (xk - xp);
            lbWyniki.Items.Add(suma.ToString());
        }
    }
}
