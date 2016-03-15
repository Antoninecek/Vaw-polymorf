using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Osoba
    {
        protected bool isHolic;
        protected String jmeno;
        protected String prijmeni;

        public Osoba(String jmeno, String prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }

        public String getJmeno()
        {
            return this.jmeno; 
        }

    }
}
