using Encrypter.Helpers;
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

namespace Encrypter
{
    public partial class MessageEncrypt : Form
    {
        public MessageEncrypt()
        {
            InitializeComponent();
            busyLoader.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Close();
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            busyLoader.Visible = true;
            string message = inputTextBox.Text;
            string password = keyTextBox.Text;
            outputTextBox.Text = Cryptography.Encrypt(message, password);
            inputTextBox.Text = String.Empty;
            busyLoader.Visible = false;

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                busyLoader.Visible = true;
                string cipherText = inputTextBox.Text;
                string passPhrase = keyTextBox.Text;
                outputTextBox.Text = Cryptography.Decrypt(cipherText, passPhrase, "SHA1", 3);
                inputTextBox.Text = String.Empty;
                busyLoader.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Key + Details: "+ ex.Message );
            }
           
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String fileExt = ".txt";
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(sd.FileName, Encoding.ASCII.GetBytes(outputTextBox.Text));
            }
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
