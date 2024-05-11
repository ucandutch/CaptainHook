namespace CaptainHook
{
    partial class SmallApp
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
            labelSmallStatus = new Label();
            buttonSmallStart = new Button();
            buttonSmallStop = new Button();
            buttonSmallClose = new Button();
            buttonSmallMaximize = new Button();
            buttonSmallLocation = new Button();
            label2 = new Label();
            labelSmallToplamOlta = new Label();
            label3 = new Label();
            labelSmallCoordinate = new Label();
            label5 = new Label();
            labelSmallOltadakiSure = new Label();
            label6 = new Label();
            labelSmallFishBait = new Label();
            label8 = new Label();
            labelSmallPause = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelSmallStatus
            // 
            labelSmallStatus.BackColor = Color.Transparent;
            labelSmallStatus.Location = new Point(50, 131);
            labelSmallStatus.Name = "labelSmallStatus";
            labelSmallStatus.Size = new Size(271, 49);
            labelSmallStatus.TabIndex = 0;
            labelSmallStatus.Text = "Durum";
            labelSmallStatus.TextAlign = ContentAlignment.MiddleCenter;
            labelSmallStatus.TextChanged += labelSmallStatus_TextChanged;
            // 
            // buttonSmallStart
            // 
            buttonSmallStart.BackColor = Color.Transparent;
            buttonSmallStart.BackgroundImage = Properties.Resources.more;
            buttonSmallStart.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSmallStart.FlatStyle = FlatStyle.Flat;
            buttonSmallStart.Location = new Point(132, 3);
            buttonSmallStart.Name = "buttonSmallStart";
            buttonSmallStart.Size = new Size(34, 27);
            buttonSmallStart.TabIndex = 1;
            buttonSmallStart.Text = "Start";
            buttonSmallStart.UseVisualStyleBackColor = false;
            // 
            // buttonSmallStop
            // 
            buttonSmallStop.BackColor = Color.Transparent;
            buttonSmallStop.BackgroundImage = Properties.Resources.minus_button;
            buttonSmallStop.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSmallStop.FlatStyle = FlatStyle.Flat;
            buttonSmallStop.Location = new Point(194, 3);
            buttonSmallStop.Name = "buttonSmallStop";
            buttonSmallStop.Size = new Size(34, 27);
            buttonSmallStop.TabIndex = 1;
            buttonSmallStop.Text = "Stop";
            buttonSmallStop.UseVisualStyleBackColor = false;
            // 
            // buttonSmallClose
            // 
            buttonSmallClose.FlatStyle = FlatStyle.Flat;
            buttonSmallClose.Location = new Point(333, 0);
            buttonSmallClose.Name = "buttonSmallClose";
            buttonSmallClose.Size = new Size(35, 27);
            buttonSmallClose.TabIndex = 3;
            buttonSmallClose.Text = "X";
            buttonSmallClose.UseVisualStyleBackColor = true;
            buttonSmallClose.Click += buttonSmallClose_Click;
            // 
            // buttonSmallMaximize
            // 
            buttonSmallMaximize.BackColor = Color.Gray;
            buttonSmallMaximize.BackgroundImage = Properties.Resources.smallhomebutton;
            buttonSmallMaximize.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSmallMaximize.FlatStyle = FlatStyle.Flat;
            buttonSmallMaximize.Location = new Point(-3, 3);
            buttonSmallMaximize.Name = "buttonSmallMaximize";
            buttonSmallMaximize.Size = new Size(39, 37);
            buttonSmallMaximize.TabIndex = 4;
            buttonSmallMaximize.UseVisualStyleBackColor = false;
            buttonSmallMaximize.Click += buttonSmallMaximize_Click;
            // 
            // buttonSmallLocation
            // 
            buttonSmallLocation.BackColor = Color.Transparent;
            buttonSmallLocation.BackgroundImage = Properties.Resources.refresh;
            buttonSmallLocation.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSmallLocation.FlatStyle = FlatStyle.Flat;
            buttonSmallLocation.Location = new Point(232, 36);
            buttonSmallLocation.Name = "buttonSmallLocation";
            buttonSmallLocation.Size = new Size(28, 26);
            buttonSmallLocation.TabIndex = 5;
            buttonSmallLocation.UseVisualStyleBackColor = false;
            buttonSmallLocation.Click += buttonSmallLocation_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 71);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 6;
            label2.Text = "Atılan Toplam Olta :";
            // 
            // labelSmallToplamOlta
            // 
            labelSmallToplamOlta.AutoSize = true;
            labelSmallToplamOlta.Location = new Point(172, 71);
            labelSmallToplamOlta.Name = "labelSmallToplamOlta";
            labelSmallToplamOlta.Size = new Size(13, 15);
            labelSmallToplamOlta.TabIndex = 7;
            labelSmallToplamOlta.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 42);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 6;
            label3.Text = "Olta Atılan Nokta :";
            // 
            // labelSmallCoordinate
            // 
            labelSmallCoordinate.AutoSize = true;
            labelSmallCoordinate.Location = new Point(172, 42);
            labelSmallCoordinate.Name = "labelSmallCoordinate";
            labelSmallCoordinate.Size = new Size(22, 15);
            labelSmallCoordinate.TabIndex = 8;
            labelSmallCoordinate.Text = "0,0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 101);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 6;
            label5.Text = "Oltadaki güncel süre :";
            // 
            // labelSmallOltadakiSure
            // 
            labelSmallOltadakiSure.AutoSize = true;
            labelSmallOltadakiSure.Location = new Point(172, 101);
            labelSmallOltadakiSure.Name = "labelSmallOltadakiSure";
            labelSmallOltadakiSure.Size = new Size(13, 15);
            labelSmallOltadakiSure.TabIndex = 9;
            labelSmallOltadakiSure.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 71);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 10;
            label6.Text = "Tüketilen Fish Bait :";
            // 
            // labelSmallFishBait
            // 
            labelSmallFishBait.AutoSize = true;
            labelSmallFishBait.Location = new Point(314, 71);
            labelSmallFishBait.Name = "labelSmallFishBait";
            labelSmallFishBait.Size = new Size(13, 15);
            labelSmallFishBait.TabIndex = 11;
            labelSmallFishBait.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 101);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 12;
            label8.Text = "Oltalar arası süre :";
            // 
            // labelSmallPause
            // 
            labelSmallPause.AutoSize = true;
            labelSmallPause.Location = new Point(314, 101);
            labelSmallPause.Name = "labelSmallPause";
            labelSmallPause.Size = new Size(13, 15);
            labelSmallPause.TabIndex = 13;
            labelSmallPause.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(-6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 191);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(29, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 40);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // SmallApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(369, 184);
            Controls.Add(pictureBox2);
            Controls.Add(labelSmallPause);
            Controls.Add(label8);
            Controls.Add(labelSmallFishBait);
            Controls.Add(label6);
            Controls.Add(labelSmallOltadakiSure);
            Controls.Add(labelSmallCoordinate);
            Controls.Add(labelSmallToplamOlta);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonSmallLocation);
            Controls.Add(buttonSmallClose);
            Controls.Add(buttonSmallStop);
            Controls.Add(buttonSmallStart);
            Controls.Add(labelSmallStatus);
            Controls.Add(buttonSmallMaximize);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SmallApp";
            Opacity = 0.6D;
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "SmallApp";
            TopMost = true;
            TransparencyKey = Color.Gray;
            Load += SmallApp_Load;
            MouseDown += SmallApp_MouseDown;
            MouseMove += SmallApp_MouseMove;
            MouseUp += SmallApp_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSmallStart;
        private Button buttonSmallStop;
        private Button buttonSmallClose;
        private Button buttonSmallMaximize;
        private Button buttonSmallLocation;
        private Label labelSmallStatus;
        private Label label2;
        private Label labelSmallToplamOlta;
        private Label label3;
        private Label labelSmallCoordinate;
        private Label label5;
        private Label labelSmallOltadakiSure;
        private Label label6;
        private Label labelSmallFishBait;
        private Label label8;
        private Label labelSmallPause;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}