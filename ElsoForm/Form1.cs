using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsoForm
{
    public partial class MainForm : Form
    {
        // Osztályváltozók
        private bool iranyFel = true;
        private bool iranyBal = true;
        private int lepesFel = 20;
        private int lepesOldal = 30;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKattints_Click(object sender, EventArgs e)
        {
            Point point = new Point(btnKattints.Location.X, btnKattints.Location.Y);
            point = btnKattints.Location;
            // Megvizsgáljuk, hogy nem megyek-e ki a formból.
            if(!iranyFel && ((point.Y - btnKattints.Height) + lepesFel) < 0)
            {
                // Függőleges irányt változtatok
                iranyFel = true;
                point.Y -= lepesFel;
            }
            if (!iranyBal && ((point.X - btnKattints.Width) + lepesOldal) < 0)
            {
                // Vízszintes irányt változtatok
                iranyBal = true;
                point.X -= lepesOldal;
            }

            // Beállítom a gomb pozícióját
            point.X += iranyBal ? lepesOldal : -lepesOldal;
            point.Y += iranyFel ? lepesFel : -lepesFel;
            btnKattints.Location = point;
            btnKattints.Location = new Point(btnKattints.Location.X - 20, btnKattints.Location.Y - 30);
        }

        private void btnKattints_MouseHover(object sender, EventArgs e)
        {
            btnKattints.BackColor = Color.Red;
        }
        private void btnKattints_MouseLeave(object sender, EventArgs e)
        {
            btnKattints.BackColor = Color.White;
            btnKattints.Text = "Kattints";
        }
    }
}
