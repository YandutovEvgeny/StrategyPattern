using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    public partial class Form1 : Form
    {
        Explorer Dora;
        public Form1()
        {
            InitializeComponent();
            Dora = new Explorer("Даша - путешественница");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) Dora.Moveble = new Walk();
            if (radioButton2.Checked) Dora.Moveble = new Car();
            if (radioButton3.Checked) Dora.Moveble = new Fly();
            MessageBox.Show(Dora.Move());
        }
    }
}
