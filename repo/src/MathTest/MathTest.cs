using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ok

{
    [TestClass]
    public class IVSMathTest
    {
        //# private IVSMath matematic

        [TestInitialize]
        public void Initialize()
        {
            IVSMath matematic = new IVSMath();
        }

        [TestMethod]
        public void ScitaniTest()
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
            Assert.AreEqual(728000000, matematic.Odcitani(832000000, -52000000));

            //Testování desetinných čísel
            Assert.AreEqual(0.56, matematic.Odcitani(0.78, 0.22));
            Assert.AreEqual(4.58545454, matematic.Odcitani(4.58545454, 0));
            Assert.AreEqual(-4.58545454, matematic.Odcitani(0, 4.58545454));
            Assert.AreEqual(-7.2, matematic.Odcitani(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Odcitani(-32, -50));
            Assert.AreNotEqual(5000, matematic.Odcitani(120700, 660780));
            Assert.AreNotEqual(70, matematic.Odcitani(0.78, 0.22));
            Assert.AreNotEqual(7.555, matematic.Odcitani(-2.4, 4.8));
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
            Assert.AreEqual(0, matematic.Deleni(0, 0));
            Assert.AreEqual(0, matematic.Deleni(3, 0));
            Assert.AreEqual(1, matematic.Deleni(5, -5));
            Assert.AreEqual(1600, matematic.Deleni(-32, -50));
            Assert.AreEqual(2516, matematic.Deleni(74, 34));
            Assert.AreEqual(-2400, matematic.Deleni(80, -30));
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
            catch (VyjimkaDeleni0)
            {
            }
            try
            {
                this.math.Div(-23, 0);
                Assert.Fail(Vyjimka);
            }
            catch (VyjimkaDeleni0)
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
                assert.fail(VyjimkaFaktorial);

            }
            catch (VyjimkaFaktorial)
            {

            }

            try
            {
                matematic.Faktorial(22.5);
                assert.fail(VyjimkaFaktorial);

            }
            catch (VyjimkaFaktorial)
            {

            }
        }

        [TestMethod]
        public void Mocnina()
        {
            // Testy na celé čísla
            Assert.AreEqual(0, matematic.Mocnina(0, 20));
            Assert.AreEqual(1, matematic.Mocnina(1, 2));
            Assert.AreEqual(0.125, matematic.Mocnina(2, -3));
            Assert.AreEqual(-9, matematic.Mocnina(-3, 3));
            Assert.AreEqual(0.0009765625, matematic.Mocnina(-2, -10));
            Assert.AreEqual(3.397951715, matematic.Mocnina(5, 0.76));
            Assert.AreEqual(0.61985385, matematic.Mocnina(8, -0.23));
            Assert.AreEqual(16, matematic.Mocnina(-4, 2));
            Assert.AreEqual(-7776, matematic.Mocnina(-6, 5));
            Assert.AreEqual(10000000, matematic.Mocnina(10, 7));
            Assert.AreEqual(1.4615016e+48, matematic.Mocnina(32, 32));

            //Testy na desetinné čísla
            Assert.AreEqual(0.03125, matematic.Mocnina(0.5, 5));
            Assert.AreEqual(-0.0006436343, matematic.Mocnina(-0.23, 5));
            Assert.AreEqual(0.17797851562, matematic.Mocnina(-0.75, 6));
            Assert.AreEqual(6.988843939e-4, matematic.Mocnina(3.5, -5.8));

            //Testy které se nerovnají
            Assert.AreNotEqual(-1, matematic.Mocnina(-1, 2));
            Assert.AreNotEqual(10, matematic.Mocnina(5, 20));
            Assert.AreNotEqual(52, matematic.Mocnina(7, 6));

        }

        [TestMethod]
        public void Odmocnina()
        {
            const string VyjimkaOdmocnina = "V programu nenastala výjimka, ikdyž byla očekávána!";

            Assert.AreEqual(1, matematic.Odmocnina(1, 2));
            Assert.AreEqual(3, matematic.Odmocnina(27, 3));
            Assert.AreEqual(0.5, matematic.Odmocnina(8, -3));
            Assert.AreEqual(1e+40, matematic.Odmocnina(10, 0.025));
            Assert.AreEqual(1e-40, matematic.Odmocnina(10, -0.025));
            Assert.AreEqual(259.7561439, matematic.Odmocnina(49, 0.7));
            Assert.AreEqual(1.741101127, matematic.Odmocnina(256, 10));
            Assert.AreEqual(5, matematic.Odmocnina(625, 4));
            Assert.AreEqual(0.2, matematic.Odmocnina(625, -4));
            Assert.AreEqual(23, matematic.Odmocnina(148035889, 6));

            Assert.AreEqual(-0.925991146, matematic.Odmocnina(-0.794, 3));
            Assert.AreEqual(0.5, matematic.Odmocnina(0.125, 3));
            Assert.AreEqual(0.12, matematic.Odmocnina(0.0000248832, 5));
            Assert.AreEqual(0.1262, matematic.Odmocnina(0.00025365149, 4));
            Assert.AreEqual(8100, matematic.Odmocnina(0.5, 90));
            Assert.AreEqual(1.007731369, matematic.Odmocnina(0.5, -90));
            Assert.AreEqual(7.46324326282, matematic.Odmocnina(55.7, 2));


            Assert.AreNotEqual(4, matematic.Odmocnina(9, 2));
            Assert.AreNotEqual(10, matematic.Odmocnina(256, 20));
            Assert.AreNotEqual(52, matematic.Odmocnina(7, 6));


            try
            {
                matematic.Odmocnina(-256, 2);
                assert.fail(VyjimkaOdmocnina);

            }
            catch (VyjimkaFaktorial)
            {

            }

            try
            {
                matematic.Odmocnina(0.55, 0);
                assert.fail(VyjimkaOdmocnina);

            }
            catch (VyjimkaOdmocnina)
            {

            }
        }

        [TestMethod]
        public void Modulo()
        {
            Assert.AreEqual(0, matematic.Modulo(8, 2));
            Assert.AreEqual(0.05, matematic.Modulo(8, 0.15));
            Assert.AreEqual(1, matematic.Modulo(25, 3));
            Assert.AreEqual(-1, matematic.Modulo(-25, 3));
            Assert.AreEqual(-2, matematic.Modulo(25, -3));
            Assert.AreEqual(0.645, matematic.Modulo(126, 0.685));
            Assert.AreEqual(-11, matematic.Modulo(259, -27));
            Assert.AreEqual(-6, matematic.Modulo(-358, 16));
            Assert.AreEqual(1556, matematic.Modulo(1556, 2000));
            Assert.AreEqual(0, matematic.Modulo(2590, -2590));
            Assert.AreEqual(138, matematic.Modulo(30592553, 623));
            Assert.AreEqual(-138, matematic.Modulo(-30592553, 623));


            Assert.AreEqual(0.005841, matematic.Modulo(0.594891, 0.008925));
            Assert.AreEqual(-0.094014425, matematic.Modulo(0.005985575, -0.1));
            Assert.AreEqual(0.0027959, matematic.Modulo(-0.0845641, 0.00546));

            Assert.AreNotEqual(4, matematic.Modulo(9, 2));
            Assert.AreNotEqual(10, matematic.Modulo(256, 20));
            Assert.AreNotEqual(52, matematic.Modulo(7, 6));
        }
    }
}
