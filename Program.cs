using System;
using System.Windows.Forms;

namespace ScreenReaderProject
{
    static class Program
    {
        
        [STAThread]
        public static void Main(string[] arg)
        {
            Application.Run(new Form1()); 
        }
    }
}
