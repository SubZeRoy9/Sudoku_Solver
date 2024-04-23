using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaeringProject
{
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
            SaveButton.Click += SaveButton_Click; //event handler for the save button
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileDialog = new SaveFileDialog();
            savefileDialog.Filter = "Text Files (.txt)|*.txt";

            if (savefileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String userInput = textBox1.Text; //saves the user input in a string
                    String filePath = savefileDialog.FileName; //saves the file path as a string.

                    File.WriteAllText(filePath, userInput); //saves the file
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error"); // if there is an error saving, it will print "error".
                }

            };


        }
    }
}
