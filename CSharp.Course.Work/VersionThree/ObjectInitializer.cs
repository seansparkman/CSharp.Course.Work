using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionThree
{
    public class ObjectInitializer
    {
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }
        public ObjectInitializer2 ObjectProperty { get; set; }
    }


    public class ObjectInitializer2
    {
        public string AnotherProperty { get; set; }
    }
}
