using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace CliMate
{
    //This is still beyond broken.
    class GridDisplayEquiRect
    {

        static int counter = 0;
        GameWindow window;
        Triangle[] test;
        Color[] colors;

        class Triangle
        {

            public Vector3 t0, t1, t2;
            Triangle n0, n1, n2;
            //Get rid of ID if it's still here
            public int ID;
            public Triangle(Vector3 t0, Vector3 t1, Vector3 t2)
            {
                this.t0 = t0;
                this.t1 = t1;
                this.t2 = t2;
                n0 = null;
                n1 = null;
                n2 = null;
                ID = -1;
            }
            public void neighbor0(Triangle t)
            {
                this.n0 = t;
            }
            public void neighbor1(Triangle t)
            {
                this.n1 = t;
            }
            public void neighbor2(Triangle t)
            {
                this.n2 = t;
            }
            public Vector3 mid()
            {
                //This method is documented and pretty quick.
                //There's a link
                //github.com/mono/opentk/blob/master/Source/OpenTK/Math/Vector3.cs
                return Vector3.BaryCentric(t0,t1,t2, 1.0f / 3.0f, 1.0f / 3.0f);
            }
            public void setID(int ID)
            {
                this.ID = ID;
            }

        };

        public GridDisplayEquiRect(int numSubs, GameWindow window)
        {
            Triangle[] ico = new Triangle[20];
            for(int i = 0; i < 5; i++)
            {
                //Each iteration of this loop will produce a 3d coordinates for 4 triangles in the parallelogram strip (did this so it'd play nice with the data representation)
                Vector3 t0;
                Vector3 t1;
                Vector3 t2;

                t0 = new Vector3((float)Math.Cos(((2 * i) * Math.PI) / 5), (float)Math.Sin(((2 * i) * Math.PI) / 5), 0.5f);
                t1 = new Vector3((float)Math.Cos(((2 * i + 2) * Math.PI) / 5), (float)Math.Sin(((2 * i + 2) * Math.PI) / 5), 0.5f);
                t2 = new Vector3(0.0f, 0.0f, 1.0f);
                ico[4 * i] = new Triangle(t0, t1, t2);

                t0 = new Vector3((float)Math.Cos(((2 * i) * Math.PI) / 5), (float)Math.Sin(((2 * i) * Math.PI) / 5), 0.5f);
                t1 = new Vector3((float)Math.Cos(((2 * i + 2) * Math.PI) / 5), (float)Math.Sin(((2 * i + 2) * Math.PI) / 5), 0.5f);
                t2 = new Vector3((float)Math.Cos(((2 * i + 1) * Math.PI) / 5), (float)Math.Sin(((2 * i + 1) * Math.PI) / 5), -0.5f);
                ico[4 * i + 1] = new Triangle(t0, t1, t2);


                t0 = new Vector3((float)Math.Cos(((2 * i + 1) * Math.PI) / 5), (float)Math.Sin(((2 * i + 1) * Math.PI) / 5), -0.5f);
                t1 = new Vector3((float)Math.Cos(((2 * i + 3) * Math.PI) / 5), (float)Math.Sin(((2 * i + 3) * Math.PI) / 5), -0.5f);
                t2 = new Vector3((float)Math.Cos(((2 * i + 2) * Math.PI) / 5), (float)Math.Sin(((2 * i + 2) * Math.PI) / 5), 0.5f);
                ico[4 * i + 2] = new Triangle(t0, t1, t2);

                t0 = new Vector3((float)Math.Cos(((2 * i + 1) * Math.PI) / 5), (float)Math.Sin(((2 * i + 1) * Math.PI) / 5), -0.5f);
                t1 = new Vector3((float)Math.Cos(((2 * i + 3) * Math.PI) / 5), (float)Math.Sin(((2 * i + 3) * Math.PI) / 5), -0.5f);
                t2 = new Vector3(0.0f, 0.0f, -1.0f);
                ico[4 * i + 3] = new Triangle(t0, t1, t2);

                //Put that garbage collector to work! Haha!
            }


            Triangle[] edge0 = Subdivide(ico[3],3);

            test = edge0;
            colors = new Color[test.Length];
            Random r = new Random();

            for (int i = 0; i < test.Length; i++)
            {
                colors[i] = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            }
            /*colors[0] = Color.Red;
            colors[1] = Color.Cyan;
            colors[2] = Color.Magenta;
            colors[3] = Color.Yellow;
            colors[4] = Color.Green;
            colors[5] = Color.Blue;
            colors[6] = Color.Purple;
            colors[7] = Color.Orange;*/

            this.window = window;

            window.Load += Window_Load;
            window.UpdateFrame += Window_UpdateFrame;
            window.RenderFrame += Window_RenderFrame;
            window.Closing += Window_Closing;


        }

        private void Window_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.LightSkyBlue);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-(window.Width / window.Height), -(window.Width / window.Height), -1, 1, -1, 1);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthMask(true);
            GL.DepthFunc(DepthFunction.Lequal);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            


        }

        private void Window_UpdateFrame(object sender, FrameEventArgs e)
        {
            
        }

        private void Window_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Rotate(1.0f, 1.0f, 1.0f, 0.0f);


            for (int i = 0; i < test.Length; i++)
            {
                drawTriangle(test[i], colors[i]);
            }

            GL.Flush();
            window.SwapBuffers();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        //Like lerping, but on a sphere!
        private Vector3 slerp(Vector3 p0, Vector3 p1, float t)
        {
            //So check the wikipedia article on slerping
            Vector3 temp0 = new Vector3(p0.X, p0.Y, p0.Z);
            Vector3 temp1 = new Vector3(p1.X, p1.Y, p1.Z);
            temp0.Normalize();
            temp1.Normalize();
            float omega = (float) Math.Acos(Vector3.Dot(temp0,temp1));
            float scale0 = (float)(Math.Sin((1.0f - t) * omega) / Math.Sin(omega));
            float scale1 = (float)(Math.Sin(t * omega) / Math.Sin(omega));
            temp0.X = p0.X;
            temp0.Y = p0.Y;
            temp0.Z = p0.Z;
            temp1.X = p1.X;
            temp1.Y = p1.Y;
            temp1.Z = p1.Z;
            p0 = Vector3.Multiply(temp0, scale0);
            p1 = Vector3.Multiply(temp1, scale1);
            Vector3 res = Vector3.Add(p0, p1);
            return res;
        }

        private Triangle[] Subdivide(Triangle t, int sub)
        {
            //Split triangle
            Vector3 p01 = slerp(t.t0,t.t1, 0.5f);
            Vector3 p12 = slerp(t.t1, t.t2, 0.5f);
            Vector3 p20 = slerp(t.t2, t.t0,0.5f);
            Triangle t0 = new Triangle(t.t0,p01,p20);
            Triangle t1 = new Triangle(t.t1, p12, p01);
            Triangle t2 = new Triangle(t.t2, p20, p12);
            t = new Triangle(p01, p12, p20);
            //Basis Case
            if (sub == 1)
            {
                t0.setID(counter++);
                t1.setID(counter++);
                t2.setID(counter++);
                t.neighbor0(t0);
                t.neighbor1(t1);
                t.neighbor2(t2);
                Triangle[] e = {t1, t2, t2, t0, t0, t1};
                return e;
            }
            else
            {

                Triangle[] e = Subdivide(t, sub - 1);
                Triangle[] e0 = Subdivide(t0, sub - 1);
                Triangle[] e1 = Subdivide(t1, sub - 1);
                Triangle[] e2 = Subdivide(t2, sub - 1);


                int third = e.Length / 3;

                //Assign neighbors
                for (int i = 0; i<third; i++)
                {
                    e[third - i - 1].neighbor0(e0[i]);
                    e0[i].neighbor0(e[third - i - 1]) ;
                    e[(2 * third) - i - 1].neighbor1(e1[third + i]);
                    e1[third + i].neighbor1(e[(2 * third) - i - 1]);
                    e[(3 * third) - i - 1].neighbor2(e2[(2 * third) + i]);
                    e2[(2 * third) + i].neighbor2(e[(3 * third) - i - 1]);
                }

                //return new edge list
                Triangle[] next = new Triangle[6*third];
                for(int i = 0; i<next.Length; i++)
                {
                    if (i<third)
                    {
                        next[i] = e1[i];
                    }
                    else if (i >= third && i < (3 * third))
                    {
                        next[i] = e2[i-third];
                    }
                    else if (i >= (3 * third) && i < (5 * third))
                    {
                        next[i] = e0[i - (2 * third)];
                    }
                    else
                    {
                        next[i] = e1[i - (3 * third)];
                    }
                    
                }
                return next;
            }
        }

        void drawTriangle(Triangle t, Color c)
        {
            GL.Begin(BeginMode.Polygon);
                GL.Color3(c);
                GL.Vertex3(t.t0.X, t.t0.Y, t.t0.Z);
                GL.Vertex3(t.t1.X, t.t1.Y, t.t1.Z);
                GL.Vertex3(t.t2.X, t.t2.Y, t.t2.Z);
            GL.End();
        }
    }
}
