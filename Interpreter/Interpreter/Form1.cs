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
using System.Runtime.CompilerServices;
using System.Timers;

namespace Interpreter
{
    public partial class Form1 : Form
    {
        string _fname;

        public Form1(string fname = "")
        {
            InitializeComponent();
            _fname = fname;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            L1.Text = "                ";
            L2.Text = "                ";
            L3.Text = "                ";
            L4.Text = "                ";
            if (!File.Exists(_fname))
            {
                MessageBox.Show("No se ha especificado un archivo válido", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
            }

            StreamReader str = new StreamReader(_fname);
            Dictionary<string, int> variables = new Dictionary<string, int>();
            string script = str.ReadToEnd();
            str.Close();
            string[] instructions = script.Split(new char[] {';', '\n'});
            foreach (string instructionToRecognise in instructions)
            {
                if (instructionToRecognise.Contains("Locate"))
                {
                    string[] parameters = instructionToRecognise.Split(',');
                    //Debug expresion MessageBox.Show(parameters[0].Substring(7,parameters[0].Length - 7));
                    //parameters[0] = x, parameters[1] = y, parameters[2] = text
                    int x = Convert.ToInt32(parameters[0].Substring(7, parameters[0].Length - 7));
                    int y = Convert.ToInt32(parameters[1]);
                    string text = "";
                    try
                    {
                        text = variables[parameters[2]].ToString();
                    }
                    catch
                    {
                        text = parameters[2].Trim(new char[] {'"'});
                    }

                    SetText(x, y, text);
                }

                if (instructionToRecognise.Contains("->"))
                {
                    string[] parameters = instructionToRecognise.Split('>');
                    parameters[0] = parameters[0].TrimEnd(new char[] {'-'});
                    //parameters[0] = Value, parameters[1] = Var Name
                    variables.Add(parameters[1], Convert.ToInt32(parameters[0]));

                }
            }

            //MessageBox.Show("Interpretado de la interfaz finalizado","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        //Functions
        private void SetText(int x, int y, string text)
        {
            switch (y)
            {
                case 1:
                    string finalTextL1 = "";
                    for (int i = 0; i < x; i++)
                    {
                        finalTextL1 += L1.Text[i];
                    }

                    finalTextL1 += text;
                    for (int i = x + text.Length; i < 16; i++)
                    {
                        finalTextL1 += L1.Text[i];
                    }

                    L1.Text = finalTextL1;
                    break;
                case 2:
                    string finalTextL2 = "";
                    for (int i = 0; i < x; i++)
                    {
                        finalTextL2 += L2.Text[i];
                    }

                    finalTextL2 += text;
                    for (int i = x + text.Length; i < 16; i++)
                    {
                        finalTextL2 += L2.Text[i];
                    }

                    L2.Text = finalTextL2;
                    break;
                case 3:
                    string finalTextL3 = "";
                    for (int i = 0; i < x; i++)
                    {
                        finalTextL3 += L3.Text[i];
                    }

                    finalTextL3 += text;
                    for (int i = x + text.Length; i < 16; i++)
                    {
                        finalTextL3 += L3.Text[i];
                    }

                    L3.Text = finalTextL3;
                    break;
                case 4:
                    string finalTextL4 = "";
                    for (int i = 0; i < x; i++)
                    {
                        finalTextL4 += L4.Text[i];
                    }

                    finalTextL4 += text;
                    for (int i = x + text.Length; i < 16; i++)
                    {
                        finalTextL4 += L4.Text[i];
                    }

                    L4.Text = finalTextL4;
                    break;
                default:
                    ErrorLogs errorLogs = new ErrorLogs("Dimension error");
                    // Not a critic error => throw new RankException();

                    break;
            }

            timer1.Enabled = true;
            timer1.Start();

        }

        #region GDIComponentDraw

        public static void DrawGdiIndicator(Panel panel, Color[] color, int repeated = 1)
        {
            Graphics gl = panel.CreateGraphics();
            int coordx = 0;
            for (int i = 0; i < repeated; i++)
            {
                gl.FillRectangle(new SolidBrush(Color.White), coordx, 0, 10, 10);
                coordx += 15;
            }

        }

        #endregion

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            CompilerIndicator compilerIndicator = new CompilerIndicator(indicatorsPanel);
            compilerIndicator.Show();
        }
    }
    public class ErrorLogs
    {
        //Error syntax: Error => CS Error detailed
        private string output;
        public ErrorLogs(string error,Exception description = null)
        {
            output = error;
            StreamWriter stw = new StreamWriter("syntaxerror.log");
            stw.Write(error + "=>" + description);
            stw.Close();
        }

        public string GetError()
        {
            return output;
        }
        
    }

    public class CompilerIndicator
    {
        private Panel _panel;
        private ErrorLogs _errorLogs;
        public CompilerIndicator(Panel panel)
        {
            _panel = panel;
        }
        public void Show()
        {
            if (1==1)
            {
                Form1.DrawGdiIndicator(_panel,new Color[] {Color.White,Color.White,Color.White},3);
            }
            else
            {
                switch (_errorLogs)
                {
                    default:Form1.DrawGdiIndicator(_panel,new Color[] {Color.White,Color.White,Color.LightCoral},3);
                        break;
                }
            }
        }
    }
}
