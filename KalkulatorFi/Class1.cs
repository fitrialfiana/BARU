using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorFi
{
    public class Calculator
    {
        public int Tambah(int a, int b)
        {
            return a + b;
        }

        public int Kurang(int a, int b)
        {
            return a - b;
        }

        public int Bagi(int a, int b)
        {
            return a / b;
        }

        public int Kali(int a, int b)
        {
            return a * b;
        }

        public int Modulus(int a, int b)
        {
            return a % b;
        }
    }
}
