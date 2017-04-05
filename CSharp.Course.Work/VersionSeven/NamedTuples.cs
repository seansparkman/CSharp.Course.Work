using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSeven
{
    public static class NamedTuples
    {
        public static (int x, int y) GetPoint()
        {
            return (7, 42);
        }
    }
}
