using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSeven
{
    public class ExpressionBodied
    {
        // TODO: Convert the constructor to an expression
        public ExpressionBodied(string value)
        {
            this.Value = value;
        }
        ~ExpressionBodied()
        {
            Console.WriteLine("FINALLY DONE");
        }

        private string value;

        // TODO: Convert this property to property expression
        public string Value { get; set; }
    }
}
