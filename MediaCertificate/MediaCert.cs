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
    public partial class MediaCert : Form
    {
        public MediaCert()
        {
            InitializeComponent();
        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            certificateGenerator1.Visible = true;
            certificateLoader1.Visible = false;
        }

        private void loadCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            certificateLoader1.Visible = true;
            certificateGenerator1.Visible = false;
        }

        private void certificateLoader1_Load(object sender, EventArgs e)
        {

        }
    }
}
