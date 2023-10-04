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
    public partial class Emulate : Form
    {
        //Emulator for use the Caltable languaje
        Dictionary<int, string> scr = new Dictionary<int, string>();
        int nodenum = 0;
        public Emulate()
        {
            InitializeComponent();
        }

        private void Emulate_Load(object sender, EventArgs e)
        {
            timer1.Start();
            treeView1.ImageList = imageList1;
            treeView1.Nodes.Add(null,"Tabla",0);
            SaveFile savef = new SaveFile("emulator.csv");
            savef.defaultParameters = "name:Caltable 249S,count:10,lim:80,index:1";
            savef.ReadSettings();
            try
            {
                label10.Text = savef.instructions["name"];
                memoryTxt.Text = savef.instructions["count"];
                majorTxt.Text = savef.instructions["lim"];
                acessUPC.Value = Convert.ToInt32(savef.instructions["index"]);
            }
            catch
            {
                File.Delete("emulator.csv");
                savef.ReadSettings();
                label10.Text = savef.instructions["name"];
                memoryTxt.Text = savef.instructions["count"];
                majorTxt.Text = savef.instructions["lim"];
                acessUPC.Value = Convert.ToInt32(savef.instructions["index"]);
            }
            timer2.Start();
        }

        private void accessBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            try
            {
                scr.Remove(Convert.ToInt32(acessUPC.Value));
                scr.Add(Convert.ToInt32(acessUPC.Value), valueTxt.Text.ToString());
                res1.Text = valueTxt.Text.ToString();
                treeView1.Nodes[0].Nodes.Add(acessUPC.Value.ToString(),"Indice " + Convert.ToInt32(acessUPC.Value), 1,1);
                treeView1.Nodes[0].Nodes[nodenum].Nodes.Add(null, "Valor " + valueTxt.Text, 2,2);
                nodenum++;
                tableBar.Value = nodenum;
            }
            catch
            {
                MessageBox.Show("Conficto en los parámetros recibidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scr.Add(scr.Count, "0");

        }

        private void acessUPC_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(acessUPC.Value) <= Convert.ToInt32(majorTxt.Text) - 2)
            {
                numberXTxt.Text = acessUPC.Value.ToString() + "\n" + Convert.ToString(acessUPC.Value + 1) + "\n" + Convert.ToString(acessUPC.Value + 2);
                SaveFile sf = new SaveFile("emulator.csv");
                sf.ReadSettings();
                sf.instructionsToSave["index"] = acessUPC.Value.ToString();
                sf.parameterslist.AddRange(new string[] { "name", "count", "lim", "index" });
                sf.SaveSettings();
                res1.Text = "0";
                res2.Text = "0";
                res3.Text = "0";
                try
                {
                    res1.Text = scr[Convert.ToInt32(acessUPC.Value)];
                    res2.Text = scr[Convert.ToInt32(acessUPC.Value) + 1];
                    res3.Text = scr[Convert.ToInt32(acessUPC.Value) + 2];
                }
                catch
                {

                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            scr.Clear();
            res1.Text = "0";
            res2.Text = "0";
            res3.Text = "0";
            nodenum = 0;
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(null, "Tabla", 0,0);
            tableBar.Value = nodenum;
        }

        private void majorTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tableBar.Maximum = Convert.ToInt32(majorTxt.Text);
                SaveFile sf = new SaveFile("emulator.csv");
                sf.ReadSettings();
                sf.instructionsToSave["lim"] = majorTxt.Text;

                sf.parameterslist.AddRange(new string[] { "name", "count", "lim","index" });
                sf.SaveSettings();
            }
            catch
            {
                tableBar.Maximum = 80;
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
                try
                {
                    memoryBar.Maximum = Convert.ToInt32(memoryTxt.Text.TrimEnd(new char[] { 'B' }));
                    SaveFile sf = new SaveFile("emulator.csv");
                    sf.ReadSettings();
                    sf.instructionsToSave["count"] = memoryTxt.Text.TrimEnd(new char[] { 'B' });
                    
                    sf.parameterslist.AddRange(new string[] {"name","count","lim","index" });
                    sf.SaveSettings();
                }
                catch
                {
                    memoryBar.Maximum = 10;
                }
                
            }
        }

        private void valueTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                memoryBar.Value = valueTxt.Text.Length;
            }
            catch
            {
                valueTxt.Text = valueTxt.Text.Substring(0, valueTxt.Text.Length - 1);
                MessageBox.Show("Limite de memoria sobrepasado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region Amination
        private void num1_MouseEnter(object sender, EventArgs e)
        {
            num1.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num1_MouseLeave(object sender, EventArgs e)
        {
            num1.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num2_MouseEnter(object sender, EventArgs e)
        {
            num2.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num2_MouseLeave(object sender, EventArgs e)
        {
            num2.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num3_MouseEnter(object sender, EventArgs e)
        {
            num3.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num3_MouseLeave(object sender, EventArgs e)
        {
            num3.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num4_MouseEnter(object sender, EventArgs e)
        {
            num4.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num4_MouseLeave(object sender, EventArgs e)
        {
            num4.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num5_MouseEnter(object sender, EventArgs e)
        {
            num5.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num5_MouseLeave(object sender, EventArgs e)
        {
            num5.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num6_MouseEnter(object sender, EventArgs e)
        {
            num6.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num6_MouseLeave(object sender, EventArgs e)
        {
            num6.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num7_MouseEnter(object sender, EventArgs e)
        {
            num7.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num7_MouseLeave(object sender, EventArgs e)
        {
            num7.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num8_MouseEnter(object sender, EventArgs e)
        {
            num8.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num8_MouseLeave(object sender, EventArgs e)
        {
            num8.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num9_MouseEnter(object sender, EventArgs e)
        {
            num9.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num9_MouseLeave(object sender, EventArgs e)
        {
            num9.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num1Txt_MouseEnter(object sender, EventArgs e)
        {
            num1.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num1Txt_MouseLeave(object sender, EventArgs e)
        {
            num1.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num2Txt_MouseEnter(object sender, EventArgs e)
        {
            num2.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num2Txt_MouseLeave(object sender, EventArgs e)
        {
            num2.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num3Txt_MouseEnter(object sender, EventArgs e)
        {
            num3.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num3Txt_MouseLeave(object sender, EventArgs e)
        {
            num3.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num4Txt_MouseEnter(object sender, EventArgs e)
        {
            num4.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num4Txt_MouseLeave(object sender, EventArgs e)
        {
            num4.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num5Txt_MouseEnter(object sender, EventArgs e)
        {
            num5.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num5Txt_MouseLeave(object sender, EventArgs e)
        {
            num5.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num6Txt_MouseEnter(object sender, EventArgs e)
        {
            num6.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num6Txt_MouseLeave(object sender, EventArgs e)
        {
            num6.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num7Txt_MouseEnter(object sender, EventArgs e)
        {
            num7.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num7Txt_MouseLeave(object sender, EventArgs e)
        {
            num7.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num8Txt_MouseEnter(object sender, EventArgs e)
        {
            num8.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num8Txt_MouseLeave(object sender, EventArgs e)
        {
            num8.BackColor = Color.FromArgb(255, 64, 64, 64);
        }

        private void num9Txt_MouseEnter(object sender, EventArgs e)
        {
            num9.BackColor = Color.FromArgb(255, 48, 48, 48);
        }

        private void num9Txt_MouseLeave(object sender, EventArgs e)
        {
            num9.BackColor = Color.FromArgb(255, 64, 64, 64);
        }
        #endregion

        private void timer2_Tick(object sender, EventArgs e)
        {
            using (Graphics gl = refreshIndicator.CreateGraphics())
            {
                gl.FillRectangle(new SolidBrush(Color.White), 0, 0, 8, 10);
                gl.FillRectangle(new SolidBrush(Color.White), 13, 0, 8, 10);
                gl.FillRectangle(new SolidBrush(Color.White), 26, 0, 8, 10);
            }
            using(Graphics gl = bufferFake.CreateGraphics())
            {
                gl.Clear(Color.FromArgb(255,0,64,0));
                gl.FillRectangle(new SolidBrush(Color.White), bufferFake.Width / 3, 0, 5, bufferFake.Height);
                gl.FillRectangle(new SolidBrush(Color.White), 0, Convert.ToInt32(acessUPC.Value) - 1, bufferFake.Width, 10);
            }
        }
    }
}
