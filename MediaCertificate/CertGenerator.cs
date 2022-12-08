using MediaCertificateUtility.Utility;
using MediaCertificateUtility.Utility.Certificate;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaCertificateUtility
{
    public partial class CertificateGenerator : UserControl
    {
        public CertificateGenerator()
        {
            InitializeComponent();
        }

        private void PasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordShow.Checked)
            {
                PasswordField.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordField.UseSystemPasswordChar = true;
            }
        }

        private void GenerateID_Click(object sender, EventArgs e)
        {
            RegistryKey GUID = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography");
            string MID = (string) GUID.GetValue("MachineGUID");
            Guid ID = Guid.NewGuid();
            IDField.Text = MID + "-" + ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = PasswordIntegrity.IsStrongPasswordNonStrict(PasswordField.Text);
            if (!x)
            {
                MessageBox.Show("Password Does Not Meet Minimum Requirements\nPlease Enter A New Password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MediaCertificate Cert = new MediaCertificate(NameField.Text, IDField.Text, ExpiryField.Value);
            Cert.GenerateSecureKeyAndIV(PasswordField.Text);
            
            
            
            Writer.DefaultExt = ".MCF";
            Writer.AddExtension = true;
            Writer.Title = "Save Location For The Certificate File";
            DialogResult Res =  Writer.ShowDialog();
            if(Res == DialogResult.Cancel)
            {
                MessageBox.Show("User Cancelled The Save","Information",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            string Location = Writer.FileName;
            bool Flag = false;
            while (!Flag)
            {
                Flag = FileUtility.CanWrite(Location);
                if (!Flag)
                {
                    MessageBox.Show("Cannot Write File\nYou May Not Have Permission", "Unable To Write File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Writer.ShowDialog();
                    Location = Writer.FileName;
                }
            }
            FileUtility.WriteMCF(Cert, Location);
            MessageBox.Show("Wrote MCF To: " + Location, "File Writer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
