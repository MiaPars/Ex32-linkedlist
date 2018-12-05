using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_linkedlist
{
    public class ClubMember
    {
        private int nr;
        private string fnavn;
        private string lnavn;
        private int alder;
        public int Nr
        {
            get { return nr; }
            set { nr = value; }
        }
        public string FNavn
        {
            get { return fnavn; }
            set { fnavn = value; }

        }
        public string LNavn
        {
            get { return lnavn; }
            set { lnavn = value; }

        }
        public int Alder
        {
            get { return alder; }
            set { alder = value; }
        }

        public ClubMember(int nr, string Fname, string Lname, int alder)
        {
            Nr = nr;
            FNavn = Fname;
            LNavn = Lname;
            Alder = alder;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
