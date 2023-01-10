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
            string testingString = "��������� ���; �����; email; ������� 1283454.";
            StringBuilder expected = new StringBuilder("1283454");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
        [TestMethod]
        public void DashShort()
        {
            string testingString = "��������� ���; �����; email; ������� 128-34-54.";
            StringBuilder expected = new StringBuilder("128-34-54");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
        [TestMethod]
        public void SpaceShort()
        {
            string testingString = "��������� ���; �����; email; ������� 128 34 54.";
            StringBuilder expected = new StringBuilder("128 34 54");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
        [TestMethod]
        public void AnyLong()
        {
            string testingString = "��������� ���; �����; email; ������� +375291234567. ��������� ���; �����; email; ������� +375 29 1234567. ��������� ���; �����; email; ������� +375(29)123-45-67.";
            StringBuilder expected = new StringBuilder("");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
        [TestMethod]
        public void LongAndShort()
        {
            string testingString = "��������� ���; �����; email; ������� 812-23-11. ��������� ���; �����; email; ������� +375 29 1234567. ��������� ���; �����; email; ������� 123 98 11. ��������� ���; �����; email; ������� 1239812;";
            StringBuilder expected = new StringBuilder("812-23-11123 98 111239812");
            PhoneScaner scaner = new PhoneScaner(testingString);
            Assert.AreEqual(expected.ToString(), scaner.getShortPhone().ToString());
        }
    }
}