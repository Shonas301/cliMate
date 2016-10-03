using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;

namespace OpenTKGridTest
{
    class Screen
    {
        public const int WIDTH = 1200;
        public const int HEIGHT = 800;
        static void Display() 
        {
            GameWindow window = new GameWindow(WIDTH, HEIGHT);
            Grid hexGrid = new Grid(window);

            window.Run();
        }
    }
}
