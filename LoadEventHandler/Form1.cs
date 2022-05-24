using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoadEventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Trying to read the text file and show contents in the List Box
            try
            {
                // Initializing a variable to hold country name
                string countryName;
                // Initializing a StreamReader variable
                StreamReader inputFile;

                // Opening a text file and storing StreamReader object in inputFile variable
                inputFile = File.OpenText("Countries.txt");

                // Reading contents of the file, while it's not an end of a file
                while (!inputFile.EndOfStream)
                {
                    // Reading a line in a file and storing it in the countryName variable
                    countryName = inputFile.ReadLine();
                    // Adding an item with the country name to the List Box 
                    countriesBox.Items.Add(countryName);
                }
                // Closing the file
                inputFile.Close();
            }
            // If an error occured while working with the file
            catch (Exception ex)
            {
                // Printing an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
