using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Interpreter
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args[0] == "")
                {
                    throw new Exception("Parameter can't be void");
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(args[0]));
            }
            catch (Exception ex)
            {
                //No parameters
                ErrorLogs errorLogs =new ErrorLogs("Parameters error",ex);
            }
        }
    }
}
