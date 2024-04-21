using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaeringProject
{
    public partial class Form2 : Form
    {
        public static int difficulty; // A variable to represent difficulty. 
        public Form2()
        {
            InitializeComponent();
        }

        //Easy Button event lisener
        private void button1_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            Form1 form1 = new Form1(difficulty);
            form1.Show();
        }
        
        //Medium Button Event Listener
        private void button2_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            Form1 form1 = new Form1(difficulty);
            form1.Show();

        }

        //Hard Button Event Listener
        private void button3_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            Form1 form1 = new Form1(difficulty);
            form1.Show();
        }
    }
}
