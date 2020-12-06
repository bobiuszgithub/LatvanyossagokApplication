using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace LatvanyossagokApplication
{
    public partial class LatvanyossagokApplication : Form
    {

        MySqlConnection conn;

        public LatvanyossagokApplication()
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
            adatBetoltes();
        }


        void letrehoz()
        {

            var createvarosokComm = conn.CreateCommand();

            createvarosokComm.CommandText = @"
CREATE TABLE IF NOT EXISTS latvanyossagokdb.varosok(
             id INT(10) NOT NULL AUTO_INCREMENT,
             nev TEXT NOT NULL,
             lakossag INT(10) NOT NULL,
             PRIMARY KEY(`id`),
             UNIQUE (nev)
);
";
            createvarosokComm.ExecuteNonQuery();

            var createlatvanyossagokComm = conn.CreateCommand();

            createlatvanyossagokComm.CommandText = @"
CREATE TABLE IF NOT EXISTS latvanyossagokdb.latvanyossagok (
              id INT(10) NOT NULL AUTO_INCREMENT,
              nev TEXT NOT NULL,
              leiras TEXT NOT NULL,
              ar INT(10) NOT NULL DEFAULT '0',
              varos_id INT(10) NOT NULL,
              PRIMARY KEY (id),
              FOREIGN KEY (varos_id) REFERENCES varosok(id)
);
";
            createlatvanyossagokComm.ExecuteNonQuery();


        }



        private List<string> adatBetoltes()
        {
            List<string> lista = new List<string>();

            lista.Clear();

            string sql = @"
SELECT id, nev, lakossag 
FROM `varosok` 
ORDER BY ID
";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    int lakossag = reader.GetInt32("lakossag");
                    Varosok v = new Varosok(id, nev, lakossag);
                    //lista.Add(nev);
                    lbox.Items.Add(v);
                }
            }


            return lista;
        }



        private void btn_add_Click(object sender, System.EventArgs e)
        {
            List<string> lista = adatBetoltes();

            lbox.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                lbox.Items.Add(lista[i]);
            }

            string nev = text_nev.Text;
            int lakossag = (int)numeric_lakossag.Value;
            if (nev.Length == 0)
            {
                MessageBox.Show("nem lehet üres a név mező!");
            }
            if (lakossag == 0)
            {
                MessageBox.Show("nem lehet 0 a lakosság!");
            }
            if (lista.Contains(nev))
            {
                MessageBox.Show("Már van ilyen név az adatbázisban!");
            }
            if (lakossag != 0 && nev.Length != 0 && !lista.Contains(nev))
            {
                var insertComm = conn.CreateCommand();
                insertComm.CommandText = @"
INSERT INTO varosok (id, nev, lakossag)
VALUES (@id, @nev, @lakossag);
";

                insertComm.Parameters.AddWithValue("@id", null);
                insertComm.Parameters.AddWithValue("@nev", nev);
                insertComm.Parameters.AddWithValue("@lakossag", lakossag);
                int erintettSorok = insertComm.ExecuteNonQuery();

                lbox.Refresh();

            }
        }

        private void btn_latvanyossag_Click(object sender, System.EventArgs e)
        {
            List<string> lista = adatBetoltes();
            for (int i = 0; i < lista.Count; i++)
            {
                cbox_varos.Items.Add(lista[i]);
            }


            var insertComm = conn.CreateCommand();

            string nev = txt_lnev.Text;
            string leiras = txt_leiras.Text;
            int ar = Convert.ToInt32(nud_ar.Value);
            int varos_id = Convert.ToInt32(cbox_varos.SelectedItem);



            insertComm.CommandText = @"
INSERT INTO latvanyossagok (id, nev, leiras, ar, varos_id) 
VALUES(@id, @nev, @leiras, @ar, @varos_id);
";
            insertComm.Parameters.AddWithValue("@id", null);
            insertComm.Parameters.AddWithValue("@nev", nev);
            insertComm.Parameters.AddWithValue("@leiras", leiras);
            insertComm.Parameters.AddWithValue("@ar", ar);
            insertComm.Parameters.AddWithValue("@varos_id", varos_id);
            int erintettSorok = insertComm.ExecuteNonQuery();

            lbox.Refresh();

        }
    }
}
