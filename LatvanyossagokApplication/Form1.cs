using MySql.Data.MySqlClient;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;
namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {

        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = latvanyossagokdb; Uid = root; Pwd = ");
            conn.Open();
            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    MessageBox.Show("Hiba a kapcsolódás során!");
                    conn.Close();
                }

            };
        }
    }
}
