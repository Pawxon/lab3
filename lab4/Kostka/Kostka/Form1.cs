using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kostka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            losuj();
        }

      

        public void losuj()
        {
            Random rnd = new Random();
            int T = rnd.Next(1, 7);

            wynik.Text = T.ToString();

        }
        

        public void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Po naciśnięciu klawisza r, wylosuje nową wartość
            if (e.KeyChar == 'r')
            {
                
                losuj();
            }
        }


        private void doSchowka(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(wynik.Text);
        }

        
    }
}
