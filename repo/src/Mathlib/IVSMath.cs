using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Mathlib
{
    public class IVSMath
    {
        /**
       * @brief Scitani Zakládní matematická operace pro sčítání
       * 
       * @param a Číselný argument pro dannou operaci.
       * @param b Číselný argument pro dannou operaci.
       * 
       * @return a Návratová hodnota výpočtu.
       */
        public double Scitani(double a, double b)
        {
            a = a + b;
            return a;
        }

        /**
      * @brief Scitani Zakládní matematická operace pro sčítání
      * 
      * @param a Číselný argument pro dannou operaci.
      * @param b Číselný argument pro dannou operaci.
      * 
      * @return a Návratová hodnota výpočtu.
      */

        public double Odcitani(double a, double b)
        {
            a = a - b;
            return a;
        }

        /**
         * @brief Nasobeni Zakládní matematická operace pro násobení
         * 
         * @param a Číselný argument pro dannou operaci.
         * @param b Číselný argument pro dannou operaci.
         * 
         * @return a Návratová hodnota výpočtu.
         */

        public double Nasobeni(double a, double b)
        {
            a = a * b;
            return a;
        }

        /**
         * @brief Deleni Zakládní matematická operace pro dělení
         * 
         * @param a Číselný argument pro dannou operaci.
         * @param b Číselný argument pro dannou operaci.
         * 
         * @warning Dělitel, čili argument B nesmí být nulový!
         * 
         * @return a Návratová hodnota výpočtu.
         */

        public double Deleni(double a, double b)
        {
            if (b == 0.0) 
            {
                throw new DivideByZeroException();
            }
            a = a / b;
            return a;
        }

        /**
         * @brief Modulo Matematická operace, která dělí dvě čísla, ale vrací zbytek! 
         *  
         * @param a Číselný argument pro dannou operaci.
         * @param b Číselný argument pro dannou operaci.
         * 
         * @warning Dělitel, čili argument B nesmí být nulový!
         * 
         * @return a Návratová hodnota(zbytek) výpočtu.
         */

        public double Modulo(double a, double b)
        {
            if (b == 0.0) 
            {
                throw new DivideByZeroException();
            }
            a = a % b;  
            return a;
        }

        /**
        * @brief Faktorial Násobí se posloupnost čísel od 1 po a 1*2*3 * ... *a-1*a 
        *  
        * @param a Číselný argument pro dannou operaci.
        * 
        * @warning Argument nesmí být desetinné číslo
        * @warning Argument nesmí být záporné číslo
        * 
        * @return a Návratová hodnota výpočtu.
        */


        public double Faktorial(double a)
        {
            double b = 1;   
            if( (a % 1) != 0 )
            {
                throw new Exception();
            }
            if (a < 0)
            {
                throw new Exception();
            }

            if (a == 0)
                return 1;

            for (int i = 1; i<= a; i++)
            {
                    b = b * i;
            }
            return b;
        }

        /**
        * @brief Odmocnina Operace která odmocní danné číslo. Odmocňuje se na přirozený exponent >= 2 
        *  
        * @param a Číselný argument pro dannou operaci. Základ
        * @param b Číselný argument pro dannou operaci. Přirozený exponent odmocniny
        * 
        * @warning Nelze udělat sudou odmocninu ze záporného čísla
        * @warning Nelze udělat nultou odmocninu z nuly
        * 
        * @return a Návratová hodnota výpočtu.
        */


        public double Odmocnina(double a, double b)
        {        
            if ((b < 0) && ((a % 2) == 0))
            {
                throw new Exception();
            }
            a =Math.Pow(b, Deleni(1 , a));
            return a;
        }

        /**
        * @brief Mocnina Operace která umocní danné číslo. 
        *  
        * @param a Číselný argument pro dannou operaci. Základ
        * @param b Číselný argument pro dannou operaci. Přirozený exponent
        * 
        * @warning Nultá mocnina z nuly je nedef.
        * 
        * @return a Návratová hodnota výpočtu.
        */

        public double Mocnina(double a, double b)
        {
            if (a == 0 && b == 0)
            {
                throw new Exception();
            }
            a = Math.Pow(a, b);
            return a;
        }
    }
}
