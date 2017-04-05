using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionTwo
{
    public class Iterators
    {
        public Iterators()
        {
            Iterations = 0;
        }

        public int Iterations { get; set; }

        public IEnumerable<int> GetEnumerator()
        {
            Iterations++;
            yield return 3;
            Iterations++;
            yield return 5;
            Iterations++;
            yield return 7;
            Iterations++;
        }
    }
}
