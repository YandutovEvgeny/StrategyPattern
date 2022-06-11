using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintStrategyPattern
{
    public partial class Form1 : Form
    {
        Paint _paint;
        public Form1()
        {
            InitializeComponent();
            _paint = new Paint(pictureBox1.CreateGraphics());
            _paint.ChangeBrush(new Spray());
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                _paint.Draw(e.X, e.Y);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) _paint.ChangeBrush(new Spray());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) _paint.ChangeBrush(new Ellipse());
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) _paint.ChangeBrush(new Square());
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) _paint.ChangeBrush(new Picture());
        }
    }
}
