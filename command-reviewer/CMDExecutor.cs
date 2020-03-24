using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace command_reviewer
{
    public  class CMDExecutor
{
        public string command { get; set; } 
        public string result { get; set;}
        public void ExecuteProces()
{
System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + this.command);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = false;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            result = Environment.NewLine;
for (int i=0; i< proc.StandardOutput.Read();i++)
{
                result += proc.StandardOutput.ReadLine();
}
}
}
}
