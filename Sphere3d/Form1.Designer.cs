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
            this.rZ = new System.Windows.Forms.RadioButton();
            this.rY = new System.Windows.Forms.RadioButton();
            this.rX = new System.Windows.Forms.RadioButton();
            this.gbrotation = new System.Windows.Forms.GroupBox();
            this.btnrotate = new System.Windows.Forms.Button();
            this.tbangle = new System.Windows.Forms.TextBox();
            this.lbrotate = new System.Windows.Forms.Label();
            this.btnbuild = new System.Windows.Forms.Button();
            this.tbsize = new System.Windows.Forms.TextBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbFront = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.gbrotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
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
            // gbrotation
            // 
            this.gbrotation.Controls.Add(this.btnrotate);
            this.gbrotation.Controls.Add(this.tbangle);
            this.gbrotation.Controls.Add(this.lbrotate);
            this.gbrotation.Controls.Add(this.rZ);
            this.gbrotation.Controls.Add(this.rX);
            this.gbrotation.Controls.Add(this.rY);
            this.gbrotation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gbrotation.Location = new System.Drawing.Point(543, 131);
            this.gbrotation.Name = "gbrotation";
            this.gbrotation.Size = new System.Drawing.Size(180, 147);
            this.gbrotation.TabIndex = 6;
            this.gbrotation.TabStop = false;
            this.gbrotation.Text = "Rotation";
            // 
            // btnrotate
            // 
            this.btnrotate.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrotate.Location = new System.Drawing.Point(61, 71);
            this.btnrotate.Name = "btnrotate";
            this.btnrotate.Size = new System.Drawing.Size(100, 64);
            this.btnrotate.TabIndex = 9;
            this.btnrotate.Text = "Rotate";
            this.btnrotate.UseVisualStyleBackColor = true;
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
            this.btnbuild.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnbuild.Location = new System.Drawing.Point(543, 28);
            this.btnbuild.Name = "btnbuild";
            this.btnbuild.Size = new System.Drawing.Size(110, 58);
            this.btnbuild.TabIndex = 7;
            this.btnbuild.Text = "Build";
            this.btnbuild.UseVisualStyleBackColor = true;
            this.btnbuild.Click += new System.EventHandler(this.btnbuild_Click);
            // 
            // tbsize
            // 
            this.tbsize.Location = new System.Drawing.Point(543, 92);
            this.tbsize.Name = "tbsize";
            this.tbsize.Size = new System.Drawing.Size(110, 20);
            this.tbsize.TabIndex = 8;
            this.tbsize.Text = "50";
            // 
            // pbLeft
            // 
            this.pbLeft.BackColor = System.Drawing.Color.DarkGray;
            this.pbLeft.Image = global::Sphere3d.Properties.Resources.viewport;
            this.pbLeft.Location = new System.Drawing.Point(268, 28);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(250, 250);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLeft.TabIndex = 11;
            this.pbLeft.TabStop = false;
            // 
            // pbTop
            // 
            this.pbTop.BackColor = System.Drawing.Color.DarkGray;
            this.pbTop.Image = global::Sphere3d.Properties.Resources.viewport;
            this.pbTop.Location = new System.Drawing.Point(12, 284);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(250, 250);
            this.pbTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTop.TabIndex = 10;
            this.pbTop.TabStop = false;
            // 
            // pbFront
            // 
            this.pbFront.BackColor = System.Drawing.Color.DarkGray;
            this.pbFront.Image = global::Sphere3d.Properties.Resources.viewport;
            this.pbFront.Location = new System.Drawing.Point(12, 28);
            this.pbFront.Name = "pbFront";
            this.pbFront.Size = new System.Drawing.Size(250, 250);
            this.pbFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFront.TabIndex = 9;
            this.pbFront.TabStop = false;
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.DarkGray;
            this.pbMain.Location = new System.Drawing.Point(268, 284);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(250, 250);
            this.pbMain.TabIndex = 2;
            this.pbMain.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(761, 553);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.pbFront);
            this.Controls.Add(this.tbsize);
            this.Controls.Add(this.btnbuild);
            this.Controls.Add(this.gbrotation);
            this.Controls.Add(this.pbMain);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbrotation.ResumeLayout(false);
            this.gbrotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.RadioButton rZ;
        private System.Windows.Forms.RadioButton rY;
        private System.Windows.Forms.RadioButton rX;
        private System.Windows.Forms.GroupBox gbrotation;
        private System.Windows.Forms.Button btnrotate;
        private System.Windows.Forms.TextBox tbangle;
        private System.Windows.Forms.Label lbrotate;
        private System.Windows.Forms.Button btnbuild;
        private System.Windows.Forms.TextBox tbsize;
        private System.Windows.Forms.PictureBox pbFront;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.PictureBox pbLeft;
    }
}

