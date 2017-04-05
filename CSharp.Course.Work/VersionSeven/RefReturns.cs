using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSeven
{
    public static class RefReturns
    {
        public static ref char GetRef(char[] list, int index)
        {
            return ref list[index];
        }

    }
}
