using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSix
{
    public class ExpressionBodiedMembers
    {
        // TODO: Convert this to an expression bodied member using lambda
        public string GetString()
        {
            return "This is a string";
        }
        // TODO: Convert this to an expression bodied member using lambda
        public int SquareFeet(int height, int width)
        {
            return height* width;
        }
    }
}
