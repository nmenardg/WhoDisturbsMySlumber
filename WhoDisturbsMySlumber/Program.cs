using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoDisturbsMySlumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var runAs = Environment.UserName;
            var identity = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            var parentProcessPath = ParentProcess.FullPath;
            var parentProcessName = ParentProcess.ProcessName;

            File.AppendAllText(DateTime.Today.ToString("yyyy-MM-dd") + ".log", String.Format(@"{0}
Run as:     {1}
Identity:   {2}
Parent process:
- Path:     {3}
- Name:     {4}

", DateTime.Now, runAs, identity, parentProcessPath, parentProcessName));
        }
    }
}
