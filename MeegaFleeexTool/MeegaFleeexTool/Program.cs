﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MeegaFleeexTool;

namespace MegaFlexTool
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
