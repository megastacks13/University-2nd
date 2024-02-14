using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TPP.LinkedList
{
    [TestClass]
    public class Test1
    {
        internal class Person
        {
            string name;
            public Person(string name)
            {
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }
        [TestMethod]
        public void AddTest()
        {
            LinkedListClass L = new LinkedListClass("Hola");
            L.Add(5);
            L.Add(5.0);
            L.Add(new Person("P"));
            Console.WriteLine(L.ToString());
            Assert.AreEqual(L.ToString(), "Hola - 5 - 5 - P - ");
        }
        [TestMethod]
        public void RemoveTest()
        {
            LinkedListClass L = new LinkedListClass("Hola");
            L.Add(5);
            L.Add(new Person("P"));
            L.Add(5.0);
            Assert.AreEqual(L.ToString(), "Hola - 5 - P - 5 - ");
            L.Remove(5.0);
            Assert.AreEqual(L.ToString(), "Hola - 5 - P - ");
            L.Remove("Hola");
            Assert.AreEqual(L.ToString(), "5 - P - ");
        }
        [TestMethod]
        public void GetElementTest()
        {
            int i = 5;
            LinkedListClass L = new LinkedListClass("Hola");
            L.Add(i);
            L.Add(new Person("P"));
            L.Add(5.0);
            Assert.AreEqual(L.ToString(), "Hola - 5 - P - 5 - ");
            
            Assert.AreEqual(i, L.GetElement(1));
        }
    }
}
