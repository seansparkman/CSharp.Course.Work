using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionTwo
{
    public class MethodGroupConversions
    {
        public string Value { get; set; }
        public void DoSomething(Func<string, string> something)
        {
            Value = something(Value);
        }

        public string Work(string value)
        {
            value += " did work";

            return value;
        }
    }
}
