using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    static class Program
    {
        // _____   ___   _____   _   _   ____      ____       _      _____ 
        //|  ___| |_ _| | ____| | \ | | |  _ \    |  _ \     / \    |_   _|
        //| |_     | |  |  _|   |  \| | | | | |   | |_) |   / _ \     | |  
        //|  _|    | |  | |___  | |\  | | |_| |   |  _ <   / ___ \    | |  
        //|_|     |___| |_____| |_| \_| |____/    |_| \_\ /_/   \_\   |_|  
        //
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            Application.Run(form1);
        }
        public static Form1 form1;
    }
}
