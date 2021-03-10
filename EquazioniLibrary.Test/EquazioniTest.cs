using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;
namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        public void TestIsDeterminedTrue()
        {
            double a = 4;
            bool valore_aspettato = true;
            bool prova = Equazioni.IsDetermined(a);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestIsDeterminedFalse()
        {
            double a = 0;
            bool valore_aspettato = false;
            bool prova = Equazioni.IsDetermined(a);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestIsInconsistedTrue()
        {
            double a = 0;
            double b = 6;
            bool valore_aspettato = true;
            bool prova = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestIsInconsistedFalse()
        {
            double a = 5;
            double b = 6;
            bool valore_aspettato = false;
            bool prova = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestIsDegree2True()
        {
            double x = 2;
            bool valore_aspettato = true;
            bool prova = Equazioni.IsDegree2(x);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestIsDegree2False()
        {
            double x = 1;
            bool valore_aspettato = false;
            bool prova = Equazioni.IsDegree2(x);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestDelta()
        {
            double a = 2;
            double b = 4;
            double c = 4;
            double valore_aspettato = -16;
            double prova = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestDelta2()
        {
            double a = 3;
            double b = 6;
            double c = 2;
            double valore_aspettato = 12;
            double prova = Equazioni.Delta(a, b, c);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void result()
        {
            double a = 1;
            double b = -3;
            double c = 2;
            string valore_aspettato = ($"x1={2} x2={1}");         
            string prova = Equazioni.Result(a, b, c);
            Assert.AreEqual(valore_aspettato, prova);          
        }
        [TestMethod]
        public void TestEquationDegree1()
        {
            double a = 0;
            double b = 3;
            double c = 6;
            string valore_aspettato = "Impossibile";
            string prova = Equazioni.EquationDegree1(a, b, c);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestEquationDegree2()
        {
            double a = 3;
            double b = 0;
            double c = 6;
            string valore_aspettato = "indeterminata";
            string prova = Equazioni.EquationDegree1(a, b, c);
            Assert.AreEqual(valore_aspettato, prova);
        }
        [TestMethod]
        public void TestEquationDegree3()
        {
            double a = 1;
            double b = -3;
            double c = 2;
            string valore_aspettato = ($"x1={2} x2={1}");
            string prova = Equazioni.EquationDegree1(a, b, c);
            Assert.AreEqual(valore_aspettato, prova);
        }

    }
}
