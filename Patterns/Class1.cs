using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Pattern
    {
        public Pattern(){}
    }
    public class StructPattern: Pattern
    {
        public List<DependedClass> dependenses = new List<DependedClass>();
        public Interface interfaces;
        public StructPattern() { }
        public void setInterface(Interface sinterf)
        {
            interfaces = sinterf;
        }
        public void SetDependend(DependedClass sdependenses)
        {

            dependenses.Add(sdependenses);
        }
    }
    public class Interface
    {
        public string stringname, name;
        public string type;
        public string method, stringmethod;
        public Interface() { }
        public void setName(string sname)
        {
            stringname = "interface " + sname;
            name = sname;
        }
        public void SetType(string stype)
        {
            type = stype;
        }
        public void SetMethod(string smethodname)
        {
            stringmethod = "public: virtual " + type + " " + smethodname + " { }; ";
            method = smethodname;
            
        }
    }
    public class DependedClass
    {
        public string name, stringname;
        public DependedClass() { }
        public void SetName(string sname)
        {
            name = "class " + sname + "{ }";
            stringname = sname;
        }
    }
    public class Adapter : StructPattern
    {
        public List<string> AdapterCode = new List<string>();
        public string objectname;
        public Adapter()
        {
        }
    }
}
