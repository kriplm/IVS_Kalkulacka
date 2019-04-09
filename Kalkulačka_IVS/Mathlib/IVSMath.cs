using System;

namespace Mathlib
{
    public class IVSMath
    {
        public double Scitani(double a, double b)
        {
            a = a + b;
            return a;
        }

        public double Odcitani(double a, double b)
        {
            a = a - b;
            return a;
        }

        public double Nasobeni(double a, double b)
        {
            a = a * b;
            return a;
        }

        public double Deleni(double a, double b)
        {
            a = a / b;
            return a;
        }

        public double Modulo(double a, double b)
        {
            a = a % b;
            return a;
        }

        public double Faktorial(double a)
        {
            double b = 1;
            if( (a % 1 ) != 0 )
            {
               
            }
            try
            {
                if ((a % 1) != 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                throw;
            }
            for(int i = 1; i<= a; i++)
            {
                    b = b * i;
            }
            return b;
        }

        public double Odmocnina(double a)
        {
            Math.Sqrt(a);
            return a;
        }

    }
}
