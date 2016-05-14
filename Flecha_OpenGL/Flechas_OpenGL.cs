using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace Flechas_OpenGL
{
    public partial class Flechas_OpenGL : Form
    {
        int eyeX = 100;
        int eyeY = 100;
        int eyeZ = 100;
        List<Int32> GList;
        List<Line> lines = new List<Line>();
        bool loaded = false;

        public Flechas_OpenGL()
        {
            InitializeComponent();

            GList = new List<Int32>();
            GList.Add(0);
        }

        private void gl_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) 
                return;

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 perspective = OpenTK.Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver2, 1F, 0.1F, 20000F);

            GL.LoadMatrix(ref perspective);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Matrix4 lookat = Matrix4.LookAt(eyeX, eyeY, eyeZ, 0, 0, 0, 0, 1, 0);
            GL.LoadMatrix(ref lookat);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.PushMatrix();
            for (int i = 0; i < GList.Count; i++)
                GL.CallList(GList[i]);

            GL.PopMatrix();
            GL.Finish();
            gl.SwapBuffers();
        }

        private void tmrRedraw_Tick(object sender, EventArgs e)
        {
            GList = new List<Int32>();
            GList.Add(0);
            foreach (Line line in lines)
            {
                decimal[] from = FactoryMatrix.xVxM(line.matrix, line.from);
                decimal[] to = FactoryMatrix.xVxM(line.matrix, line.to);

                GL.NewList(GList.Count, ListMode.Compile);
                GL.Begin(BeginMode.Lines);

                GL.LineWidth(line.width);
                GL.Color3(line.color);
                GL.Vertex3(Decimal.ToDouble(from[0]), Decimal.ToDouble(from[1]), Decimal.ToDouble(from[2]));
                GL.Vertex3(Decimal.ToDouble(to[0]), Decimal.ToDouble(to[1]), Decimal.ToDouble(to[2]));

                GL.End();
                GL.EndList();
                GList.Add(GList.Count);

            }
            gl_Paint(gl, null);
        }

        private void gl_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.Black);

            generarFlechas();
            actualizarValor();
        }

        private void lineGenerator(float width, Color color, int x1, int y1, int z1, int x2, int y2, int z2)
        {
            Line temp = new Line();

            temp.from[0] = x1;
            temp.from[1] = y1;
            temp.from[2] = z1;
            temp.to[0] = x2;
            temp.to[1] = y2;
            temp.to[2] = z2;
            temp.color = color;
            temp.width = width;
            lines.Add(temp);
        }

        private void generarFlechas()
        {
            lineGenerator(1, Color.Yellow, -100, 0, 0, 100, 0, 0);
            lineGenerator(1, Color.Yellow, -100, 0, 0, -90, 0, 5);
            lineGenerator(1, Color.Yellow, -100, 0, 0, -90, 0, -5);
            lineGenerator(1, Color.Yellow, 100, 0, 0, 90, 0, 5);
            lineGenerator(1, Color.Yellow, 100, 0, 0, 90, 0, -5);

            lineGenerator(1, Color.Red, 0, -100, 0, 0, 100, 0);
            lineGenerator(1, Color.Red, 0, -100, 0, 5, -90, 0);
            lineGenerator(1, Color.Red, 0, -100, 0, -5, -90, 0);
            lineGenerator(1, Color.Red, 0, 100, 0, 5, 90, 0);
            lineGenerator(1, Color.Red, 0, 100, 0, -5, 90, 0);

            lineGenerator(1, Color.Blue, 0, 0, -100, 0, 0, 100);
            lineGenerator(1, Color.Blue, 0, 0, -100, 0, 5, -90);
            lineGenerator(1, Color.Blue, 0, 0, -100, 0, -5, -90);
            lineGenerator(1, Color.Blue, 0, 0, 100, 0, 5, 90);
            lineGenerator(1, Color.Blue, 0, 0, 100, 0, -5, 90);
        }

        private void btn_xIzq_Click(object sender, EventArgs e)
        {
            eyeX += 10;
            actualizarValor();
        }

        private void btn_xDer_Click(object sender, EventArgs e)
        {
            eyeX -= 10;
            actualizarValor();
        }

        private void btn_yIzq_Click(object sender, EventArgs e)
        {
            eyeY += 10;
            actualizarValor();
        }

        private void btn_yDer_Click(object sender, EventArgs e)
        {
            eyeY -= 10;
            actualizarValor();
        }

        private void btn_zIzq_Click(object sender, EventArgs e)
        {
            eyeZ += 10;
            actualizarValor();
        }

        private void btn_zDer_Click(object sender, EventArgs e)
        {
            eyeZ -= 10;
            actualizarValor();
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            eyeX = 100;
            eyeY = 100;
            eyeZ = 100;
            actualizarValor();
        }

        private void actualizarValor()
        {
            lbl_valorX.Text = eyeX.ToString();
            lbl_valorY.Text = eyeY.ToString();
            lbl_valorZ.Text = eyeZ.ToString();
        }

        private void btn_efecto1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeX -= 5;
                actualizarValor();
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }
        }

        private void btn_efecto2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeY -= 5;
                actualizarValor();
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }
        }

        private void btn_efecto3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeZ -= 5;
                actualizarValor();
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }
        }

        private void btn_efecto4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (eyeX > 0)
                    eyeX -= 5;
                else
                    eyeX += 5;

                if (eyeY > 0)
                    eyeY -= 5;
                else
                    eyeY += 5;

                if (eyeZ > 0)
                    eyeZ -= 5;
                else
                    eyeZ += 5;
                actualizarValor();
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }
        }

        private void btn_efecto5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (eyeX > 0)
                    eyeX += 5;
                else
                    eyeX -= 5;

                if (eyeY > 0)
                    eyeY += 5;
                else
                    eyeY -= 5;

                if (eyeZ > 0)
                    eyeZ += 5;
                else
                    eyeZ -= 5;
                actualizarValor();
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }
        }

        private void btn_efecto6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeX -= 10;
                eyeY -= 10;
                actualizarValor();
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }
        }

        private void btn_efecto7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeX -= 10;
                eyeZ -= 10;
                actualizarValor();
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }
        }

        private void btn_efecto8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeY -= 10;
                eyeZ -= 10;
                actualizarValor();
                System.Threading.Thread.Sleep(1);
                this.Refresh();
            }
        }

        private void btn_efecto9_Click(object sender, EventArgs e)
        {
            for (int i = -100; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    lineGenerator(1, Color.Yellow, -100, 0, i, 100, 0, i);
                    lineGenerator(1, Color.Yellow, i, 0, -100, i, 0, 100);
                }
            }
            btn_efecto9.Enabled = false;
        }

        private void btn_efecto10_Click(object sender, EventArgs e)
        {
            for (int i = -100; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    lineGenerator(1, Color.Red, i, -100, 0, i, 100, 0);
                    lineGenerator(1, Color.Red, -100, i, 0, 100, i, 0);
                }
            }
            btn_efecto10.Enabled = false;
        }

        private void btn_efecto11_Click(object sender, EventArgs e)
        {
            for (int i = -100; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    lineGenerator(1, Color.Blue, 0, i, -100, 0, i, 100);
                    lineGenerator(1, Color.Blue, 0, -100, i, 0, 100, i);
                }
            }
            btn_efecto11.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_AcercaDe from = new Form_AcercaDe();
            from.ShowDialog();
        }
    }
}