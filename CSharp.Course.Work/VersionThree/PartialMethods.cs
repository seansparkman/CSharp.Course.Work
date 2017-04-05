using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionThree
{
    partial class PartialMethodClass
    {
        partial void PartialMethod(int x)
        {
            Value = x;
        }
    }

    partial class PartialMethodClass
    {
        public int Value { get; set; }
        partial void PartialMethod(int x);
        public void Load(int x)
        {
            PartialMethod(x);
        }
    }
}
