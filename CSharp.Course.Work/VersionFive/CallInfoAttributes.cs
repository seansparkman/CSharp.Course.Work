using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionFive
{
    public static class CallInfoAttributes
    {
        public static CallInformation CallInfo(
            [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
            [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
            [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            return new CallInformation
            {
                CallerMemberName = memberName,
                CallerFilePath = sourceFilePath,
                CallerLineNumber = sourceLineNumber
            };
        }
    }

    public class CallInformation
    {
        public string CallerMemberName { get; set; }
        public string CallerFilePath { get; set; }
        public int CallerLineNumber { get; set; }
    }
}
