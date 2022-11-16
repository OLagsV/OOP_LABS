using customArrsLib;

namespace odnomerMassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getLengthTest()
        {
            int trueLength = 6;
            double[] testArr = { 1.0, 0, -4.2, 11.92, 0, 0.99 };
            OdnomerMass testMass = new OdnomerMass(testArr, "Testing");
            Assert.AreEqual(trueLength, testMass.getLength());
        }

        [TestMethod]
        public void getAnElementTest()
        {
            double trueElement = 14.2;
            int trueIndex = 4;
            double[] testArr = { 1.0, 0, -4.2, 11.92, 14.2, 0.99 };
            OdnomerMass testMass = new OdnomerMass(testArr, "Testing");
            Assert.AreEqual(trueElement, testMass.getAnEllement(4));
        }

        [TestMethod]
        public void proizvTest()
        {
            int[] indexUmnozh = { 0, 2, 3};
            double[] testArr = { 1.0, 0, -4.2, 11.92, 14.2, 0.99 };
            double trueProizv = -50.064;
            OdnomerMass testMass = new OdnomerMass(testArr, "Testing");
            Assert.AreEqual(trueProizv, testMass.summOrUmnozh(indexUmnozh));
        }

        [TestMethod]
        public void summTest()
        {
            double[] testArr = { 1.0, 0, -4.2, 11.92, 14.2, 0.99 };
            double trueSumm = 23.91;
            OdnomerMass testMass = new OdnomerMass(testArr, "Testing");
            Assert.AreEqual(trueSumm, testMass.summOrUmnozh());
        }

        [TestMethod]
        public void delenieTest()
        {
            double[] testArr1 = { 1.0, 0, -4.2, 11.92, 14.2, 0.99 };
            double[] testArr2 = { 0.5, 1, -4.2, 4, 1, 0.5};
            double[] trueDel = {2, 0, 1, 2.98,14.2,1.98};
            Assert.IsTrue(Enumerable.SequenceEqual(trueDel, OdnomerMass.delenie(testArr1,testArr2)));
        }
    }
}