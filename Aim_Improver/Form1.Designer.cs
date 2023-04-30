namespace Aim_Improver
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
            this.pictureBox_aim = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_aim)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_aim
            // 
            this.pictureBox_aim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_aim.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_aim.Image")));
            this.pictureBox_aim.Location = new System.Drawing.Point(251, 62);
            this.pictureBox_aim.Name = "pictureBox_aim";
            this.pictureBox_aim.Size = new System.Drawing.Size(102, 101);
            this.pictureBox_aim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_aim.TabIndex = 0;
            this.pictureBox_aim.TabStop = false;
            this.pictureBox_aim.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.ForeColor = System.Drawing.Color.Black;
            this.lbl_score.Location = new System.Drawing.Point(13, 13);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(127, 39);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "Score: 0";
            this.lbl_score.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time.ForeColor = System.Drawing.Color.Black;
            this.lbl_time.Location = new System.Drawing.Point(654, 13);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(130, 39);
            this.lbl_time.TabIndex = 1;
            this.lbl_time.Text = "Time: 60";
            this.lbl_time.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(304, 281);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(220, 82);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(359, 89);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(234, 46);
            this.lbl_title.TabIndex = 3;
            this.lbl_title.Text = "Aim Improver";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(843, 468);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pictureBox_aim);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aim Improver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_aim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_aim;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_title;
    }
}

