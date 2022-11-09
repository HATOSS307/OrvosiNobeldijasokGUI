using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OrvosiNobeldijasokGUI
{
    public partial class Ev : Form
    {
        public Ev()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ellenor = 0;
            if (string.IsNullOrEmpty(Eves.Text) || string.IsNullOrEmpty(Nev.Text) || string.IsNullOrEmpty(szh.Text) || string.IsNullOrEmpty(orszag.Text))
            {
                MessageBox.Show("Hiba");
                return;
            }
            else
            {
                ellenor = Convert.ToInt32(Eves.Text);
                if (!(ellenor > 1989))
                {
                    MessageBox.Show("Hiba! Az évszám nem megfelelő!");
                }
                else
                {
                    try
                    {
                        if (!File.Exists("uj_dijazott.txt"))
                        {
                            File.WriteAllText("uj_dijazott.txt", "Év;Név;SzületésHalálozás;Országkód\n");
                            File.AppendAllText("uj_dijazott.txt", $"{Eves.Text};{Nev.Text};{szh.Text};{orszag.Text}\n");

                        }
                        else
                        {
                            File.AppendAllText("uj_dijazott.txt", $"{Eves.Text};{Nev.Text};{szh.Text};{orszag.Text}\n");
                        }
                    }
                    catch (Exception x )
                    {

                        MessageBox.Show(Convert.ToString(x)); ;
                    }
                    Eves.Clear();
                    Nev.Clear();
                    szh.Clear();
                    orszag.Clear();

                }
            }
        }
    }
}
