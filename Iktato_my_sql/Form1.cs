using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iktato_my_sql
{
    public partial class Form1 : Form
    {
        // Osztályváltozók
        private MySqlConnection connection;
        private DataSet dataSet;
        private MySqlDataAdapter dataAdapter;
        private BindingSource bindingSource;
        private BeosztasokForm2 beosztasokForm2;

        private string TableName = "beosztasok";
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeDataGridView();
            InitializeBindingNavigator();
            connection.Close();
            beosztasokForm2 = new BeosztasokForm2(DBConnection.GetConnectionString_2("MyDBConnection"));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
