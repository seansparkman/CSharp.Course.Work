using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSix
{
    public class NameofOperator
    {
        public string StringProperty
        {
            get { return nameof(StringProperty); }
        }
        public string IntProperty
        {
            get { return nameof(IntProperty); }
        }
    }
}
