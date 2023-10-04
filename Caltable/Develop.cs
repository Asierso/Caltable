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
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using System.Threading;

namespace Caltable
{
    public partial class Develop : Form
    {
        int writes = 0;
        bool licensed = false;
        public Develop()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            File.Create(modelTxt.Text + ".bs");
            UpdateDirectoryTree();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StreamWriter stw = new StreamWriter(modelTxt.Text + ".bs");
            stw.Write(script.Text);
            stw.Close();
            UpdateDirectoryTree();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader str = new StreamReader(modelTxt.Text + ".bs");
                script.Text = str.ReadToEnd();
                str.Close();
            }
            catch
            {
                MessageBox.Show("Archivo no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void commands_AfterSelect(object sender, TreeViewEventArgs e)
        {
            script.Text += commands.SelectedNode.Name;
            
        }

        private void UpdateDirectoryTree()
        {
            directory.Nodes.Clear();
            directory.ImageList = imageList1;
            directory.Nodes.Add(Directory.GetCurrentDirectory(),Path.GetDirectoryName(Directory.GetCurrentDirectory()),7,7);
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string fileOne in files)
            {
                if(Path.GetExtension(fileOne) == ".bs")
                {
                    directory.Nodes[0].Nodes.Add(fileOne, Path.GetFileName(fileOne), 8, 8);
                }
                else
                {
                    directory.Nodes[0].Nodes.Add(fileOne, Path.GetFileName(fileOne), 9, 9);
                }
            }
            directory.ExpandAll();
        }
        private void UpdateVarsTree()
        {
            vars.Nodes.Clear();
            try
            {
                for (int i = 0; i < script.Text.Length; i++)
                {
                    if (script.Text[i] == '-' && script.Text[i + 1] == '>')
                    {
                        if (script.Text[i + 2] == ' ')
                        {
                            vars.Nodes.Add(i.ToString(), "Variable sin asignar", 2, 2);
                        }
                        else if (script.Text[i + 2] == '\n')
                        {
                            vars.Nodes.Add(i.ToString(), "Variable sin asignar", 2, 2);
                        }
                        else
                        {
                            vars.Nodes.Add(i.ToString(), "Variable " + script.Text[i + 2].ToString(), 2, 2);
                        }
                    }
                }
            }
            catch
            {
                vars.Nodes.Add(null, "Variable sin asignar", 2, 2);
            }
        }
        private void Develop_Load(object sender, EventArgs e)
        {
            commands.ImageList = imageList1;
            vars.ImageList = imageList1;
            commands.Nodes.Add(null,"Impresión",1,1);
            commands.Nodes[0].Nodes.Add("Locate x,y,","Locate",0,0);
            commands.Nodes[0].Nodes.Add("Cls", "Clear", 0, 0);
            commands.Nodes.Add(null,"Variable",2,2);
            commands.Nodes[1].Nodes.Add("num->var", "Variable INT",0,0);
            commands.Nodes.Add(null, "Condicional", 3, 3);
            commands.Nodes[2].Nodes.Add("If x=y:", "If", 0, 0);
            commands.Nodes[2].Nodes.Add("Then", "Then", 0, 0);
            commands.Nodes[2].Nodes.Add("IfEnd;", "IfEnd", 0, 0);
            commands.Nodes[2].Nodes.Add("Else", "Else", 0, 0);
            commands.Nodes[2].Nodes.Add("And", "And", 0, 0);
            commands.Nodes[2].Nodes.Add("Or", "Or", 0, 0);
            commands.Nodes[2].Nodes.Add("Not", "Not", 0, 0);
            commands.Nodes.Add(null, "Eventos", 4, 4);
            commands.Nodes[3].Nodes.Add("GetKey", "GetKey", 0, 0);
            commands.Nodes.Add(null, "Códigos (FX5800P)", 5, 5);
            commands.Nodes[4].Nodes.Add("83", "Izquierda", 0, 0);
            commands.Nodes[4].Nodes.Add("86", "Derecha", 0, 0);
            commands.Nodes[4].Nodes.Add("84", "Arriba", 0, 0);
            commands.Nodes[4].Nodes.Add("85", "Abajo", 0, 0);
            commands.Nodes[4].Nodes.Add("81", "Modo", 0, 0);
            commands.Nodes[4].Nodes.Add("82", "Función", 0, 0);
            commands.Nodes.Add(null, "Búcles", 6, 6);
            commands.Nodes[5].Nodes.Add("While x=y", "While", 0, 0);
            commands.Nodes[5].Nodes.Add("WhileEnd", "WhileEnd", 0, 0);
            commands.Nodes[5].Nodes.Add("Do", "Do", 0, 0);
            commands.Nodes[5].Nodes.Add("For", "For", 0, 0);
            commands.Nodes[5].Nodes.Add("Next", "Next", 0, 0);
            commands.Nodes[5].Nodes.Add("Break;", "Break", 0, 0);
            commands.ExpandAll();
            UpdateDirectoryTree();
            //Load prod.csv
            SaveFile savef = new SaveFile("prod.csv");
            savef.defaultParameters = "code:0,name:null,mail:null";
            savef.ReadSettings();
            if (savef.instructions["code"] == "01023213232124319232192302139483847372834844823745378257823548632537822837467738234545")
            {
                state.BackColor = Color.FromKnownColor(KnownColor.Lime);
                licensed = true;
            }
            regnameTxt.Text = savef.instructions["name"];
            mailregTxt.Text = savef.instructions["mail"];
        }

        private void updateTxt_Click(object sender, EventArgs e)
        {
            UpdateVarsTree();
        }

        private void vars_AfterSelect(object sender, TreeViewEventArgs e)
        {
            script.Focus();
            script.Select(Convert.ToInt32(vars.SelectedNode.Index), Convert.ToInt32(vars.SelectedNode.Index) + 3);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            UpdateDirectoryTree();
        }

        private void directory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Path.GetExtension(directory.SelectedNode.Name) == ".bs")
            {
                if (script.Text == "")
                {
                    StreamReader str = new StreamReader(directory.SelectedNode.Name);
                    script.Text = str.ReadToEnd();
                    str.Close();
                }
                else
                {
                    if (MessageBox.Show("Estas seguro de que quieres abrirlo. Perderas la información no guardada", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        StreamReader str = new StreamReader(directory.SelectedNode.Name);
                        script.Text = str.ReadToEnd();
                        str.Close();
                    }
                }
            }
            else if (Path.GetExtension(directory.SelectedNode.Name) == ".csv")
            {
                MessageBox.Show("Extensión no compatible. Los archivos de configuración de caltable no se pueden editar aquí. Solo son válidos los archivos con extensión .bs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Extensión no compatible. Solo son válidos los archivos con extensión .bs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    File.Delete(directory.SelectedNode.Name);
                    UpdateDirectoryTree();
                }
                catch
                {
                    MessageBox.Show("Error al borrar. Seleccione el nodo/archivo a elimimar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Develop_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void script_TextChanged(object sender, EventArgs e)
        {
            writes++;
            savePrb.Value = writes * 10;
            if (writes == 10)
            {
                StreamWriter stw = new StreamWriter(modelTxt.Text + "_emergencySave.bs");
                stw.Write(script.Text);
                stw.Close();
                writes = 0;
                UpdateVarsTree();
            }
        }

        private void publishBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (licensed == true)
                {
                    if (!File.Exists(publishModelTxt.Text + ".bs"))
                    {
                        throw new Exception();
                    }
                    Cursor = Cursors.WaitCursor;
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(Credentials.email);
                    msg.To.Add("asiersostudio@gmail.com");
                    msg.Body = "<h2>" + regnameTxt.Text + " quiere publicar su utilidad</h2><h3>Datos del usuario </h3><p> Nombre: " + regnameTxt.Text +  "<br> Email: " + mailregTxt.Text + "</p><h3>Comentario:</h3><p>" + publishCommitTxt.Text + "</p>";
                    msg.Attachments.Add(new Attachment(publishModelTxt.Text + ".bs"));
                    msg.IsBodyHtml = true;
                    msg.Subject = "Aviso de publicación";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    NetworkCredential cert = new NetworkCredential(Credentials.email, Credentials.pwd);
                    smtp.Credentials = cert;
                    smtp.EnableSsl = true;
                    smtp.Send(msg);
                    SendVerificatedMail();
                    Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Se requiere una licencia para publicar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ha habido un error al publicar. Revise que el modelo sea correcto y que se tenga conexión a internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendVerificatedMail()
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(Credentials.email);
            msg.To.Add(mailregTxt.Text);
            msg.Body = "<h2>Se ha enviado la publicación correctamente</h2><h3>Recibirás un correo en unos días despues de que se hayan verificado tus utilidades.</h3><h2>Gracias por tu colaboración</h2>";
            msg.Attachments.Add(new Attachment(publishModelTxt.Text + ".bs"));
            msg.IsBodyHtml = true;
            msg.Subject = "Aviso de publicación";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential cert = new NetworkCredential(Credentials.email, Credentials.pwd);
            smtp.Credentials = cert;
            smtp.EnableSsl = true;
            smtp.Send(msg);
        }

        private void interpretBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (!File.Exists("Interpreter.exe"))
            {
                try
                {
                    WebClient wc = new WebClient();
                    wc.DownloadFile("https://asierso.github.io/Caltable/Interpreter/Interpreter.exe", "Interpreter.exe");
                }
                catch
                {
                    MessageBox.Show("No se ha podido descargar el interprete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    WebClient wc = new WebClient();
                    wc.DownloadString("https://asierso.github.io/Caltable/version.dat");
                    wc.DownloadFile("https://asierso.github.io/Caltable/Interpreter/Interpreter.exe", "Interpreter.exe");
                }
                catch
                {

                }
            }
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "Interpreter.exe";
                psi.Arguments = modelTxt.Text + ".bs";
                Process.Start(psi);
                Cursor = Cursors.Default;
            }
            catch
            {

            }

        }
    }
}
