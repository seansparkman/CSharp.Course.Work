using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionSeven
{
    public static class LocalFunctions
    {
        public static int SquareFeet(int height, int width)
        {
            if (height == 0)
                throw new ArgumentException("Invalid height", nameof(height));

            if (width == 0)
                throw new ArgumentException("Invalid height", nameof(width));

            return Multiply(height, width);

            int Multiply(int x, int y)
            {
                return x * y;
            }
        }

        public static async Task<int> DoSomething()
        {
            // code some logic here...
            return await Wait();

            async Task<int> Wait()
            {
                await Task.Delay(1);
                return 42;
            }
        }
    }
}
