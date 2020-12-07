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
                    //MessageBox.Show("Hiba a kapcsolódás során!");
                    conn.Close();
                }

            };
            letrehoz();
            varosadatBetoltes();
            latvanyossagokBetoltes();
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



        void varosadatBetoltes()
        {

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
                    List<Latvanyossagok> lista = new List<Latvanyossagok>();

                    //string uzlet;

                    //try
                    //{
                    //    uzlet = reader.GetString("uzlet");
                    //}
                    //catch (SqlNullValueException ex)
                    //{
                    //    uzlet = null;
                    //}

                    var varos = new Varosok(id, nev, lakossag, lista);
                    lbox_varosok.Items.Add(varos);
                }
            }


        }

        void latvanyossagokBetoltes()
        {

            string sql = @"
SELECT id, nev, leiras, ar, varos_id 
FROM latvanyossagok 
order by id;
";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string leiras = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int varos_id = reader.GetInt32("varos_id");

                    //string uzlet;

                    //try
                    //{
                    //    uzlet = reader.GetString("uzlet");
                    //}
                    //catch (SqlNullValueException ex)
                    //{
                    //    uzlet = null;
                    //}

                    var latvanyossag = new Latvanyossagok(id, nev, leiras, ar, varos_id);
                }
            }
            comboboxfeltoltes();

        }

        void comboboxfeltoltes()
        {
            cbox_varos.Items.Clear();
            List<string> varosnevek = new List<string>();
            for (int i = 0; i < lbox_varosok.Items.Count; i++)
            {
                Varosok va = (Varosok)lbox_varosok.Items[i];
                varosnevek.Add(va.Nev);
            }

            for (int i = 0; i < varosnevek.Count; i++)
            {
                cbox_varos.Items.Add(varosnevek[i]);
            }

        }
        private void btn_add_Click(object sender, System.EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < lbox_varosok.Items.Count; i++)
            {
                Varosok v = (Varosok)lbox_varosok.Items[i];
                id = v.Id;
                id++;
            }
            string nev = text_nev.Text;
            int lakossag = (int)numeric_lakossag.Value;
            bool letezik = false;
            List<Latvanyossagok> lista = new List<Latvanyossagok>();



            var varos = new Varosok(id, nev, lakossag, lista);

            //ellenőrzések 
            List<string> varosnevek = new List<string>();
            for (int i = 0; i < lbox_varosok.Items.Count; i++)
            {
                Varosok va = (Varosok)lbox_varosok.Items[i];
                varosnevek.Add(va.Nev);
            }

            if (varosnevek.Contains(nev))
            {
                MessageBox.Show("ilyen név már létezik");
                letezik = true;
            }
            if (nev.Length == 0)
            {
                MessageBox.Show("nem lehet üres a név mező!");
            }
            if (lakossag == 0)
            {
                MessageBox.Show("nem lehet 0 a lakosság!");
            }




            if (lakossag != 0 && nev.Length != 0 && letezik == false)
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

                lbox_varosok.Items.Add(varos);
                comboboxfeltoltes();
            }
        }

        private void btn_latvanyossag_Click(object sender, System.EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < lbox_varos_latvanyossagok.Items.Count; i++)
            {
                Latvanyossagok l = (Latvanyossagok)lbox_varos_latvanyossagok.Items[i];
                id = l.Id;
                id++;
            }
            string nev = txt_lnev.Text;
            string leiras = txt_leiras.Text;
            int ar = Convert.ToInt32(nud_ar.Value);


            int varos_id = Convert.ToInt32(cbox_varos.SelectedIndex) + 1;

            var latvanyossag = new Latvanyossagok(id, nev, leiras, ar, varos_id);




            //Ellenőrzések
            if (nev.Length == 0)
            {
                MessageBox.Show("nem lehet üres a név mező");
            }
            if (leiras.Length == 0)
            {
                MessageBox.Show("nem lehet üres a leírás");
            }
            if (ar == 0)
            {
                MessageBox.Show("Az ár nem lehet  nulla");
            }
            if (varos_id == -1)
            {
                MessageBox.Show("A város id-t ki kell választani!");
            }



            if (nev.Length != 0 && leiras.Length != 0 && ar != 0 && varos_id != -1)
            {
                var insertComm = conn.CreateCommand();
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



            }


            latvanyossagujratolt();
        }

        private void btn_varos_edit_Click(object sender, EventArgs e)
        {
            Varosok v = (Varosok)lbox_varosok.SelectedItem;
            int id = v.Id;
            int lakossag = Convert.ToInt32(numeric_lakossag.Value);
            List<Latvanyossagok> lista = new List<Latvanyossagok>();

            List<string> varosnevek = new List<string>();
            for (int i = 0; i < lbox_varosok.Items.Count; i++)
            {
                Varosok va = (Varosok)lbox_varosok.Items[i];
                varosnevek.Add(va.Nev);
            }

            if (varosnevek.Contains(text_nev.Text))
            {
                MessageBox.Show("ilyen város név már létezik!");
                text_nev.Text = v.Nev;
            }
            else
            {
                Varosok v2 = new Varosok(id, text_nev.Text, lakossag, lista);
                lbox_varosok.Items[lbox_varosok.SelectedIndex] = v2;
                var editComm = conn.CreateCommand();
                editComm.CommandText = @"
UPDATE varosok SET nev = @nev, lakossag = @lakossag WHERE varosok.id = @id;
";

                editComm.Parameters.AddWithValue("@id", id);
                editComm.Parameters.AddWithValue("@nev", text_nev.Text);
                editComm.Parameters.AddWithValue("@lakossag", lakossag);
                int erintettSorok = editComm.ExecuteNonQuery();
            }

        }

        private void lbox_varosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_varos_delete.Visible = true;
            btn_varos_edit.Visible = true;
            lbox_varos_latvanyossagok.Items.Clear();
            Varosok v = (Varosok)lbox_varosok.SelectedItem;
            if (lbox_varosok.SelectedItem == null)
            {
                nup_test.Value = 0;
                text_nev.Text = " ";
                numeric_lakossag.Value = 0;
            }
            else
            {
                //nup_test.Value = v.Id;
                text_nev.Text = v.Nev;
                numeric_lakossag.Value = v.Lakossag;
            }

            //nup_test.Value = lbox_varosok.SelectedIndex+1;




            string sql = @"
SELECT `id`, `nev`, `leiras`, `ar`, `varos_id` 
FROM `latvanyossagok` 
WHERE varos_id = @kivalasztott_varosid";


            int vid = lbox_varosok.SelectedIndex + 1;
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@kivalasztott_varosid", vid);
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string leiras = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int varos_id = reader.GetInt32("varos_id");

                    v.Latvanyossagok.Add(new Latvanyossagok(id, nev, leiras, ar, varos_id));
                    var latvany = new Latvanyossagok(id, nev, leiras, ar, varos_id);
                    lbox_varos_latvanyossagok.Items.Add(latvany);



                }
            }

        }
        
        private void latvanyossagujratolt()
        {
            lbox_varos_latvanyossagok.Items.Clear();
            Varosok v = (Varosok)lbox_varosok.SelectedItem;

            string sql = @"
SELECT `id`, `nev`, `leiras`, `ar`, `varos_id` 
FROM `latvanyossagok` 
WHERE varos_id = @kivalasztott_varosid";


            int vid = lbox_varosok.SelectedIndex + 1;
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@kivalasztott_varosid", vid);
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string leiras = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int varos_id = reader.GetInt32("varos_id");

                    v.Latvanyossagok.Add(new Latvanyossagok(id, nev, leiras, ar, varos_id));
                    var latvany = new Latvanyossagok(id, nev, leiras, ar, varos_id);
                    lbox_varos_latvanyossagok.Items.Add(latvany);



                }
            }

        }

        private int latvanyossagokszama()
        {

            Varosok v = (Varosok)lbox_varosok.SelectedItem;
            if (lbox_varosok.SelectedItem == null)
            {
                nup_test.Value = 0;
                text_nev.Text = " ";
                numeric_lakossag.Value = 0;
            }
            else
            {
                //nup_test.Value = v.Id;
                text_nev.Text = v.Nev;
                numeric_lakossag.Value = v.Lakossag;
            }

            string sql = @"
SELECT `id`, `nev`, `leiras`, `ar`, `varos_id` 
FROM `latvanyossagok` 
WHERE varos_id = @kivalasztott_varosid";


            int vid = lbox_varosok.SelectedIndex + 1;
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@kivalasztott_varosid", vid);
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string leiras = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int varos_id = reader.GetInt32("varos_id");
                    v.Latvanyossagok.Add(new Latvanyossagok(id, nev, leiras, ar, varos_id));
                   



                }
            }
            return v.Latvanyossagok.Count;
        }

       

        private void btn_varos_delete_Click(object sender, EventArgs e)
        {
            int latvanyossagdb = latvanyossagokszama();

            if (latvanyossagdb == 0)
            {
                var deleteComm = conn.CreateCommand();
                deleteComm.CommandText = @"
DELETE FROM `varosok` WHERE varosok.id = @id;
";
                var foreigncheckonComm = conn.CreateCommand();

                foreigncheckonComm.CommandText = @"SET FOREIGN_KEY_CHECKS=0;";
                foreigncheckonComm.ExecuteNonQuery();

                Varosok v = (Varosok)lbox_varosok.SelectedItem;
                int id = v.Id;
                deleteComm.Parameters.AddWithValue("@id", id);
                int erintettSorok = deleteComm.ExecuteNonQuery();
                lbox_varosok.Items.RemoveAt(lbox_varosok.SelectedIndex);

                var foreigncheckoffComm = @"SET FOREIGN_KEY_CHECKS=0;";
                foreigncheckonComm.ExecuteNonQuery();
                btn_varos_delete.Visible = false;
                btn_varos_edit.Visible = false;
            }
            else
            {
                MessageBox.Show("Ennek a városnak van látványossága nem lehet törölni!");
            }


        }

        private void lbox_varos_latvanyossagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Latvanyossagok l = (Latvanyossagok)lbox_varos_latvanyossagok.SelectedItem;
            if (lbox_varos_latvanyossagok.SelectedItem == null)
            {
                txt_lnev.Text = "";
                txt_leiras.Text = "";
                nud_ar.Value = 0;
                cbox_varos.SelectedIndex = -1;
                btn_latvany_edit.Visible = false;
                btn_latvany_delete.Visible = false;
            }
            else
            {
                txt_lnev.Text = l.Nev;
                txt_leiras.Text = l.Leiras;
                nud_ar.Value = l.Ar;
                cbox_varos.SelectedIndex = l.Varos_id-1;
                btn_latvany_edit.Visible = true;
                btn_latvany_delete.Visible = true;
            }
        }

        private void btn_latvany_edit_Click(object sender, EventArgs e)
        {
            Latvanyossagok l = (Latvanyossagok)lbox_varos_latvanyossagok.SelectedItem;
            int id = l.Id;
            int ar = Convert.ToInt32(nud_ar.Value);
            Latvanyossagok l2 = new Latvanyossagok(id, txt_lnev.Text, txt_leiras.Text, ar, cbox_varos.SelectedIndex);
            lbox_varos_latvanyossagok.Items[lbox_varos_latvanyossagok.SelectedIndex] = l2;

            var editComm = conn.CreateCommand();
            editComm.CommandText = @"
UPDATE latvanyossagok SET nev = @nev, leiras = @leiras, ar = @ar, varos_id = @varos_id WHERE latvanyossagok.id = @id;
";

            editComm.Parameters.AddWithValue("@id", id);
            editComm.Parameters.AddWithValue("@nev", txt_lnev.Text);
            editComm.Parameters.AddWithValue("@leiras", txt_leiras.Text);
            editComm.Parameters.AddWithValue("@ar", ar);
            editComm.Parameters.AddWithValue("@varos_id", cbox_varos.SelectedIndex+1);
            int erintettSorok = editComm.ExecuteNonQuery();

        }

        private void btn_latvany_delete_Click(object sender, EventArgs e)
        {


                var deleteComm = conn.CreateCommand();
                deleteComm.CommandText = @"
DELETE FROM latvanyossagok WHERE latvanyossagok.id = @id;
";
                var foreigncheckonComm = conn.CreateCommand();

                foreigncheckonComm.CommandText = @"SET FOREIGN_KEY_CHECKS=0;";
                foreigncheckonComm.ExecuteNonQuery();

                Latvanyossagok l = (Latvanyossagok)lbox_varos_latvanyossagok.SelectedItem;
                int id = l.Id;
                deleteComm.Parameters.AddWithValue("@id", id);
                int erintettSorok = deleteComm.ExecuteNonQuery();
                lbox_varos_latvanyossagok.Items.RemoveAt(lbox_varos_latvanyossagok.SelectedIndex);

                var foreigncheckoffComm = @"SET FOREIGN_KEY_CHECKS=0;";
                foreigncheckonComm.ExecuteNonQuery();

            btn_latvany_edit.Visible = false;
            btn_latvany_delete.Visible = false;

        }
    }
}
