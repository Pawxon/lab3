using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class nowy : Form
    {
        public nowy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=1234;database=komis;";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();

            var sql = "INSERT INTO samochody(marka,model,pojemnosc,kolor,cena) VALUES(@marka,@model,@pojemnosc,@kolor,@cena)";


            MySqlCommand commandDatabase = new MySqlCommand(sql, databaseConnection);
            commandDatabase.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            commandDatabase.Parameters.AddWithValue("@model", textBoxModel.Text);
            commandDatabase.Parameters.AddWithValue("@pojemnosc", textBoxPojemnosc.Text);
            commandDatabase.Parameters.AddWithValue("@kolor", textBoxKolor.Text);
            commandDatabase.Parameters.AddWithValue("@cena", textBoxCena.Text);




            commandDatabase.Prepare();

            commandDatabase.ExecuteNonQuery();
            


            this.Close();
            databaseConnection.Close();


        }

       
    }
}
