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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rX = new System.Windows.Forms.RadioButton();
            this.rY = new System.Windows.Forms.RadioButton();
            this.rZ = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 148);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sphere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Радиус:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(597, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "40";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rotate 45";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rZ);
            this.panel1.Controls.Add(this.rY);
            this.panel1.Controls.Add(this.rX);
            this.panel1.Location = new System.Drawing.Point(569, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // rX
            // 
            this.rX.AutoSize = true;
            this.rX.Checked = true;
            this.rX.Location = new System.Drawing.Point(28, 14);
            this.rX.Name = "rX";
            this.rX.Size = new System.Drawing.Size(32, 17);
            this.rX.TabIndex = 0;
            this.rX.TabStop = true;
            this.rX.Text = "X";
            this.rX.UseVisualStyleBackColor = true;
            // 
            // rY
            // 
            this.rY.AutoSize = true;
            this.rY.Location = new System.Drawing.Point(28, 37);
            this.rY.Name = "rY";
            this.rY.Size = new System.Drawing.Size(32, 17);
            this.rY.TabIndex = 1;
            this.rY.TabStop = true;
            this.rY.Text = "Y";
            this.rY.UseVisualStyleBackColor = true;
            // 
            // rZ
            // 
            this.rZ.AutoSize = true;
            this.rZ.Location = new System.Drawing.Point(28, 61);
            this.rZ.Name = "rZ";
            this.rZ.Size = new System.Drawing.Size(32, 17);
            this.rZ.TabIndex = 2;
            this.rZ.Text = "Z";
            this.rZ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(20, 20);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rZ;
        private System.Windows.Forms.RadioButton rY;
        private System.Windows.Forms.RadioButton rX;
    }
}

