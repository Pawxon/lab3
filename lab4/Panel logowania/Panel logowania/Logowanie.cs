using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;







namespace Panel_logowania
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }





        static void Hash(string[] args)
        {
            string plainData = "1234";
            Console.WriteLine("Raw data: {0}", plainData);
            string hashedData = ComputeSha256Hash(plainData);
            Console.WriteLine("Hash {0}", hashedData);
            Console.WriteLine(ComputeSha256Hash("Mahesh"));
            Console.ReadLine();
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void clear_Click(object sender, EventArgs e)
        {
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";

        }


        private void log_in_Click(object sender, EventArgs e)
        {
            string hashedData = ComputeSha256Hash(textBoxPassword.Text);

            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Podaj login", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else


            if (textBoxPassword.Text == "")
            {

                MessageBox.Show("Podaj hasło", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else

            if ((textBoxLogin.Text == "Pawel") && (hashedData == ComputeSha256Hash("1234"))){
                this.Hide();

                uzytkownik1 loginCheckWindow = new uzytkownik1();
                loginCheckWindow.Show();
                
            }
            else

            if ((textBoxLogin.Text == "Jakub") && (hashedData == ComputeSha256Hash("5678")))
            {
                this.Hide();

                uzytkownik2 loginCheckWindow = new uzytkownik2();
                loginCheckWindow.Show();

            }
            else

            
            {

                MessageBox.Show("Podałeś niepoprawne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

       
    }
}
