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
    public partial class OptionPage : Form
    {
        public OptionPage()
        {
            InitializeComponent();
            MenuActive.Height = LoginBtn.Height;
            MenuActive.Top = LoginBtn.Top;
            MenuActive.BringToFront();
        }

        private void loginControl1_Load(object sender, EventArgs e)
        {

        }

        private void OptionPage_Load(object sender, EventArgs e)
        {

        }

        private void loginControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MenuActive.Height = LoginBtn.Height;
            MenuActive.Top = LoginBtn.Top;
            LoginBtn.BringToFront();
            MenuActive.BringToFront();
            
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            MenuActive.Height = CreateBtn.Height;
            MenuActive.Top = CreateBtn.Top;
            MenuActive.BringToFront();
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MenuActive.Height = HelpBtn.Height;
            MenuActive.Top = HelpBtn.Top;
            MenuActive.BringToFront();
        }

        private void OptionPageLanding_Load(object sender, EventArgs e)
        {

        }
    }
}
