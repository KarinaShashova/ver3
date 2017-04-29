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
        [TestMethod]
        public void DependedSetName()
        {
            DependedClass depended = new DependedClass();
            depended.SetName("Depend");
            Assert.AreEqual("Depend", depended.stringname);
        }
        [TestMethod]
        public void GetDependend()
        {
            StructPattern pattern = new StructPattern();
            DependedClass dep = new DependedClass();
            dep.SetName("Class1");
            pattern.SetDependend(dep);
            Assert.AreEqual(dep, pattern.dependenses[0]);
        }
        [TestMethod]
        public void SetType()
        {
            Interface interf = new Interface();
            interf.SetType("int");
            Assert.AreEqual("int", interf.type);
        }
        [TestMethod]
        public void SetInterfaceMethod()
        {
            Interface interf = new Interface();
            interf.SetType("int");
            interf.SetMethod("InterfaceMethod");
            Assert.AreEqual("public: virtual int InterfaceMethod { }; ", interf.stringmethod);
        }
        [TestMethod]
        public void SetInterfaceMethod()
        {
            Interface interf = new Interface();
            interf.SetType("int");
            interf.SetMethod("InterfaceMethod");
            Assert.AreEqual("InterfaceMethod", interf.method);
        }
        [TestMethod]
        public void AdpterPatternCreationClass()
        {
            Adapter pattern = new Adapter();
            Assert.IsNotNull(pattern);
        }
        [TestMethod]
        public void AdpterSetPrivated()
        {
            Adapter pattern = new Adapter();
            DependedClass dep= new DependedClass();
            dep.SetName("Cl1");
            pattern.objectname="ob";
            pattern.SetDependend(dep);
            pattern.SetPrivated();
            Assert.AreEqual("private: Cl1 ob ;", pattern.privated);
        }
    }
}
