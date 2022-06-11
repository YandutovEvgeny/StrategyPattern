using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardStrategyPAttern
{
    class BubbleSort : IArrayController
    {
        public void DoSomething(int[] arr, int n)
        {
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int buffer = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = buffer;
                    }
                }
            }
        }
    }
}
