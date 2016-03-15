using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication3
{
    class Holic : Osoba
    {
        private ArrayList zakaznici = new ArrayList();
        

        public Holic(String jmeno, String prijmeni):base(jmeno, prijmeni)
        {
            isHolic = true;
        }

        public void pridejZakaznika(Osoba a)
        {
            zakaznici.Add(a);
        }

        public ArrayList getList() 
        {
            return this.zakaznici;
        }

    }
}
