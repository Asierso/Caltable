using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace Caltable
{
    public partial class Form1 : Form //Ui of main program
    {
        int finalHerence = 0;
        string finalSelected = "0";
        string[] finalValue = new string[100];
        int finalValueIndex = 0;
        string finalType;
        bool count = false;
        string errorUNC = "OK";
        string errorC = "OK";
        int memory = 10;
        Color[] lightpalete = { Color.FromKnownColor(KnownColor.Control), Color.FromKnownColor(KnownColor.ControlText) }; // Bg , Fg
        Color[] darkpalete = { Color.FromArgb(255, 25, 25, 25), Color.FromArgb(255, 200, 200, 200), Color.FromArgb(255, 35, 35, 35) }; //Bg, Fg , ButtonBg
        public Form1()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Form1_Load(object sender, EventArgs e)
        {
            //Updater Comp
            try
            {
                WebClient wc = new WebClient();
                string data = wc.DownloadString("https://asierso.github.io/Caltable/initial.ini");
                if(data == "0")
                {
                    MessageBox.Show("La aplicación ha sido dada de baja", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
                if(!File.Exists("initial.ini"))
                {
                    Welcome welcom = new Welcome();
                    welcom.ShowDialog();
                }
                StreamWriter certwriter = new StreamWriter("initial.ini");
                certwriter.Write(data);
                certwriter.Close();
            }
            catch
            {
                try
                {
                    StreamReader certreader = new StreamReader("initial.ini");
                    string dataoffline = certreader.ReadLine();
                    certreader.Close();
                    if (dataoffline == "0")
                    {
                        MessageBox.Show("La aplicación ha sido dada de baja", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
                catch
                {
                    MessageBox.Show("Se requiere internet la primera vez que se inicie Caltable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            //Get updates
            try
            {
                WebClient wc2 = new WebClient();
                string newVersion = wc2.DownloadString("https://asierso.github.io/Caltable/version.dat");
                string thisVersion = Application.ProductVersion;
                if (newVersion.TrimEnd(new char[] { '\n' }) != thisVersion)
                {
                    MessageBox.Show("Hay una actualización disponible del programa\nVersión nueva: " + newVersion.TrimEnd(new char[] { '\n' }) + "\nVersion actual: " + thisVersion, "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
            //Rest Init
            selectMode.Items.AddRange(new string[] { "Normal"});
            value1Type.Items.AddRange(new string[] { "INT", "STRING", "CHAR" });
            cdataMode.Items.AddRange(new string[] { "Normal" });
            cdataMode.SelectedItem = "Normal";
            cdataMode.Text = "Normal";
            //infoLbl.Text = "Caltable creado por\nAsierso\nVersion " + Application.ProductVersion + "\nImportante leer \ndocumentación";
            SaveFile savef = new SaveFile("mscreen.csv");
            savef.defaultParameters = "count:10,idk:2";
            savef.ReadSettings();
            memoryTxt.Text = savef.instructions["count"];
            idCount.Value = Convert.ToInt32(savef.instructions["idk"]);
            if(!File.Exists("prod.csv"))
            {
                unirseToolStripMenuItem.Enabled = true;
            }
            else
            {
                SaveFile savef2 = new SaveFile("prod.csv");
                savef2.defaultParameters = "code:0,name:null,mail:null";
                savef2.ReadSettings();
                if(savef2.instructions["code"] == "01023213232124319232192302139483847372834844823745378257823548632537822837467738234545")
                {
                    entornoDeDesarrolloToolStripMenuItem.Enabled = true;
                }
                else
                {
                    File.Delete("prod.csv");
                    unirseToolStripMenuItem.Enabled = true;
                }
            }
            componentTree.ImageList = imageList1;
            componentTreeB.ImageList = imageList1;
            componentTree.Nodes.Add(null,"Lista de datos",0,0);
            componentTreeB.Nodes.Add(null, "Lista de datos", 0, 0);
            componentTree.ExpandAll();
            componentTreeB.ExpandAll();
            timer1.Start();
            //Load DataTable
        }

        private void selectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectMode.SelectedItem.ToString() == "Normal")
            {
                value1Type.Items.Clear();
                value1Type.Items.AddRange(new string[] { "INT", "STRING", "CHAR" });
                finalSelected = "0";
            }
            else if (selectMode.SelectedItem.ToString() == "Programacion")
            {
                value1Type.Items.Clear();
                value1Type.Items.AddRange(new string[] { "COM", "INT", "STRING", "CHAR" });
                finalSelected = "1";
            }
            else if (selectMode.SelectedItem.ToString() == "Metadatos")
            {
                value1Type.Items.Clear();
                value1Type.Items.AddRange(new string[] { "N/D" });
                finalSelected = "1";
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Codes code = new Codes();
            componentTree.Nodes[0].Nodes.Add(null,code.GetCodesByVals(value1Value.Text, 1) + ": " + value1Value.Text, 1,1);
            int value = Convert.ToInt32(code.GetCodesByVals(value1Value.Text, 2));
            try
            {
                if (value1Type.SelectedItem.ToString() == "INT")
                {
                    value = Convert.ToInt32(value1Value.Text);
                    string split = value1Value.Text;
                    if (split[1] == '0')
                    {
                        value++;
                    }
                }
            }
            catch
            {

            }
            finalValue[finalValueIndex] = finalType.ToString() + value;
            finalValueIndex++;
        }

        private void herence_TextChanged(object sender, EventArgs e)
        {
            try
            {
                finalHerence = Convert.ToInt32(herence.Text);
            }
            catch
            {
                finalHerence = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == true)
            {
                processVal.Value += 10;
                if (processVal.Value == 100)
                {
                    processVal.Value = 0;
                    count = false;
                }
            }
            uncodeTxt.Text = finalHerence.ToString() + finalSelected.ToString() + ".";
            foreach (string fval in finalValue)
            {
                uncodeTxt.Text += fval;
            }
            try
            {
                uncodeFill.Value = uncodeTxt.Text.Length * 10;
                errorUNC = "OK";
                label10.ForeColor = Color.FromKnownColor(KnownColor.LimeGreen);
            }
            catch
            {
                uncodeFill.Value = uncodeFill.Maximum;
                errorUNC = "OWERFLOW";
                label10.ForeColor = Color.FromKnownColor(KnownColor.Red);
            }
            label10.Text = errorC + "," + errorUNC;
        }

        private void value1Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = "0";
            string data = value1Type.SelectedItem.ToString();
            switch (data)
            {
                case "INT": value = "0"; break;
                case "STRING": value = "00"; break;
                case "CHAR": value = "000"; break;
                case "COM": value = "0000"; break;
            }
            finalType = Convert.ToString(value);
        }

        private void codificBtn_Click(object sender, EventArgs e)
        {
            count = true;
            if (idCount.Value == 0)
            {
                codeTxt.Text = uncodeTxt.Text;
                keyTxt.Text = "0";
                codeTxt.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
                keyTxt.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
            }
            else
            {
                List<string> chargp = new List<string>();
                for (int i = 3; i < uncodeTxt.Text.Length; i++)
                {
                    chargp.Add(uncodeTxt.Text[i].ToString());
                }
                keyTxt.Text = "0" + idCount.Value.ToString() + "E";
                for (int i = 0; i < chargp.ToArray().Length; i++)
                {
                    if (idCount.Value + Convert.ToInt32(chargp[i]) >= 10)
                    {
                        chargp[i] = Convert.ToString(Convert.ToInt32(chargp[i]) - idCount.Value);
                        keyTxt.Text += "1";
                    }
                    else
                    {
                        chargp[i] = Convert.ToString(Convert.ToInt32(chargp[i]) + idCount.Value);
                        keyTxt.Text += "0";
                    }

                }
                codeTxt.Text = finalHerence.ToString() + finalSelected + ".";
                for (int i = 0; i < chargp.ToArray().Length; i++)
                {
                    codeTxt.Text += chargp[i].ToString();
                }
                codeTxt.BackColor = Color.FromKnownColor(KnownColor.LimeGreen);
                keyTxt.BackColor = Color.FromKnownColor(KnownColor.LimeGreen);
                try
                {
                    codeFill.Value = codeTxt.Text.Length * 10;
                    errorC = "OK";
                    label10.ForeColor = Color.FromKnownColor(KnownColor.LimeGreen);
                }
                catch
                {
                    codeFill.Value = codeFill.Maximum;
                    errorC = "OWERFLOW";
                    codeTxt.BackColor = Color.FromKnownColor(KnownColor.Gold);
                    keyTxt.BackColor = Color.FromKnownColor(KnownColor.Gold);
                    label10.ForeColor = Color.FromKnownColor(KnownColor.Red);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void label12_Click(object sender, EventArgs e)
        {

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
                uncodeFill.Maximum = memory * 10;
                codeFill.Maximum = memory * 10;
            }
            SaveFile sf = new SaveFile("mscreen.csv");
            sf.ReadSettings();
            sf.instructionsToSave["count"] = memoryTxt.Text.TrimEnd(new char[] { 'B' });
            sf.parameterslist.AddRange(new string[] { "count", "idk" });
            sf.SaveSettings();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (searchTxt.Text == "*#0*#")
            {
                //Admin codes
                Develop devel = new Develop();
                devel.Show();
            }
            else
            {
                Codes codes = new Codes();
                int value = Convert.ToInt32(codes.GetCodesByVals(searchTxt.Text, 2));
                string type = codes.GetCodesByVals(searchTxt.Text, 1);
                if (value == 0)
                {
                    bresult.Text += "Valor de tipo " + type + " s'" + searchTxt.Text + "' no existe. (no sirve con valores de INT)\n";
                }
                else
                {
                    bresult.Text += "Valor de tipo " + type + " '" + searchTxt.Text + "' existe con valor " + value.ToString() + "\n";
                }
            }
        }

        private void descodificBtn_Click(object sender, EventArgs e)
        {
            count = true;
            string key = dkeyTxt.Text;
            string dcode = dcodeTxt.Text;
            int keyid = Convert.ToInt32(key[1].ToString());
            string keybin = "";
            for (int i = 0; i < key.Length - 3; i++)
            {
                keybin += key[i + 3];
            }
            string duncode = "";
            bool index = true;
            bool correct = true;
            int il = 0;
            for (int i = 0; i < dcode.Length; i++)
            {
                if (dcode[i] == '.')
                {
                    index = false;
                    il = i + 1;
                }
                if (index == true)
                {
                    duncode += dcode[i].ToString();
                }

            }
            duncode += ".";
            //MessageBox.Show("Binarios" + keybin + dcode + "  " +  il.ToString(), "");
            try
            {
                duncodeTxt.BackColor = Color.FromKnownColor(KnownColor.Control);
                for (int i = 0; i < keybin.Length; i++)
                {
                    if (keybin[i] == '0')
                    {
                        int x1 = Convert.ToInt32(dcode[i + il].ToString());
                        int x2 = Convert.ToInt32(key[1].ToString());
                        duncode += Convert.ToString(x1 - x2);
                        //MessageBox.Show(x1.ToString() + "+" + x2.ToString() + "=" + Convert.ToString(x1 - x2) + "WITH" + keybin[i]);
                    }
                    else if (keybin[i] == '1')
                    {
                        int x1 = Convert.ToInt32(dcode[i + il].ToString());
                        int x2 = Convert.ToInt32(key[1].ToString());
                        duncode += Convert.ToString(x1 + x2);
                    }
                    else
                    {
                        MessageBox.Show("La llave no es correcta. Fallo en (Bin " + Convert.ToString(i + il + 1) + ")", "Error");
                        duncodeTxt.BackColor = Color.FromKnownColor(KnownColor.LightCoral);
                        correct = false;
                    }
                }
                if (correct == true)
                {
                    duncodeTxt.BackColor = Color.FromKnownColor(KnownColor.LimeGreen);
                }
                duncodeTxt.Text = duncode;
            }
            catch
            {
                MessageBox.Show("La llave no es correcta. Fallo desconocido", "Error");
            }
        }

        private void valsBtn_Click(object sender, EventArgs e)
        {
            Codes codes = new Codes();
            string value = valsTxt.Text;
            string type = codes.GetCodesByVals(value, 1);
            string valuestr = codes.GetCodesByVals(value, 0);
            if (type == "")
            {
                bresult.Text += "Valor con la id '" + value + "' no existe. (no sirve con valores de INT)\n";
            }
            else if (type == "COM")
            {

                bresult.Text += "Valor con la id '" + value + "' es equivalente a " + valuestr + "\nque es de tipo " + type + " en modo programacion\n";
            }
            else
            {
                bresult.Text += "Valor con la id '" + value + "' es equivalente a " + valuestr + "\nque es de tipo " + type + " en modo normal\n";
            }

        }

        private void converterBtn_Click(object sender, EventArgs e)
        {
            string convertVal = cmainvalTxt.Text;
            string header = "";
            string body = "";
            string charset = "";
            string type = "";
            int iterator = 0;
            bool isHeader = true;
            count = true;
            Codes code = new Codes();
            convertVal += "0";
            foreach (char convertValChar in convertVal)
            {
                try
                {
                    if (convertValChar == '.')
                    {
                        isHeader = false;
                    }
                    else if (isHeader == true)
                    {
                        header += convertValChar.ToString();
                    }
                    else if (convertValChar == '0')
                    {
                        charset += convertValChar.ToString();
                    }
                    else if (convertVal[iterator + 1] == '0' && convertValChar != '0')
                    {
                        charset += convertValChar.ToString();
                        body += code.GetCodesByVals(charset, 0);
                        componentTreeB.Nodes[0].Nodes.Add(null,code.GetCodesByVals(charset, 1) + ": " + code.GetCodesByVals(charset, 0),1,1);
                        charset = "";
                    }
                    else
                    {
                        charset += convertValChar.ToString();
                    }
                    iterator++;
                }
                catch
                {
                   
                }
            }
            header = "";
            for (int i = 0; i < convertVal.Length; i++)
            {
                if (convertVal[i + 1] == '.')
                {
                    type = convertVal[i].ToString();
                    i = convertVal.Length;
                }
                else
                {
                    header += convertVal[i].ToString();
                }
            }
            cdataMode.SelectedIndex = Convert.ToInt32(type);
            cherencesTxt.Text = header;
            cvaluext.Text = body;
        }
        
        private void modoBásicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Simplify simp = new Simplify();
            simp.Show();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credits credits = new Credits();
            credits.ShowDialog();
        }

        private void guardarLlaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de llave(*.key)|*.key";
            sfd.Title = "Guardar llave";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stw = new StreamWriter(sfd.FileName);
                stw.Write(dkeyTxt.Text);
                stw.Close();
            }
        }

        private void metadatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Metadata mt = new Metadata();
            mt.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void emulacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Emulate emul = new Emulate();
            emul.Show();
            Cursor = Cursors.Default;
        }

        private void utilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Utility ut = new Utility();
            ut.Show();
            Cursor = Cursors.Default;
            //MessageBox.Show("Esta función todavía no está disponible. Próximamente lo estará", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void restablecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("emulator.csv");
                File.Delete("utility.csv");
                File.Delete("simplify.csv");
                File.Delete("mscreen.csv");
                File.Delete("initial.ini");
                MessageBox.Show("Ajustes borrados correctamente. Caltable se reiniciará", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            catch
            {

            }
        }

        private void idCount_ValueChanged(object sender, EventArgs e)
        {
            SaveFile sf = new SaveFile("mscreen.csv");
            sf.ReadSettings();
            sf.instructionsToSave["idk"] = idCount.Value.ToString();
            sf.parameterslist.AddRange(new string[] { "count", "idk" });
            sf.SaveSettings();
        }

        private void dide_Click(object sender, EventArgs e)
        {
            Develop devel = new Develop();
            devel.Show();
        }

        private void másToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unirseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper hp = new Helper();
            hp.Show();
            SaveFile savef2 = new SaveFile("prod.csv");
            savef2.defaultParameters = "code:0,name:null,mail:null";
            savef2.ReadSettings();
            if (savef2.instructions["code"] == "01023213232124319232192302139483847372834844823745378257823548632537822837467738234545")
            {
                entornoDeDesarrolloToolStripMenuItem.Enabled = true;
            }
        }

        private void entornoDeDesarrolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Develop devel = new Develop();
            devel.Show();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void resetTree_Click(object sender, EventArgs e)
        {
            componentTree.Nodes.Clear();
            componentTree.Nodes.Add(null, "Lista de datos", 0, 0);
            componentTree.ExpandAll();
        }
    }
    class Codes //Work like search index engine
    {
        public string GetCodesByVals(string value, int rdirection)
        {
            string type = "";
            string valuestr = "";
            string retval = "";
            int valuei = 0;
            switch (value)
            {
                case "001": valuestr = "a"; type = "STRING"; break;
                case "002": valuestr = "b"; type = "STRING"; break;
                case "003": valuestr = "c"; type = "STRING"; break;
                case "004": valuestr = "d"; type = "STRING"; break;
                case "005": valuestr = "e"; type = "STRING"; break;
                case "006": valuestr = "f"; type = "STRING"; break;
                case "007": valuestr = "g"; type = "STRING"; break;
                case "008": valuestr = "h"; type = "STRING"; break;
                case "009": valuestr = "i"; type = "STRING"; break;
                case "0011": valuestr = "j"; type = "STRING"; break;
                case "0012": valuestr = "k"; type = "STRING"; break;
                case "0013": valuestr = "l"; type = "STRING"; break;
                case "0014": valuestr = "m"; type = "STRING"; break;
                case "0015": valuestr = "n"; type = "STRING"; break;
                case "0016": valuestr = "o"; type = "STRING"; break;
                case "0017": valuestr = "p"; type = "STRING"; break;
                case "0018": valuestr = "q"; type = "STRING"; break;
                case "0019": valuestr = "r"; type = "STRING"; break;
                case "0021": valuestr = "s"; type = "STRING"; break;
                case "0022": valuestr = "t"; type = "STRING"; break;
                case "0023": valuestr = "u"; type = "STRING"; break;
                case "0024": valuestr = "v"; type = "STRING"; break;
                case "0025": valuestr = "x"; type = "STRING"; break;
                case "0026": valuestr = "y"; type = "STRING"; break;
                case "0027": valuestr = "z"; type = "STRING"; break;
                case "0001": valuestr = "+"; type = "CHAR"; break;
                case "0002": valuestr = "-"; type = "CHAR"; break;
                case "0003": valuestr = "*"; type = "CHAR"; break;
                case "0004": valuestr = "/"; type = "CHAR"; break;
                case "0005": valuestr = "="; type = "CHAR"; break;
                case "0006": valuestr = "e^2"; type = "CHAR"; break;
                case "0007": valuestr = "e^3"; type = "CHAR"; break;
                case "0008": valuestr = "r^2"; type = "CHAR"; break;
                case "0009": valuestr = "("; type = "CHAR"; break;
                case "00011": valuestr = ")"; type = "CHAR"; break;
                case "00012": valuestr = "log"; type = "CHAR"; break;
                case "00013": valuestr = "sen"; type = "CHAR"; break;
                case "00014": valuestr = "cos"; type = "CHAR"; break;
                case "00015": valuestr = "tan"; type = "CHAR"; break;
                case "00016": valuestr = "cosec"; type = "CHAR"; break;
                case "00017": valuestr = "sec"; type = "CHAR"; break;
                case "00018": valuestr = "cotg"; type = "CHAR"; break;
                case "00001": valuestr = "If"; type = "COM"; break;
                case "00002": valuestr = "Locate"; type = "COM"; break;
                case "00003": valuestr = "Else"; type = "COM"; break;
                case "00004": valuestr = "Then"; type = "COM"; break;
                case "00005": valuestr = "Endif"; type = "COM"; break;
                case "00006": valuestr = "=="; type = "COM"; break;
                case "00007": valuestr = "!="; type = "COM"; break;
                case "00008": valuestr = ">"; type = "COM"; break;
                case "00009": valuestr = "<"; type = "COM"; break;
                case "000011": valuestr = "While"; type = "COM"; break;
                case "000012": valuestr = "Whend"; type = "COM"; break;
                case "000013": valuestr = ","; type = "COM"; break;
                case "000014": valuestr = "'"; type = "COM"; break;
                case "000015": valuestr = ";"; type = "COM"; break;
                case "a": valuei = 1; type = "STRING"; break;
                case "b": valuei = 2; type = "STRING"; break;
                case "c": valuei = 3; type = "STRING"; break;
                case "d": valuei = 4; type = "STRING"; break;
                case "e": valuei = 5; type = "STRING"; break;
                case "f": valuei = 6; type = "STRING"; break;
                case "g": valuei = 7; type = "STRING"; break;
                case "h": valuei = 8; type = "STRING"; break;
                case "i": valuei = 9; type = "STRING"; break;
                case "j": valuei = 11; type = "STRING"; break;
                case "k": valuei = 12; type = "STRING"; break;
                case "l": valuei = 13; type = "STRING"; break;
                case "m": valuei = 14; type = "STRING"; break;
                case "n": valuei = 15; type = "STRING"; break;
                case "o": valuei = 16; type = "STRING"; break;
                case "p": valuei = 17; type = "STRING"; break;
                case "q": valuei = 18; type = "STRING"; break;
                case "r": valuei = 19; type = "STRING"; break;
                case "s": valuei = 21; type = "STRING"; break;
                case "t": valuei = 22; type = "STRING"; break;
                case "u": valuei = 23; type = "STRING"; break;
                case "v": valuei = 24; type = "STRING"; break;
                case "w": valuei = 25; type = "STRING"; break;
                case "x": valuei = 26; type = "STRING"; break;
                case "y": valuei = 27; type = "STRING"; break;
                case "z": valuei = 28; type = "STRING"; break;
                case "+": valuei = 1; type = "CHAR"; break;
                case "-": valuei = 2; type = "CHAR"; break;
                case "*": valuei = 3; type = "CHAR"; break;
                case "/": valuei = 4; type = "CHAR"; break;
                case "=": valuei = 5; type = "CHAR"; break;
                case "e^2": valuei = 6; type = "CHAR"; break;
                case "e^3": valuei = 7; type = "CHAR"; break;
                case "r^2": valuei = 8; type = "CHAR"; break;
                case "(": valuei = 9; type = "CHAR"; break;
                case ")": valuei = 11; type = "CHAR"; break;
                case "log": valuei = 12; type = "CHAR"; break;
                case "sen": valuei = 13; type = "CHAR"; break;
                case "cos": valuei = 14; type = "CHAR"; break;
                case "tan": valuei = 15; type = "CHAR"; break;
                case "cosec": valuei = 16; type = "CHAR"; break;
                case "sec": valuei = 17; type = "CHAR"; break;
                case "cotg": valuei = 18; type = "CHAR"; break;
                case "If": valuei = 1; type = "COM"; break;
                case "Locate": valuei = 2; type = "COM"; break;
                case "Else": valuei = 3; type = "COM"; break;
                case "Then": valuei = 4; type = "COM"; break;
                case "Endif": valuei = 5; type = "COM"; break;
                case "==": valuei = 6; type = "COM"; break;
                case "!=": valuei = 7; type = "COM"; break;
                case ">": valuei = 8; type = "COM"; break;
                case "<": valuei = 9; type = "COM"; break;
                case "While": valuei = 11; type = "COM"; break;
                case "Wend": valuei = 12; type = "COM"; break;
                case ",": valuei = 13; type = "COM"; break;
                case "'": valuei = 14; type = "COM"; break;
                case ";": valuei = 15; type = "COM"; break;
                default:
                    try
                    {
                        valuei = Convert.ToInt32(value);
                        foreach (char valueChar in value)
                        {
                            if (valueChar.ToString() != "0")
                            {
                                valuestr += valueChar.ToString();
                            }
                        }
                        type = "INT";
                    }
                    catch
                    {

                    }
                    break;
            }
            switch (rdirection)
            {
                case 0: retval = valuestr; break;
                case 1: retval = type; break;
                case 2: retval = valuei.ToString(); break;
            }
            return retval;
        }
    }
}
