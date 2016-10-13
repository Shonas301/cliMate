using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace CliMate
{
    interface Grid
    {
        Bitmap sendDisplay(int width, int height, int MODE);
    }
}
