namespace Sphere3d
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rZ = new System.Windows.Forms.RadioButton();
            this.rY = new System.Windows.Forms.RadioButton();
            this.rX = new System.Windows.Forms.RadioButton();
            this.gbRotation = new System.Windows.Forms.GroupBox();
            this.btnrotate = new System.Windows.Forms.Button();
            this.tbangle = new System.Windows.Forms.TextBox();
            this.lbrotate = new System.Windows.Forms.Label();
            this.btnbuild = new System.Windows.Forms.Button();
            this.tbsize = new System.Windows.Forms.TextBox();
            this.gbCreate = new System.Windows.Forms.GroupBox();
            this.tbbasez = new System.Windows.Forms.TextBox();
            this.tbbasey = new System.Windows.Forms.TextBox();
            this.tbbasex = new System.Windows.Forms.TextBox();
            this.lbbasez = new System.Windows.Forms.Label();
            this.lbbasey = new System.Windows.Forms.Label();
            this.lbbasex = new System.Windows.Forms.Label();
            this.lbsize = new System.Windows.Forms.Label();
            this.gbMove = new System.Windows.Forms.GroupBox();
            this.btnmove = new System.Windows.Forms.Button();
            this.tbmovez = new System.Windows.Forms.TextBox();
            this.tbmovey = new System.Windows.Forms.TextBox();
            this.tbmovex = new System.Windows.Forms.TextBox();
            this.lbmovez = new System.Windows.Forms.Label();
            this.lbmovey = new System.Windows.Forms.Label();
            this.lbmovex = new System.Windows.Forms.Label();
            this.pnViews = new System.Windows.Forms.Panel();
            this.pbFront = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.btnquick = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrimitives = new System.Windows.Forms.TabPage();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.lbLod = new System.Windows.Forms.Label();
            this.trackBarLOD = new System.Windows.Forms.TrackBar();
            this.gbRotation.SuspendLayout();
            this.gbCreate.SuspendLayout();
            this.gbMove.SuspendLayout();
            this.pnViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPrimitives.SuspendLayout();
            this.tabEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLOD)).BeginInit();
            this.SuspendLayout();
            // 
            // rZ
            // 
            this.rZ.AutoSize = true;
            this.rZ.Location = new System.Drawing.Point(23, 119);
            this.rZ.Name = "rZ";
            this.rZ.Size = new System.Drawing.Size(32, 17);
            this.rZ.TabIndex = 2;
            this.rZ.Text = "Z";
            this.rZ.UseVisualStyleBackColor = true;
            // 
            // rY
            // 
            this.rY.AutoSize = true;
            this.rY.Location = new System.Drawing.Point(23, 95);
            this.rY.Name = "rY";
            this.rY.Size = new System.Drawing.Size(32, 17);
            this.rY.TabIndex = 1;
            this.rY.TabStop = true;
            this.rY.Text = "Y";
            this.rY.UseVisualStyleBackColor = true;
            // 
            // rX
            // 
            this.rX.AutoSize = true;
            this.rX.Checked = true;
            this.rX.Location = new System.Drawing.Point(23, 72);
            this.rX.Name = "rX";
            this.rX.Size = new System.Drawing.Size(32, 17);
            this.rX.TabIndex = 0;
            this.rX.TabStop = true;
            this.rX.Text = "X";
            this.rX.UseVisualStyleBackColor = true;
            // 
            // gbRotation
            // 
            this.gbRotation.Controls.Add(this.btnrotate);
            this.gbRotation.Controls.Add(this.tbangle);
            this.gbRotation.Controls.Add(this.lbrotate);
            this.gbRotation.Controls.Add(this.rZ);
            this.gbRotation.Controls.Add(this.rX);
            this.gbRotation.Controls.Add(this.rY);
            this.gbRotation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gbRotation.Location = new System.Drawing.Point(6, 6);
            this.gbRotation.Name = "gbRotation";
            this.gbRotation.Size = new System.Drawing.Size(180, 147);
            this.gbRotation.TabIndex = 6;
            this.gbRotation.TabStop = false;
            this.gbRotation.Text = "Rotation";
            // 
            // btnrotate
            // 
            this.btnrotate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnrotate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrotate.Location = new System.Drawing.Point(61, 71);
            this.btnrotate.Name = "btnrotate";
            this.btnrotate.Size = new System.Drawing.Size(100, 64);
            this.btnrotate.TabIndex = 9;
            this.btnrotate.Text = "Rotate";
            this.btnrotate.UseVisualStyleBackColor = false;
            this.btnrotate.Click += new System.EventHandler(this.btnrotate_Click);
            // 
            // tbangle
            // 
            this.tbangle.Location = new System.Drawing.Point(61, 27);
            this.tbangle.Name = "tbangle";
            this.tbangle.Size = new System.Drawing.Size(100, 20);
            this.tbangle.TabIndex = 8;
            this.tbangle.Text = "90";
            // 
            // lbrotate
            // 
            this.lbrotate.AutoSize = true;
            this.lbrotate.Location = new System.Drawing.Point(18, 30);
            this.lbrotate.Name = "lbrotate";
            this.lbrotate.Size = new System.Drawing.Size(37, 13);
            this.lbrotate.TabIndex = 7;
            this.lbrotate.Text = "Angle:";
            // 
            // btnbuild
            // 
            this.btnbuild.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnbuild.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnbuild.Location = new System.Drawing.Point(9, 120);
            this.btnbuild.Name = "btnbuild";
            this.btnbuild.Size = new System.Drawing.Size(152, 24);
            this.btnbuild.TabIndex = 7;
            this.btnbuild.Text = "Build";
            this.btnbuild.UseVisualStyleBackColor = false;
            this.btnbuild.Click += new System.EventHandler(this.btnbuild_Click);
            // 
            // tbsize
            // 
            this.tbsize.Location = new System.Drawing.Point(61, 94);
            this.tbsize.Name = "tbsize";
            this.tbsize.Size = new System.Drawing.Size(100, 20);
            this.tbsize.TabIndex = 8;
            this.tbsize.Text = "50";
            // 
            // gbCreate
            // 
            this.gbCreate.Controls.Add(this.tbbasez);
            this.gbCreate.Controls.Add(this.tbbasey);
            this.gbCreate.Controls.Add(this.tbbasex);
            this.gbCreate.Controls.Add(this.lbbasez);
            this.gbCreate.Controls.Add(this.lbbasey);
            this.gbCreate.Controls.Add(this.lbbasex);
            this.gbCreate.Controls.Add(this.lbsize);
            this.gbCreate.Controls.Add(this.tbsize);
            this.gbCreate.Controls.Add(this.btnbuild);
            this.gbCreate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gbCreate.Location = new System.Drawing.Point(6, 15);
            this.gbCreate.Name = "gbCreate";
            this.gbCreate.Size = new System.Drawing.Size(180, 157);
            this.gbCreate.TabIndex = 12;
            this.gbCreate.TabStop = false;
            this.gbCreate.Text = "Create";
            // 
            // tbbasez
            // 
            this.tbbasez.Location = new System.Drawing.Point(61, 68);
            this.tbbasez.Name = "tbbasez";
            this.tbbasez.Size = new System.Drawing.Size(100, 20);
            this.tbbasez.TabIndex = 13;
            this.tbbasez.Text = "0";
            // 
            // tbbasey
            // 
            this.tbbasey.Location = new System.Drawing.Point(61, 42);
            this.tbbasey.Name = "tbbasey";
            this.tbbasey.Size = new System.Drawing.Size(100, 20);
            this.tbbasey.TabIndex = 13;
            this.tbbasey.Text = "0";
            // 
            // tbbasex
            // 
            this.tbbasex.Location = new System.Drawing.Point(61, 16);
            this.tbbasex.Name = "tbbasex";
            this.tbbasex.Size = new System.Drawing.Size(100, 20);
            this.tbbasex.TabIndex = 13;
            this.tbbasex.Text = "0";
            // 
            // lbbasez
            // 
            this.lbbasez.AutoSize = true;
            this.lbbasez.Location = new System.Drawing.Point(18, 75);
            this.lbbasez.Name = "lbbasez";
            this.lbbasez.Size = new System.Drawing.Size(12, 13);
            this.lbbasez.TabIndex = 12;
            this.lbbasez.Text = "z";
            // 
            // lbbasey
            // 
            this.lbbasey.AutoSize = true;
            this.lbbasey.Location = new System.Drawing.Point(18, 49);
            this.lbbasey.Name = "lbbasey";
            this.lbbasey.Size = new System.Drawing.Size(12, 13);
            this.lbbasey.TabIndex = 11;
            this.lbbasey.Text = "y";
            // 
            // lbbasex
            // 
            this.lbbasex.AutoSize = true;
            this.lbbasex.Location = new System.Drawing.Point(18, 23);
            this.lbbasex.Name = "lbbasex";
            this.lbbasex.Size = new System.Drawing.Size(12, 13);
            this.lbbasex.TabIndex = 10;
            this.lbbasex.Text = "x";
            // 
            // lbsize
            // 
            this.lbsize.AutoSize = true;
            this.lbsize.Location = new System.Drawing.Point(12, 101);
            this.lbsize.Name = "lbsize";
            this.lbsize.Size = new System.Drawing.Size(43, 13);
            this.lbsize.TabIndex = 9;
            this.lbsize.Text = "Radius:";
            // 
            // gbMove
            // 
            this.gbMove.Controls.Add(this.btnmove);
            this.gbMove.Controls.Add(this.tbmovez);
            this.gbMove.Controls.Add(this.tbmovey);
            this.gbMove.Controls.Add(this.tbmovex);
            this.gbMove.Controls.Add(this.lbmovez);
            this.gbMove.Controls.Add(this.lbmovey);
            this.gbMove.Controls.Add(this.lbmovex);
            this.gbMove.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gbMove.Location = new System.Drawing.Point(7, 160);
            this.gbMove.Name = "gbMove";
            this.gbMove.Size = new System.Drawing.Size(179, 135);
            this.gbMove.TabIndex = 13;
            this.gbMove.TabStop = false;
            this.gbMove.Text = "Move";
            // 
            // btnmove
            // 
            this.btnmove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnmove.Location = new System.Drawing.Point(8, 97);
            this.btnmove.Name = "btnmove";
            this.btnmove.Size = new System.Drawing.Size(152, 23);
            this.btnmove.TabIndex = 14;
            this.btnmove.Text = "Move";
            this.btnmove.UseVisualStyleBackColor = false;
            this.btnmove.Click += new System.EventHandler(this.btnmove_Click);
            // 
            // tbmovez
            // 
            this.tbmovez.Location = new System.Drawing.Point(60, 71);
            this.tbmovez.Name = "tbmovez";
            this.tbmovez.Size = new System.Drawing.Size(100, 20);
            this.tbmovez.TabIndex = 17;
            this.tbmovez.Text = "0";
            // 
            // tbmovey
            // 
            this.tbmovey.Location = new System.Drawing.Point(60, 45);
            this.tbmovey.Name = "tbmovey";
            this.tbmovey.Size = new System.Drawing.Size(100, 20);
            this.tbmovey.TabIndex = 18;
            this.tbmovey.Text = "0";
            // 
            // tbmovex
            // 
            this.tbmovex.Location = new System.Drawing.Point(60, 19);
            this.tbmovex.Name = "tbmovex";
            this.tbmovex.Size = new System.Drawing.Size(100, 20);
            this.tbmovex.TabIndex = 19;
            this.tbmovex.Text = "0";
            // 
            // lbmovez
            // 
            this.lbmovez.AutoSize = true;
            this.lbmovez.Location = new System.Drawing.Point(17, 78);
            this.lbmovez.Name = "lbmovez";
            this.lbmovez.Size = new System.Drawing.Size(12, 13);
            this.lbmovez.TabIndex = 16;
            this.lbmovez.Text = "z";
            // 
            // lbmovey
            // 
            this.lbmovey.AutoSize = true;
            this.lbmovey.Location = new System.Drawing.Point(17, 52);
            this.lbmovey.Name = "lbmovey";
            this.lbmovey.Size = new System.Drawing.Size(12, 13);
            this.lbmovey.TabIndex = 15;
            this.lbmovey.Text = "y";
            // 
            // lbmovex
            // 
            this.lbmovex.AutoSize = true;
            this.lbmovex.Location = new System.Drawing.Point(17, 26);
            this.lbmovex.Name = "lbmovex";
            this.lbmovex.Size = new System.Drawing.Size(12, 13);
            this.lbmovex.TabIndex = 14;
            this.lbmovex.Text = "x";
            // 
            // pnViews
            // 
            this.pnViews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnViews.Controls.Add(this.pbFront);
            this.pnViews.Controls.Add(this.pbTop);
            this.pnViews.Controls.Add(this.pbMain);
            this.pnViews.Controls.Add(this.pbLeft);
            this.pnViews.Location = new System.Drawing.Point(12, 28);
            this.pnViews.Name = "pnViews";
            this.pnViews.Size = new System.Drawing.Size(518, 520);
            this.pnViews.TabIndex = 14;
            // 
            // pbFront
            // 
            this.pbFront.BackColor = System.Drawing.Color.DarkGray;
            this.pbFront.Image = ((System.Drawing.Image)(resources.GetObject("pbFront.Image")));
            this.pbFront.Location = new System.Drawing.Point(5, 5);
            this.pbFront.Name = "pbFront";
            this.pbFront.Size = new System.Drawing.Size(250, 250);
            this.pbFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFront.TabIndex = 9;
            this.pbFront.TabStop = false;
            this.pbFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbFront_MouseDown);
            this.pbFront.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbFront_MouseUp);
            // 
            // pbTop
            // 
            this.pbTop.BackColor = System.Drawing.Color.DarkGray;
            this.pbTop.Image = ((System.Drawing.Image)(resources.GetObject("pbTop.Image")));
            this.pbTop.Location = new System.Drawing.Point(5, 260);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(250, 250);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTop.TabIndex = 10;
            this.pbTop.TabStop = false;
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.DarkGray;
            this.pbMain.Location = new System.Drawing.Point(260, 260);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(250, 250);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMain.TabIndex = 2;
            this.pbMain.TabStop = false;
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.Color.DarkGray;
            this.pbLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbLeft.Image")));
            this.pbLeft.Location = new System.Drawing.Point(260, 5);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(250, 250);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLeft.TabIndex = 11;
            this.pbLeft.TabStop = false;
            // 
            // btnquick
            // 
            this.btnquick.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnquick.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnquick.Location = new System.Drawing.Point(6, 254);
            this.btnquick.Name = "btnquick";
            this.btnquick.Size = new System.Drawing.Size(75, 23);
            this.btnquick.TabIndex = 15;
            this.btnquick.Text = "Drag\'n\'Drop";
            this.btnquick.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrimitives);
            this.tabControl1.Controls.Add(this.tabEdit);
            this.tabControl1.Location = new System.Drawing.Point(536, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 500);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPrimitives
            // 
            this.tabPrimitives.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPrimitives.Controls.Add(this.trackBarLOD);
            this.tabPrimitives.Controls.Add(this.lbLod);
            this.tabPrimitives.Controls.Add(this.gbCreate);
            this.tabPrimitives.Controls.Add(this.btnquick);
            this.tabPrimitives.Location = new System.Drawing.Point(4, 22);
            this.tabPrimitives.Name = "tabPrimitives";
            this.tabPrimitives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimitives.Size = new System.Drawing.Size(192, 474);
            this.tabPrimitives.TabIndex = 0;
            this.tabPrimitives.Text = "Primitives";
            // 
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabEdit.Controls.Add(this.gbRotation);
            this.tabEdit.Controls.Add(this.gbMove);
            this.tabEdit.Location = new System.Drawing.Point(4, 22);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(192, 474);
            this.tabEdit.TabIndex = 1;
            this.tabEdit.Text = "Edit";
            // 
            // lbLod
            // 
            this.lbLod.AutoSize = true;
            this.lbLod.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbLod.Location = new System.Drawing.Point(24, 187);
            this.lbLod.Name = "lbLod";
            this.lbLod.Size = new System.Drawing.Size(29, 13);
            this.lbLod.TabIndex = 16;
            this.lbLod.Text = "LOD";
            // 
            // trackBarLOD
            // 
            this.trackBarLOD.Location = new System.Drawing.Point(67, 178);
            this.trackBarLOD.Minimum = 1;
            this.trackBarLOD.Name = "trackBarLOD";
            this.trackBarLOD.Size = new System.Drawing.Size(104, 45);
            this.trackBarLOD.TabIndex = 17;
            this.trackBarLOD.Value = 1;
            this.trackBarLOD.ValueChanged += new System.EventHandler(this.trackBarLOD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(761, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnViews);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbRotation.ResumeLayout(false);
            this.gbRotation.PerformLayout();
            this.gbCreate.ResumeLayout(false);
            this.gbCreate.PerformLayout();
            this.gbMove.ResumeLayout(false);
            this.gbMove.PerformLayout();
            this.pnViews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPrimitives.ResumeLayout(false);
            this.tabPrimitives.PerformLayout();
            this.tabEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLOD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.RadioButton rZ;
        private System.Windows.Forms.RadioButton rY;
        private System.Windows.Forms.RadioButton rX;
        private System.Windows.Forms.GroupBox gbRotation;
        private System.Windows.Forms.Button btnrotate;
        private System.Windows.Forms.TextBox tbangle;
        private System.Windows.Forms.Label lbrotate;
        private System.Windows.Forms.Button btnbuild;
        private System.Windows.Forms.TextBox tbsize;
        private System.Windows.Forms.PictureBox pbFront;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.GroupBox gbCreate;
        private System.Windows.Forms.Label lbsize;
        private System.Windows.Forms.TextBox tbbasez;
        private System.Windows.Forms.TextBox tbbasey;
        private System.Windows.Forms.TextBox tbbasex;
        private System.Windows.Forms.Label lbbasez;
        private System.Windows.Forms.Label lbbasey;
        private System.Windows.Forms.Label lbbasex;
        private System.Windows.Forms.GroupBox gbMove;
        private System.Windows.Forms.Button btnmove;
        private System.Windows.Forms.TextBox tbmovez;
        private System.Windows.Forms.TextBox tbmovey;
        private System.Windows.Forms.TextBox tbmovex;
        private System.Windows.Forms.Label lbmovez;
        private System.Windows.Forms.Label lbmovey;
        private System.Windows.Forms.Label lbmovex;
        private System.Windows.Forms.Panel pnViews;
        private System.Windows.Forms.Button btnquick;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrimitives;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TrackBar trackBarLOD;
        private System.Windows.Forms.Label lbLod;
    }
}

