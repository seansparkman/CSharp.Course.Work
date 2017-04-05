using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSeven
{
    public class TypeSwitchA
    {
        public string StringProperty { get; } = "This is a string";
    }
    public class TypeSwitchB
        : TypeSwitchA
    {
        public int IntProperty { get; } = 42;
    }
    public class TypeSwitchC
        : TypeSwitchA
    {
        public int StringProperty { get; } = 7;
    }
}
