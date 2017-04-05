using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSeven
{
    public class ExpressionBodied
    {
        public ExpressionBodied(string value) => this.Value = value;

        private string value;

        public string Value
        {
            get => value;
            set => this.value = value;
        }
    }
}
