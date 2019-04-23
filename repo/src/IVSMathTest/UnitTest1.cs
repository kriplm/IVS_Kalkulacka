using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mathlib;

namespace IVSMathTest
{
    [TestClass]
    public class IVSMathTest
    {
        private IVSMath matematic;
        [TestMethod]

        [TestInitialize]
        public void Initialize()
        {
            matematic = new IVSMath();
        }

        [TestMethod]
        public void Scitani()
        {
            //Testování celých čísel
            Assert.AreEqual(0, matematic.Scitani(0, 0));
            Assert.AreEqual(1, matematic.Scitani(0, 1));
            Assert.AreEqual(-5, matematic.Scitani(0, -5));
            Assert.AreEqual(3, matematic.Scitani(3, 0));
            Assert.AreEqual(-82, matematic.Scitani(-32, -50));
            Assert.AreEqual(108, matematic.Scitani(74, 34));
            Assert.AreEqual(50, matematic.Scitani(80, -30));
            Assert.AreEqual(781480, matematic.Scitani(120700, 660780));
            Assert.AreEqual(-781480, matematic.Scitani(-120700, -660780));
            Assert.AreEqual(-540080, matematic.Scitani(120700, -660780));
            Assert.AreEqual(832000000, matematic.Scitani(780000000, 52000000));
            Assert.AreEqual(-832000000, matematic.Scitani(-780000000, -52000000));
            Assert.AreEqual(728000000, matematic.Scitani(780000000, -52000000));
            //Testování desetinných čísel
            Assert.AreEqual(1, matematic.Scitani(0.78, 0.22));
            Assert.AreEqual(4.58545454, matematic.Scitani(4.58545454, 0));
            Assert.AreEqual(4.58545454, matematic.Scitani(0, 4.58545454));
            Assert.AreEqual(2.4, matematic.Scitani(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Scitani(-32, -50));
            Assert.AreNotEqual(5000, matematic.Scitani(120700, 660780));
            Assert.AreNotEqual(70, matematic.Scitani(0.78, 0.22));
            Assert.AreNotEqual(7.555, matematic.Scitani(-2.4, 4.8));
        }

        [TestMethod]
        public void Odcitani()
        {
            //Testování celých čísel
            Assert.AreEqual(0, matematic.Odcitani(0, 0));
            Assert.AreEqual(-1, matematic.Odcitani(0, 1));
            Assert.AreEqual(5, matematic.Odcitani(0, -5));
            Assert.AreEqual(3, matematic.Odcitani(3, 0));
            Assert.AreEqual(18, matematic.Odcitani(-32, -50));
            Assert.AreEqual(40, matematic.Odcitani(74, 34));
            Assert.AreEqual(110, matematic.Odcitani(80, -30));
            Assert.AreEqual(-540080, matematic.Odcitani(120700, 660780));
            Assert.AreEqual(540080, matematic.Odcitani(-120700, -660780));
            Assert.AreEqual(781480, matematic.Odcitani(120700, -660780));
            Assert.AreEqual(728000000, matematic.Odcitani(780000000, 52000000));
            Assert.AreEqual(-728000000, matematic.Odcitani(-780000000, -52000000));
            Assert.AreEqual(884000000, matematic.Odcitani(832000000, -52000000));

            //Testování desetinných čísel
            Assert.AreEqual(0.56, matematic.Odcitani(0.78, 0.22));
            Assert.AreEqual(4.58545454, matematic.Odcitani(4.58545454, 0));
            Assert.AreEqual(-4.58545454, matematic.Odcitani(0, 4.58545454));
            ///Assert.AreEqual(-7.2, matematic.Odcitani(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Odcitani(-32, -50));
            Assert.AreNotEqual(5000, matematic.Odcitani(120700, 660780));
            Assert.AreNotEqual(70, matematic.Odcitani(0.78, 0.22));
            Assert.AreNotEqual(7.555, matematic.Odcitani(-2.4, 4.8));
        }

       

        [TestMethod]
        public void Modulo()
        {
            Assert.AreEqual(0, matematic.Modulo(8, 2));
            ///Assert.AreEqual(0.05, matematic.Modulo(8, 0.15));
            Assert.AreEqual(1, matematic.Modulo(25, 3));
            Assert.AreEqual(-1, matematic.Modulo(-25, 3));
            //Assert.AreEqual(-2, matematic.Modulo(25, -3));
            ///Assert.AreEqual(0.645, matematic.Modulo(126, 0.685));
            //Assert.AreEqual(-11, matematic.Modulo(259, -27));
            Assert.AreEqual(-6, matematic.Modulo(-358, 16));
            Assert.AreEqual(1556, matematic.Modulo(1556, 2000));
            Assert.AreEqual(0, matematic.Modulo(2590, -2590));
            Assert.AreEqual(138, matematic.Modulo(30592553, 623));
            Assert.AreEqual(-138, matematic.Modulo(-30592553, 623));

            Assert.AreNotEqual(4, matematic.Modulo(9, 2));
            Assert.AreNotEqual(10, matematic.Modulo(256, 20));
            Assert.AreNotEqual(52, matematic.Modulo(7, 6));


            const string Vyjimka = "V programu nenastala výjimka, ikdyž byla očekávana!";
            try
            {
                matematic.Deleni(28.51561651, 0);
                Assert.Fail(Vyjimka);
            }
            catch (DivideByZeroException)
            {
            }

        }

        [TestMethod]
        public void Odmocnina()
        {
            // Testy na celé čísla
            Assert.AreEqual(0, matematic.Odmocnina(20, 0));
            Assert.AreEqual(1, matematic.Odmocnina(2, 1));
            Assert.AreEqual(0.125, matematic.Odmocnina(2, 0.015625));
            Assert.AreEqual(3, matematic.Odmocnina(3, 27));
            Assert.AreEqual(10, matematic.Odmocnina(2, 100));
            Assert.AreEqual(7, matematic.Odmocnina(11, 1977326743));



            //Testy na desetinné čísla
            Assert.AreEqual(25, matematic.Odmocnina(0.5, 5));
            Assert.AreEqual(25, matematic.Odmocnina(0.5, 5));
            Assert.AreEqual(25, matematic.Odmocnina(0.5, 5));


            //Testy které se nerovnají
            Assert.AreNotEqual(-1, matematic.Odmocnina(-1, 2));
            Assert.AreNotEqual(10, matematic.Odmocnina(5, 20));
            Assert.AreNotEqual(52, matematic.Odmocnina(7, 6));
            const string Vyjimka = "V programu nenastala výjimka, ikdyž byla očekávana!";
            try
            {
                matematic.Mocnina(-5, 6);
                Assert.Fail(Vyjimka);
            }
            catch (Exception)
            {
            }

        }

        [TestMethod]
        public void Mocnina()
        {
            // testy na celé čísla
            Assert.AreEqual(0, matematic.Mocnina(0, 20));
            Assert.AreEqual(1, matematic.Mocnina(1, 2));
            Assert.AreEqual(0.125, matematic.Mocnina(2, -3));
            Assert.AreEqual(-27, matematic.Mocnina(-3, 3));
            Assert.AreEqual(0.0009765625, matematic.Mocnina(-2, -10));
            Assert.AreEqual(2097152, matematic.Mocnina(8, 7));
            Assert.AreEqual(16, matematic.Mocnina(-4, 2));
            Assert.AreEqual(-7776, matematic.Mocnina(-6, 5));
            Assert.AreEqual(10000000, matematic.Mocnina(10, 7));


            //testy na desetinné čísla
            Assert.AreEqual(0.03125, matematic.Mocnina(0.5, 5));
            Assert.AreEqual(-0.0009765625, matematic.Mocnina(-0.25, 5));
            Assert.AreEqual(0.177978515625, matematic.Mocnina(-0.75, 6));


            //testy které se nerovnají
            Assert.AreNotEqual(-1, matematic.Mocnina(-1, 2));
            Assert.AreNotEqual(10, matematic.Mocnina(5, 20));
            Assert.AreNotEqual(52, matematic.Mocnina(7, 6));

            const string vyjimka = "v programu nenastala výjimka, ikdyž byla očekávana!";
            try
            {
                matematic.Mocnina(0, -1);
                Assert.Fail(vyjimka);
            }
            catch (Exception)
            {
            }

        }

        [TestMethod]
        public void Nasobeni()
        {
            //Testování celých čísel
            Assert.AreEqual(0, matematic.Nasobeni(0, 0));
            Assert.AreEqual(0, matematic.Nasobeni(0, 1));
            Assert.AreEqual(0, matematic.Nasobeni(0, -5));
            Assert.AreEqual(0, matematic.Nasobeni(3, 0));
            Assert.AreEqual(1600, matematic.Nasobeni(-32, -50));
            Assert.AreEqual(2516, matematic.Nasobeni(74, 34));
            Assert.AreEqual(-2400, matematic.Nasobeni(80, -30));
            Assert.AreEqual(796620000, matematic.Nasobeni(120700, 6600));
            Assert.AreEqual(796620000, matematic.Nasobeni(-120700, -6600));


            //Testování desetinných čísel
            Assert.AreEqual(0.1716, matematic.Nasobeni(0.78, 0.22));
            Assert.AreEqual(0, matematic.Nasobeni(4.58545454, 0));
            Assert.AreEqual(0, matematic.Nasobeni(0, 4.58545454));
            Assert.AreEqual(-11.52, matematic.Nasobeni(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Scitani(-32, -50));
            Assert.AreNotEqual(5000, matematic.Scitani(120700, 660780));
            Assert.AreNotEqual(70, matematic.Scitani(0.78, 0.22));
            Assert.AreNotEqual(7.555, matematic.Scitani(-2.4, 4.8));
        }

        [TestMethod]
        public void Deleni()
        {
            //Testování celých čísel
            Assert.AreEqual(0, matematic.Deleni(0, 1));
            Assert.AreEqual(0, matematic.Deleni(0, -5));
            Assert.AreEqual(-1, matematic.Deleni(5, -5));
            Assert.AreEqual(0.64, matematic.Deleni(-32, -50));
            ///Assert.AreEqual(2.17647058824, matematic.Deleni(74, 34));
            Assert.AreEqual(-3, matematic.Deleni(90, -30));
            Assert.AreEqual(159, matematic.Deleni(1049400, 6600));
            Assert.AreEqual(1560, matematic.Deleni(-8268000, -5300));
            Assert.AreEqual(-1560, matematic.Deleni(8268000, -5300));

            //Testování desetinných čísel
            Assert.AreEqual(4, matematic.Deleni(0.88, 0.22));
            Assert.AreEqual(0, matematic.Deleni(0, 4.58545454));
            Assert.AreEqual(-0.5, matematic.Deleni(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Deleni(-32, -50));
            Assert.AreNotEqual(5000, matematic.Deleni(120700, 660780));
            Assert.AreNotEqual(70, matematic.Deleni(0.78, 0.22));
            Assert.AreNotEqual(7.555, matematic.Deleni(-2.4, 4.8));

            //Testování vyhození výjímky
            const string Vyjimka = "V programu nenastala výjimka, ikdyž byla očekávana!";
            try
            {
                matematic.Deleni(28.51561651, 0);
                Assert.Fail(Vyjimka);
            }
            catch (DivideByZeroException)
            {
            }

            try
            {
                matematic.Deleni(-23, 0);
                Assert.Fail(Vyjimka);
            }
            catch (DivideByZeroException)
            {
            }
        }

        [TestMethod]
        public void Faktorial()
        {
           const string VyjimkaFaktorial = "V programu nenastala výjimka, ikdyž byla očekávána!";

            Assert.AreEqual(1, matematic.Faktorial(0));
            Assert.AreEqual(1, matematic.Faktorial(1));
            Assert.AreEqual(5040, matematic.Faktorial(7));
            Assert.AreEqual(1307674368000, matematic.Faktorial(15));

            Assert.AreNotEqual(7, matematic.Faktorial(2));
            Assert.AreNotEqual(7, matematic.Faktorial(20));
            Assert.AreNotEqual(7, matematic.Faktorial(30));
            try
            {
                matematic.Faktorial(-5);
                Assert.Fail(VyjimkaFaktorial);

            }
            catch (Exception)
            {

            }

            try
            {
                matematic.Faktorial(22.5);
                Assert.Fail(VyjimkaFaktorial);

            }
            catch (Exception)
            {
            }
        }


    }
}
