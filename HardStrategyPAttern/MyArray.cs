using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardStrategyPAttern
{
    class MyArray
    {
        IArrayController arrayController;
        public int[] Arr { get; set; }
        public int N { get; private set; }

        public MyArray(int n)
        {
            Arr = new int[n];
            N = n;
            arrayController = new Randomator();
            arrayController.DoSomething(Arr, N);
        }

        public void ChangeController(IArrayController controller)
        {
            arrayController = controller;
        }
        public void ApplyController()
        {
            arrayController.DoSomething(Arr, N);
        }

        public string GetResult()
        {
            string result = "";
            for (int i = 0; i < N; i++)
            {
                result += Arr[i] + " ";
            }
            return result;
        }
    }
}
