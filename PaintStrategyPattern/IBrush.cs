using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStrategyPattern
{
    interface IBrush
    {
        void Draw(Graphics graphics, int x, int y);
    }
}
