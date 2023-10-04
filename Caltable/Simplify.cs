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
    public partial class Simplify : Form //Main menu but simplified for basic proposes
    {
        public Simplify()
        {
            InitializeComponent();
        }

        private void Simplify_Load(object sender, EventArgs e)
        {
            codecSelect.Items.AddRange(new string[] { "Decimal", "Texto" });
            SaveFile savef = new SaveFile("simplify.csv");
            savef.defaultParameters = "proc:";
            savef.ReadSettings();
            dataTxt.Text = savef.instructions["proc"];
        }

        private void processTxt_Click(object sender, EventArgs e)
        {
            try
            {
            Codes code = new Codes();
            string convertVal = dataTxt.Text;
            resultTxt.Text = "";
            int multi = 10;
            switch (codecSelect.SelectedItem)
            {
                case "Decimal":
                    multi = 9;
                    resultTxt.Text = "00.";
                    foreach (char convertValChar in convertVal)
                    {
                        switch (code.GetCodesByVals(convertValChar.ToString(), 1))
                        {
                            case "INT": resultTxt.Text += "0" + code.GetCodesByVals(convertValChar.ToString(), 2); break;
                            case "STRING": resultTxt.Text += "00" + code.GetCodesByVals(convertValChar.ToString(), 2); break;
                            case "CHAR": resultTxt.Text += "000" + code.GetCodesByVals(convertValChar.ToString(), 2); break;
                        }

                    }
                    break;
                case "Texto":
                    string header = "";
                    string body = "";
                    string charset = "";
                    string type = "";
                    int iterator = 0;
                    bool isHeader = true;
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
                    resultTxt.Text = body;
                    break;
            }
                try
                {
                    progressBar1.Value = resultTxt.Text.Length * multi;
                }
                catch
                {
                    progressBar1.Value = 100;
                }
                
            }
            catch
            {
                MessageBox.Show("Conficto en los parámetros recibidos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            SaveFile sf = new SaveFile("simplify.csv");
            sf.ReadSettings();
            sf.instructionsToSave["proc"] = dataTxt.Text;

            sf.parameterslist.AddRange(new string[] { "proc"});
            sf.SaveSettings();
        }
    }
}
