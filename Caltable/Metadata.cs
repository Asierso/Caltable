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
    public partial class Metadata : Form
    {
        string fname = "1";
        int memory = 10;
        List<string> ids = new List<string>();
        public Metadata()
        {
            InitializeComponent();
        }

        private void Metadata_Load(object sender, EventArgs e)
        {
            treenode.ImageList = imageList1;
            treenode.Nodes.Add(null,"Archivo",0,0);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(indexUPC.Value.ToString().Contains("0"))
            {
                MessageBox.Show("Conficto en los parámetros recibidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                treenode.Nodes[0].Nodes.Add(null, "Hereda " + indexUPC.Value.ToString(),1,1);
                ids.Add(indexUPC.Value.ToString());
            }
            try
            {
                memoryBar.Value = (fname.Length + 2 + ids.Count + ids.Count) * 10;
            }
            catch
            {
                MessageBox.Show("Limite de memoria sobrepasado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fnameUPC.Value.ToString().Contains("0"))
            {
                MessageBox.Show("Conficto en los parámetros recibidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fname = fnameUPC.Value.ToString();
                shownameTxt.Text = "Nombre: " + fname;
            }
        }

        private void memoryTxt_TextChanged(object sender, EventArgs e)
        {
            if (!memoryTxt.Text.Contains("B"))
            {
                memoryTxt.Text += "B";
            }
            if (memoryTxt.Text.Contains("B"))
            {
                memory = Convert.ToInt32(memoryTxt.Text.TrimEnd(new char[] { 'B' }));
            }
            memoryBar.Maximum = Convert.ToInt32(memoryTxt.Text);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            treenode.Nodes[0].Nodes.Clear();
            ids.Clear();
            memoryBar.Value = (fname.Length + 2 + ids.Count + ids.Count) * 10;
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            string generated = "";
            foreach(string oneid in ids.ToArray())
            {
                generated += "0" + oneid;
            }
            generated += ".20" + fname;
            resultTxt.Text = generated;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            treenode.SelectedNode.Name = "111";
            string rem = treenode.SelectedNode.Text.TrimStart(new char[] { 'H', 'e', 'r', 'd', 'a', ' ' });
            ids.Remove(rem);
            treenode.SelectedNode.Nodes.Remove(treenode.SelectedNode);
        }
    }
}
