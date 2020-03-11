using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wpftest.HelpClasses
{
    public class FileWorker
    {
        // --- Data Base ---
        public void CreateBD(string name)
        {
            if (name != "")
            {
                File.WriteAllText(Vars.DesktopPath + name + ".bd", null);
            }
        }
        public void DeleteBD(string name)
        {
            if (File.Exists(Vars.DesktopPath + name + ".bd"))
            {
                File.Delete(Vars.DesktopPath + name + ".bd");
            }
        }
        public string CheckBD(string name)
        {
            if (File.Exists(Vars.DesktopPath + name + ".bd"))
            {
                if (File.ReadAllText(Vars.DesktopPath + name + ".bd").Length > 0)
                {
                    return "All good";
                }
                else
                {
                    return "Empty";
                }
            }
            else
            {
                return "Not exist";
            }
        }

    }
}
