using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionFour
{
    public static class NamedAndOptionalParameters
    {
        public static int SquareFeet(int height, int width)
        {
            return height * width;
        }

        public static string Repeat(string word, int times = 2)
        {
            return string.Join(" ", Enumerable.Repeat(word, times).ToArray());
        }
    }
}
