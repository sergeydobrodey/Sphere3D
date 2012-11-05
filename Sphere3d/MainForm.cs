using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Sphere3d
{
    public partial class mainForm : Form
    {
      
        #region global variables
        List<GraphicModel> ModelsTree = new List<GraphicModel>();     
        int size = 0;
        Point3d basepoint;
        float Lod = 0.2F;
        PointF delta = new PointF(0, 0);
        int VIEWPORT = 200;   // size of image
        Color ModelColor = Color.Red;
        byte MainViewType = 2;
        PointF rotdelta = new PointF(0, 0);


        
        #endregion
       
     

        public mainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        #region methods

        private void AddSphere()
        {            
            ModelsTree.Add(new GraphicModel(basepoint, size, Lod, ModelColor));                      
            HistoryBox.Items.Add("Object "+ModelsTree.Count);
            if (trackBarColorPicker.Value != trackBarColorPicker.Maximum)
                trackBarColorPicker.Value += 1;
            else trackBarColorPicker.Value = trackBarColorPicker.Minimum;
        }

        private void DrawSphere(bool update)
        {            
            Graphics gF = pbFront.CreateGraphics();
            Graphics gL = pbLeft.CreateGraphics();
            Graphics gT = pbTop.CreateGraphics();
            Graphics gM = pbMain.CreateGraphics();
            double viewparam1 = Convert.ToDouble(tbviewparam1.Text);
            double viewparam2 = Convert.ToDouble(tbviewparam2.Text);
            double viewparam3 = Convert.ToDouble(tbviewparam3.Text);
            double viewparam4 = Convert.ToDouble(tbviewparam4.Text);
            if (update)
            {
                Initialize();
                foreach (GraphicModel temp in ModelsTree)
                    temp.DrawModel(gF, gL, gT, gM, VIEWPORT, MainViewType, viewparam1, viewparam2,viewparam3,viewparam4);
             
            }
            else ModelsTree[ModelsTree.Count - 1].DrawModel(gF, gL, gT, gM, VIEWPORT, MainViewType, viewparam1, viewparam2, viewparam3, viewparam4); 
        }
       
        private void UpdateSphere(GraphicModel model)
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
            if (model!=null)
            {
                model.UpdateModel(movex, movey, movez, scalex, scaley, scalez, anglex, angley, anglez);
                DrawSphere(true);
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
            pbFront.Refresh();
            pbLeft.Refresh();
            pbTop.Refresh();
            pbMain.Refresh();
        }


        #endregion

        #region buttons handlers

        private void btnbuild_Click(object sender, EventArgs e)
        {                       
            size = Convert.ToInt32(tbsize.Text);             
            basepoint = new Point3d(Convert.ToDouble(tbbasex.Text), Convert.ToDouble(tbbasey.Text), Convert.ToDouble(tbbasez.Text));
            AddSphere();
            DrawSphere(false);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (HistoryBox.SelectedIndex != -1)
            {
                ModelsTree.RemoveAt(HistoryBox.SelectedIndex);
                HistoryBox.Items.RemoveAt(HistoryBox.SelectedIndex);
                if (ModelsTree.Count != 0)
                    UpdateSphere(ModelsTree[ModelsTree.Count - 1]);
                else Initialize();
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DrawSphere(true);
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            pbMain.Refresh();
            var gM = pbMain.CreateGraphics();
            double viewparam1 = Convert.ToDouble(tbviewparam1.Text);
            double viewparam2 = Convert.ToDouble(tbviewparam2.Text);
            double viewparam3 = Convert.ToDouble(tbviewparam3.Text);
            double viewparam4 = Convert.ToDouble(tbviewparam4.Text);
            ModelsTree[ModelsTree.Count - 1].Fill(gM, MainViewType, viewparam1, viewparam2, viewparam3, viewparam4,chkLight.Checked);
        }

        private void btnrotate_Click(object sender, EventArgs e)
        {
            if (ModelsTree.Count!=0)
            UpdateSphere(ModelsTree[ModelsTree.Count-1]);           
        }

        private void btnmove_Click(object sender, EventArgs e)
        {
            if (ModelsTree.Count != 0)
            UpdateSphere(ModelsTree[ModelsTree.Count - 1]);     
        }

        private void btnscale_Click(object sender, EventArgs e)
        {
            if (ModelsTree.Count != 0)
            UpdateSphere(ModelsTree[ModelsTree.Count - 1]);     
        }
        
        private void trackBarLOD_ValueChanged(object sender, EventArgs e)
        {
            Lod = (float)trackBarLOD.Value / 10;
            tabControlMain.Refresh();
        } 

        private void trackBarColorPicker_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBarColorPicker.Value)
            {
                case 0: ModelColor = Color.Red; break;
                case 1: ModelColor = Color.Yellow; break;
                case 2: ModelColor = Color.Green; break;
                case 3: ModelColor = Color.Blue; break;
                case 4: ModelColor = Color.White; break;
                case 5: ModelColor = Color.Indigo; break;
            }
        }

        private void rbtnView_CheckedChanged(object sender, EventArgs e)
        {           
                if (rbtnViewRect.Checked)
                {
                    lbviewparam3.Visible = false;
                    tbviewparam3.Visible = false;
                    lbviewparam4.Visible = false;
                    tbviewparam4.Visible = false;
                    lbviewparam1.Text = "fi angle:";
                    lbviewparam2.Text = "psi angle:";
                    MainViewType = 0;
                    
                }

                if (rbtnViewOblique.Checked)
                {
                    lbviewparam3.Visible = false;
                    tbviewparam3.Visible = false;
                    lbviewparam4.Visible = false;
                    tbviewparam4.Visible = false;
                    lbviewparam1.Text = "L:";
                    lbviewparam2.Text = "alpha angle:";
                    MainViewType = 1;                    
                }

                if (rbtnGeometricView.Checked)
                {
                    lbviewparam1.Text = "Distanse:";
                    lbviewparam2.Text = "q:";
                    lbviewparam3.Text = "fi anlge:";
                    lbviewparam4.Text = "psi angle:";
                    lbviewparam3.Visible = true;
                    tbviewparam3.Visible = true;
                    lbviewparam4.Visible = true;
                    tbviewparam4.Visible = true;
                    MainViewType = 2;
                }

            
            //UpdateSphere(ModelsTree[ModelsTree.Count-1]);     
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
                Point3d radpoint = new Point3d(e.X, e.Y, 0);
                size = Convert.ToInt32(Math.Sqrt((radpoint.x - basepoint.x) * (radpoint.x - basepoint.x) + (radpoint.y - basepoint.y) * (radpoint.y - basepoint.y)));
                basepoint.x -= VIEWPORT;
                basepoint.y -= VIEWPORT;
                AddSphere();
                DrawSphere(false);
            }
            if (e.Button == MouseButtons.Right)
            {
                float scrollangley = delta.X - e.X;   // need to fix
                float scrollanglex = delta.Y - e.Y;
                tbanglex.Text = Convert.ToString(scrollanglex);
                tbangley.Text = Convert.ToString(scrollangley);
                if (ModelsTree.Count != 0)
                UpdateSphere(ModelsTree[ModelsTree.Count - 1]);     
            }
            if (e.Button == MouseButtons.Middle)
            {

                float scrollzoom = delta.Y - e.Y;  // need to fix                
                scrollzoom=1+scrollzoom/70;
                tbScaleX.Text = Convert.ToString(scrollzoom);
                tbScaleY.Text = Convert.ToString(scrollzoom);
                tbScaleZ.Text = Convert.ToString(scrollzoom);
                if (ModelsTree.Count != 0)
                UpdateSphere(ModelsTree[ModelsTree.Count - 1]);   
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
                pnlGlobalView.Height = 260;
                btnPanelGlobalView.Text = "-                  GlobalView";
            }


        }
       

        private void btnPanelColorPicker_Click(object sender, EventArgs e)
        {
            if (pnlColorPicker.Height != 30)
            {
                pnlColorPicker.Height = 30;
                btnPanelColorPicker.Text = "+                     Color";
            }
            else
            {
                pnlColorPicker.Height = 100;
                btnPanelColorPicker.Text = "-                     Color";
            }
        }
        #endregion

       

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked)
            {
                pbMain.Refresh();
                var gM = pbMain.CreateGraphics();
                double viewparam1 = Convert.ToDouble(tbviewparam1.Text) + e.Delta;
                double viewparam2 = Convert.ToDouble(tbviewparam2.Text);
                double viewparam3 = Convert.ToDouble(tbviewparam3.Text) + e.Y - rotdelta.Y;
                double viewparam4 = Convert.ToDouble(tbviewparam4.Text) + e.X - rotdelta.X;
                rotdelta.X = e.X;
                rotdelta.Y = e.Y;
                tbviewparam3.Text = Convert.ToString(viewparam3);
                tbviewparam4.Text = Convert.ToString(viewparam4);
                ModelsTree[ModelsTree.Count - 1].DrawModelFast(gM, VIEWPORT, MainViewType, viewparam1, viewparam2, viewparam3, viewparam4);

            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBox1.Checked)
            {
                pbMain.Refresh();
                var gM = pbMain.CreateGraphics();
              
                double viewparam1 = Convert.ToDouble(tbviewparam1.Text) ;
                double viewparam2 = Convert.ToDouble(tbviewparam2.Text);
                double viewparam3 = Convert.ToDouble(tbviewparam3.Text);
                double viewparam4 = Convert.ToDouble(tbviewparam4.Text);
                
                switch ( e.KeyData)
                {
                    case Keys.W:
                        viewparam1 += 5;
                        break;
                    case Keys.S:
                        viewparam1 -= 5;
                        break;
                }
                tbviewparam1.Text = Convert.ToString(viewparam1);
              
                ModelsTree[ModelsTree.Count - 1].DrawModelFast(gM, VIEWPORT, MainViewType, viewparam1, viewparam2, viewparam3, viewparam4);

            }
        }
       
        

        

       
       
    }
}

