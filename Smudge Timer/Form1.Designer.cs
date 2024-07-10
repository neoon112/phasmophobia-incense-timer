
namespace Smudge_Timer
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
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.colon = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.lblMs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpiritRed = new System.Windows.Forms.Label();
            this.lblRegularRed = new System.Windows.Forms.Label();
            this.lblDemonRed = new System.Windows.Forms.Label();
            this.lblDemonGreen = new System.Windows.Forms.Label();
            this.labalTimers = new System.Windows.Forms.Timer(this.components);
            this.lblRegularGreen = new System.Windows.Forms.Label();
            this.lblSpiritGreen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimiseBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.questionLbl = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.smudgedatLbl = new System.Windows.Forms.Label();
            this.settingsTimer = new System.Windows.Forms.Timer(this.components);
            this.minutesLbl = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.Colon2 = new System.Windows.Forms.Label();
            this.resetButton2 = new RoundedButton();
            this.smudgedButton = new RoundedButton();
            this.roundedButton1 = new RoundedButton();
            this.button4 = new RoundedButton();
            this.button1 = new RoundedButton();
            this.button3 = new RoundedButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMinutes.Location = new System.Drawing.Point(268, 92);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(67, 54);
            this.lblMinutes.TabIndex = 0;
            this.lblMinutes.Text = "00";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeconds.Location = new System.Drawing.Point(343, 92);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(67, 54);
            this.lblSeconds.TabIndex = 1;
            this.lblSeconds.Text = "00";
            // 
            // colon
            // 
            this.colon.AutoSize = true;
            this.colon.BackColor = System.Drawing.Color.Transparent;
            this.colon.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon.ForeColor = System.Drawing.SystemColors.Control;
            this.colon.Location = new System.Drawing.Point(324, 89);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(32, 54);
            this.colon.TabIndex = 2;
            this.colon.Text = ":";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1;
            this.clockTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMs
            // 
            this.lblMs.AutoSize = true;
            this.lblMs.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMs.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMs.Location = new System.Drawing.Point(415, 101);
            this.lblMs.Name = "lblMs";
            this.lblMs.Size = new System.Drawing.Size(52, 42);
            this.lblMs.TabIndex = 7;
            this.lblMs.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(399, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = ".";
            // 
            // lblSpiritRed
            // 
            this.lblSpiritRed.AutoSize = true;
            this.lblSpiritRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblSpiritRed.Font = new System.Drawing.Font("Nirmala UI Semilight", 18.25F);
            this.lblSpiritRed.ForeColor = System.Drawing.Color.Red;
            this.lblSpiritRed.Location = new System.Drawing.Point(47, 138);
            this.lblSpiritRed.Name = "lblSpiritRed";
            this.lblSpiritRed.Size = new System.Drawing.Size(70, 35);
            this.lblSpiritRed.TabIndex = 9;
            this.lblSpiritRed.Text = "Spirit";
            // 
            // lblRegularRed
            // 
            this.lblRegularRed.AutoSize = true;
            this.lblRegularRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblRegularRed.Font = new System.Drawing.Font("Nirmala UI Semilight", 18.25F);
            this.lblRegularRed.ForeColor = System.Drawing.Color.Red;
            this.lblRegularRed.Location = new System.Drawing.Point(49, 96);
            this.lblRegularRed.Name = "lblRegularRed";
            this.lblRegularRed.Size = new System.Drawing.Size(96, 35);
            this.lblRegularRed.TabIndex = 10;
            this.lblRegularRed.Text = "Regular";
            // 
            // lblDemonRed
            // 
            this.lblDemonRed.AutoSize = true;
            this.lblDemonRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblDemonRed.Font = new System.Drawing.Font("Nirmala UI Semilight", 18.25F);
            this.lblDemonRed.ForeColor = System.Drawing.Color.Red;
            this.lblDemonRed.Location = new System.Drawing.Point(49, 58);
            this.lblDemonRed.Name = "lblDemonRed";
            this.lblDemonRed.Size = new System.Drawing.Size(94, 35);
            this.lblDemonRed.TabIndex = 11;
            this.lblDemonRed.Text = "Demon";
            // 
            // lblDemonGreen
            // 
            this.lblDemonGreen.AutoSize = true;
            this.lblDemonGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblDemonGreen.Font = new System.Drawing.Font("Nirmala UI Semilight", 18.25F);
            this.lblDemonGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDemonGreen.Location = new System.Drawing.Point(49, 58);
            this.lblDemonGreen.Name = "lblDemonGreen";
            this.lblDemonGreen.Size = new System.Drawing.Size(94, 35);
            this.lblDemonGreen.TabIndex = 12;
            this.lblDemonGreen.Text = "Demon";
            // 
            // labalTimers
            // 
            this.labalTimers.Enabled = true;
            this.labalTimers.Interval = 10;
            this.labalTimers.Tick += new System.EventHandler(this.labalTimers_Tick);
            // 
            // lblRegularGreen
            // 
            this.lblRegularGreen.AutoSize = true;
            this.lblRegularGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblRegularGreen.Font = new System.Drawing.Font("Nirmala UI Semilight", 18.25F);
            this.lblRegularGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRegularGreen.Location = new System.Drawing.Point(49, 96);
            this.lblRegularGreen.Name = "lblRegularGreen";
            this.lblRegularGreen.Size = new System.Drawing.Size(96, 35);
            this.lblRegularGreen.TabIndex = 13;
            this.lblRegularGreen.Text = "Regular";
            // 
            // lblSpiritGreen
            // 
            this.lblSpiritGreen.AutoSize = true;
            this.lblSpiritGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblSpiritGreen.Font = new System.Drawing.Font("Nirmala UI Semilight", 18.25F);
            this.lblSpiritGreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSpiritGreen.Location = new System.Drawing.Point(47, 138);
            this.lblSpiritGreen.Name = "lblSpiritGreen";
            this.lblSpiritGreen.Size = new System.Drawing.Size(70, 35);
            this.lblSpiritGreen.TabIndex = 14;
            this.lblSpiritGreen.Text = "Spirit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.minimiseBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 53);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // minimiseBtn
            // 
            this.minimiseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.minimiseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimiseBtn.FlatAppearance.BorderSize = 0;
            this.minimiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseBtn.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiseBtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.minimiseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimiseBtn.Location = new System.Drawing.Point(483, 10);
            this.minimiseBtn.Name = "minimiseBtn";
            this.minimiseBtn.Size = new System.Drawing.Size(38, 36);
            this.minimiseBtn.TabIndex = 16;
            this.minimiseBtn.Text = "-";
            this.minimiseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimiseBtn.UseVisualStyleBackColor = false;
            this.minimiseBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.closeBtn.Location = new System.Drawing.Point(518, 10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 36);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "x";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incense Timer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.questionLbl);
            this.panel2.Controls.Add(this.ad);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblDemonGreen);
            this.panel2.Controls.Add(this.lblSpiritGreen);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblSpiritRed);
            this.panel2.Controls.Add(this.lblDemonRed);
            this.panel2.Controls.Add(this.lblRegularGreen);
            this.panel2.Controls.Add(this.lblRegularRed);
            this.panel2.Location = new System.Drawing.Point(-3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 218);
            this.panel2.TabIndex = 19;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this.questionLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.questionLbl.Location = new System.Drawing.Point(149, 10);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(19, 21);
            this.questionLbl.TabIndex = 19;
            this.questionLbl.Text = "?";
            this.questionLbl.Click += new System.EventHandler(this.questionLbl_Click);
            // 
            // ad
            // 
            this.ad.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.ad.AutoSize = true;
            this.ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ad.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.ad.Location = new System.Drawing.Point(8, 185);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(134, 13);
            this.ad.TabIndex = 17;
            this.ad.TabStop = true;
            this.ad.Text = "Scratchamophobia.com.au";
            this.ad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ad_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI Semilight", 5.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(35, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 10);
            this.label6.TabIndex = 18;
            this.label6.Text = "⚫";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI Semilight", 5.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(35, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 10);
            this.label5.TabIndex = 17;
            this.label5.Text = "⚫";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 5.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(35, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 10);
            this.label4.TabIndex = 16;
            this.label4.Text = "⚫";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 23.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 42);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ghosts";
            // 
            // smudgedatLbl
            // 
            this.smudgedatLbl.AutoSize = true;
            this.smudgedatLbl.Font = new System.Drawing.Font("Nirmala UI Semilight", 13F);
            this.smudgedatLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.smudgedatLbl.Location = new System.Drawing.Point(279, 140);
            this.smudgedatLbl.Name = "smudgedatLbl";
            this.smudgedatLbl.Size = new System.Drawing.Size(178, 25);
            this.smudgedatLbl.TabIndex = 21;
            this.smudgedatLbl.Text = "Smudged At: 00m:00s";
            // 
            // settingsTimer
            // 
            this.settingsTimer.Enabled = true;
            this.settingsTimer.Tick += new System.EventHandler(this.topmosttimer_Tick);
            // 
            // minutesLbl
            // 
            this.minutesLbl.AutoSize = true;
            this.minutesLbl.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.minutesLbl.Location = new System.Drawing.Point(274, 86);
            this.minutesLbl.Name = "minutesLbl";
            this.minutesLbl.Size = new System.Drawing.Size(67, 54);
            this.minutesLbl.TabIndex = 25;
            this.minutesLbl.Text = "00";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSeconds.Location = new System.Drawing.Point(390, 86);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(67, 54);
            this.labelSeconds.TabIndex = 26;
            this.labelSeconds.Text = "00";
            // 
            // Colon2
            // 
            this.Colon2.AutoSize = true;
            this.Colon2.BackColor = System.Drawing.Color.Transparent;
            this.Colon2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colon2.ForeColor = System.Drawing.SystemColors.Control;
            this.Colon2.Location = new System.Drawing.Point(365, 85);
            this.Colon2.Name = "Colon2";
            this.Colon2.Size = new System.Drawing.Size(32, 54);
            this.Colon2.TabIndex = 27;
            this.Colon2.Text = ":";
            // 
            // resetButton2
            // 
            this.resetButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.resetButton2.CornerRadius = 20;
            this.resetButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton2.FlatAppearance.BorderSize = 0;
            this.resetButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton2.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F);
            this.resetButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.resetButton2.Location = new System.Drawing.Point(386, 182);
            this.resetButton2.Name = "resetButton2";
            this.resetButton2.Size = new System.Drawing.Size(113, 32);
            this.resetButton2.TabIndex = 24;
            this.resetButton2.Text = "Reset (F8)";
            this.resetButton2.UseVisualStyleBackColor = false;
            this.resetButton2.Click += new System.EventHandler(this.resetButton2_Click);
            // 
            // smudgedButton
            // 
            this.smudgedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.smudgedButton.CornerRadius = 20;
            this.smudgedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smudgedButton.FlatAppearance.BorderSize = 0;
            this.smudgedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smudgedButton.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F);
            this.smudgedButton.ForeColor = System.Drawing.SystemColors.Control;
            this.smudgedButton.Location = new System.Drawing.Point(256, 182);
            this.smudgedButton.Name = "smudgedButton";
            this.smudgedButton.Size = new System.Drawing.Size(113, 32);
            this.smudgedButton.TabIndex = 23;
            this.smudgedButton.Text = "Smudged (F6)";
            this.smudgedButton.UseVisualStyleBackColor = false;
            this.smudgedButton.Click += new System.EventHandler(this.smudgedButton_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))));
            this.roundedButton1.CornerRadius = 10;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.25F);
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.roundedButton1.Location = new System.Drawing.Point(489, 53);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(75, 30);
            this.roundedButton1.TabIndex = 22;
            this.roundedButton1.Text = "Settings";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.button4.CornerRadius = 20;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(385, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "Reset (F8)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.button1.CornerRadius = 20;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(253, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Start (F6)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.button3.CornerRadius = 20;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(253, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Stop (F7)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(565, 254);
            this.Controls.Add(this.Colon2);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.minutesLbl);
            this.Controls.Add(this.resetButton2);
            this.Controls.Add(this.smudgedButton);
            this.Controls.Add(this.smudgedatLbl);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMs);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Smudge Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label colon;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label lblMs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSpiritRed;
        private System.Windows.Forms.Label lblRegularRed;
        private System.Windows.Forms.Label lblDemonRed;
        private System.Windows.Forms.Label lblDemonGreen;
        private System.Windows.Forms.Timer labalTimers;
        private System.Windows.Forms.Label lblRegularGreen;
        private System.Windows.Forms.Label lblSpiritGreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minimiseBtn;
        private RoundedButton button3;
        private RoundedButton button1;
        private RoundedButton button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel ad;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label smudgedatLbl;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Timer settingsTimer;
        private RoundedButton smudgedButton;
        private RoundedButton resetButton2;
        private System.Windows.Forms.Label minutesLbl;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label Colon2;
    }
}

