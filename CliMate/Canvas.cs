﻿using System;
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
        private const int DEFAULT_SIZE = 10;        //Default brush size

        private const double DEFAULT_SPEED = 200;   //Default brush speed
        private const double MIN_BRUSH_SPEED = 0;
        private const double MAX_BRUSH_SPEED = 500;

        private Heightmap image;
        private long prevTime = DateTime.Now.Ticks / TimeSpan.TicksPerSecond;

        //Brushes
        private Dictionary<RadioButton, Brush> brushButtonMap = new Dictionary<RadioButton, Brush>();
        private double brushSize
        {
            get { return (double)brushSizeBox.Value; }
            set { brushSizeBox.Value = (decimal)value; }
        }
        private double brushSpeed
        {
            get { return (double)brushSpeedBox.Value; }
            set { brushSpeedBox.Value = (decimal)value; }
        }

        private Brush currentBrush = null;

        //Tools
        private delegate void ToolMethod(long currTime, long deltaTimeMs, double deltaTime, MouseState mouse);
        private Dictionary<RadioButton, ToolMethod> toolButtonMap = new Dictionary<RadioButton, ToolMethod>();
        private ToolMethod currentTool = null;

        //leveraging canvas to make masks, is for mask if forMask = true;
        private bool forMask;

        //Constructors
        public Canvas(bool forMask)
        {
            this.forMask = forMask;
            InitializeComponent();
        }

        //Misc functions
        private void UpdateDisplay()
        {
            //TODO: Do this more efficiently.
            tempPicBox.Image = image.ToBitmap();
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

        private RadioButton AddRadioButtonOption<T>(string name, T option, Dictionary<RadioButton, T> dictionary, FlowLayoutPanel panel, EventHandler handler)
        {
            //Creates a radio button for the given option and adds it to the given dictionary/panel

            //Create the button
            RadioButton button = new RadioButton();
            button.Text = name;

            //Add it to the system
            dictionary.Add(button, option);
            panel.Controls.Add(button);
            button.CheckedChanged += handler;

            //Return the button
            return button;
        }

        private RadioButton AddBrushType(string name, Brush brush)
        {
            //Creates the radio button for the brush
            return AddRadioButtonOption<Brush>(name, brush, brushButtonMap, brushTypePanel, brushTypeRadioButton_CheckedChanged);
        }

        private RadioButton AddTool(string name, ToolMethod type)
        {
            //Creates a radio button for the tool
            return AddRadioButtonOption<ToolMethod>(name, type, toolButtonMap, toolLayoutPanel, toolTypeRadioButton_CheckedChanged);
        }


        //Tool methods
        private void PaintBrushTool(long currTime, long deltaTimeMs, double deltaTime, MouseState mouse)
        {
            //Paint with left-click
            if (mouse.leftButton)
            {
                Bitmap picboxBitmap = new Bitmap(tempPicBox.Image);
                currentBrush.Apply(image, picboxBitmap, mouse.x, mouse.y, brushSize, brushSpeed, deltaTime);
                tempPicBox.Image = picboxBitmap;
            }
        }

        private void EraserTool(long currTime, long deltaTimeMs, double deltaTime, MouseState mouse)
        {
            //Erase with left-click
            if (mouse.leftButton)
            {
                Bitmap picboxBitmap = new Bitmap(tempPicBox.Image);
                currentBrush.Apply(image, picboxBitmap, mouse.x, mouse.y, brushSize, brushSpeed * -1, deltaTime);
                tempPicBox.Image = picboxBitmap;
            }
        }


        //Events
        private void Canvas_Load(object sender, EventArgs e)
        {
            //Get the image dimensions
            WidthHeightDialog dialog = new WidthHeightDialog();
            dialog.ShowDialog();

            //Create the image and picbox
            image = new Heightmap(dialog.width, dialog.height);
            tempPicBox.Image = image.ToBitmap();

            //Enable the timer
            tickTimer.Enabled = true;

            //Set default brush params
            brushSpeedBox.Minimum = (decimal)MIN_BRUSH_SPEED;
            brushSpeedBox.Maximum = (decimal)MAX_BRUSH_SPEED;

            brushSize = DEFAULT_SIZE;
            brushSpeed = DEFAULT_SPEED;

            //Add all brush types
            AddBrushType("Circle", new CircleBrush()).Checked = true;

            AddBrushType("Square", new SquareBrush());

            //Add all tools
            AddTool("Paint Brush", PaintBrushTool).Checked = true;
            AddTool("Eraser", EraserTool);
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            //Get the mouse data
            MouseState ms = GetMouseState();

            //Call game tick
            OnGameTick(ms);
        }

        private void OnGameTick(MouseState mouse)
        {
            //Compute the delta time
            long currTime = DateTime.Now.Ticks / TimeSpan.TicksPerSecond;
            long deltaTimeMs = currTime - prevTime;
            double deltaTime = (double)deltaTimeMs / 1000;

            currentTool(currTime, deltaTimeMs, deltaTime, mouse);
        }

        private void brushTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Switch brush type
            RadioButton button = (RadioButton)sender;

            if (button.Checked)
            {
                currentBrush = brushButtonMap[button];
            }
        }

        private void toolTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Switch tools
            RadioButton button = (RadioButton)sender;

            if (button.Checked)
            {
                currentTool = toolButtonMap[button];
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Set the image to the project's main input
            if (!forMask)
            {
                Form1.currentOpenProject.SetFirstHeightmap(image);
            }
            else
            {
                Form1.currentOpenProject.CreateMask(image.width, image.height);
                int[,] mask = Form1.currentOpenProject.GetMask();
                Bitmap bit = image.ToBitmap();
                for (int i = 0; i < bit.Width; i++)
                {
                    for(int j = 0; j < bit.Height; j++)
                    {
                        Color pixel = bit.GetPixel(i, j);
                        if (pixel == Heightmap.ValueToColor(0))
                        {
                            mask[i, j] = 0;
                        }
                        else
                        {
                            mask[i, j] = 1;
                        }
                    }
                }
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reset the image
            image = new Heightmap(image.width, image.height);
            tempPicBox.Image = image.ToBitmap();
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


    //Brush classes

    public abstract class Brush
    {
        public abstract void Apply(Heightmap targetHeightmap, Bitmap targetBitmap, int x, int y, double size, double speed, double deltaTime);
    }

    public class SquareBrush : Brush
    {
        public override void Apply(Heightmap targetHeightmap, Bitmap targetBitmap, int x, int y, double size, double speed, double deltaTime)
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

    public class CircleBrush : Brush
    {
        public override void Apply(Heightmap targetHeightmap, Bitmap targetBitmap, int x, int y, double size, double speed, double deltaTime)
        {
            double radius = size;

            //Make a bounding box around the circle
            int startX = (int)((double)x - size);
            int endX = (int)((double)x + size);

            int startY = (int)((double)y - size);
            int endY = (int)((double)y + size);

            //Make sure the corners are in bounds
            startX = Utils.CapBounds(startX, 0, targetHeightmap.width);
            endX = Utils.CapBounds(endX, 0, targetHeightmap.width);

            startY = Utils.CapBounds(startY, 0, targetHeightmap.height);
            endY = Utils.CapBounds(endY, 0, targetHeightmap.height);

            //Loop through the bounding box, skipping any pixels that fall outside the circle

            int centerX = x;
            int centerY = y;    //Save x and y, since we're using those variable names in the loop

            for (x = startX; x < endX; x++)
            {
                for (y = startY; y < endY; y++)
                {
                    //Skip this pixel if it's not within the radius
                    double squaredDist = (x - centerX) * (x - centerX) + (y - centerY) * (y - centerY);
                    if (squaredDist > radius * radius)
                    {
                        continue;
                    }

                    //Make it so the speed decreases as it gets further from the center
                    double distPercent = squaredDist / (radius * radius);
                    double scaledSpeed = Utils.Lerp(speed, 0, distPercent);

                    //Change the height at this position
                    double val = targetHeightmap.GetValue(x, y);
                    val += scaledSpeed * deltaTime;

                    //Ensure the value stays within the limits
                    if (Math.Abs(val) > Heightmap.MAX_HEIGHT)
                    {
                        val = Math.Sign(val) * Heightmap.MAX_HEIGHT;
                    }

                    //Apply the height change
                    targetHeightmap.SetValue(x, y, val);
                    targetBitmap.SetPixel(x, y, Heightmap.ValueToColor(val));
                }
            }//End of double for loop

        }//End of function
    }
}
