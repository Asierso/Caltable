using System;
using System.Net;
namespace updater
{
    class prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current:" + args[0]);
            WebClient wc = new WebClient();
            string data = wc.DownloadString("https://asierso.github.io/Caltable/ver.txt");
            if(data != args[0])
            {
                wc.DownloadFile("https://asierso.github.io/Caltable/File/"+ data + ".exe",data + ".exe");
            }
        }
    }
}