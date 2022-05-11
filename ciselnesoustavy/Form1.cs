using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciselnesoustavy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool JePrvocislo(int cislo)
        {
            if (cislo < 2) return false;
            if (cislo == 2) return true;
            for (int i = 3; i < Math.Sqrt(cislo); i += 2)
            {
                if (cislo % i == 0) return false;
            }
            return true;
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string prvocisla = " ";
                int n = int.Parse(maskedTextBox1.Text);
                int pocet = 0;
                for (int i = 0; i < n; i++)
                {
                    int cislo = rnd.Next(5, 120);
                    if (JePrvocislo(cislo))
                    {
                        pocet++;
                        prvocisla += " ";
                        prvocisla += cislo;
                    }
                }
                if (pocet > 0) MessageBox.Show("Prvočísla jsou:" + prvocisla,"Nalezeno prvočíslo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Žádné prvočíslo v posloupnosti není!", "Nenalezeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Nezadal jsi číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 
}
