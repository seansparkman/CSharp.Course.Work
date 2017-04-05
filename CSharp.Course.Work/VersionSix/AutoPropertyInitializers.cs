using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSix
{
    public class AutoPropertyInitializers
    {
        // TODO: set StringProperty to "This is a string" by default
        public string StringProperty { get; }
        // TODO: Set IntProperty to 42 by default
        public int IntProperty { get; }
        // TODO: Set ObjectProperty to a new AutoPropertyInitializers2 and
        // assign AnotherProperty with "Yes, another property"
        public AutoPropertyInitializers2 ObjectProperty { get; }
    }

    public class AutoPropertyInitializers2
    {
        public string AnotherProperty { get; set; }
    }
}
