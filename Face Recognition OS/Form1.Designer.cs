namespace Face_Recognition_OS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_faceDetect = new System.Windows.Forms.Button();
            this.label_faceDetect = new System.Windows.Forms.Label();
            this.but_FaceRegistered = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_sign = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 426);
            this.panel1.TabIndex = 0;
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 423);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // but_faceDetect
            // 
            this.but_faceDetect.Location = new System.Drawing.Point(380, 189);
            this.but_faceDetect.Name = "but_faceDetect";
            this.but_faceDetect.Size = new System.Drawing.Size(293, 63);
            this.but_faceDetect.TabIndex = 1;
            this.but_faceDetect.Text = "检测人脸";
            this.but_faceDetect.UseVisualStyleBackColor = true;
            this.but_faceDetect.Click += new System.EventHandler(this.but_faceDetect_ClickAsync);
            // 
            // label_faceDetect
            // 
            this.label_faceDetect.AutoSize = true;
            this.label_faceDetect.Font = new System.Drawing.Font("宋体", 12F);
            this.label_faceDetect.Location = new System.Drawing.Point(483, 15);
            this.label_faceDetect.Name = "label_faceDetect";
            this.label_faceDetect.Size = new System.Drawing.Size(40, 16);
            this.label_faceDetect.TabIndex = 2;
            this.label_faceDetect.Text = "test";
            // 
            // but_FaceRegistered
            // 
            this.but_FaceRegistered.Location = new System.Drawing.Point(380, 277);
            this.but_FaceRegistered.Name = "but_FaceRegistered";
            this.but_FaceRegistered.Size = new System.Drawing.Size(293, 67);
            this.but_FaceRegistered.TabIndex = 3;
            this.but_FaceRegistered.Text = "人脸注册";
            this.but_FaceRegistered.UseVisualStyleBackColor = true;
            this.but_FaceRegistered.Click += new System.EventHandler(this.but_FaceRegistered_Click);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(451, 140);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(189, 21);
            this.text_name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(397, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "人脸信息:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(397, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "状态信息:";
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("宋体", 12F);
            this.label_state.Location = new System.Drawing.Point(483, 90);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(40, 16);
            this.label_state.TabIndex = 6;
            this.label_state.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(397, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "姓名:";
            // 
            // but_sign
            // 
            this.but_sign.Location = new System.Drawing.Point(380, 371);
            this.but_sign.Name = "but_sign";
            this.but_sign.Size = new System.Drawing.Size(293, 67);
            this.but_sign.TabIndex = 9;
            this.but_sign.Text = "人脸签到";
            this.but_sign.UseVisualStyleBackColor = true;
            this.but_sign.Click += new System.EventHandler(this.but_sign_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_sign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.but_FaceRegistered);
            this.Controls.Add(this.label_faceDetect);
            this.Controls.Add(this.but_faceDetect);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_faceDetect;
        private System.Windows.Forms.Label label_faceDetect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_FaceRegistered;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_sign;
    }
}

