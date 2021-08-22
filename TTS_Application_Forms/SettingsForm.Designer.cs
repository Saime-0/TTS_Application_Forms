
namespace TTS_Application_Forms
{
    partial class SettingsForm
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
            this.buttonCancelSettings = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.comboBoxOutputDevice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDemoOutput = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmotion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelFormName = new System.Windows.Forms.Label();
            this.comboBoxVoice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMain.Controls.Add(this.buttonCancelSettings);
            this.panelMain.Controls.Add(this.buttonSaveSettings);
            this.panelMain.Controls.Add(this.comboBoxOutputDevice);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.comboBoxDemoOutput);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.trackBarSpeed);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.comboBoxEmotion);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Controls.Add(this.comboBoxVoice);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(305, 332);
            this.panelMain.TabIndex = 0;
            // 
            // buttonCancelSettings
            // 
            this.buttonCancelSettings.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCancelSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancelSettings.FlatAppearance.BorderSize = 0;
            this.buttonCancelSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelSettings.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelSettings.ForeColor = System.Drawing.Color.White;
            this.buttonCancelSettings.Location = new System.Drawing.Point(23, 284);
            this.buttonCancelSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancelSettings.Name = "buttonCancelSettings";
            this.buttonCancelSettings.Size = new System.Drawing.Size(124, 29);
            this.buttonCancelSettings.TabIndex = 14;
            this.buttonCancelSettings.TabStop = false;
            this.buttonCancelSettings.Text = "Cancel";
            this.buttonCancelSettings.UseVisualStyleBackColor = false;
            this.buttonCancelSettings.Click += new System.EventHandler(this.buttonCancelSettings_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSaveSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSaveSettings.FlatAppearance.BorderSize = 0;
            this.buttonSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveSettings.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSaveSettings.Location = new System.Drawing.Point(159, 284);
            this.buttonSaveSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(124, 29);
            this.buttonSaveSettings.TabIndex = 13;
            this.buttonSaveSettings.TabStop = false;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.UseVisualStyleBackColor = false;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // comboBoxOutputDevice
            // 
            this.comboBoxOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOutputDevice.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOutputDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.comboBoxOutputDevice.FormattingEnabled = true;
            this.comboBoxOutputDevice.Location = new System.Drawing.Point(153, 230);
            this.comboBoxOutputDevice.Name = "comboBoxOutputDevice";
            this.comboBoxOutputDevice.Size = new System.Drawing.Size(135, 24);
            this.comboBoxOutputDevice.TabIndex = 12;
            this.comboBoxOutputDevice.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(18, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Output Device";
            // 
            // comboBoxDemoOutput
            // 
            this.comboBoxDemoOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDemoOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDemoOutput.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDemoOutput.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxDemoOutput.FormattingEnabled = true;
            this.comboBoxDemoOutput.Location = new System.Drawing.Point(153, 182);
            this.comboBoxDemoOutput.Name = "comboBoxDemoOutput";
            this.comboBoxDemoOutput.Size = new System.Drawing.Size(135, 24);
            this.comboBoxDemoOutput.TabIndex = 10;
            this.comboBoxDemoOutput.TabStop = false;
            this.comboBoxDemoOutput.SelectedValueChanged += new System.EventHandler(this.comboBoxDemoOutput_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(18, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Demo Output";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 3;
            this.trackBarSpeed.Location = new System.Drawing.Point(153, 137);
            this.trackBarSpeed.Maximum = 13;
            this.trackBarSpeed.Minimum = 7;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(135, 45);
            this.trackBarSpeed.TabIndex = 8;
            this.trackBarSpeed.TabStop = false;
            this.trackBarSpeed.Value = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speed";
            // 
            // comboBoxEmotion
            // 
            this.comboBoxEmotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmotion.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxEmotion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxEmotion.FormattingEnabled = true;
            this.comboBoxEmotion.Location = new System.Drawing.Point(153, 93);
            this.comboBoxEmotion.Name = "comboBoxEmotion";
            this.comboBoxEmotion.Size = new System.Drawing.Size(135, 24);
            this.comboBoxEmotion.TabIndex = 6;
            this.comboBoxEmotion.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(18, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emotion";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.panelTop.Controls.Add(this.labelFormName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(305, 24);
            this.panelTop.TabIndex = 4;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // labelFormName
            // 
            this.labelFormName.AutoSize = true;
            this.labelFormName.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFormName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelFormName.Location = new System.Drawing.Point(3, 3);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(81, 19);
            this.labelFormName.TabIndex = 0;
            this.labelFormName.Text = "Settings";
            this.labelFormName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFormName_MouseDown);
            this.labelFormName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelFormName_MouseMove);
            // 
            // comboBoxVoice
            // 
            this.comboBoxVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxVoice.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxVoice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxVoice.FormattingEnabled = true;
            this.comboBoxVoice.Location = new System.Drawing.Point(153, 45);
            this.comboBoxVoice.Name = "comboBoxVoice";
            this.comboBoxVoice.Size = new System.Drawing.Size(135, 24);
            this.comboBoxVoice.TabIndex = 3;
            this.comboBoxVoice.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Voice";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 332);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVoice;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox comboBoxEmotion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.ComboBox comboBoxOutputDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDemoOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonCancelSettings;
    }
}