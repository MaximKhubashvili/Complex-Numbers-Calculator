using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppCalculator;

namespace UnitTest
{
    [TestClass]
    public class ComplexTest
    {


        ///Тест для Add
        [TestMethod()]
        public void ComplexAddTest()
        {
            //Complex expected = new Complex("5+i5");
            Complex expected = new Complex(5,5);
            Complex target = new Complex(2,4);
            Complex Value = new Complex(3,1);
            Complex actual;
            actual = (Complex)target.Add(Value);
            Assert.AreEqual(expected.GetNumberString(), actual.GetNumberString());
        }

        ///Тест для Deduct
        [TestMethod()]
        public void ComplexDeductTest()
        {
            Complex expected = new Complex(3,1);
            Complex target = new Complex(5,4);
            Complex Value = new Complex(2,3);
            Complex actual;
            actual = (Complex)target.Deduct(Value);
            Assert.AreEqual(expected.GetNumberString(), actual.GetNumberString());
        }

        ///Тест для Mul
        [TestMethod()]
        public void ComplexMulTest()
        {
            Complex expected = new Complex(2,0);
            Complex target = new Complex(1,1);
            Complex Value = new Complex(1,-1);
            Complex actual;
            actual = (Complex)target.Mul(Value);
            Assert.AreEqual(expected.GetNumberString(), actual.GetNumberString());
        }

        ///Тест для Divide
        [TestMethod()]
        public void ComplexDivideTest()
        {
            Complex expected = new Complex(2.5,-0.5);
            Complex target = new Complex(3,2);
            Complex Value = new Complex(1,1);
            Complex actual;
            actual = (Complex)target.Divide(Value);
            Assert.AreEqual(expected.GetNumberString(), actual.GetNumberString());
        }

        ///Тест для Rev
        [TestMethod()]
        public void ComplexRevTest()
        {
            Complex expected = new Complex(0.5,0.5);
            Complex target = new Complex(1,1);
            Complex actual;
            actual = (Complex)target.Rev();
            Assert.AreEqual(expected.GetNumberString(), actual.GetNumberString());
        }

        ///Тест для Sqr
        [TestMethod()]
        public void ComplexSqrTest()
        {
            Complex expected = new Complex(5,12);
            Complex target = new Complex(3,2);
            Complex actual;
            actual = (Complex)target.Sqr();
            Assert.AreEqual(expected.GetNumberString(), actual.GetNumberString());
        }


    }
}
