using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionTwo
{
    public class GenericMethod
    {
        // implement static method Result of Type T where T is GenericMethodClassA and new-able
    }

    public class GenericMethodClassA
    {
        public virtual string Result()
        {
            return "A";
        }
    }

    public class GenericMethodClassB
        : GenericMethodClassA
    {
        public override string Result()
        {
            return "B";
        }
    }
}
