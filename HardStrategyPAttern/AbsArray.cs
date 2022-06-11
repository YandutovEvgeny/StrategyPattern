using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardStrategyPAttern
{
    class AbsArray : IArrayController
    {
        public void DoSomething(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = Math.Abs(arr[i]);
            }
        }
    }
}
