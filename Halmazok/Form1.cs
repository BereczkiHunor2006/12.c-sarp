using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halmazok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                List<int> ahalmaz = new List<int>(gd.Items.Add(i));
            }
            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                List<int> bhalmaz= new List<int>(gf.Items.Add(i));
            }
            List<int> metszet = new List<int>(gd.Items.Cast<int>().Intersect(gf.Items.Cast<int>()));
            foreach (var i in metszet)
            {
                metster.Items.Add(i);
            }
        }
    }
}
