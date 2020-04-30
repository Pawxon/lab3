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
using System.Collections;


namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=1234;database=komis;";
        public Form1()
        {
            InitializeComponent();
        }


        public void wyswietlanie()
        {
            // Wyświetla listę samochodów z bazy danych
            listBox1.Items.Clear();

            string query = "SELECT * FROM samochody";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Udało się!");
                    while (reader.Read())
                    {

                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        listBox1.Items.Add(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5]);

                    }
                }
                else
                {
                    MessageBox.Show("Brak rekordów!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            wyswietlanie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nowy newcar = new nowy();
            newcar.Show();
            
        }

        private void button3_Delete_Click(object sender, EventArgs e)
        {

            Form2 delete = new Form2();
            delete.Show();





        }


        //Sortuje liste
        private void button4_Sort_Click(object sender, EventArgs e)
        {

            ArrayList list = new ArrayList();

            foreach (object o in listBox1.Items)
            {
                list.Add(o);
            }
            list.Sort();
            list.Reverse();
            listBox1.Items.Clear();
            foreach (object o in list)
            {
                listBox1.Items.Add(o);
            }

        }
    }
}
