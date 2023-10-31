namespace Assignment_1_Elevator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnOpen = new Button();
            btnClose = new Button();
            timer_left = new System.Windows.Forms.Timer(components);
            timer_right = new System.Windows.Forms.Timer(components);
            back_timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 381);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(134, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(148, 381);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(282, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 381);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.Location = new Point(538, 312);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(43, 42);
            btnOpen.TabIndex = 3;
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click_1;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(587, 312);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 42);
            btnClose.TabIndex = 4;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // timer_left
            // 
            timer_left.Interval = 20;
            timer_left.Tick += timer_left_Tick;
            // 
            // timer_right
            // 
            timer_right.Interval = 20;
            timer_right.Tick += timer_right_Tick;
            // 
            // back_timer
            // 
            back_timer.Interval = 20;
            back_timer.Tick += back_timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 691);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnOpen;
        private Button btnClose;
        private System.Windows.Forms.Timer timerLeft;
        private System.Windows.Forms.Timer timer_left;
        private System.Windows.Forms.Timer timer_right;
        private System.Windows.Forms.Timer back_timer;
    }
}