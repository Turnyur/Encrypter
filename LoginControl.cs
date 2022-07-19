using Encrypter.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypter
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String username = usernameInput.Text;
            String password = passwordInput.Text;
            if (!((username=="" || username.Length<1) ||
                (password == "" || password.Length < 1)
                ))
            {
                if (checkLoginDetails(username, password))
                {
                    this.Parent.Hide();
                    Menu mainpage = new Menu();
                    mainpage.Show();

                }
            }

            
        }

        private bool checkLoginDetails(string username, string password)
        {
            try
            {
                var reader = DatabaseLayer.QueryDB("SELECT * FROM logins where Username='"+username+ "' and Passowrd='" + password+"'");
                if (reader.HasRows)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Invalid Login credentials. Please check your details and retry.");
                    return false;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Connection Error ! " + ex.Message, "Information");
                
                return false;

            }

           
           
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {

        }
    }
}
