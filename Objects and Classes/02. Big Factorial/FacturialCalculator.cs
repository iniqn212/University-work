using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02._Big_Factorial
{
    class FacturialCalculator
    {
        public FacturialCalculator(int n)
        {
            N = n;
        }

        public int N { get; set; }

        public BigInteger calculate()
        {
            BigInteger facturiel = 1;

            for (int i = 2; i <= N; i++)
            {
                facturiel *= i;
            }

            return facturiel;
        }
    }
}
