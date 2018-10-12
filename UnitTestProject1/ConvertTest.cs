using System;
using GramConvert;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GramConvertUnitTest
{
    [TestClass]
    public class ConvertTest
    {
        GramOunce G = new GramOunce();
        
        
        //Gram til Ounce tests
        [TestMethod]
        public void GramToOunceTest()
        {
            Assert.AreEqual(3.1746565755, G.GramToOunce(90), 0.00000001);
        }

        [TestMethod]
        public void GramToOunceTestNegativeNumbers()
        {
            Assert.AreEqual(-3.1746565755, G.GramToOunce(-90), 0.00000001);
        }

        [TestMethod]
        public void GramToOunceTestDecimalNumbers()
        {
            Assert.AreEqual(3.1790111461, G.GramToOunce(90.12345), 0.000001);
        }

        //Ounce til Gram tests
        [TestMethod]
        public void OunceToGramTest()
        {
            Assert.AreEqual(2551.4568, G.OunceToGram(90), 0.00001);
        }

        [TestMethod]
        public void OunceToGramTestNegativeNumbers()
        {
            Assert.AreEqual(-2551.4568, G.OunceToGram(-90), 0.00001);
        }

        [TestMethod]
        public void OunceToGramDecimalNumbers()
        {
            Assert.AreEqual(2554.9565482, G.OunceToGram(90.12345), 0.00001 );
        }
    }
}
