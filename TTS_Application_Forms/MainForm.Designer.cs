
namespace TTS_Application_Forms
{
    partial class MainForm
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
			this.panelMain = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelSoundMute = new System.Windows.Forms.Panel();
			this.panelVoiceMute = new System.Windows.Forms.Panel();
			this.panelOpenSettings = new System.Windows.Forms.Panel();
			this.trackBarVoiceVolume = new System.Windows.Forms.TrackBar();
			this.trackBarSoundVolume = new System.Windows.Forms.TrackBar();
			this.textBoxTargetText = new System.Windows.Forms.TextBox();
			this.buttonPlaySound = new System.Windows.Forms.Button();
			this.panelTop = new System.Windows.Forms.Panel();
			this.labelFormName = new System.Windows.Forms.Label();
			this.buttonMinimze = new System.Windows.Forms.Button();
			this.buttonCloseWindow = new System.Windows.Forms.Button();
			this.panelMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVoiceVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarSoundVolume)).BeginInit();
			this.panelTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			this.panelMain.Controls.Add(this.panel1);
			this.panelMain.Controls.Add(this.pictureBox1);
			this.panelMain.Controls.Add(this.panelSoundMute);
			this.panelMain.Controls.Add(this.panelVoiceMute);
			this.panelMain.Controls.Add(this.panelOpenSettings);
			this.panelMain.Controls.Add(this.trackBarVoiceVolume);
			this.panelMain.Controls.Add(this.trackBarSoundVolume);
			this.panelMain.Controls.Add(this.textBoxTargetText);
			this.panelMain.Controls.Add(this.buttonPlaySound);
			this.panelMain.Controls.Add(this.panelTop);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(448, 242);
			this.panelMain.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::TTS_Application_Forms.Properties.Resources.enter_gray;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new System.Drawing.Point(426, 197);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(20, 20);
			this.panel1.TabIndex = 7;
			this.panel1.Click += new System.EventHandler(this.panel1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = global::TTS_Application_Forms.Properties.Resources.Playing_60_483;
			this.pictureBox1.Location = new System.Drawing.Point(241, 193);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(35, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// panelSoundMute
			// 
			this.panelSoundMute.BackgroundImage = global::TTS_Application_Forms.Properties.Resources.headphones;
			this.panelSoundMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelSoundMute.Location = new System.Drawing.Point(305, 50);
			this.panelSoundMute.Name = "panelSoundMute";
			this.panelSoundMute.Size = new System.Drawing.Size(30, 30);
			this.panelSoundMute.TabIndex = 7;
			this.panelSoundMute.Click += new System.EventHandler(this.panelSoundMute_Click);
			// 
			// panelVoiceMute
			// 
			this.panelVoiceMute.BackgroundImage = global::TTS_Application_Forms.Properties.Resources.robot;
			this.panelVoiceMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelVoiceMute.Location = new System.Drawing.Point(165, 50);
			this.panelVoiceMute.Name = "panelVoiceMute";
			this.panelVoiceMute.Size = new System.Drawing.Size(30, 30);
			this.panelVoiceMute.TabIndex = 6;
			this.panelVoiceMute.Click += new System.EventHandler(this.panelVoiceMute_Click);
			// 
			// panelOpenSettings
			// 
			this.panelOpenSettings.BackgroundImage = global::TTS_Application_Forms.Properties.Resources.menu;
			this.panelOpenSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelOpenSettings.Location = new System.Drawing.Point(9, 32);
			this.panelOpenSettings.Name = "panelOpenSettings";
			this.panelOpenSettings.Size = new System.Drawing.Size(26, 26);
			this.panelOpenSettings.TabIndex = 5;
			this.panelOpenSettings.Click += new System.EventHandler(this.panelOpenSettings_Click);
			// 
			// trackBarVoiceVolume
			// 
			this.trackBarVoiceVolume.LargeChange = 3;
			this.trackBarVoiceVolume.Location = new System.Drawing.Point(191, 50);
			this.trackBarVoiceVolume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.trackBarVoiceVolume.Name = "trackBarVoiceVolume";
			this.trackBarVoiceVolume.Size = new System.Drawing.Size(89, 45);
			this.trackBarVoiceVolume.TabIndex = 0;
			this.trackBarVoiceVolume.TabStop = false;
			this.trackBarVoiceVolume.ValueChanged += new System.EventHandler(this.trackBarVoiceVolume_ValueChanged);
			this.trackBarVoiceVolume.MouseCaptureChanged += new System.EventHandler(this.trackBarVoiceVolume_MouseCaptureChanged);
			// 
			// trackBarSoundVolume
			// 
			this.trackBarSoundVolume.LargeChange = 3;
			this.trackBarSoundVolume.Location = new System.Drawing.Point(331, 50);
			this.trackBarSoundVolume.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.trackBarSoundVolume.Name = "trackBarSoundVolume";
			this.trackBarSoundVolume.Size = new System.Drawing.Size(89, 45);
			this.trackBarSoundVolume.TabIndex = 0;
			this.trackBarSoundVolume.TabStop = false;
			this.trackBarSoundVolume.ValueChanged += new System.EventHandler(this.trackBarSoundVolume_ValueChanged);
			this.trackBarSoundVolume.MouseCaptureChanged += new System.EventHandler(this.trackBarSoundVolume_MouseCaptureChanged);
			// 
			// textBoxTargetText
			// 
			this.textBoxTargetText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
			this.textBoxTargetText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTargetText.Font = new System.Drawing.Font("JetBrains Mono", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxTargetText.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textBoxTargetText.Location = new System.Drawing.Point(26, 102);
			this.textBoxTargetText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBoxTargetText.Multiline = true;
			this.textBoxTargetText.Name = "textBoxTargetText";
			this.textBoxTargetText.Size = new System.Drawing.Size(396, 69);
			this.textBoxTargetText.TabIndex = 1;
			this.textBoxTargetText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTargetText_KeyDown);
			this.textBoxTargetText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTargetText_KeyPress);
			this.textBoxTargetText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxTargetText_KeyUp);
			// 
			// buttonPlaySound
			// 
			this.buttonPlaySound.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonPlaySound.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonPlaySound.FlatAppearance.BorderSize = 0;
			this.buttonPlaySound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPlaySound.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonPlaySound.ForeColor = System.Drawing.Color.White;
			this.buttonPlaySound.Location = new System.Drawing.Point(278, 193);
			this.buttonPlaySound.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonPlaySound.Name = "buttonPlaySound";
			this.buttonPlaySound.Size = new System.Drawing.Size(146, 30);
			this.buttonPlaySound.TabIndex = 0;
			this.buttonPlaySound.TabStop = false;
			this.buttonPlaySound.Text = "Play Record";
			this.buttonPlaySound.UseVisualStyleBackColor = false;
			this.buttonPlaySound.Click += new System.EventHandler(this.buttonPlaySound_Click);
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
			this.panelTop.Controls.Add(this.labelFormName);
			this.panelTop.Controls.Add(this.buttonMinimze);
			this.panelTop.Controls.Add(this.buttonCloseWindow);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(448, 24);
			this.panelTop.TabIndex = 0;
			this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
			this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
			// 
			// labelFormName
			// 
			this.labelFormName.AutoSize = true;
			this.labelFormName.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelFormName.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelFormName.Location = new System.Drawing.Point(3, 2);
			this.labelFormName.Name = "labelFormName";
			this.labelFormName.Size = new System.Drawing.Size(108, 19);
			this.labelFormName.TabIndex = 2;
			this.labelFormName.Text = "Application";
			this.labelFormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFormName_MouseDown);
			this.labelFormName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelFormName_MouseMove);
			// 
			// buttonMinimze
			// 
			this.buttonMinimze.BackgroundImage = global::TTS_Application_Forms.Properties.Resources.minimize_gray;
			this.buttonMinimze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonMinimze.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonMinimze.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
			this.buttonMinimze.FlatAppearance.BorderSize = 5;
			this.buttonMinimze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(105)))), ((int)(((byte)(109)))));
			this.buttonMinimze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(105)))), ((int)(((byte)(109)))));
			this.buttonMinimze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMinimze.Location = new System.Drawing.Point(400, 0);
			this.buttonMinimze.Name = "buttonMinimze";
			this.buttonMinimze.Size = new System.Drawing.Size(24, 24);
			this.buttonMinimze.TabIndex = 1;
			this.buttonMinimze.TabStop = false;
			this.buttonMinimze.UseVisualStyleBackColor = true;
			this.buttonMinimze.Click += new System.EventHandler(this.buttonMinimze_Click);
			this.buttonMinimze.MouseEnter += new System.EventHandler(this.buttonMinimze_MouseEnter);
			this.buttonMinimze.MouseLeave += new System.EventHandler(this.buttonMinimze_MouseLeave);
			// 
			// buttonCloseWindow
			// 
			this.buttonCloseWindow.BackgroundImage = global::TTS_Application_Forms.Properties.Resources.close_gray;
			this.buttonCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonCloseWindow.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonCloseWindow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
			this.buttonCloseWindow.FlatAppearance.BorderSize = 5;
			this.buttonCloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.buttonCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
			this.buttonCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCloseWindow.Location = new System.Drawing.Point(424, 0);
			this.buttonCloseWindow.Name = "buttonCloseWindow";
			this.buttonCloseWindow.Size = new System.Drawing.Size(24, 24);
			this.buttonCloseWindow.TabIndex = 0;
			this.buttonCloseWindow.TabStop = false;
			this.buttonCloseWindow.UseVisualStyleBackColor = true;
			this.buttonCloseWindow.Click += new System.EventHandler(this.buttonCloseWindow_Click);
			this.buttonCloseWindow.MouseEnter += new System.EventHandler(this.buttonCloseWindow_MouseEnter);
			this.buttonCloseWindow.MouseLeave += new System.EventHandler(this.buttonCloseWindow_MouseLeave);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 242);
			this.Controls.Add(this.panelMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarVoiceVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarSoundVolume)).EndInit();
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textBoxTargetText;
        private System.Windows.Forms.Button buttonPlaySound;
        private System.Windows.Forms.TrackBar trackBarSoundVolume;
        private System.Windows.Forms.TrackBar trackBarVoiceVolume;
        private System.Windows.Forms.Button buttonCloseWindow;
        private System.Windows.Forms.Button buttonMinimze;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Panel panelOpenSettings;
        private System.Windows.Forms.Panel panelVoiceMute;
        private System.Windows.Forms.Panel panelSoundMute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}