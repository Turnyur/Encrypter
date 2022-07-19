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
    public partial class Watermarker : Form
    {
        public Watermarker()
        {
            InitializeComponent();
            autoGenRadioBtn.Checked = true;
            autoGenTextBox.Text = autoGenerateWatermarkText();
            busyLoader.Visible = false;
        }

        private void Watermarker_Load(object sender, EventArgs e)
        {

        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = od.FileName;
            }
        }

        private void autoGenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            autoGenTextBox.Text = autoGenerateWatermarkText();
            autoGenTextBox.ReadOnly = true;
        }

        private string autoGenerateWatermarkText()
        {
            //ToDo
            return "NA/12/RRWY/376/OJD";
        }

        private void manualRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            autoGenTextBox.Focus();
            autoGenTextBox.Text = String.Empty;
            autoGenTextBox.ReadOnly = false;
            autoGenTextBox.Visible = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Close();
        }

        private void autoGenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void watermarkBtn_Click(object sender, EventArgs e)
        {
            busyLoader.Visible = true;
        }
    }
}
