using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace frazioni_semplificata
{
    internal class Frazione
    {
        public int N { get; set; }
        public int D { get; set; }

        public Frazione (int n, int d)
        {
            Semplifica(ref n, ref d);
                N = n;
                D = d;
        }
         private void Semplifica(ref int n, ref int d)
        {
            int mcd = CalcolaMcd(n, d);
            n = n / mcd;
            d = d / mcd;
        }

        private int CalcolaMcd(int a, int b)
        {
            int resto;
            while (b != 0)
            {
                resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{N}/{D}";
        }   

    }
}
