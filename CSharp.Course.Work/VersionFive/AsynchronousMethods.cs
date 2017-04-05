using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionFive
{
    public static class AsynchronousMethods
    {
        public async static Task AsyncMethod()
        {
            await Task.Delay(1);
        }
    }
}
