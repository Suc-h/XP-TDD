using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1POS()
        {
            string name = unitTestSeSuchem.Form1.GetName("Martin");
            Assert.IsTrue(name.Length < 10);

        }

        [TestMethod]
        public void TestMethod1NEG()
        {
            string name = unitTestSeSuchem.Form1.GetName("David Suchy");
            Assert.IsTrue(name.Length < 10);

        }



        [TestMethod]
        public void TestMethod2POS()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetSpecialziation("Kouzelník");
            Assert.IsTrue(truefalse);
         
        }

        [TestMethod]
        public void TestMethod2NEG()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetSpecialziation("Rampelník");
            Assert.IsTrue(truefalse);
        }



        [TestMethod]
        public void TestMethod3POS()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetFace("velký nos");
            Assert.IsTrue(truefalse);

        }

        [TestMethod]
        public void TestMethod3NEG()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetFace("klavesnice");
            Assert.IsTrue(truefalse);

        }
        [TestMethod]
        public void TestMethod4POS()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetHair("pleška");
            Assert.IsTrue(truefalse);

        }
        [TestMethod]
        public void TestMethod4NEG()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetHair("dildo");
            Assert.IsTrue(truefalse);

        }
        [TestMethod]
        public void TestMethod5POS()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetHairColour("blond");
            Assert.IsTrue(truefalse);

        }
        [TestMethod]
        public void TestMethod5NEG()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetHairColour("zrzek");
            Assert.IsTrue(truefalse);

        }

        [TestMethod]
        public void TestMethod6POS()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetJob("obchodník");
            Assert.IsTrue(truefalse);

        }
        [TestMethod]
        public void TestMethod6NEG()
        {
            bool truefalse = unitTestSeSuchem.Form1.GetJob("koček");
            Assert.IsTrue(truefalse);

        }

        [TestMethod]
        public void TestMethod7POS()
        {
            string truefalse = unitTestSeSuchem.Form1.GetBoss("Ano");
            Assert.AreSame("Ano", truefalse);

        }
        [TestMethod]
        public void TestMethod7NEG()
        {
            string truefalse = unitTestSeSuchem.Form1.GetBoss("Ne");
            Assert.AreSame("Ano", truefalse);
        }

        [TestMethod]
        public void TestMethod8POS()
        {
            int truefalse = unitTestSeSuchem.Form1.GetX(69);
            Assert.IsTrue(truefalse > 0 && truefalse < 100);

        }
        [TestMethod]
        public void TestMethod8NEG()
        {
            int truefalse = unitTestSeSuchem.Form1.GetX(150);
            Assert.IsTrue(truefalse > 0 && truefalse < 100);
        }

        [TestMethod]
        public void TestMethod9POS()
        {
            int truefalse = unitTestSeSuchem.Form1.GetY(18);
            Assert.IsTrue(truefalse > 0 && truefalse < 100);

        }
        [TestMethod]
        public void TestMethod9NEG()
        {
            int truefalse = unitTestSeSuchem.Form1.GetY(-9);
            Assert.IsTrue(truefalse > 0 && truefalse < 100);
        }

       

        [TestMethod]
        public void TestMethod10POS()
        {
            
            int xp = unitTestSeSuchem.Form1.GetXP(1);
            int level = unitTestSeSuchem.Form1.GetLevel(18);
            Assert.IsTrue(xp * level > 0 && xp*level < 100);

        }
        [TestMethod]
        public void TestMethod10NEG()
        {
            int xp = unitTestSeSuchem.Form1.GetXP(10);
            int level = unitTestSeSuchem.Form1.GetLevel(18);
            Assert.IsTrue(xp * level > 0 && xp * level < 100);
        }


    }
}
