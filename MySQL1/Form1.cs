using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace MySQL1
{
    public partial class Form1 : Form
   {
        //Változók definiálása
        #region Kapcsolat properties
        private MySqlConnection mysqlConn;
        private MySqlDataReader mysqlDr;
        #endregion Kapcsolat properties

        #region Üzenet szövegek
        private string openSikeres = "A kapcsolódás az adatbázishoz sikeres!", openNemSikeres = "A kapcsolódás az adatbázishoz sikertelen!", cantoRead = "Az olvasás megkezdődhet!", closedDB = "Az adatbázis bezárva!";
        #endregion Üzenet szövegek
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlConn.Close();
            MessageBox.Show(closedDB);

            //formState = FormState.Closed;
            //buttonSwitch(formState);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mysqlConnect();
        }
        private void mysqlConnect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "iktat";

            try
            {
                mysqlConn = new MySqlConnection(sb.ToString());
                mysqlConn.Open();
                MessageBox.Show(openSikeres);

                /*var formState = FormState.Opened;
                buttonSwitch(formState);*/
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{openNemSikeres} \n {ex.Message}");
            }
        }
    }
}
