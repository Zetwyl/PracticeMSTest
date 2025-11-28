using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice9;
using System;

namespace Variant4Tests
{
    [TestClass]
    public class UnitTest1
    {
        //
        // test factorial
        //

        [TestMethod]
        public void Test_f_TwoDigitNumber()
        {
            int num = 10;
            int expected = 100;

            Variant4 v = new Variant4();
            int actual = v.f(num);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_f_SingleDigit()
        {
            int num = 5;
            int expected = 5;

            Variant4 v = new Variant4();
            int actual = v.f(num);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_f_Zero()
        {
            Variant4 v = new Variant4();
            int actual = v.f(0);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_f_NegativeNumber()
        {
            Variant4 v = new Variant4();
            int actual = v.f(-15);
            Assert.AreEqual(-15, actual);
        }

        [TestMethod]
        public void Test_f_BigNumber()
        {
            Variant4 v = new Variant4();
            int actual = v.f(1000);
            Assert.AreEqual(1000, actual);
        }

        [TestMethod]
        public void Test_f_FractionConverted()
        {
            Variant4 v = new Variant4();
            double d = 7.8;
            int converted = (int)d; // 7
            int actual = v.f(converted);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void Test_f_CharConverted()
        {
            Variant4 v = new Variant4();
            char c = '9';
            int number = int.Parse(c.ToString());
            int actual = v.f(number);
            Assert.AreEqual(9, actual);
        }

        //
        // Test_IsPalindrom
        //

        [TestMethod]
        public void Test_IsPalindrom_True()
        {
            string str = "Level";

            Variant4 v = new Variant4();
            bool actual = v.IsPalindrom(str);

            Assert.IsTrue(actual); // "level" == "level" (после ToLower)
        }

        [TestMethod]
        public void Test_IsPalindrom_False()
        {
            string str = "Hello";

            Variant4 v = new Variant4();
            bool actual = v.IsPalindrom(str);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_IsPalindrom_Symbols()
        {
            Variant4 v = new Variant4();
            bool actual = v.IsPalindrom("___");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_IsPalindrom_EmptyString_ShouldThrow()
        {
            Variant4 v = new Variant4();

            try
            {
                v.IsPalindrom("");
                Assert.Fail("Ожидалось исключение ArgumentException.");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_IsPalindrom_SingleChar_ShouldBeTrue()
        {
            Variant4 v = new Variant4();
            bool actual = v.IsPalindrom("_");
            Assert.IsTrue(actual);
        }

        //
        // Test_LessonTime
        //

        [TestMethod]
        public void Test_LessonTime_FirstLesson()
        {
            int lesson = 1;
            string expected = "08 45";

            Variant4 v = new Variant4();
            string actual = v.LessonTime(lesson);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_LessonTime_SixthLesson()
        {
            int lesson = 6;
            string expected = "12 55";

            Variant4 v = new Variant4();
            string actual = v.LessonTime(lesson);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_LessonTime_MaxAllowedLesson()
        {
            Variant4 v = new Variant4();
            string actual = v.LessonTime(15);
            Assert.IsTrue(actual.Length > 0);
        }

        [TestMethod]
        public void Test_LessonTime_TooBig_ShouldThrow()
        {
            Variant4 v = new Variant4();

            try
            {
                v.LessonTime(20);
                Assert.Fail("Ожидалось исключение ArgumentException.");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_LessonTime_Negative_ShouldThrow()
        {
            Variant4 v = new Variant4();

            try
            {
                v.LessonTime(-3);
                Assert.Fail("Ожидалось исключение ArgumentException.");
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
