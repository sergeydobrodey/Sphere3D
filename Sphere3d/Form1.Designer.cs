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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rZ = new System.Windows.Forms.RadioButton();
            this.rY = new System.Windows.Forms.RadioButton();
            this.rX = new System.Windows.Forms.RadioButton();
            this.gbrotation = new System.Windows.Forms.GroupBox();
            this.lbrotate = new System.Windows.Forms.Label();
            this.tbangle = new System.Windows.Forms.TextBox();
            this.btnrotate = new System.Windows.Forms.Button();
            this.btnbuild = new System.Windows.Forms.Button();
            this.tbsize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbrotation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::Sphere3d.Properties.Resources.Untitled;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.gbrotation.Location = new System.Drawing.Point(555, 301);
            this.gbrotation.Name = "gbrotation";
            this.gbrotation.Size = new System.Drawing.Size(180, 147);
            this.gbrotation.TabIndex = 6;
            this.gbrotation.TabStop = false;
            this.gbrotation.Text = "Rotation";
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
            // tbangle
            // 
            this.tbangle.Location = new System.Drawing.Point(61, 27);
            this.tbangle.Name = "tbangle";
            this.tbangle.Size = new System.Drawing.Size(100, 20);
            this.tbangle.TabIndex = 8;
            this.tbangle.Text = "90";
            // 
            // btnrotate
            // 
            this.btnrotate.Location = new System.Drawing.Point(61, 71);
            this.btnrotate.Name = "btnrotate";
            this.btnrotate.Size = new System.Drawing.Size(100, 64);
            this.btnrotate.TabIndex = 9;
            this.btnrotate.Text = "Rotate";
            this.btnrotate.UseVisualStyleBackColor = true;
            this.btnrotate.Click += new System.EventHandler(this.btnrotate_Click);
            // 
            // btnbuild
            // 
            this.btnbuild.Location = new System.Drawing.Point(555, 61);
            this.btnbuild.Name = "btnbuild";
            this.btnbuild.Size = new System.Drawing.Size(110, 58);
            this.btnbuild.TabIndex = 7;
            this.btnbuild.Text = "Build";
            this.btnbuild.UseVisualStyleBackColor = true;
            this.btnbuild.Click += new System.EventHandler(this.btnbuild_Click);
            // 
            // tbsize
            // 
            this.tbsize.Location = new System.Drawing.Point(555, 135);
            this.tbsize.Name = "tbsize";
            this.tbsize.Size = new System.Drawing.Size(110, 20);
            this.tbsize.TabIndex = 8;
            this.tbsize.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 623);
            this.Controls.Add(this.tbsize);
            this.Controls.Add(this.btnbuild);
            this.Controls.Add(this.gbrotation);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbrotation.ResumeLayout(false);
            this.gbrotation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rZ;
        private System.Windows.Forms.RadioButton rY;
        private System.Windows.Forms.RadioButton rX;
        private System.Windows.Forms.GroupBox gbrotation;
        private System.Windows.Forms.Button btnrotate;
        private System.Windows.Forms.TextBox tbangle;
        private System.Windows.Forms.Label lbrotate;
        private System.Windows.Forms.Button btnbuild;
        private System.Windows.Forms.TextBox tbsize;
    }
}

