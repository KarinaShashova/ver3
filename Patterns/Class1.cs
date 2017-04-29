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
        public StructPattern() { }
    }
    public class Interface
    {
        public string stringname, name;
        public Interface() { }
        public void setName(string sname)
        {
            stringname = "interface " + sname;
            name = sname;
        }
    }
}
