using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace CliMate
{
    class GridDisplayEquiRect
    {
        //const float PHI = 3.236067f/2.0f;
        class Triangle
        {

            public Vector3 t0, t1, t2;
            Triangle left, right, top;
            public Triangle(Vector3 t0, Vector3 t1, Vector3 t2)
            {
                this.t0 = t0;
                this.t1 = t1;
                this.t2 = t2;
                top = null;
                left = null;
                right = null;
            }
            public void setRight(Triangle t)
            {
                this.right = t;
            }
            public void setLeft(Triangle t)
            {
                this.left = t;
            }
            public void setTop(Triangle t)
            {
                this.top = t;
            }
            public Vector3 mid()
            {
                return Vector3.BaryCentric(t0,t1,t2,.5f,.5f);
            }

        };

        public GridDisplayEquiRect(int numSubs)
        {
            Triangle[] ico = new Triangle[20];
            for(int i = 0; i < 5; i++)
            {
                //Each iteration of this loop will produce a 3d coordinates for 4 triangles in the parallelogram strip (did this so it'd play nice with the data representation)
                Vector3 t0;
                Vector3 t1;
                Vector3 t2;

                t0 = new Vector3((float)Math.Cos((2 * i * Math.PI) / 5), (float)Math.Sin((2 * i * Math.PI) / 5), 1.0f);
                t1 = new Vector3((float)Math.Cos(((2 * i + 2) * Math.PI) / 5), (float)Math.Sin(((2 * i + 2) * Math.PI) / 5), 1.0f);
                t2 = new Vector3(0.0f, 0.0f, 1.0f);
                ico[4 * i] = new Triangle(t0,t1,t2);

                t0 = new Vector3((float) Math.Cos((2 * i * Math.PI)/5), (float)Math.Cos((2 * i * Math.PI) / 5), 0.5f);
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


        }

        //Like lerping, but on a sphere!
        private Vector3 slerp(Vector3 p0, Vector3 p1, float t)
        {
            //So check the wikipedia article on slerping
            Vector3 temp0 = new Vector3(p0.X, p0.Y, p0.Z);
            Vector3 temp1 = new Vector3(p1.X, p1.Y, p1.Z);
            float omega = (float) Math.Acos(Vector3.Dot(temp0,temp1));
            float scale0 = (float)(Math.Sin((1.0f - t) * omega) / Math.Sin(omega));
            float scale1 = (float)(Math.Sin(t * omega) / Math.Sin(omega));
            p0 = Vector3.Multiply(temp0, scale0);
            p1 = Vector3.Multiply(temp1, scale1);
            Vector3 res = Vector3.Add(temp0, temp1);
            return res;
        }

        

    }
}
