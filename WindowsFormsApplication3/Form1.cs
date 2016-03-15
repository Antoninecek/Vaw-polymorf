using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public ArrayList holici = new ArrayList();
        //public ArrayList zakaznici = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String jmeno = jmenoT.Text;
            String prijmeni = prijmeniT.Text;
            bool holic = jeHolic.Checked;
            if (holic)
            {
                Osoba h = new Holic(jmeno, prijmeni);
                holici.Add(h);
                holiciLB.Items.Add(h.getJmeno());
            }
            else
            {
                try {
                    String a = holiciLB.SelectedItem.ToString();
                    Osoba z = new Zakaznik(jmeno, prijmeni);
                    //zakaznici.Add(z);

                    foreach (Holic h in holici)
                    {
                        if (a.Equals(h.getJmeno()))
                        {
                            h.pridejZakaznika(z);
                            holiciLB_SelectedIndexChanged(sender, e);
                            break;
                        }
                    }
                }
                catch(NullReferenceException nre)
                {
                    vypisTB.Text = "neni vybran holic";
                }
            }

        }



        private void jeHolic_Click(object sender, EventArgs e)
        {

        }

        private void holiciLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            zakazniciLB.Items.Clear();
            String vyber = holiciLB.SelectedItem.ToString();
            ArrayList zakaznici = null;
            foreach (Holic h in holici)
            {
                if (h.getJmeno().Equals(vyber))
                {
                    zakaznici = h.getList();
                    break;
                }
            }

            foreach (Zakaznik z in zakaznici)
            {
                
                zakazniciLB.Items.Add(z.getJmeno());
            }
            if (zakaznici.Count == 0)
            {
                vypisTB.Text = "zadni zakaznici";
            }
            else
            {
                vypisTB.Text = "vypsano "+zakaznici.Count+" zakaniku";
            }

        }

        private void vycistiB_Click(object sender, EventArgs e)
        {
            holici.Clear();
            holiciLB.Items.Clear();
            zakazniciLB.Items.Clear();
            vypisTB.Text = "vycisteno";
        }
    }
}
