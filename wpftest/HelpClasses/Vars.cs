﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpftest.HelpClasses
{
    static public class Vars
    {
        // main path
        static public string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

        // sportsmens list
        public static List<Sportsmen> sportsmens = new List<Sportsmen>();
        
    }
}
