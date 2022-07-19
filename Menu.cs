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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            watermarker.AutoCheck = true;
        }

        private void watermarker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (watermarker.Checked)
            {
                this.Close();
                Watermarker wm = new Watermarker();
                wm.Show();
            }
            if (fileEncrypter.Checked)
            {
                this.Close();
                FileEncrypt wm = new FileEncrypt();
                wm.Show();
            }
            if (messageEncrypter.Checked)
            {
                this.Close();
                MessageEncrypt wm = new MessageEncrypt();
                wm.Show();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
