using MediaCertificateUtility.Utility;
using MediaCertificateUtility.Utility.Certificate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaCertificateUtility
{
    public partial class CertificateLoader : UserControl
    {
        public MediaCertificate Certificate;
        public CertificateLoader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Res = MCFLoader.ShowDialog();
            if(Res == DialogResult.Cancel)
            {
                return;
            }
            string Location = MCFLoader.FileName;
            Certificate = FileUtility.ReadCertificate(Location);
            NameField.Text = Certificate.Name;
            IDField.Text = Certificate.ID;
            ExpiryField.Text = Certificate.Expiry;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordFeld.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordFeld.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Res = FileLoader.ShowDialog();
            if(Res == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                string Location = FileLoader.FileName;
                CryptoUtility.EncryptFile(Certificate, Location, PasswordFeld.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Could Not Encrypt\nYou may have entered the wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileLoader.Title = "Select .EDF File";
            DialogResult Res = FileLoader.ShowDialog();
            if (Res == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                string Location = FileLoader.FileName;
                CryptoUtility.DecryptFile(Certificate, Location, PasswordFeld.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Could Not Encrypt\nYou may have entered the wrong password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
