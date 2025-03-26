using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KepekKorbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label5.Image = label6.Image;
            label6.Image = label7.Image;
            label7.Image = label8.Image;
            label8.Image = label9.Image;
            label9.Image = label10.Image;
            label10.Image = label3.Image;
            label3.Image = label4.Image;
            label4.Image = label5.Image;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label5.Image = label4.Image;
            label4.Image = label3.Image;
            label3.Image = label10.Image;
            label10.Image = label9.Image;
            label9.Image = label8.Image;
            label8.Image = label7.Image;
            label7.Image = label6.Image;
            label6.Image = label5.Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
