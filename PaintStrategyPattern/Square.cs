using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStrategyPattern
{
    class Square : IBrush
    {
        public void Draw(Graphics graphics, int x, int y)
        {
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            graphics.FillRectangle(solidBrush, x, y, 10, 10);
        }
    }
}
