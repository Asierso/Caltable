using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caltable
{
    public partial class RegistCode : Form
    {
        string _name;
        string _code;
        string _mail;
        public RegistCode(string name,string code,string mail)
        {
            InitializeComponent();
            _name = name;
            _code = code;
            _mail = mail;
        }

        private void RegistCode_Load(object sender, EventArgs e)
        {

        }

        private void codeTxt_TextChanged(object sender, EventArgs e)
        {
            if(codeTxt.Text == _code)
            {
                StreamWriter stw = new StreamWriter("prod.csv");
                stw.Write("code:01023213232124319232192302139483847372834844823745378257823548632537822837467738234545,name:" + _name +",mail:" + _mail);
                stw.Close();
                MessageBox.Show("Se ha instalado la clave correctamente. Caltable se reiniciará para aplicar los cambios","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Question);
                this.Close();
                Application.Restart();
            }
        }
    }
}
