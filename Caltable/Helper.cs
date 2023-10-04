using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caltable
{
    public partial class Helper : Form
    {
        public Helper()
        {
            InitializeComponent();
        }

        private void aceptCHK_CheckedChanged(object sender, EventArgs e)
        {
            joinBtn.Enabled = aceptCHK.Checked;
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(Credentials.email);
                msg.To.Add(emailTxt.Text);
                Random rdn = new Random();
                string code = rdn.Next(1000, 9999).ToString();
                if(nameTxt.Text == "")
                {
                    throw new Exception();
                }
                msg.Body = "<h2>Tu solicitud ha sido recibida correctamente.</h2> <p>Para verificar el email, introduce el siguiente código en el programa: <h1>" + code + "</h1></p>";
                msg.IsBodyHtml = true;
                msg.Subject = "Activar aceso a unirse";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                NetworkCredential cert = new NetworkCredential(Credentials.email, Credentials.pwd);
                smtp.Credentials = cert;
                smtp.EnableSsl = true;
                smtp.Send(msg);
                Cursor = Cursors.Default;
                RegistCode rc = new RegistCode(nameTxt.Text, code, emailTxt.Text);
                rc.Show();
                this.Close();
            }
            catch
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Dirección de correo inválida. Compruebe que la dirección de correo sea válida y que se haya puesto un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class Credentials
    {
        public static string email = "helpasiersostudio@gmail.com";
        public static string pwd = "asierso2004";
    }
}
