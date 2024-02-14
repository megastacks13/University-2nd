using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TPP.LinkedList
{
    [TestClass]
    public class OptionalTests
    {
        [TestMethod]
        public void AddTest()
        {
            LinkedList.SetClass s = new LinkedList.SetClass(1);
            s.Add(1);
            s.Add("Hola");
            s.Add(2);
            s.Add(1);
            Assert.AreEqual(s.ToString(), "1 - Hola - 2 - ");
        }

        [TestMethod]
        public void AddOperatorTest()
        {
            LinkedList.SetClass s = new LinkedList.SetClass(1);
            s.Add("Hola");
            s = s + 2;
            Assert.AreEqual(s.ToString(), "1 - Hola - 2 - ");
        }

        [TestMethod]
        public void RemoveOperatorTest()
        {
            LinkedList.SetClass s = new LinkedList.SetClass(1);
            s.Add("Hola");
            s += 2;
            s -= 1;
            Assert.AreEqual(s.ToString(), "Hola - 2 - ");
        }

        [TestMethod]
        public void GetOperatorTest()
        {
            LinkedList.SetClass s = new LinkedList.SetClass(1);
            s.Add("Hola");
            s += 2;
            Assert.AreEqual(s[1], "Hola");
        }
        [TestMethod]
        public void ContainedOperatorTest()
        {
            LinkedList.SetClass s = new LinkedList.SetClass(1);
            s.Add("Hola");
            s += 2;
            Assert.AreEqual(s^"Hola", true);
        }

        [TestMethod]
        public void UnionOperatorTest()
        {
            LinkedList.SetClass s = new LinkedList.SetClass(1);
            s.Add("Hola");
            s += 2;
            
            LinkedList.SetClass j = new SetClass(3);
            SetClass k = s | j;
            Assert.AreEqual(k.ToString(), "1 - Hola - 2 - 3 - ");
        }

        [TestMethod]
        public void IntersectionOperatorTest()
        {
            LinkedList.SetClass s = new LinkedList.SetClass(1);
            s.Add("Hola");
            s = s + 2;

            LinkedList.SetClass j = new SetClass(3);
            j = j + 2;
            SetClass k = s & j;
            Assert.AreEqual(k.ToString(), "2 - ");
        }
        [TestMethod]
        public void DifferenceOperatorTest()
        {
            LinkedList.SetClass s = new LinkedList.SetClass(1);
            s.Add("Hola");
            s = s + 2;

            LinkedList.SetClass j = new SetClass(3);
            j = j + 2;
            SetClass k = s - j;
            Assert.AreEqual(k.ToString(), "1 - Hola - 3 - ");
        }
    }
}
