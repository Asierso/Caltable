using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Caltable
{       
    class SaveFile //Class for save in csv nano actions.
    {
        public Dictionary<string, string> instructions = new Dictionary<string, string>(); //Temporal savefile data
        public Dictionary<string, string> instructionsToSave = new Dictionary<string, string>(); //Data to modify/save
        public string defaultParameters;
        public List<string> parameterslist = new List<string>();
        private string _fname;
        public SaveFile(string fname)
        {
            _fname = fname;
        }
        public void ReadSettings()
        {
            if (!File.Exists(_fname))
            {
                StreamWriter stw = new StreamWriter(_fname);
                stw.Write(defaultParameters);
                stw.Close();
            }
            using (StreamReader str = new StreamReader(_fname))
            {
                string emulatorSettings = str.ReadToEnd();
                str.Close();
                string[] settings = emulatorSettings.Split(',');
                foreach (string instructionOnly in settings)
                {
                    try
                    {
                        string[] instructionsArray = instructionOnly.Split(':');
                        instructions.Add(instructionsArray[0], instructionsArray[1]);
                        instructionsToSave.Add(instructionsArray[0], instructionsArray[1]);
                    }
                    catch
                    {
                        //Memory files updated
                    }
                }
            }
        }
        public void SaveSettings()
        {
            //Formule savefile
            //string[] parameters = { "name", "count" };
            string filecontent = "";
            int paramGet = 0;
            foreach (string parameterOne in parameterslist)
            {
                filecontent += parameterslist[paramGet] + ":" + instructionsToSave[parameterOne] + ",";
                paramGet++;
            }
            filecontent = filecontent.Substring(0, filecontent.Length - 1);
            StreamWriter stw = new StreamWriter(_fname);
            stw.Write(filecontent);
            stw.Close();
        }
    }
}
