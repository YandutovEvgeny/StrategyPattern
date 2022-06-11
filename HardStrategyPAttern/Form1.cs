using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardStrategyPAttern
{
    public partial class Form1 : Form
    {
        MyArray _array;
        public Form1()
        {
            InitializeComponent();
            _array = new MyArray(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                _array.ChangeController(new Randomator());
                _array.ApplyController();
                MessageBox.Show(_array.GetResult());
            }
            if(radioButton2.Checked)
            {
                _array.ChangeController(new BubbleSort());
                _array.ApplyController();
                MessageBox.Show(_array.GetResult());
            }
            if(radioButton3.Checked)
            {
                _array.ChangeController(new AbsArray());
                _array.ApplyController();
                MessageBox.Show(_array.GetResult());
            }
        }
    }
}
