namespace CaptainHook
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
            pictureBox1 = new PictureBox();
            timerFishBar = new System.Windows.Forms.Timer(components);
            labelStatus = new Label();
            timerReeling = new System.Windows.Forms.Timer(components);
            labelFish = new Label();
            Start = new Button();
            comboBoxOutputDevices = new ComboBox();
            progressBarSoundLevel = new ProgressBar();
            timerSoundcheck = new System.Windows.Forms.Timer(components);
            labelCoordinate = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            labelOltadakiSure = new Label();
            timerAudio = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            labelSesSeviyesi = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panelAnasayfa = new Panel();
            checkBoxZamanlayici = new CheckBox();
            textBoxZamanlayiciMN = new TextBox();
            textBoxOltaMaxSuresi = new TextBox();
            textBoxOltaAraSuresi = new TextBox();
            textBoxZamanlayiciHR = new TextBox();
            label32 = new Label();
            label30 = new Label();
            label28 = new Label();
            label27 = new Label();
            label1 = new Label();
            label23 = new Label();
            label22 = new Label();
            buttonFishingBait = new Button();
            buttonSeaweedSalad = new Button();
            Pathfinder = new CheckBox();
            label29 = new Label();
            label20 = new Label();
            label21 = new Label();
            labelCurrentTime = new Label();
            label19 = new Label();
            labelToplamOlta = new Label();
            label18 = new Label();
            labelPause = new Label();
            label31 = new Label();
            labelDate = new Label();
            label8 = new Label();
            timerPause = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            timerWalk = new System.Windows.Forms.Timer(components);
            pictureBoxSettings = new PictureBox();
            groupBoxSettings = new GroupBox();
            menuStrip1 = new MenuStrip();
            pathFinderToolStripMenuItem = new ToolStripMenuItem();
            sesAyarlarıToolStripMenuItem = new ToolStripMenuItem();
            panelSoundSettings = new Panel();
            label25 = new Label();
            label24 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            panelPathFinder = new Panel();
            comboBoxBalikSayisi = new ComboBox();
            button8 = new Button();
            button7 = new Button();
            label37 = new Label();
            label36 = new Label();
            button5 = new Button();
            button6 = new Button();
            label35 = new Label();
            label34 = new Label();
            label33 = new Label();
            label11 = new Label();
            label10 = new Label();
            comboBoxFishStop = new ComboBox();
            comboBoxBalikNoktalari = new ComboBox();
            comboBoxNoktalar = new ComboBox();
            comboBoxHaritalar = new ComboBox();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label38 = new Label();
            label12 = new Label();
            groupBoxLog = new GroupBox();
            textBoxLogSearch = new TextBox();
            label26 = new Label();
            listBox1 = new ListBox();
            pictureBoxLog = new PictureBox();
            pictureBoxMain = new PictureBox();
            timerCurrentTime = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelAnasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).BeginInit();
            groupBoxSettings.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelSoundSettings.SuspendLayout();
            panelPathFinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            groupBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Location = new Point(22, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timerFishBar
            // 
            timerFishBar.Enabled = true;
            timerFishBar.Interval = 150;
            timerFishBar.Tick += timerFishBar_Tick;
            // 
            // labelStatus
            // 
            labelStatus.BackColor = Color.Transparent;
            labelStatus.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.ForeColor = SystemColors.ActiveCaptionText;
            labelStatus.Location = new Point(49, 604);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(268, 79);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Test Duyurusu - Bu alanda duyurular gösterilecek. Status Update Ekranı";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            labelStatus.TextChanged += labelStatus_TextChanged;
            labelStatus.Click += labelStatus_Click;
            // 
            // timerReeling
            // 
            timerReeling.Interval = 30;
            timerReeling.Tick += timerReeling_Tick;
            // 
            // labelFish
            // 
            labelFish.AutoSize = true;
            labelFish.BackColor = Color.Transparent;
            labelFish.Location = new Point(190, 68);
            labelFish.Name = "labelFish";
            labelFish.Size = new Size(65, 15);
            labelFish.TabIndex = 3;
            labelFish.Text = "Beklemede";
            labelFish.Visible = false;
            // 
            // Start
            // 
            Start.BackColor = Color.Transparent;
            Start.FlatStyle = FlatStyle.Flat;
            Start.Location = new Point(175, 413);
            Start.Name = "Start";
            Start.Size = new Size(86, 31);
            Start.TabIndex = 4;
            Start.Text = "Durdur";
            Start.UseVisualStyleBackColor = false;
            Start.Click += button1_Click;
            // 
            // comboBoxOutputDevices
            // 
            comboBoxOutputDevices.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOutputDevices.FormattingEnabled = true;
            comboBoxOutputDevices.Location = new Point(24, 50);
            comboBoxOutputDevices.Name = "comboBoxOutputDevices";
            comboBoxOutputDevices.Size = new Size(272, 23);
            comboBoxOutputDevices.TabIndex = 5;
            comboBoxOutputDevices.SelectedIndexChanged += comboBoxOutputDevices_SelectedIndexChanged;
            // 
            // progressBarSoundLevel
            // 
            progressBarSoundLevel.Location = new Point(4, 153);
            progressBarSoundLevel.Name = "progressBarSoundLevel";
            progressBarSoundLevel.Size = new Size(314, 19);
            progressBarSoundLevel.Step = 100;
            progressBarSoundLevel.TabIndex = 6;
            // 
            // timerSoundcheck
            // 
            timerSoundcheck.Enabled = true;
            timerSoundcheck.Interval = 1000;
            timerSoundcheck.Tick += timerSoundcheck_Tick;
            // 
            // labelCoordinate
            // 
            labelCoordinate.AutoSize = true;
            labelCoordinate.BackColor = Color.Transparent;
            labelCoordinate.Location = new Point(126, 198);
            labelCoordinate.Name = "labelCoordinate";
            labelCoordinate.Size = new Size(22, 15);
            labelCoordinate.TabIndex = 7;
            labelCoordinate.Text = "0,0";
            labelCoordinate.Click += labelCoordinate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(956, 612);
            button1.Name = "button1";
            button1.Size = new Size(74, 44);
            button1.TabIndex = 8;
            button1.Text = "Koordinat Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            button1.MouseClick += button1_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(86, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 10;
            label2.Text = "Bar kontrol";
            label2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(83, 413);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 11;
            button2.Text = "Başlat";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelOltadakiSure
            // 
            labelOltadakiSure.AutoSize = true;
            labelOltadakiSure.BackColor = Color.Transparent;
            labelOltadakiSure.Location = new Point(126, 236);
            labelOltadakiSure.Name = "labelOltadakiSure";
            labelOltadakiSure.Size = new Size(13, 15);
            labelOltadakiSure.TabIndex = 12;
            labelOltadakiSure.Text = "0";
            // 
            // timerAudio
            // 
            timerAudio.Enabled = true;
            timerAudio.Interval = 10;
            timerAudio.Tick += timerAudio_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(64, 175);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 13;
            label4.Text = "Kaydedilen Max. Ses :";
            // 
            // labelSesSeviyesi
            // 
            labelSesSeviyesi.AutoSize = true;
            labelSesSeviyesi.BackColor = Color.Transparent;
            labelSesSeviyesi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSesSeviyesi.Location = new Point(190, 180);
            labelSesSeviyesi.Name = "labelSesSeviyesi";
            labelSesSeviyesi.Size = new Size(19, 21);
            labelSesSeviyesi.TabIndex = 14;
            labelSesSeviyesi.Text = "0";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(128, 240);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 27);
            textBox1.TabIndex = 15;
            textBox1.Text = "27";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.MenuHighlight;
            checkBox1.Location = new Point(16, 115);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Ayarları Kaydet";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(19, 184);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 17;
            label5.Text = "Olta Atılan Nokta :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(323, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 18);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(54, 221);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 20;
            label7.Text = "Olta Süresi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(116, 36);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 21;
            label3.Text = "Captain Hook";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.refresh;
            pictureBox3.Location = new Point(120, 182);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(16, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panelAnasayfa
            // 
            panelAnasayfa.BackColor = Color.Transparent;
            panelAnasayfa.Controls.Add(checkBoxZamanlayici);
            panelAnasayfa.Controls.Add(textBoxZamanlayiciMN);
            panelAnasayfa.Controls.Add(textBoxOltaMaxSuresi);
            panelAnasayfa.Controls.Add(textBoxOltaAraSuresi);
            panelAnasayfa.Controls.Add(textBoxZamanlayiciHR);
            panelAnasayfa.Controls.Add(label32);
            panelAnasayfa.Controls.Add(label30);
            panelAnasayfa.Controls.Add(label28);
            panelAnasayfa.Controls.Add(label27);
            panelAnasayfa.Controls.Add(label1);
            panelAnasayfa.Controls.Add(label23);
            panelAnasayfa.Controls.Add(label22);
            panelAnasayfa.Controls.Add(buttonFishingBait);
            panelAnasayfa.Controls.Add(buttonSeaweedSalad);
            panelAnasayfa.Controls.Add(Pathfinder);
            panelAnasayfa.Controls.Add(Start);
            panelAnasayfa.Controls.Add(label29);
            panelAnasayfa.Controls.Add(label20);
            panelAnasayfa.Controls.Add(label21);
            panelAnasayfa.Controls.Add(labelCurrentTime);
            panelAnasayfa.Controls.Add(label19);
            panelAnasayfa.Controls.Add(labelToplamOlta);
            panelAnasayfa.Controls.Add(label18);
            panelAnasayfa.Controls.Add(button2);
            panelAnasayfa.Controls.Add(labelPause);
            panelAnasayfa.Controls.Add(pictureBox3);
            panelAnasayfa.Controls.Add(label31);
            panelAnasayfa.Controls.Add(label7);
            panelAnasayfa.Controls.Add(labelCoordinate);
            panelAnasayfa.Controls.Add(label5);
            panelAnasayfa.Controls.Add(labelOltadakiSure);
            panelAnasayfa.Location = new Point(15, 133);
            panelAnasayfa.Name = "panelAnasayfa";
            panelAnasayfa.Size = new Size(331, 450);
            panelAnasayfa.TabIndex = 24;
            panelAnasayfa.MouseDown += panelAnasayfa_MouseDown;
            panelAnasayfa.MouseMove += panelAnasayfa_MouseMove;
            panelAnasayfa.MouseUp += panelAnasayfa_MouseUp;
            // 
            // checkBoxZamanlayici
            // 
            checkBoxZamanlayici.AutoSize = true;
            checkBoxZamanlayici.ForeColor = Color.DimGray;
            checkBoxZamanlayici.Location = new Point(174, 322);
            checkBoxZamanlayici.Name = "checkBoxZamanlayici";
            checkBoxZamanlayici.Size = new Size(101, 19);
            checkBoxZamanlayici.TabIndex = 37;
            checkBoxZamanlayici.Text = "*Zamanlayıcı :";
            checkBoxZamanlayici.UseVisualStyleBackColor = true;
            checkBoxZamanlayici.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBoxZamanlayiciMN
            // 
            textBoxZamanlayiciMN.BackColor = Color.Tan;
            textBoxZamanlayiciMN.BorderStyle = BorderStyle.None;
            textBoxZamanlayiciMN.Location = new Point(296, 323);
            textBoxZamanlayiciMN.Name = "textBoxZamanlayiciMN";
            textBoxZamanlayiciMN.Size = new Size(18, 16);
            textBoxZamanlayiciMN.TabIndex = 36;
            textBoxZamanlayiciMN.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxOltaMaxSuresi
            // 
            textBoxOltaMaxSuresi.BackColor = Color.Tan;
            textBoxOltaMaxSuresi.BorderStyle = BorderStyle.None;
            textBoxOltaMaxSuresi.Location = new Point(158, 236);
            textBoxOltaMaxSuresi.Name = "textBoxOltaMaxSuresi";
            textBoxOltaMaxSuresi.Size = new Size(18, 16);
            textBoxOltaMaxSuresi.TabIndex = 36;
            textBoxOltaMaxSuresi.Text = "35";
            textBoxOltaMaxSuresi.TextAlign = HorizontalAlignment.Center;
            textBoxOltaMaxSuresi.TextChanged += textBoxOltaMaxSuresi_TextChanged;
            textBoxOltaMaxSuresi.KeyPress += textBoxOltaMaxSuresi_KeyPress;
            textBoxOltaMaxSuresi.Leave += textBoxOltaMaxSuresi_Leave;
            // 
            // textBoxOltaAraSuresi
            // 
            textBoxOltaAraSuresi.BackColor = Color.Tan;
            textBoxOltaAraSuresi.BorderStyle = BorderStyle.None;
            textBoxOltaAraSuresi.Location = new Point(291, 236);
            textBoxOltaAraSuresi.Name = "textBoxOltaAraSuresi";
            textBoxOltaAraSuresi.Size = new Size(18, 16);
            textBoxOltaAraSuresi.TabIndex = 36;
            textBoxOltaAraSuresi.Text = "3";
            textBoxOltaAraSuresi.TextAlign = HorizontalAlignment.Center;
            textBoxOltaAraSuresi.TextChanged += textBoxOltaAraSuresi_TextChanged;
            textBoxOltaAraSuresi.KeyPress += textBoxOltaAraSuresi_KeyPress;
            textBoxOltaAraSuresi.Leave += textBoxOltaAraSuresi_Leave;
            // 
            // textBoxZamanlayiciHR
            // 
            textBoxZamanlayiciHR.BackColor = Color.Tan;
            textBoxZamanlayiciHR.BorderStyle = BorderStyle.None;
            textBoxZamanlayiciHR.Location = new Point(275, 323);
            textBoxZamanlayiciHR.Name = "textBoxZamanlayiciHR";
            textBoxZamanlayiciHR.Size = new Size(18, 16);
            textBoxZamanlayiciHR.TabIndex = 36;
            textBoxZamanlayiciHR.TextAlign = HorizontalAlignment.Center;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.ForeColor = Color.IndianRed;
            label32.Location = new Point(228, 271);
            label32.Name = "label32";
            label32.Size = new Size(62, 15);
            label32.TabIndex = 35;
            label32.Text = "___________";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.ForeColor = Color.IndianRed;
            label30.Location = new Point(12, 271);
            label30.Name = "label30";
            label30.Size = new Size(157, 15);
            label30.TabIndex = 35;
            label30.Text = "______________________________";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.IndianRed;
            label28.Location = new Point(49, 117);
            label28.Name = "label28";
            label28.Size = new Size(237, 15);
            label28.TabIndex = 35;
            label28.Text = "______________________________________________";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(221, 103);
            label27.Name = "label27";
            label27.Size = new Size(22, 15);
            label27.TabIndex = 34;
            label27.Text = "10'";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 103);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 34;
            label1.Text = "30'";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.DimGray;
            label23.Location = new Point(197, 8);
            label23.Name = "label23";
            label23.Size = new Size(73, 20);
            label23.TabIndex = 33;
            label23.Text = "*Fish Bait";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.DimGray;
            label22.Location = new Point(58, 8);
            label22.Name = "label22";
            label22.Size = new Size(117, 20);
            label22.TabIndex = 33;
            label22.Text = "*Seaweed Salad";
            // 
            // buttonFishingBait
            // 
            buttonFishingBait.BackgroundImage = Properties.Resources.T1_FISHINGBAIT;
            buttonFishingBait.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFishingBait.Cursor = Cursors.Hand;
            buttonFishingBait.FlatStyle = FlatStyle.Flat;
            buttonFishingBait.Location = new Point(193, 31);
            buttonFishingBait.Name = "buttonFishingBait";
            buttonFishingBait.Size = new Size(73, 69);
            buttonFishingBait.TabIndex = 32;
            buttonFishingBait.UseVisualStyleBackColor = true;
            // 
            // buttonSeaweedSalad
            // 
            buttonSeaweedSalad.BackgroundImage = Properties.Resources.T1_MEAL_SEAWEEDSALAD;
            buttonSeaweedSalad.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSeaweedSalad.Cursor = Cursors.Hand;
            buttonSeaweedSalad.FlatStyle = FlatStyle.Flat;
            buttonSeaweedSalad.Location = new Point(68, 31);
            buttonSeaweedSalad.Name = "buttonSeaweedSalad";
            buttonSeaweedSalad.Size = new Size(73, 69);
            buttonSeaweedSalad.TabIndex = 32;
            buttonSeaweedSalad.UseVisualStyleBackColor = true;
            buttonSeaweedSalad.Click += buttonSeaweedSalad_Click;
            // 
            // Pathfinder
            // 
            Pathfinder.AutoSize = true;
            Pathfinder.BackColor = Color.Transparent;
            Pathfinder.ForeColor = Color.MediumBlue;
            Pathfinder.Location = new Point(39, 321);
            Pathfinder.Name = "Pathfinder";
            Pathfinder.Size = new Size(81, 19);
            Pathfinder.TabIndex = 26;
            Pathfinder.Text = "Pathfinder";
            Pathfinder.UseVisualStyleBackColor = false;
            Pathfinder.CheckedChanged += Pathfinder_CheckedChanged;
            // 
            // label29
            // 
            label29.Location = new Point(290, 324);
            label29.Name = "label29";
            label29.Size = new Size(10, 15);
            label29.TabIndex = 31;
            label29.Text = ":";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(276, 236);
            label20.Name = "label20";
            label20.Size = new Size(15, 15);
            label20.TabIndex = 31;
            label20.Text = "<";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(141, 236);
            label21.Name = "label21";
            label21.Size = new Size(15, 15);
            label21.TabIndex = 31;
            label21.Text = "<";
            // 
            // labelCurrentTime
            // 
            labelCurrentTime.AutoSize = true;
            labelCurrentTime.Location = new Point(273, 305);
            labelCurrentTime.Name = "labelCurrentTime";
            labelCurrentTime.Size = new Size(44, 15);
            labelCurrentTime.TabIndex = 29;
            labelCurrentTime.Text = "label20";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(192, 305);
            label19.Name = "label19";
            label19.Size = new Size(75, 15);
            label19.TabIndex = 28;
            label19.Text = "Güncel Saat :";
            // 
            // labelToplamOlta
            // 
            labelToplamOlta.AutoSize = true;
            labelToplamOlta.Location = new Point(126, 160);
            labelToplamOlta.Name = "labelToplamOlta";
            labelToplamOlta.Size = new Size(13, 15);
            labelToplamOlta.TabIndex = 27;
            labelToplamOlta.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 145);
            label18.Name = "label18";
            label18.Size = new Size(108, 15);
            label18.TabIndex = 26;
            label18.Text = "Atılan toplam olta :";
            // 
            // labelPause
            // 
            labelPause.AutoSize = true;
            labelPause.Location = new Point(267, 236);
            labelPause.Name = "labelPause";
            labelPause.Size = new Size(13, 15);
            labelPause.TabIndex = 24;
            labelPause.Text = "0";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Location = new Point(183, 221);
            label31.Name = "label31";
            label31.Size = new Size(87, 15);
            label31.TabIndex = 20;
            label31.Text = "Olta Ara Süresi:";
            // 
            // labelDate
            // 
            labelDate.BackColor = Color.Transparent;
            labelDate.ForeColor = Color.DimGray;
            labelDate.Location = new Point(177, 107);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(170, 23);
            labelDate.TabIndex = 23;
            labelDate.Text = "labeldate";
            labelDate.TextAlign = ContentAlignment.BottomRight;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(346, 553);
            label8.Name = "label8";
            label8.Size = new Size(10, 140);
            label8.TabIndex = 25;
            label8.Text = "Vers ion   2027";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerPause
            // 
            timerPause.Interval = 1000;
            timerPause.Tick += timerPause_Tick;
            // 
            // button4
            // 
            button4.Location = new Point(897, 633);
            button4.Name = "button4";
            button4.Size = new Size(53, 23);
            button4.TabIndex = 6;
            button4.Text = "Tıkla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // timerWalk
            // 
            timerWalk.Interval = 1000;
            timerWalk.Tick += timerWalk_Tick;
            // 
            // pictureBoxSettings
            // 
            pictureBoxSettings.BackColor = Color.Transparent;
            pictureBoxSettings.Cursor = Cursors.Hand;
            pictureBoxSettings.Image = Properties.Resources.settingsbutton1;
            pictureBoxSettings.Location = new Point(336, 198);
            pictureBoxSettings.Name = "pictureBoxSettings";
            pictureBoxSettings.Size = new Size(61, 53);
            pictureBoxSettings.TabIndex = 26;
            pictureBoxSettings.TabStop = false;
            pictureBoxSettings.Click += pictureBox8_Click;
            // 
            // groupBoxSettings
            // 
            groupBoxSettings.BackColor = Color.Transparent;
            groupBoxSettings.Controls.Add(menuStrip1);
            groupBoxSettings.Controls.Add(panelSoundSettings);
            groupBoxSettings.Controls.Add(panelPathFinder);
            groupBoxSettings.Controls.Add(label38);
            groupBoxSettings.Location = new Point(15, 133);
            groupBoxSettings.Name = "groupBoxSettings";
            groupBoxSettings.Size = new Size(331, 450);
            groupBoxSettings.TabIndex = 27;
            groupBoxSettings.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("HoloLens MDL2 Assets", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pathFinderToolStripMenuItem, sesAyarlarıToolStripMenuItem });
            menuStrip1.Location = new Point(48, 41);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(215, 24);
            menuStrip1.TabIndex = 27;
            menuStrip1.Text = "menuStrip1";
            // 
            // pathFinderToolStripMenuItem
            // 
            pathFinderToolStripMenuItem.Name = "pathFinderToolStripMenuItem";
            pathFinderToolStripMenuItem.Size = new Size(123, 20);
            pathFinderToolStripMenuItem.Text = "PathFinder Ayarları";
            pathFinderToolStripMenuItem.Click += pathFinderToolStripMenuItem_Click;
            // 
            // sesAyarlarıToolStripMenuItem
            // 
            sesAyarlarıToolStripMenuItem.Name = "sesAyarlarıToolStripMenuItem";
            sesAyarlarıToolStripMenuItem.Size = new Size(84, 20);
            sesAyarlarıToolStripMenuItem.Text = "Ses Ayarları";
            sesAyarlarıToolStripMenuItem.Click += sesAyarlarıToolStripMenuItem_Click;
            // 
            // panelSoundSettings
            // 
            panelSoundSettings.BackColor = Color.Transparent;
            panelSoundSettings.Controls.Add(label25);
            panelSoundSettings.Controls.Add(label24);
            panelSoundSettings.Controls.Add(label17);
            panelSoundSettings.Controls.Add(label16);
            panelSoundSettings.Controls.Add(label15);
            panelSoundSettings.Controls.Add(label14);
            panelSoundSettings.Controls.Add(label13);
            panelSoundSettings.Controls.Add(comboBoxOutputDevices);
            panelSoundSettings.Controls.Add(labelSesSeviyesi);
            panelSoundSettings.Controls.Add(label4);
            panelSoundSettings.Controls.Add(textBox1);
            panelSoundSettings.Controls.Add(progressBarSoundLevel);
            panelSoundSettings.Location = new Point(0, 73);
            panelSoundSettings.Name = "panelSoundSettings";
            panelSoundSettings.Size = new Size(331, 377);
            panelSoundSettings.TabIndex = 30;
            panelSoundSettings.Visible = false;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(297, 175);
            label25.Name = "label25";
            label25.Size = new Size(25, 15);
            label25.TabIndex = 22;
            label25.Text = "100";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(4, 175);
            label24.Name = "label24";
            label24.Size = new Size(13, 15);
            label24.TabIndex = 21;
            label24.Text = "0";
            // 
            // label17
            // 
            label17.ForeColor = Color.IndianRed;
            label17.Location = new Point(7, 267);
            label17.Name = "label17";
            label17.Size = new Size(297, 71);
            label17.TabIndex = 20;
            label17.Text = "Maksimum performans için oyun ses seviyesini maximuımda tutmanız tavsiye edilir. ";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.ForeColor = Color.IndianRed;
            label16.Location = new Point(7, 75);
            label16.Name = "label16";
            label16.Size = new Size(297, 42);
            label16.TabIndex = 20;
            label16.Text = "Ses çıkış aygıtları kısmında sadece oyunun kullandığı ses çıkışını seçmeniz gerekmekte.";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.SteelBlue;
            label15.Location = new Point(4, 135);
            label15.Name = "label15";
            label15.Size = new Size(68, 15);
            label15.TabIndex = 19;
            label15.Text = "Ses Seviyesi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.SteelBlue;
            label14.Location = new Point(24, 32);
            label14.Name = "label14";
            label14.Size = new Size(95, 15);
            label14.TabIndex = 19;
            label14.Text = "Ses çıkış aygıtları";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 222);
            label13.Name = "label13";
            label13.Size = new Size(235, 15);
            label13.TabIndex = 19;
            label13.Text = "Balığın yoklanacağı ses seviyesi (Minimum)";
            // 
            // panelPathFinder
            // 
            panelPathFinder.BackColor = Color.Transparent;
            panelPathFinder.Controls.Add(comboBoxBalikSayisi);
            panelPathFinder.Controls.Add(button8);
            panelPathFinder.Controls.Add(button7);
            panelPathFinder.Controls.Add(label37);
            panelPathFinder.Controls.Add(label36);
            panelPathFinder.Controls.Add(button5);
            panelPathFinder.Controls.Add(button6);
            panelPathFinder.Controls.Add(label35);
            panelPathFinder.Controls.Add(label34);
            panelPathFinder.Controls.Add(label33);
            panelPathFinder.Controls.Add(label11);
            panelPathFinder.Controls.Add(label10);
            panelPathFinder.Controls.Add(comboBoxFishStop);
            panelPathFinder.Controls.Add(comboBoxBalikNoktalari);
            panelPathFinder.Controls.Add(comboBoxNoktalar);
            panelPathFinder.Controls.Add(comboBoxHaritalar);
            panelPathFinder.Controls.Add(button3);
            panelPathFinder.Controls.Add(pictureBox4);
            panelPathFinder.Controls.Add(pictureBox5);
            panelPathFinder.Location = new Point(0, 73);
            panelPathFinder.Name = "panelPathFinder";
            panelPathFinder.Size = new Size(331, 377);
            panelPathFinder.TabIndex = 26;
            panelPathFinder.Paint += panelPathFinder_Paint;
            // 
            // comboBoxBalikSayisi
            // 
            comboBoxBalikSayisi.BackColor = Color.Tan;
            comboBoxBalikSayisi.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBalikSayisi.FlatStyle = FlatStyle.Flat;
            comboBoxBalikSayisi.FormattingEnabled = true;
            comboBoxBalikSayisi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxBalikSayisi.Location = new Point(136, 253);
            comboBoxBalikSayisi.Name = "comboBoxBalikSayisi";
            comboBoxBalikSayisi.Size = new Size(45, 23);
            comboBoxBalikSayisi.TabIndex = 28;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.minus_button;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(234, 43);
            button8.Name = "button8";
            button8.Size = new Size(25, 23);
            button8.TabIndex = 27;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.more;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(203, 43);
            button7.Name = "button7";
            button7.Size = new Size(25, 23);
            button7.TabIndex = 27;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label37
            // 
            label37.ForeColor = Color.IndianRed;
            label37.Location = new Point(14, 278);
            label37.Name = "label37";
            label37.Size = new Size(297, 48);
            label37.TabIndex = 20;
            label37.Text = "Belirtilen yerde durduktan sonra kaç defa olta atılacağını belirleyen alan. Bittiğinde rotaya devam edecektir.";
            label37.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            label36.ForeColor = Color.IndianRed;
            label36.Location = new Point(14, 197);
            label36.Name = "label36";
            label36.Size = new Size(297, 42);
            label36.TabIndex = 20;
            label36.Text = "Karakterin hangi konuma geldiğinde balık tutmak için duracağını belirleyen alan";
            label36.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(183, 329);
            button5.Name = "button5";
            button5.Size = new Size(107, 23);
            button5.TabIndex = 24;
            button5.Text = "Balık noktasi";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.minus_button;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(234, 85);
            button6.Name = "button6";
            button6.Size = new Size(25, 22);
            button6.TabIndex = 6;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.ForeColor = Color.SteelBlue;
            label35.Location = new Point(128, 237);
            label35.Name = "label35";
            label35.Size = new Size(61, 15);
            label35.TabIndex = 5;
            label35.Text = "Olta Sayısı";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.ForeColor = Color.SteelBlue;
            label34.Location = new Point(34, 154);
            label34.Name = "label34";
            label34.Size = new Size(142, 15);
            label34.TabIndex = 5;
            label34.Text = "Olta Atılacak Koordinatlar";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.ForeColor = Color.SteelBlue;
            label33.Location = new Point(34, 111);
            label33.Name = "label33";
            label33.Size = new Size(198, 15);
            label33.TabIndex = 5;
            label33.Text = "Balık Tutmak için durulacak noktalar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.SteelBlue;
            label11.Location = new Point(34, 68);
            label11.Name = "label11";
            label11.Size = new Size(155, 15);
            label11.TabIndex = 5;
            label11.Text = "Kayıtlı Yürüyüş koordinatları";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.SteelBlue;
            label10.Location = new Point(34, 26);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 4;
            label10.Text = "Kayıt İsmi";
            // 
            // comboBoxFishStop
            // 
            comboBoxFishStop.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFishStop.FormattingEnabled = true;
            comboBoxFishStop.Location = new Point(34, 169);
            comboBoxFishStop.Name = "comboBoxFishStop";
            comboBoxFishStop.Size = new Size(168, 23);
            comboBoxFishStop.TabIndex = 3;
            // 
            // comboBoxBalikNoktalari
            // 
            comboBoxBalikNoktalari.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBalikNoktalari.FormattingEnabled = true;
            comboBoxBalikNoktalari.Location = new Point(34, 129);
            comboBoxBalikNoktalari.Name = "comboBoxBalikNoktalari";
            comboBoxBalikNoktalari.Size = new Size(168, 23);
            comboBoxBalikNoktalari.TabIndex = 3;
            // 
            // comboBoxNoktalar
            // 
            comboBoxNoktalar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNoktalar.Location = new Point(34, 84);
            comboBoxNoktalar.Name = "comboBoxNoktalar";
            comboBoxNoktalar.Size = new Size(168, 23);
            comboBoxNoktalar.TabIndex = 3;
            comboBoxNoktalar.SelectedIndexChanged += comboBoxNoktalar_SelectedIndexChanged;
            // 
            // comboBoxHaritalar
            // 
            comboBoxHaritalar.FormattingEnabled = true;
            comboBoxHaritalar.Location = new Point(34, 43);
            comboBoxHaritalar.Name = "comboBoxHaritalar";
            comboBoxHaritalar.Size = new Size(168, 23);
            comboBoxHaritalar.TabIndex = 2;
            comboBoxHaritalar.SelectedIndexChanged += comboBoxHaritalar_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(85, 329);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Devam Et";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.more;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(205, 169);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            pictureBox4.Click += button5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.more;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Location = new Point(203, 85);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label38.Location = new Point(101, 16);
            label38.Name = "label38";
            label38.Size = new Size(118, 29);
            label38.TabIndex = 0;
            label38.Text = "Ayarlar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(1494, 96);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 25;
            label12.Text = "label12";
            // 
            // groupBoxLog
            // 
            groupBoxLog.BackColor = Color.Transparent;
            groupBoxLog.Controls.Add(textBoxLogSearch);
            groupBoxLog.Controls.Add(label26);
            groupBoxLog.Controls.Add(listBox1);
            groupBoxLog.Location = new Point(15, 133);
            groupBoxLog.Name = "groupBoxLog";
            groupBoxLog.Size = new Size(331, 450);
            groupBoxLog.TabIndex = 30;
            groupBoxLog.TabStop = false;
            groupBoxLog.Visible = false;
            // 
            // textBoxLogSearch
            // 
            textBoxLogSearch.BackColor = Color.Tan;
            textBoxLogSearch.BorderStyle = BorderStyle.None;
            textBoxLogSearch.Location = new Point(1, 22);
            textBoxLogSearch.Name = "textBoxLogSearch";
            textBoxLogSearch.Size = new Size(105, 16);
            textBoxLogSearch.TabIndex = 20;
            textBoxLogSearch.Text = "Search";
            textBoxLogSearch.TextAlign = HorizontalAlignment.Center;
            textBoxLogSearch.TextChanged += textBoxLogSearch_TextChanged;
            textBoxLogSearch.Enter += textBoxLogSearch_Enter;
            textBoxLogSearch.Leave += textBoxLogSearch_Leave;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label26.Location = new Point(129, 17);
            label26.Name = "label26";
            label26.Size = new Size(58, 29);
            label26.TabIndex = 19;
            label26.Text = "Log";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Tan;
            listBox1.ForeColor = SystemColors.ControlText;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(331, 394);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.ControlAdded += listBox1_ControlAdded;
            // 
            // pictureBoxLog
            // 
            pictureBoxLog.BackColor = Color.Transparent;
            pictureBoxLog.Cursor = Cursors.Hand;
            pictureBoxLog.Image = Properties.Resources.Menu_Button_removebg_preview;
            pictureBoxLog.Location = new Point(343, 259);
            pictureBoxLog.Name = "pictureBoxLog";
            pictureBoxLog.Size = new Size(52, 63);
            pictureBoxLog.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLog.TabIndex = 28;
            pictureBoxLog.TabStop = false;
            pictureBoxLog.Click += pictureBox9_Click;
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.BackColor = Color.Transparent;
            pictureBoxMain.Cursor = Cursors.Hand;
            pictureBoxMain.Image = Properties.Resources.Menu_Button_removebg_preview;
            pictureBoxMain.Location = new Point(346, 134);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(52, 63);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMain.TabIndex = 29;
            pictureBoxMain.TabStop = false;
            pictureBoxMain.Click += pictureBoxMain_Click;
            // 
            // timerCurrentTime
            // 
            timerCurrentTime.Enabled = true;
            timerCurrentTime.Interval = 1000;
            timerCurrentTime.Tick += timerCurrentTime_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(15, 586);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(332, 15);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Magenta;
            BackgroundImage = Properties.Resources.result__1_2;
            ClientSize = new Size(399, 700);
            Controls.Add(panelAnasayfa);
            Controls.Add(progressBar1);
            Controls.Add(pictureBoxMain);
            Controls.Add(pictureBoxLog);
            Controls.Add(label12);
            Controls.Add(button4);
            Controls.Add(labelStatus);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(pictureBoxSettings);
            Controls.Add(label8);
            Controls.Add(groupBoxSettings);
            Controls.Add(groupBoxLog);
            Controls.Add(pictureBox1);
            Controls.Add(labelFish);
            Controls.Add(label2);
            Controls.Add(labelDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Captain Hook";
            FormClosing += Form1_FormClosing_1;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            MouseClick += Form1_MouseClick;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelAnasayfa.ResumeLayout(false);
            panelAnasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSettings).EndInit();
            groupBoxSettings.ResumeLayout(false);
            groupBoxSettings.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelSoundSettings.ResumeLayout(false);
            panelSoundSettings.PerformLayout();
            panelPathFinder.ResumeLayout(false);
            panelPathFinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            groupBoxLog.ResumeLayout(false);
            groupBoxLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerFishBar;
        private System.Windows.Forms.Timer timerReeling;
        private Label labelFish;
        private Button Start;
        private ComboBox comboBoxOutputDevices;
        private ProgressBar progressBarSoundLevel;
        private System.Windows.Forms.Timer timerSoundcheck;
        private Label labelCoordinate;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label labelOltadakiSure;
        private System.Windows.Forms.Timer timerAudio;
        private Label label4;
        private Label labelSesSeviyesi;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panelAnasayfa;
        private Label labelDate;
        private System.Windows.Forms.Timer timerPause;
        private Label labelPause;
        private Label label8;
        private Button button4;
        private System.Windows.Forms.Timer timerWalk;
        public Label labelStatus;
        private CheckBox Pathfinder;
        private PictureBox pictureBoxSettings;
        private GroupBox groupBoxSettings;
        private Panel panelPathFinder;
        private ComboBox comboBoxBalikSayisi;
        private Button button8;
        private Button button7;
        private Label label12;
        private Button button5;
        private Button button6;
        private Label label11;
        private Label label10;
        private ComboBox comboBoxFishStop;
        private ComboBox comboBoxBalikNoktalari;
        private ComboBox comboBoxNoktalar;
        private ComboBox comboBoxHaritalar;
        private Button button3;
        private PictureBox pictureBox4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pathFinderToolStripMenuItem;
        private PictureBox pictureBoxLog;
        private PictureBox pictureBoxMain;
        private GroupBox groupBoxLog;
        private ListBox listBox1;
        private ToolStripMenuItem sesAyarlarıToolStripMenuItem;
        private Panel panelSoundSettings;
        private Label label13;
        private Label label15;
        private Label label14;
        private Label label17;
        private Label label16;
        private Label labelToplamOlta;
        private Label label18;
        private Label label21;
        private Label labelCurrentTime;
        private Label label19;
        private Button buttonFishingBait;
        private Button buttonSeaweedSalad;
        private Label label23;
        private Label label22;
        private Label label25;
        private Label label24;
        private TextBox textBoxLogSearch;
        private Label label26;
        private System.Windows.Forms.Timer timerCurrentTime;
        private ProgressBar progressBar1;
        private Label label28;
        private Label label27;
        private Label label1;
        private TextBox textBoxZamanlayiciMN;
        private TextBox textBoxZamanlayiciHR;
        private Label label29;
        private CheckBox checkBoxZamanlayici;
        private Label label30;
        private Label label31;
        private TextBox textBoxOltaMaxSuresi;
        private TextBox textBoxOltaAraSuresi;
        private Label label20;
        private Label label32;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label37;
        private Label label38;
        private PictureBox pictureBox5;
    }
}
