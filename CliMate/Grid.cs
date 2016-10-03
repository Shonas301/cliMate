using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace OpenTKGridTest
{
    class Grid
    {
        //These just get division out of the way so the program isn't doing it every time it draws a shape 
        const float RATIOX = (float)Screen.HEIGHT / (float)Screen.WIDTH;
        const float RATIOY = (float)Screen.WIDTH / (float)Screen.HEIGHT;
        const float DIVWIDTH = 1.0f / (float)Screen.WIDTH;
        const float DIVHEIGHT = 1.0f / (float)Screen.HEIGHT;
        const float ROOT3 = 1.732051f;

        const int TOP = 0;
        const int LEFT = 1;
        const int RIGHT = 2;


        public GameWindow window;

        public Grid(GameWindow window)
        {
            this.window = window;

            window.Load += Window_Load;
            window.UpdateFrame += Window_UpdateFrame;
            window.RenderFrame += Window_RenderFrame;
            window.Closing += Window_Closing;
        }

        private void Window_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.LightSkyBlue);
            GL.Clear(ClearBufferMask.ColorBufferBit);



            Random rand = new Random();

            int frequency = 20;
            float size = Screen.HEIGHT / frequency;
            float curX = 0;
            float curY = Screen.HEIGHT;




            for (int i = 0; i < frequency; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Color val = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                    if (i == 1)
                    {
                        DrawCorner(curX + (j * ROOT3 * size), curY, size, val, TOP);
                    }
                    else if (i == frequency - 1 && j == 0)
                    {
                        DrawCorner(curX + (j * ROOT3 * size), curY, size, val, LEFT);
                    }
                    else if (i == frequency - 1 && j == i - 1)
                    {
                        DrawCorner(curX + (j * ROOT3 * size), curY, size, val, RIGHT);
                    }
                    else if(j==0){
                        DrawEdge(curX + (j * ROOT3 * size), curY, size, val, LEFT);
                    }
                    else if (j == (i - 1))
                    {
                        DrawEdge(curX + (j * ROOT3 * size), curY, size, val, RIGHT);
                    }
                    else if (i == frequency - 1)
                    {
                        DrawEdge(curX + (j * ROOT3 * size), curY, size, val, TOP);
                    }
                    else
                    {
                        DrawHex(curX + (j * ROOT3 * size), curY, size, val);
                    }
                }
                curX -= (ROOT3 / 2 * size);
                curY -= 1.5f * size;
            }

            GL.Flush();
            window.SwapBuffers();
        }

        private void Window_UpdateFrame(object sender, FrameEventArgs e)
        {

        }

        private void Window_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.ClearColor(Color.LightSkyBlue);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        //Method for drawing a hexagon
        private void DrawHex(float x, float y, float size, Color value)
        {
            x *= DIVWIDTH;
            y *= DIVHEIGHT;
            size /= Screen.HEIGHT;
            GL.Begin(BeginMode.Polygon);
            //Set that color
            GL.Color3(value);
            //This loop just goes around a circle dropping a vertex every 60 degrees
            for (int i = 0; i < 6; ++i)
            {
                //RATIOY is added to comp for the fact that openTK uses coordinates relative to screen size
                GL.Vertex2(RATIOX * size * Math.Sin(i / 6.0 * 2 * Math.PI) + x, size * Math.Cos(i / 6.0 * 2 * Math.PI) + y);
            }
            GL.End();
        }

        //This method draws the corners of each facet
        //So I went with drawing unique shapes because stencils don't have the capability of masking 20 triangles at once and it's kinda complicated to implement anyway
        private void DrawCorner(float x, float y, float size, Color value, int orientation)
        {
            x *= DIVWIDTH;
            y *= DIVHEIGHT;
            size *= DIVHEIGHT;
            GL.Begin(BeginMode.Polygon);
            //Set that color
            GL.Color3(value);
            //This loop just goes around a circle dropping a vertex every 60 degrees
            if (orientation == TOP)
            {
                GL.Vertex2(x, y);
                //Magic numbers whatever. It's trig. Get over it.
                GL.Vertex2(x - (RATIOX * ROOT3 * size / 4), y - (0.75f * size));
                GL.Vertex2(x, y - size);
                GL.Vertex2(x + (RATIOX * ROOT3 * size / 4), y - (0.75f * size));
            }
            else if (orientation == LEFT)
            {
                GL.Vertex2(x, y);
                GL.Vertex2(x + (RATIOX * size * ROOT3 / 2), y);
                GL.Vertex2(x + (RATIOX * size * ROOT3 / 2), y + (0.5f * size));
                GL.Vertex2(x + (RATIOX * ROOT3 * size / 4), y + (0.75f * size));
            }
            else if (orientation == RIGHT)
            {
                GL.Vertex2(x, y);
                GL.Vertex2(x - (RATIOX * size * ROOT3 / 2), y);
                GL.Vertex2(x - (RATIOX * size * ROOT3 / 2), y + (0.5f * size));
                GL.Vertex2(x - (RATIOX * ROOT3 * size / 4), y + (0.75f * size));
            }
            GL.End();
        }
        private void DrawEdge(float x, float y, float size, Color value, int orientation)
        {
            x *= DIVWIDTH;
            y *= DIVHEIGHT;
            size *= DIVHEIGHT;

            GL.Begin(BeginMode.Polygon);
            GL.Color3(value);
            if (orientation==LEFT)
            {
                GL.Vertex2(x + (RATIOX * size * ROOT3 / 4), y + (size * 0.75f));
                for (int i = 1; i < 4; ++i)
                {
                    GL.Vertex2(RATIOX * size * Math.Sin(i / 6.0 * 2 * Math.PI) + x, size * Math.Cos(i / 6.0 * 2 * Math.PI) + y);
                }
                GL.Vertex2(x - (RATIOX * size * ROOT3 / 4), y - (size * 0.75f));
            }
            if (orientation == RIGHT)
            {
                GL.Vertex2(x + (RATIOX * size * ROOT3 / 4), y - (size * 0.75f));
                for (int i = 3; i < 6; ++i)
                {
                    GL.Vertex2(RATIOX * size * Math.Sin(i / 6.0 * 2 * Math.PI) + x, size * Math.Cos(i / 6.0 * 2 * Math.PI) + y);
                }
                GL.Vertex2(x - (RATIOX * size * ROOT3 / 4), y + (size * 0.75f));
            }
            if (orientation == TOP)
            {
                GL.Vertex2(x - (RATIOX * size * ROOT3 / 2), y);
                for (int i = 5; i < 8; ++i)
                {
                    GL.Vertex2(RATIOX * size * Math.Sin(i / 6.0 * 2 * Math.PI) + x, size * Math.Cos(i / 6.0 * 2 * Math.PI) + y);
                }
                GL.Vertex2(x + (RATIOX * size * ROOT3 / 2), y);
            }
            GL.End();
        }
    }
}
