using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliMate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenTK.GameWindow window = new OpenTK.GameWindow(640,480);
            GridDisplayEquiRect disp = new GridDisplayEquiRect(3, window);
            window.Run();
            Application.Run(new Form1());
            
        }
    }
}
