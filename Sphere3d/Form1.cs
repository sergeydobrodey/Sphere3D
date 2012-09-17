using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Sphere3d
{
    public partial class mainForm : Form
    {        

        

        #region global variables
        List<Point3d> sh = new List<Point3d>();  
        List<double[,]> matrix = new List<double[,]>();
        int size = 0;
        Point3d basepoint;
        float Lod = 0.2F;
        PointF delta = new PointF(0, 0);    
        int W = 1;
        #endregion

        #region Matrix
        public void Rotate(double anglex,double angley,double anglez)
        {  
            double Cx = Math.Cos(anglex);
            double Sx = Math.Sin(anglex);
            double Cy = Math.Cos(angley);
            double Sy = Math.Sin(angley);
            double Cz = Math.Cos(anglez);
            double Sz = Math.Sin(anglez);
            double[,] rotateX = { { 1, 0, 0, 0 }, { 0, Cx, Sx, 0 }, { 0, -Sx, Cx, 0 }, { 0, 0, 0, 1 } };
            double[,] rotateY = { { Cy, 0, Sy, 0 }, { 0, 1, 0, 0 }, { -Sy, 0, Cy, 0 }, { 0, 0, 0, 1 } };
            double[,] rotateZ = { { Cz, Sz, 0, 0 }, { -Sz, Cz, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            matrix.Add(rotateX);
            matrix.Add(rotateY);
            matrix.Add(rotateZ);
        }

        public void Move(double movex, double movey, double movez)
        {
            double[,] move = { { 1, 0, 0, movex }, { 0, 1, 0, movey }, { 0, 0,1, movez }, { 0, 0, 0, 1 } };
            matrix.Add(move);
        }

        public void Scale(double scalex, double scaley, double scalez)
        {
            double[,] scale = { { scalex, 0, 0, 0 }, { 0, scaley, 0, 0 }, { 0, 0, scalez, 0 }, { 0, 0, 0, 1 } };
            matrix.Add(scale);
            
        }
        #endregion

        #region  Mathematics 
        public void GetSphere(Point3d basepoint,int R)
        {
         
            sh.Clear();           
            double x, y, z, fi, psi;
            for (fi = 0; fi < Math.PI; fi += Lod)
                for (psi = 0; psi < 2 * Math.PI; psi += Lod)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    sh.Add(new Point3d((int)x, (int)y, (int)z));                   
                }
            for (psi = 0; psi < Math.PI; psi +=  Lod)
                for (fi = 0; fi < 2 * Math.PI; fi += Lod)
                {
                    x = basepoint.x + R * Math.Sin(psi) * Math.Cos(fi);
                    y = basepoint.y + R * Math.Sin(psi) * Math.Sin(fi);
                    z = basepoint.z + R * Math.Cos(psi);
                    sh.Add(new Point3d((int)x, (int)y, (int)z));                     
                }            
        }
       
        public void Draw2D(Graphics g, Point3d pt1, Point3d pt2)
        {
            Pen pen = new Pen(Color.Black, 1);
            if (rbtnViewRect.Checked)        
                g.DrawLine(pen, new PointF((float)(pt1.x / Math.Cos(Math.PI / 6) - pt1.z * Math.Cos(Math.PI / 6) + pbFront.Width / 2), (float)(-pt1.y + pt1.z * Math.Sin(Math.PI / 6) + pt1.x * Math.Sin(Math.PI / 6) + pbFront.Width / 2)), new PointF((float)(pt2.x / Math.Cos(Math.PI / 6) - pt2.z * Math.Cos(Math.PI / 6) + pbFront.Width / 2), (float)(-pt2.y + pt2.z * Math.Sin(Math.PI / 6) + pt2.x * Math.Sin(Math.PI / 6) + pbFront.Width / 2)));
            else
                g.DrawLine(pen, new PointF(pt1.x - pt1.z / 2 + pbFront.Width / 2, -pt1.y + pt1.z / 2 + pbFront.Width / 2), new PointF(pt2.x - pt2.z / 2 + pbFront.Width / 2, -pt2.y + pt2.z / 2 + pbFront.Width / 2));
        }

        public Point3d MultiplicateF(Point3d vertex, double[,] ar)
        {
            double[,] result= new double[4,1];
            double[,] a = ar;
            double[,] b = new double[4, 1];
            b[0, 0] = vertex.x;
            b[1, 0] = vertex.y;
            b[2, 0] = vertex.z;
            b[3, 0] = W;
            
            
            for (int i = 0; i < 4; i++)   
               for (int j = 0; j < 1; j++)
               {
                   result[i, j] = 0;
                   for (int r = 0; r < 4; r++)
                       result[i, j] += a[i, r] * b[r, j];
               }   
            
            vertex.x = (float)(result[0,0]);
            vertex.y = (float)(result[1, 0]);
            vertex.z = (float)(result[2, 0]);
            
            return vertex;

        }

        public double[,] MultiplicateM(double[,] a, double[,] b)
        {
            double[,] result = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    result[i, j] = 0;
                    for (int r = 0; r < 4; r++)
                        result[i, j] += a[i, r] * b[r, j];
                }   
            return result;
        }

        public double[,] MatrixReady() 
        {           

            double movex = Convert.ToDouble(tbmovex.Text);
            double movey = Convert.ToDouble(tbmovey.Text);
            double movez = Convert.ToDouble(tbmovez.Text);
            Move(movex, movey, movez);

            try
            {
                double scalex = Convert.ToDouble(tbScaleX.Text);
                double scaley = Convert.ToDouble(tbScaleY.Text);
                double scalez = Convert.ToDouble(tbScaleZ.Text);
                Scale(scalex, scaley, scalez);
            }
            catch (FormatException)
            {
                MessageBox.Show("Use decimal comma", "Something wrong");
            }
           

            double anglex = Convert.ToDouble(tbanglex.Text) * Math.PI / 180; ;
            double angley = Convert.ToDouble(tbangley.Text) * Math.PI / 180; ;
            double anglez = Convert.ToDouble(tbanglez.Text) * Math.PI / 180; ;
            Rotate(anglex, angley, anglez);

            double[,] result = new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
            for (int i = 0; i < matrix.Count; i++)
                result = MultiplicateM(result, matrix[i]);     
            return result;
        }

        #endregion


        public mainForm()
        {
            InitializeComponent();  
        }

        #region Draw
        private void DrawSphere()
        {
            Graphics gF = pbFront.CreateGraphics();
            Graphics gL = pbLeft.CreateGraphics();
            Graphics gT = pbTop.CreateGraphics();
            Graphics gM = pbMain.CreateGraphics();
            Pen pen = new Pen(Color.Blue, 1);

            int i = 0;

            for (i = 0; i < sh.Count-1; i++)
            {
                gF.DrawLine(pen, sh[i].x + pbFront.Width/2, sh[i].y + pbFront.Width/2, sh[i + 1].x + pbFront.Width/2, sh[i + 1].y + pbFront.Width/2);
                gL.DrawLine(pen, sh[i].x + pbFront.Width/2, sh[i].z + pbFront.Width/2, sh[i + 1].x + pbFront.Width/2, sh[i + 1].z + pbFront.Width/2);
                gT.DrawLine(pen, sh[i].y + pbFront.Width/2, sh[i].z + pbFront.Width/2, sh[i + 1].y + pbFront.Width/2, sh[i + 1].z + pbFront.Width/2);
                Draw2D(gM, sh[i], sh[i + 1]);
            }
            
        }

        private void Initialize()
        {
            pbFront.Image = Properties.Resources.viewport;
            pbLeft.Image = Properties.Resources.viewport;
            pbTop.Image = Properties.Resources.viewport;
            pbMain.Image = null;
            pbFront.Refresh();
            pbLeft.Refresh();
            pbTop.Refresh();
            pbMain.Refresh();
        }
        #endregion

        #region buttons handlers

        private void btnbuild_Click(object sender, EventArgs e)
        {
            Initialize();
            
            size = Convert.ToInt32(tbsize.Text);
            basepoint = new Point3d(Convert.ToDouble(tbbasex.Text), Convert.ToDouble(tbbasey.Text), Convert.ToDouble(tbbasez.Text));
            GetSphere(basepoint,size);
            DrawSphere();
        }

        private void btnrotate_Click(object sender, EventArgs e)
        {            
                Initialize();
                double[,] matrixACT = MatrixReady();
                matrix.Clear();
                for (int i = 0; i < sh.Count; i++)
                {
                    sh[i] = MultiplicateF(sh[i], matrixACT);
                }
                DrawSphere();
                tbanglex.Text = "0";
                tbangley.Text = "0";
                tbanglez.Text = "0";
                tbmovex.Text = "0";
                tbmovey.Text = "0";
                tbmovez.Text = "0";
                tbScaleX.Text = "1";
                tbScaleY.Text = "1";
                tbScaleZ.Text = "1";

           
        }


        private void btnmove_Click(object sender, EventArgs e)
        {
            btnrotate_Click(this, null);    // call btnrotate_Click 
        }

        private void btnscale_Click(object sender, EventArgs e)
        {
            btnrotate_Click(this, null);    // call btnrotate_Click 
        }

        private void trackBarLOD_ValueChanged(object sender, EventArgs e)
        {
            Lod = (float)trackBarLOD.Value / 10;
            tabControlMain.Refresh();
        }

        private void rbtnViewOblique_CheckedChanged(object sender, EventArgs e)
        {
            btnrotate_Click(this, null); // call btnrotate_Click 
        }
        #endregion


        #region PaintOnFrontView
        private void pbFront_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            basepoint = new Point3d(e.X, e.Y, 0);
            if (e.Button == MouseButtons.Right)
                delta = e.Location;
            if (e.Button == MouseButtons.Middle)
                delta = e.Location;

        }

        private void pbFront_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Initialize();
                Point3d radpoint = new Point3d(e.X, e.Y, 0);
                size = Convert.ToInt32(Math.Sqrt((radpoint.x - basepoint.x) * (radpoint.x - basepoint.x) + (radpoint.y - basepoint.y) * (radpoint.y - basepoint.y)));
                basepoint.x -= pbFront.Width / 2;
                basepoint.y -= pbFront.Width / 2;
                GetSphere(basepoint, size);
                DrawSphere();
            }
            if (e.Button == MouseButtons.Right)
            {
                float scrollangley = delta.X - e.X;   // need to fix
                float scrollanglex = delta.Y - e.Y;
                tbanglex.Text = Convert.ToString(scrollanglex);
                tbangley.Text = Convert.ToString(scrollangley);
                btnrotate_Click(this, null); 
            }
            if (e.Button == MouseButtons.Middle)
            {

                float scrollzoom = delta.Y - e.Y;  // need to fix                
                scrollzoom=1+scrollzoom/70;
                tbScaleX.Text = Convert.ToString(scrollzoom);
                tbScaleY.Text = Convert.ToString(scrollzoom);
                tbScaleZ.Text = Convert.ToString(scrollzoom);
                btnrotate_Click(this, null);

            }

        }
        #endregion       
       

        #region DropDownPanels
        private void btnPanelCreate_Click(object sender, EventArgs e)
        {

            if (pnlCreate.Height != 30)
            {
                pnlCreate.Height = 30;
                btnPanelCreate.Text = "+                    Create";
            }
            else
            {
                pnlCreate.Height = 170;
                btnPanelCreate.Text = "-                    Create";
            }
        }

        private void btnPanelRotate_Click(object sender, EventArgs e)
        {
            if (pnlRotate.Height != 30)
            {
                pnlRotate.Height = 30;
                btnPanelRotate.Text = "+                    Rotate";
            }
            else
            {
                pnlRotate.Height = 140;
                btnPanelRotate.Text = "-                    Rotate";
            }
        }

        private void btnPanelMove_Click(object sender, EventArgs e)
        {
            if (pnlMove.Height != 30)
            {
                pnlMove.Height = 30;
                btnPanelMove.Text = "+                    Move";
            }
            else
            {
                pnlMove.Height = 140;
                btnPanelMove.Text = "-                    Move";
            }
        }

        private void btnPanelScale_Click(object sender, EventArgs e)
        {
            if (pnlScale.Height != 30)
            {
                pnlScale.Height = 30;
                btnPanelScale.Text = "+                    Scale";
            }
            else
            {
                pnlScale.Height = 140;
                btnPanelScale.Text = "-                    Scale";
            }
        }

      

        private void btnPanelGlobalView_Click(object sender, EventArgs e)
        {
             if (pnlGlobalView.Height != 30)
            {
                pnlGlobalView.Height = 30;
                btnPanelGlobalView.Text = "+                  GlobalView";
            }
            else
            {
                pnlGlobalView.Height = 170;
                btnPanelGlobalView.Text = "-                  GlobalView";
            }


        }
        #endregion
    }
}

