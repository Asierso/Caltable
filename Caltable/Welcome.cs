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
namespace Caltable
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            basicBtn.Hide();
            advancedBtn.Hide();
            endBtn.Hide();
        }

        private void start_Click(object sender, EventArgs e)
        {
            clcDraw.Hide();
            basicBtn.Show();
            advancedBtn.Show();
            start.Hide();
            label2.Text = "Escoge que uso\nle vas a dar al \nprograma";
        }

        private void basicBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "La función de Panel básico\nse adapta más a tus\nnecesidades";
            endBtn.Show();
            basicBtn.Hide();
            advancedBtn.Hide();
        }

        private void advancedBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "El panel inicial te permitirá\nusar funciones\núnicas y útiles";
            endBtn.Show();
            basicBtn.Hide();
            advancedBtn.Hide();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
