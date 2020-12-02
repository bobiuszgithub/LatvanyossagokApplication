using MySql.Data.MySqlClient;
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
            letrehoz();
        }


        void letrehoz()
        {

            var createvarosokComm = conn.CreateCommand();

            createvarosokComm.CommandText = @"
CREATE TABLE IF NOT EXISTS latvanyossagokdb.varosok(
             id INT(10) NOT NULL AUTO_INCREMENT,
             nev TEXT NOT NULL,
             lakossag INT(10) NOT NULL,
             PRIMARY KEY(`id`)
);
";
            createvarosokComm.ExecuteNonQuery();

            var createlatvanyossagokComm = conn.CreateCommand();

            createlatvanyossagokComm.CommandText = @"
CREATE TABLE IF NOT EXISTS latvanyossagokdb.latvanyossagok (
              id INT(10) NOT NULL AUTO_INCREMENT,
              nev TEXT NOT NULL,
              leiras TEXT NOT NULL,
              ar INT(10) NOT NULL,
              varos_id INT(10) NOT NULL,
              PRIMARY KEY (id),
              FOREIGN KEY (varos_id) REFERENCES varosok(id)
);
";
            createlatvanyossagokComm.ExecuteNonQuery();


        }



    }
}
