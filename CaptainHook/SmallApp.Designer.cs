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
            label1 = new Label();
            buttonSmallStop = new Button();
            buttonSmallClose = new Button();
            buttonSmallMaximize = new Button();
            buttonSmallLocation = new Button();
            SuspendLayout();
            // 
            // labelSmallStatus
            // 
            labelSmallStatus.BackColor = Color.Transparent;
            labelSmallStatus.Location = new Point(25, 131);
            labelSmallStatus.Name = "labelSmallStatus";
            labelSmallStatus.Size = new Size(258, 49);
            labelSmallStatus.TabIndex = 0;
            labelSmallStatus.Text = "Durum";
            labelSmallStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSmallStart
            // 
            buttonSmallStart.BackColor = Color.Transparent;
            buttonSmallStart.BackgroundImage = Properties.Resources.more;
            buttonSmallStart.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSmallStart.FlatStyle = FlatStyle.Flat;
            buttonSmallStart.Location = new Point(214, 68);
            buttonSmallStart.Name = "buttonSmallStart";
            buttonSmallStart.Size = new Size(34, 34);
            buttonSmallStart.TabIndex = 1;
            buttonSmallStart.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Status:";
            // 
            // buttonSmallStop
            // 
            buttonSmallStop.BackColor = Color.Transparent;
            buttonSmallStop.BackgroundImage = Properties.Resources.minus_button;
            buttonSmallStop.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSmallStop.FlatStyle = FlatStyle.Flat;
            buttonSmallStop.Location = new Point(249, 68);
            buttonSmallStop.Name = "buttonSmallStop";
            buttonSmallStop.Size = new Size(34, 34);
            buttonSmallStop.TabIndex = 1;
            buttonSmallStop.UseVisualStyleBackColor = false;
            // 
            // buttonSmallClose
            // 
            buttonSmallClose.FlatStyle = FlatStyle.Flat;
            buttonSmallClose.Location = new Point(260, 12);
            buttonSmallClose.Name = "buttonSmallClose";
            buttonSmallClose.Size = new Size(35, 27);
            buttonSmallClose.TabIndex = 3;
            buttonSmallClose.Text = "X";
            buttonSmallClose.UseVisualStyleBackColor = true;
            buttonSmallClose.Click += buttonSmallClose_Click;
            // 
            // buttonSmallMaximize
            // 
            buttonSmallMaximize.FlatStyle = FlatStyle.Flat;
            buttonSmallMaximize.Location = new Point(225, 12);
            buttonSmallMaximize.Name = "buttonSmallMaximize";
            buttonSmallMaximize.Size = new Size(35, 27);
            buttonSmallMaximize.TabIndex = 4;
            buttonSmallMaximize.Text = "O";
            buttonSmallMaximize.UseVisualStyleBackColor = true;
            buttonSmallMaximize.Click += buttonSmallMaximize_Click;
            // 
            // buttonSmallLocation
            // 
            buttonSmallLocation.BackColor = Color.Transparent;
            buttonSmallLocation.BackgroundImage = Properties.Resources.refresh;
            buttonSmallLocation.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSmallLocation.FlatStyle = FlatStyle.Flat;
            buttonSmallLocation.Location = new Point(152, 68);
            buttonSmallLocation.Name = "buttonSmallLocation";
            buttonSmallLocation.Size = new Size(28, 30);
            buttonSmallLocation.TabIndex = 5;
            buttonSmallLocation.UseVisualStyleBackColor = false;
            buttonSmallLocation.Click += buttonSmallLocation_Click;
            // 
            // SmallApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.result__1_;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(295, 184);
            Controls.Add(buttonSmallLocation);
            Controls.Add(buttonSmallMaximize);
            Controls.Add(buttonSmallClose);
            Controls.Add(label1);
            Controls.Add(buttonSmallStop);
            Controls.Add(buttonSmallStart);
            Controls.Add(labelSmallStatus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SmallApp";
            Text = "SmallApp";
            TopMost = true;
            Load += SmallApp_Load;
            MouseDown += SmallApp_MouseDown;
            MouseMove += SmallApp_MouseMove;
            MouseUp += SmallApp_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSmallStart;
        private Label label1;
        private Button buttonSmallStop;
        private Button buttonSmallClose;
        private Button buttonSmallMaximize;
        private Button buttonSmallLocation;
        private Label labelSmallStatus;
    }
}