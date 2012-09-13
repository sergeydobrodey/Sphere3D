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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbRotation = new System.Windows.Forms.GroupBox();
            this.btnrotate = new System.Windows.Forms.Button();
            this.tbanglez = new System.Windows.Forms.TextBox();
            this.tbangley = new System.Windows.Forms.TextBox();
            this.tbanglex = new System.Windows.Forms.TextBox();
            this.lbanglez = new System.Windows.Forms.Label();
            this.lbanglex = new System.Windows.Forms.Label();
            this.lbangley = new System.Windows.Forms.Label();
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPrimitives = new System.Windows.Forms.TabPage();
            this.trackBarLOD = new System.Windows.Forms.TrackBar();
            this.lbLod = new System.Windows.Forms.Label();
            this.tabEdit = new System.Windows.Forms.TabPage();
            this.gbScale = new System.Windows.Forms.GroupBox();
            this.btnscale = new System.Windows.Forms.Button();
            this.lbscalez = new System.Windows.Forms.Label();
            this.tbScaleZ = new System.Windows.Forms.TextBox();
            this.lbscaley = new System.Windows.Forms.Label();
            this.tbScaleY = new System.Windows.Forms.TextBox();
            this.tbScaleX = new System.Windows.Forms.TextBox();
            this.lbscalex = new System.Windows.Forms.Label();
            this.imgListTabMain = new System.Windows.Forms.ImageList(this.components);
            this.gbRotation.SuspendLayout();
            this.gbCreate.SuspendLayout();
            this.gbMove.SuspendLayout();
            this.pnViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPrimitives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLOD)).BeginInit();
            this.tabEdit.SuspendLayout();
            this.gbScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRotation
            // 
            this.gbRotation.Controls.Add(this.btnrotate);
            this.gbRotation.Controls.Add(this.tbanglez);
            this.gbRotation.Controls.Add(this.tbangley);
            this.gbRotation.Controls.Add(this.tbanglex);
            this.gbRotation.Controls.Add(this.lbanglez);
            this.gbRotation.Controls.Add(this.lbanglex);
            this.gbRotation.Controls.Add(this.lbangley);
            this.gbRotation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gbRotation.Location = new System.Drawing.Point(6, 6);
            this.gbRotation.Name = "gbRotation";
            this.gbRotation.Size = new System.Drawing.Size(180, 135);
            this.gbRotation.TabIndex = 6;
            this.gbRotation.TabStop = false;
            this.gbRotation.Text = "Rotation";
            // 
            // btnrotate
            // 
            this.btnrotate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnrotate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrotate.Location = new System.Drawing.Point(8, 94);
            this.btnrotate.Name = "btnrotate";
            this.btnrotate.Size = new System.Drawing.Size(152, 28);
            this.btnrotate.TabIndex = 9;
            this.btnrotate.Text = "Rotate";
            this.btnrotate.UseVisualStyleBackColor = false;
            this.btnrotate.Click += new System.EventHandler(this.btnrotate_Click);
            // 
            // tbanglez
            // 
            this.tbanglez.Location = new System.Drawing.Point(60, 68);
            this.tbanglez.Name = "tbanglez";
            this.tbanglez.Size = new System.Drawing.Size(100, 20);
            this.tbanglez.TabIndex = 17;
            this.tbanglez.Text = "0";
            // 
            // tbangley
            // 
            this.tbangley.Location = new System.Drawing.Point(60, 42);
            this.tbangley.Name = "tbangley";
            this.tbangley.Size = new System.Drawing.Size(100, 20);
            this.tbangley.TabIndex = 18;
            this.tbangley.Text = "0";
            // 
            // tbanglex
            // 
            this.tbanglex.Location = new System.Drawing.Point(60, 16);
            this.tbanglex.Name = "tbanglex";
            this.tbanglex.Size = new System.Drawing.Size(100, 20);
            this.tbanglex.TabIndex = 19;
            this.tbanglex.Text = "0";
            // 
            // lbanglez
            // 
            this.lbanglez.AutoSize = true;
            this.lbanglez.Location = new System.Drawing.Point(39, 75);
            this.lbanglez.Name = "lbanglez";
            this.lbanglez.Size = new System.Drawing.Size(15, 13);
            this.lbanglez.TabIndex = 16;
            this.lbanglez.Text = "z:";
            // 
            // lbanglex
            // 
            this.lbanglex.AutoSize = true;
            this.lbanglex.Location = new System.Drawing.Point(39, 23);
            this.lbanglex.Name = "lbanglex";
            this.lbanglex.Size = new System.Drawing.Size(15, 13);
            this.lbanglex.TabIndex = 14;
            this.lbanglex.Text = "x:";
            // 
            // lbangley
            // 
            this.lbangley.AutoSize = true;
            this.lbangley.Location = new System.Drawing.Point(39, 49);
            this.lbangley.Name = "lbangley";
            this.lbangley.Size = new System.Drawing.Size(15, 13);
            this.lbangley.TabIndex = 15;
            this.lbangley.Text = "y:";
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
            this.gbMove.Location = new System.Drawing.Point(6, 147);
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
            this.lbmovez.Location = new System.Drawing.Point(39, 78);
            this.lbmovez.Name = "lbmovez";
            this.lbmovez.Size = new System.Drawing.Size(15, 13);
            this.lbmovez.TabIndex = 16;
            this.lbmovez.Text = "z:";
            // 
            // lbmovey
            // 
            this.lbmovey.AutoSize = true;
            this.lbmovey.Location = new System.Drawing.Point(39, 52);
            this.lbmovey.Name = "lbmovey";
            this.lbmovey.Size = new System.Drawing.Size(15, 13);
            this.lbmovey.TabIndex = 15;
            this.lbmovey.Text = "y:";
            // 
            // lbmovex
            // 
            this.lbmovex.AutoSize = true;
            this.lbmovex.Location = new System.Drawing.Point(39, 26);
            this.lbmovex.Name = "lbmovex";
            this.lbmovex.Size = new System.Drawing.Size(15, 13);
            this.lbmovex.TabIndex = 14;
            this.lbmovex.Text = "x:";
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
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPrimitives);
            this.tabControlMain.Controls.Add(this.tabEdit);
            this.tabControlMain.ImageList = this.imgListTabMain;
            this.tabControlMain.ItemSize = new System.Drawing.Size(16, 16);
            this.tabControlMain.Location = new System.Drawing.Point(536, 35);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(200, 500);
            this.tabControlMain.TabIndex = 16;
            // 
            // tabPrimitives
            // 
            this.tabPrimitives.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPrimitives.Controls.Add(this.trackBarLOD);
            this.tabPrimitives.Controls.Add(this.lbLod);
            this.tabPrimitives.Controls.Add(this.gbCreate);
            this.tabPrimitives.ImageIndex = 0;
            this.tabPrimitives.Location = new System.Drawing.Point(4, 20);
            this.tabPrimitives.Name = "tabPrimitives";
            this.tabPrimitives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimitives.Size = new System.Drawing.Size(192, 476);
            this.tabPrimitives.TabIndex = 0;
            // 
            // trackBarLOD
            // 
            this.trackBarLOD.Location = new System.Drawing.Point(67, 178);
            this.trackBarLOD.Minimum = 1;
            this.trackBarLOD.Name = "trackBarLOD";
            this.trackBarLOD.Size = new System.Drawing.Size(104, 42);
            this.trackBarLOD.TabIndex = 17;
            this.trackBarLOD.Value = 1;
            this.trackBarLOD.ValueChanged += new System.EventHandler(this.trackBarLOD_ValueChanged);
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
            // tabEdit
            // 
            this.tabEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabEdit.Controls.Add(this.gbScale);
            this.tabEdit.Controls.Add(this.gbRotation);
            this.tabEdit.Controls.Add(this.gbMove);
            this.tabEdit.ImageIndex = 1;
            this.tabEdit.Location = new System.Drawing.Point(4, 20);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabEdit.Size = new System.Drawing.Size(192, 476);
            this.tabEdit.TabIndex = 1;
            // 
            // gbScale
            // 
            this.gbScale.Controls.Add(this.btnscale);
            this.gbScale.Controls.Add(this.lbscalez);
            this.gbScale.Controls.Add(this.tbScaleZ);
            this.gbScale.Controls.Add(this.lbscaley);
            this.gbScale.Controls.Add(this.tbScaleY);
            this.gbScale.Controls.Add(this.tbScaleX);
            this.gbScale.Controls.Add(this.lbscalex);
            this.gbScale.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gbScale.Location = new System.Drawing.Point(6, 288);
            this.gbScale.Name = "gbScale";
            this.gbScale.Size = new System.Drawing.Size(179, 130);
            this.gbScale.TabIndex = 14;
            this.gbScale.TabStop = false;
            this.gbScale.Text = "Scale";
            // 
            // btnscale
            // 
            this.btnscale.Location = new System.Drawing.Point(6, 100);
            this.btnscale.Name = "btnscale";
            this.btnscale.Size = new System.Drawing.Size(154, 23);
            this.btnscale.TabIndex = 20;
            this.btnscale.Text = "Scale";
            this.btnscale.UseVisualStyleBackColor = true;
            this.btnscale.Click += new System.EventHandler(this.btnscale_Click);
            // 
            // lbscalez
            // 
            this.lbscalez.AutoSize = true;
            this.lbscalez.Location = new System.Drawing.Point(39, 81);
            this.lbscalez.Name = "lbscalez";
            this.lbscalez.Size = new System.Drawing.Size(15, 13);
            this.lbscalez.TabIndex = 2;
            this.lbscalez.Text = "z:";
            // 
            // tbScaleZ
            // 
            this.tbScaleZ.Location = new System.Drawing.Point(60, 74);
            this.tbScaleZ.Name = "tbScaleZ";
            this.tbScaleZ.Size = new System.Drawing.Size(100, 20);
            this.tbScaleZ.TabIndex = 17;
            this.tbScaleZ.Text = "1";
            // 
            // lbscaley
            // 
            this.lbscaley.AutoSize = true;
            this.lbscaley.Location = new System.Drawing.Point(39, 55);
            this.lbscaley.Name = "lbscaley";
            this.lbscaley.Size = new System.Drawing.Size(15, 13);
            this.lbscaley.TabIndex = 1;
            this.lbscaley.Text = "y:";
            // 
            // tbScaleY
            // 
            this.tbScaleY.Location = new System.Drawing.Point(60, 48);
            this.tbScaleY.Name = "tbScaleY";
            this.tbScaleY.Size = new System.Drawing.Size(100, 20);
            this.tbScaleY.TabIndex = 18;
            this.tbScaleY.Text = "1";
            // 
            // tbScaleX
            // 
            this.tbScaleX.Location = new System.Drawing.Point(60, 22);
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(100, 20);
            this.tbScaleX.TabIndex = 19;
            this.tbScaleX.Text = "1";
            // 
            // lbscalex
            // 
            this.lbscalex.AutoSize = true;
            this.lbscalex.Location = new System.Drawing.Point(39, 29);
            this.lbscalex.Name = "lbscalex";
            this.lbscalex.Size = new System.Drawing.Size(15, 13);
            this.lbscalex.TabIndex = 0;
            this.lbscalex.Text = "x:";
            // 
            // imgListTabMain
            // 
            this.imgListTabMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListTabMain.ImageStream")));
            this.imgListTabMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListTabMain.Images.SetKeyName(0, "tabprimitives.png");
            this.imgListTabMain.Images.SetKeyName(1, "tabedit.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(753, 576);
            this.Controls.Add(this.tabControlMain);
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
            this.tabControlMain.ResumeLayout(false);
            this.tabPrimitives.ResumeLayout(false);
            this.tabPrimitives.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLOD)).EndInit();
            this.tabEdit.ResumeLayout(false);
            this.gbScale.ResumeLayout(false);
            this.gbScale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.GroupBox gbRotation;
        private System.Windows.Forms.Button btnrotate;
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
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPrimitives;
        private System.Windows.Forms.TabPage tabEdit;
        private System.Windows.Forms.TrackBar trackBarLOD;
        private System.Windows.Forms.Label lbLod;
        private System.Windows.Forms.ImageList imgListTabMain;
        private System.Windows.Forms.GroupBox gbScale;
        private System.Windows.Forms.Button btnscale;
        private System.Windows.Forms.Label lbscalez;
        private System.Windows.Forms.TextBox tbScaleZ;
        private System.Windows.Forms.Label lbscaley;
        private System.Windows.Forms.TextBox tbScaleY;
        private System.Windows.Forms.TextBox tbScaleX;
        private System.Windows.Forms.Label lbscalex;
        private System.Windows.Forms.TextBox tbanglez;
        private System.Windows.Forms.TextBox tbangley;
        private System.Windows.Forms.TextBox tbanglex;
        private System.Windows.Forms.Label lbanglez;
        private System.Windows.Forms.Label lbanglex;
        private System.Windows.Forms.Label lbangley;
    }
}

