using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStrategyPattern
{
    class Spray : IBrush
    {
        public void Draw(Graphics graphics, int x, int y)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                graphics.FillEllipse(solidBrush, random.Next(-10 ,11) + x, 
                    random.Next(-10, 11) + y, 2, 2);
            }
             
        }
    }
}
