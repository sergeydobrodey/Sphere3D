using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Sphere3d
{
    public partial class mainForm : Form
    {


      
        #region global variables

        GraphicModel item;       
        int size = 0;
        Point3d basepoint;
        float Lod = 0.2F;
        PointF delta = new PointF(0, 0);
        int VIEWPORT = 200;   // size of image
     
        #endregion
            


        public mainForm()
        {
            InitializeComponent();  
        }

        #region methods
        private void DrawSphere()
        {
            Graphics gF = pbFront.CreateGraphics();
            Graphics gL = pbLeft.CreateGraphics();
            Graphics gT = pbTop.CreateGraphics();
            Graphics gM = pbMain.CreateGraphics();
            item.DrawModel(gF, gL, gT, gM, VIEWPORT, rbtnViewRect.Checked);
            
        }

        private void UpdateSphere()
        {
            Initialize();
            double movex = Convert.ToDouble(tbmovex.Text);
            double movey = Convert.ToDouble(tbmovey.Text);
            double movez = Convert.ToDouble(tbmovez.Text);
            double scalex = Convert.ToDouble(tbScaleX.Text);
            double scaley = Convert.ToDouble(tbScaleY.Text);
            double scalez = Convert.ToDouble(tbScaleZ.Text);
            double anglex = Convert.ToDouble(tbanglex.Text);
            double angley = Convert.ToDouble(tbangley.Text);
            double anglez = Convert.ToDouble(tbanglez.Text);
            if (item!=null)
            {
                item.UpdateModel(movex, movey, movez, scalex, scaley, scalez, anglex, angley, anglez);
                DrawSphere();
            }
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
            item = new GraphicModel(basepoint, size, Lod);   
            DrawSphere();
        }

        private void btnrotate_Click(object sender, EventArgs e)
        {
            UpdateSphere();           
        }

        private void btnmove_Click(object sender, EventArgs e)
        {
            UpdateSphere();     
        }

        private void btnscale_Click(object sender, EventArgs e)
        {
            UpdateSphere();     
        }

        private void trackBarLOD_ValueChanged(object sender, EventArgs e)
        {
            Lod = (float)trackBarLOD.Value / 10;
            tabControlMain.Refresh();
        }

        private void rbtnViewOblique_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSphere();     
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
                basepoint.x -= VIEWPORT;
                basepoint.y -= VIEWPORT;
                item = new GraphicModel(basepoint, size, Lod);               
                DrawSphere();
            }
            if (e.Button == MouseButtons.Right)
            {
                float scrollangley = delta.X - e.X;   // need to fix
                float scrollanglex = delta.Y - e.Y;
                tbanglex.Text = Convert.ToString(scrollanglex);
                tbangley.Text = Convert.ToString(scrollangley);
                UpdateSphere();     
            }
            if (e.Button == MouseButtons.Middle)
            {

                float scrollzoom = delta.Y - e.Y;  // need to fix                
                scrollzoom=1+scrollzoom/70;
                tbScaleX.Text = Convert.ToString(scrollzoom);
                tbScaleY.Text = Convert.ToString(scrollzoom);
                tbScaleZ.Text = Convert.ToString(scrollzoom);
                UpdateSphere();   
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

