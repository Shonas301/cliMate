using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace CliMate
{
    public partial class Canvas : Form
    {
        private const int DEFAULT_SIZE = 600;

        private Heightmap image;
        private Brush currentBrush = new SquareBrush();

        private long prevTime = DateTime.Now.Ticks / TimeSpan.TicksPerSecond;

        public Canvas()
        {
            InitializeComponent();
        }

        private void Canvas_Load(object sender, EventArgs e)
        {
            //Get the image dimensions
            WidthHeightDialog dialog = new WidthHeightDialog();
            dialog.ShowDialog();

            //Create the image and picbox
            image = new Heightmap(dialog.width, dialog.height);
            tempPicBox.Image = new Bitmap(image.width, image.height);

            //Enable the timer
            tickTimer.Enabled = true;
        }

        private void OnGameTick(MouseState mouse)
        {
            //Compute the delta time
            long currTime = DateTime.Now.Ticks / TimeSpan.TicksPerSecond;
            long deltaTimeMs = currTime - prevTime;
            double deltaTime = (double)deltaTimeMs / 1000;

            //Controls
            if (mouse.leftButton)
            {
                Bitmap picboxBitmap = new Bitmap(tempPicBox.Image);

                currentBrush.Apply(image, picboxBitmap, mouse.x, mouse.y, 100, deltaTime);

                tempPicBox.Image = picboxBitmap;
            }

        }

        private void UpdateDisplay()
        {
            //TODO: Do this more efficiently.
            tempPicBox.Image = image.ToBitmap();
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            //Get the mouse data
            MouseState ms = GetMouseState();

            //Call game tick
            OnGameTick(ms);
        }

        private MouseState GetMouseState()
        {
            //Figures out the current mouse state.
            MouseState mouse = new MouseState(0, 0, false, false, false);

            //Mouse buttons
            mouse.leftButton = (MouseButtons == MouseButtons.Left);
            mouse.rightButton = (MouseButtons == MouseButtons.Right);
            mouse.middleButton = (MouseButtons == MouseButtons.Middle);

            //--Finding mouse position in the image's space--

            //Find the position relative to picbox
            Point unscaledPos = tempPicBox.PointToClient(Cursor.Position);

            //TODO: Scale the position with the image properly
            mouse.x = unscaledPos.X;
            mouse.y = unscaledPos.Y;

            return mouse;
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
        public abstract void Apply(Heightmap targetHeightmap, Bitmap targetBitmap, int x, int y, double size, double deltaTime);
    }

    public class SquareBrush : Brush
    {
        private double speed = 200;
        public override void Apply(Heightmap targetHeightmap, Bitmap targetBitmap, int x, int y, double size, double deltaTime)
        {
            //Make a square around the coordinates
            int startX = (int)((double)x - size / 2);
            int endX = (int)((double)x + size / 2);

            int startY = (int)((double)y - size / 2);
            int endY = (int)((double)y + size / 2);

            //Make sure the corners of the square are in bounds
            startX = Utils.CapBounds(startX, 0, targetHeightmap.width);
            endX = Utils.CapBounds(endX, 0, targetHeightmap.width);

            startY = Utils.CapBounds(startY, 0, targetHeightmap.height);
            endY = Utils.CapBounds(endY, 0, targetHeightmap.height);

            //Iterate through the square, applying the logic to it.
            for (x = startX; x < endX; x++)
            {
                for (y = startY; y < endY; y++)
                {
                    //Change the height at this position
                    double val = targetHeightmap.GetValue(x, y);
                    val += speed * deltaTime;

                    //Ensure the value stays within the limits
                    if (Math.Abs(val) > Heightmap.MAX_HEIGHT)
                    {
                        val = Math.Sign(val) * Heightmap.MAX_HEIGHT;
                    }

                    //Apply the height change
                    targetHeightmap.SetValue(x, y, val);
                    targetBitmap.SetPixel(x, y, Heightmap.ValueToColor(val));
                }
            }
        }
  
    }
}
