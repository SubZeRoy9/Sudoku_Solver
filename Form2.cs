using System;
using System.IO;
using System.Windows.Forms;

namespace HaeringProject
{
    public partial class Form2 : Form
    {
        public static String filePath;
        public static int difficulty; // A variable to represent difficulty. 
        public Form2()
        {
            InitializeComponent();
        }

        //Easy Button event lisener
        private void easyButton_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            Form1 form1 = new Form1(difficulty);
            form1.Show();
        }
        
        //Medium Button Event Listener
        private void mediumButton_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            Form1 form1 = new Form1(difficulty);
            form1.Show();

        }

        //Hard Button Event Listener
        private void hardButton_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            Form1 form1 = new Form1(difficulty);
            form1.Show();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            difficulty = 4;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int[,] userBoard = new int[9, 9];
                filePath = openFileDialog.FileName;

                String[] fileContents = File.ReadAllLines(filePath);

                for (int i = 0; i < fileContents.Length; i++)
                {
                    // Split the line by spaces to get individual numbers
                    string[] numbers = fileContents[i].Split(' ');

                    // Loop through each number in the line
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        // Parse the string to integer and assign it to the array
                        userBoard[i, j] = int.Parse(numbers[j]);
                    }
                }
                Form1 form1 = new Form1(4, userBoard);
                form1.Show();


            }

        }
    }
}
