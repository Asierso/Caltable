using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caltable
{
    public partial class Credits : Form //Credits only
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Encontraste un easter egg", ":O", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Credits_Load(object sender, EventArgs e)
        {
            versionTxt.Text += " vr" + Application.ProductVersion;
        }
    }
}
