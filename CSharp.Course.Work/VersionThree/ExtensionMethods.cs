using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionThree
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/extension-methods
    /// </summary>
    public static class ExtensionMethods
    {
        public static int WordCount(this String text)
        {
            return text.Split(new char[] { ' ', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
