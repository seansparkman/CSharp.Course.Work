using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionTwo
{
    public class GetterSetterSeparateAccessibility
    {
        public GetterSetterSeparateAccessibility()
        {
            Value1 = 1;
        }

        public int Value1 { get; private set; }

        public int Value2 { private get; set; }

        // uncomment this line to see the compiler error
        // private int Value3 { public get; set; }

        public int GetValue2()
        {
            return Value2;
        }
    }
}
