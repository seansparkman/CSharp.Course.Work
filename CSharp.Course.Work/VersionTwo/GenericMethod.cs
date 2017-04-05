using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionTwo
{
    public class GenericMethod
    {
        public static T Result<T>() where T : GenericMethodClassA, new()
        {
            return new T();
        }
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
