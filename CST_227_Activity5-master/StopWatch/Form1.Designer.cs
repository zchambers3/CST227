namespace StopWatch
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_target = new System.Windows.Forms.PictureBox();
            this.pic_falseTarget = new System.Windows.Forms.PictureBox();
            this.pic_falseTarget1 = new System.Windows.Forms.PictureBox();
            this.pic_falseTarget2 = new System.Windows.Forms.PictureBox();
            this.pic_falseTarget3 = new System.Windows.Forms.PictureBox();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.btn_missClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_falseTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_falseTarget1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_falseTarget2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_falseTarget3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_start.AutoSize = true;
            this.btn_start.Location = new System.Drawing.Point(15, 520);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stop.AutoSize = true;
            this.btn_stop.Location = new System.Drawing.Point(96, 520);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reset.AutoSize = true;
            this.btn_reset.Location = new System.Drawing.Point(177, 520);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Timer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // pic_target
            // 
            this.pic_target.Location = new System.Drawing.Point(11, 179);
            this.pic_target.Name = "pic_target";
            this.pic_target.Size = new System.Drawing.Size(50, 50);
            this.pic_target.TabIndex = 8;
            this.pic_target.TabStop = false;
            this.pic_target.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic_falseTarget
            // 
            this.pic_falseTarget.Location = new System.Drawing.Point(12, 236);
            this.pic_falseTarget.Name = "pic_falseTarget";
            this.pic_falseTarget.Size = new System.Drawing.Size(50, 50);
            this.pic_falseTarget.TabIndex = 10;
            this.pic_falseTarget.TabStop = false;
            this.pic_falseTarget.Click += new System.EventHandler(this.pic_falseTarget_Click);
            // 
            // pic_falseTarget1
            // 
            this.pic_falseTarget1.Location = new System.Drawing.Point(11, 292);
            this.pic_falseTarget1.Name = "pic_falseTarget1";
            this.pic_falseTarget1.Size = new System.Drawing.Size(50, 50);
            this.pic_falseTarget1.TabIndex = 11;
            this.pic_falseTarget1.TabStop = false;
            this.pic_falseTarget1.Click += new System.EventHandler(this.pic_falseTarget1_Click);
            // 
            // pic_falseTarget2
            // 
            this.pic_falseTarget2.Location = new System.Drawing.Point(11, 348);
            this.pic_falseTarget2.Name = "pic_falseTarget2";
            this.pic_falseTarget2.Size = new System.Drawing.Size(50, 50);
            this.pic_falseTarget2.TabIndex = 12;
            this.pic_falseTarget2.TabStop = false;
            this.pic_falseTarget2.Click += new System.EventHandler(this.pic_falseTarget2_Click);
            // 
            // pic_falseTarget3
            // 
            this.pic_falseTarget3.Location = new System.Drawing.Point(11, 404);
            this.pic_falseTarget3.Name = "pic_falseTarget3";
            this.pic_falseTarget3.Size = new System.Drawing.Size(50, 50);
            this.pic_falseTarget3.TabIndex = 13;
            this.pic_falseTarget3.TabStop = false;
            this.pic_falseTarget3.Click += new System.EventHandler(this.pic_falseTarget3_Click);
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.Location = new System.Drawing.Point(258, 520);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(75, 23);
            this.btn_playAgain.TabIndex = 15;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = true;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // btn_missClick
            // 
            this.btn_missClick.BackgroundImage = global::StopWatch.Properties.Resources.purple_background;
            this.btn_missClick.Location = new System.Drawing.Point(-8, -20);
            this.btn_missClick.Name = "btn_missClick";
            this.btn_missClick.Size = new System.Drawing.Size(1006, 594);
            this.btn_missClick.TabIndex = 16;
            this.btn_missClick.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 555);
            this.Controls.Add(this.btn_missClick);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.pic_falseTarget3);
            this.Controls.Add(this.pic_falseTarget2);
            this.Controls.Add(this.pic_falseTarget1);
            this.Controls.Add(this.pic_falseTarget);
            this.Controls.Add(this.pic_target);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_falseTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_falseTarget1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_falseTarget2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_falseTarget3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_target;
        private System.Windows.Forms.PictureBox pic_falseTarget;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic_falseTarget1;
        private System.Windows.Forms.PictureBox pic_falseTarget2;
        private System.Windows.Forms.PictureBox pic_falseTarget3;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Button btn_missClick;
    }
}

