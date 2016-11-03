using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliMate
{
    public partial class Canvas : Form
    {
        private const int DEFAULT_SIZE = 100;

        private Heightmap image = new Heightmap(DEFAULT_SIZE, DEFAULT_SIZE);

        public Canvas()
        {
            InitializeComponent();
        }

        private void OnGameTick(MouseState mouse, double deltaTime)
        {
            //
        }

        private void UpdateDisplay()
        {
            //TODO: Update the display
        }
    }

    public class MouseState
    {
        public bool leftButton;
        public bool rightButton;
        public bool middleButton;

        public int x;   //In the heightmap's coordinate space
        public int y;   //In the heightmap's coordinate space

        public MouseState(int x, int y, bool leftButton, bool middleButton, bool rightButton)
        {
            this.x = x;
            this.y = y;
            this.leftButton = leftButton;
            this.rightButton = rightButton;
            this.middleButton = middleButton;
        }
    }

    public abstract class Brush
    {
        public abstract void Apply(Heightmap target, int x, int y, double size, double deltaTime);
    }

    public class SquareBrush : Brush
    {
        private double speed = 10;
        public override void Apply(Heightmap target, int x, int y, double size, double deltaTime)
        {
            //Make a square around the coordinates
            int startX = (int)((double)x - size / 2);
            int endX = (int)((double)x + size / 2);

            int startY = (int)((double)y - size / 2);
            int endY = (int)((double)y + size / 2);

            //Make sure the corners of the square are in bounds
            startX = CapBounds(startX, 0, target.width);
            endX = CapBounds(endX, 0, target.width);

            startY = CapBounds(startY, 0, target.height);
            endY = CapBounds(endY, 0, target.height);

            //Iterate through the square, applying the logic to it.
            for (x = startX; x < endX; x++)
            {
                for (y = startY; y < endY; y++)
                {
                    //Change the height at this position
                    double val = target.GetValue(x, y);
                    val += speed * deltaTime;

                    //Ensure the value stays within the limits
                    if (Math.Abs(val) > Heightmap.MAX_HEIGHT)
                    {
                        val = Math.Sign(val) * Heightmap.MAX_HEIGHT;
                    }

                    //Apply the height change
                    target.SetValue(x, y, val);
                }
            }
        }

        private int CapBounds(int num, int min, int max)
        {
            //Ensures num is inside the given inclusive bounds

            if (num < min)
            {
                num = min;
            }

            if (num > max)
            {
                num = max;
            }

            return num;
        }
    }
}
