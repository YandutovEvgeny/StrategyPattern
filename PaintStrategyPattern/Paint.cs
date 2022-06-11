using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStrategyPattern
{
    class Paint
    {
        IBrush _brush;
        Graphics _graphics;

        public Paint(Graphics graphics)
        {
            _graphics = graphics;
        }

        public void ChangeBrush(IBrush brush)
        {
            _brush = brush;
        }
        public void Draw(int x, int y)
        {
            _brush.Draw(_graphics, x, y);
        }
    }
}
