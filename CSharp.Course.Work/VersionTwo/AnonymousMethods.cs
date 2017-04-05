using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionTwo
{
    public delegate void DoWorkHandler(object sender, EventArgs args);
    public class AnonymousMethods
    {
        public AnonymousMethods()
        {
        }

        public event DoWorkHandler Worked;

        public void OnWorked(EventArgs args)
        {
            var worked = Worked;
            if (worked != null)
            {
                worked(this, args);
            }
        }
    }
}
