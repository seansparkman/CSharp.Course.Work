using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSix
{
    public class AutoPropertyInitializers
    {

        public string StringProperty { get; } = "This is a string";
        public int IntProperty { get; } = 42;
        public AutoPropertyInitializers2 ObjectProperty { get; } = new AutoPropertyInitializers2
        {
            AnotherProperty = "Yes, another property"
        };
    }

    public class AutoPropertyInitializers2
    {
        public string AnotherProperty { get; set; }
    }
}
