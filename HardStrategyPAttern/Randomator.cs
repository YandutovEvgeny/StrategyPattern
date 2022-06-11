using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardStrategyPAttern
{
    class Randomator : IArrayController
    {
        public void DoSomething(int[] arr, int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-10, 11);
            }
        }
    }
}
