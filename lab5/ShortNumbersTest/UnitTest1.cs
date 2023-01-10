using PhonesLib;
using System.Text;

namespace ShortNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NoSpaceShort()
        {
            string testingString = "Случайное ФИО; адрес; email; телефон 1283454.";
            StringBuilder expected = new StringBuilder("1283454");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
        [TestMethod]
        public void DashShort()
        {
            string testingString = "Случайное ФИО; адрес; email; телефон 128-34-54.";
            StringBuilder expected = new StringBuilder("128-34-54");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
        [TestMethod]
        public void SpaceShort()
        {
            string testingString = "Случайное ФИО; адрес; email; телефон 128 34 54.";
            StringBuilder expected = new StringBuilder("128 34 54");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
        [TestMethod]
        public void AnyLong()
        {
            string testingString = "Случайное ФИО; адрес; email; телефон +375291234567. Случайное ФИО; адрес; email; телефон +375 29 1234567. Случайное ФИО; адрес; email; телефон +375(29)123-45-67.";
            StringBuilder expected = new StringBuilder("");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
        [TestMethod]
        public void LongAndShort()
        {
            string testingString = "Случайное ФИО; адрес; email; телефон 812-23-11. Случайное ФИО; адрес; email; телефон +375 29 1234567. Случайное ФИО; адрес; email; телефон 123 98 11. Случайное ФИО; адрес; email; телефон 1239812;";
            StringBuilder expected = new StringBuilder("812-23-11123 98 111239812");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
    }
}