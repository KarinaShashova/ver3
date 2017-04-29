using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patterns;

namespace Верификация3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PatternCreationClass()
        {
            Pattern pattern = new Pattern();
            Assert.IsNotNull(pattern);
        }
        [TestMethod]
        public void StructPatternCreationClass()
        {
            StructPattern pattern = new StructPattern();
            Assert.IsNotNull(pattern);
        }
        [TestMethod]
        public void InterfaceCreationClass()
        {
            Interface interf = new Interface();
            Assert.IsNotNull(interf);
        }
        [TestMethod]
        public void InterfaceSetName()
        {
            Interface interf = new Interface();
            interf.setName("Go");
            Assert.AreEqual("interface Go", interf.stringname);
        }
        [TestMethod]
        public void InterfaceSetName()
        {
            Interface interf = new Interface();
            interf.setName("Go");
            Assert.AreEqual("Go", interf.name);
        }
        [TestMethod]
        public void GetInterface()
        {
            StructPattern pattern = new StructPattern();
            Interface interf = new Interface();
            interf.setName("Go");
            pattern.setInterface(interf);
            Assert.AreEqual(interf, pattern.interfaces);
        }
        [TestMethod]
        public void DependedCreationClass()
        {
            DependedClass depended = new DependedClass();
            Assert.IsNotNull(depended);
        }

        [TestMethod]
        public void DependedSetName()
        {
            DependedClass depended = new DependedClass();
            depended.SetName("Depend");
            Assert.AreEqual("class Depend { }", depended.name);
        }

    }
}
