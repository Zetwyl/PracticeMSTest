using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice9;

namespace Variant4Tests
{
    [TestClass]
    public class UnitTest1
    {
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
    }
}
