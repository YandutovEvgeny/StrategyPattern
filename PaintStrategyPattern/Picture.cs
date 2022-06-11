using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStrategyPattern
{
    class Picture : IBrush
    {
        public void Draw(Graphics graphics, int x, int y)
        {
            graphics.DrawImage(Image.FromFile("C:\\Users\\Admin\\Figures\\bird.png"), x, y, 25, 25);
        }
    }
}
