using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol_prvocislo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zjistit_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value != textBox1.Lines.Count())
                {
                    MessageBox.Show("Zadal jsi jiný počet prvků než N!", "Error");
                    return;
                }

                foreach (string radek in textBox1.Lines)
                {
                    int cislo = Convert.ToInt32(radek);

                    if (cislo >= 5 && cislo <= 120)
                    {
                        if (prvocislo(cislo))
                        {
                            MessageBox.Show("První prvočíslo ze zadaných čísel je " + cislo, "Výsledek");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Některé číslo se nenachází v intervalu <5;120>!", "Error");
                        return;
                    }
                }
                MessageBox.Show("V posloupnosti se nenachází žádné prvočíslo!", "Výsledek");
            }
            catch
            {
                MessageBox.Show("Zadal jsi špatné údaje!");
                return;
            }
        }

        private bool prvocislo (int cislo)
        {
            double cislo2 = cislo / 2;
            for (int i = 2; i <= cislo2; i++)
            {
                if (cislo % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
