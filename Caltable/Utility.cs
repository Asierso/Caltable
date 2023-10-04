using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Caltable
{
    public partial class Utility : Form
    {
        public string model;
        public List<string> modelarray = new List<string>();
        public Utility()
        {
            InitializeComponent();
        }

        private void Utility_Load(object sender, EventArgs e)
        {
            try
            {
                WebClient wc = new WebClient();
                string modelstr = wc.DownloadString("https://asierso.github.io/Caltable/models.csv");
                models.Items.AddRange(modelstr.Split(','));
                modelarray.AddRange(modelstr.Split(','));
                downloadBinBtn.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error de conexion. Se requiere una conexión a internet para descargar las utilidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            try
            {
                SaveFile savef = new SaveFile("utility.csv");
                savef.defaultParameters = "repos:asierso.github.io/Caltable,model:Generic";
                savef.ReadSettings();
                if (savef.instructions["model"] != "Undefined")
                {
                    models.SelectedItem = savef.instructions["model"];
                }
                reposTxt.Text = savef.instructions["repos"];
                UpdateTree();
            }
            catch
            {

            }
            try
            {
                WebClient wc = new WebClient();
                string crt = wc.DownloadString("https://" + reposTxt.Text + "/certificate.crt");
                if(reposTxt.Text == crt)
                {
                    statePanel.BackColor = Color.FromKnownColor(KnownColor.Lime);
                    certPanel.BackColor = Color.FromKnownColor(KnownColor.Lime);
                }
            }
            catch
            {
                statePanel.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
                certPanel.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
            }
        }

        private void models_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = models.SelectedItem.ToString();
            //downloadBinBtn.Enabled = true;
            SaveFile sf = new SaveFile("utility.csv");
            sf.ReadSettings();
            sf.instructionsToSave["model"] = model;

            sf.parameterslist.AddRange(new string[] { "repos", "model"});
            sf.SaveSettings();
            UpdateTree();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaveFile sf = new SaveFile("utility.csv");
            sf.ReadSettings();
            sf.instructionsToSave["repos"] = reposTxt.Text;

            sf.parameterslist.AddRange(new string[] { "repos", "model" });
            sf.SaveSettings();
            UpdateTree();
            try
            {
                WebClient wc = new WebClient();
                string crt = wc.DownloadString("https://" + reposTxt.Text + "/certificate.crt");
                if (reposTxt.Text == crt)
                {
                    statePanel.BackColor = Color.FromKnownColor(KnownColor.Lime);
                    certPanel.BackColor = Color.FromKnownColor(KnownColor.Lime);
                }
            }
            catch
            {
                statePanel.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
                certPanel.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
            }
        }

        private void downloadBinBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo basic (*.bs)|*.bs";
            sfd.Title = "Descargar utilidades";
            sfd.FileName = model + "_utilities";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stw = new StreamWriter(sfd.FileName);
                WebClient wc = new WebClient();
                stw.Write(wc.DownloadString("https://" + reposTxt.Text + "/Utilities/" + model + ".bs"));
                stw.Close();
            }
        }
        private void UpdateTree()
        {
            treeMain.Nodes.Clear();
            treeMain.ImageList = imageList1;
            treeMain.Nodes.Add("Repositorio " + reposTxt.Text);
            treeMain.Nodes[0].Nodes.Add(null,"Dispositivos",1,1);
            treeMain.Nodes[0].Nodes[0].Nodes.Add(null,"Selecionado (" + model + ")",1,1);
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadString("https://" + reposTxt.Text + "/Utilities/" + model + ".bs");
                treeMain.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(null,model + "_utilities.bs",2,2);
                downloadBinBtn.Enabled = true;
            }
            catch
            {
                treeMain.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(null,"Modelo no compatible",3,3);
                downloadBinBtn.Enabled = false;
            }
            int node = 0;
            foreach (string modelarrayOne in modelarray)
            {
                treeMain.Nodes[0].Nodes[0].Nodes.Add(null,modelarrayOne,1,1);
                node++;
            }
            treeMain.ExpandAll();

        }
    }
}
