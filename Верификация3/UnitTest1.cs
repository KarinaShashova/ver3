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
        public void InterfaceSetName1()
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
        public void DependedSetName1()
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
        public void SetInterfaceMethod1()
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
            Assert.AreEqual("private:  Cl1 ob ;", pattern.privated);
        }
        [TestMethod]
        public void AdpterSetPublced()
        {
            Adapter pattern = new Adapter();
            Interface inter = new Interface();
            inter.setName("Interf");
            inter.SetType("int");
            inter.SetMethod("Meth");
            pattern.setInterface(inter);
            pattern.SetPubliced();
            Assert.AreEqual("public:  int Meth {} ;", pattern.publiced);
        }
        [TestMethod]
        public void GetAdapterCode()
        {
            Adapter adapter = new Adapter();
            Interface interf = new Interface();
            DependedClass dep = new DependedClass();
            string[] test = { "interface Interf {", "public: virtual int Method { }; }", "class Cl1 { }", "class Adapter :public Interf {", "private:  Cl1 cl ;", "public:  int Method {} ; }" };
            interf.setName("Interf");
            interf.SetType("int");
            interf.SetMethod("Method");
            dep.SetName("Cl1");
            adapter.interfaces = interf;
            adapter.dependenses.Add(dep);
            adapter.SetName("Adapter");
            adapter.objectname = "cl";
            adapter.SetPrivated();
            adapter.SetPubliced();
            adapter.GetAdapterCode();
            for (int i = 0; i < adapter.AdapterCode.Count; i++)
            {
                Assert.AreEqual(test[i], adapter.AdapterCode[i]);
            }

        }
    }
}
