using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;


namespace CliMate
{
    class Screen
    {
        public const int WIDTH = 1800;
        public const int HEIGHT = 400;
        public static void run()
        {
            GeoGrid grid = new GeoGrid(10);

            GameWindow window = new GameWindow(WIDTH, HEIGHT);
            GeoDisplayIco hexGrid = new GeoDisplayIco(window, grid);

            window.Run();
        }
    }
}
