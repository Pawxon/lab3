using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String p = textBox1.Text;
            Int64 liczba = Convert.ToInt64(p);
            int lenght = p.Length;
            Int64[] wspolczynniki = new Int64[] {1,3,7,9,1,3,7,9,1,3 };

            if (lenght != 11)
            {
                label2.Text = "Pesel NIEPORPAWNY!";

            }
            else
            {
                Int64 suma =0;
                Int64 tempint =10000000000;
                for (int i=0; i<10; i++)
                {
                    suma += wspolczynniki[i] * (liczba / tempint % 10);
                    tempint = tempint / 10;
                }
               
                
                Int64 warunek = 10 - (suma%10); 
                if (warunek == 10)
                {
                    warunek = 0;
                }

                if (warunek == (liczba%10) )
                {
                    label2.Text = "Pesel poprawny";
                }
                else
                {
                    label2.Text = "Pesel NIEPORPAWNY!";
                }

                Debug.WriteLine(p);
                Debug.WriteLine(lenght);
                Debug.WriteLine(suma);
                Debug.WriteLine(warunek);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
