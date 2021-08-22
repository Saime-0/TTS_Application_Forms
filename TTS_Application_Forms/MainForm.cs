using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_Application_Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Mp3Player.ISoundEngineInitDevice();
            Mp3Player.onStatusDeviceAvailableChanged += Mp3Player_onStatusDeviceAvailableChanged;
            
        }

        private void Mp3Player_onStatusDeviceAvailableChanged(bool status)
        {
            MessageBox.Show(Properties.Settings.Default.DemoOutput + "\n" + Mp3Player.isDeviceAvailable);
        }

        // v
        bool VoiceMuted;
        bool SoundMuted;

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTipOpenSettings = new(), toolTipVoiceMute = new(), toolTipSoundMute = new();
            toolTipOpenSettings.SetToolTip(panelOpenSettings, "Open settings windows.");
            toolTipOpenSettings.SetToolTip(panelVoiceMute, "Disable audio playback on the \"Output device\" device.");
            toolTipOpenSettings.SetToolTip(panelSoundMute, "Disable audio playback on the \"Demo output\" device.");

            VoiceMuted = Properties.Settings.Default.VoiceMute;
            if (VoiceMuted)
            {
                trackBarVoiceVolume.Value = 0;
                panelVoiceMute.BackgroundImage = ImageOnVoiceMute;
            }
            else
            {
                trackBarVoiceVolume.Value = Properties.Settings.Default.VoiceVolume;
            }
            SoundMuted = Properties.Settings.Default.SoundMute;
            if (SoundMuted)
            {
                trackBarSoundVolume.Value = 0;
                panelSoundMute.BackgroundImage = ImageOnSoundMute;
            }
            else
            {
                trackBarSoundVolume.Value = Properties.Settings.Default.SoundVolume;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!VoiceMuted) Properties.Settings.Default.VoiceVolume = trackBarVoiceVolume.Value;
            Properties.Settings.Default.VoiceMute = VoiceMuted;
            if (!SoundMuted) Properties.Settings.Default.SoundVolume = trackBarSoundVolume.Value;
            Properties.Settings.Default.SoundMute = SoundMuted;
            Properties.Settings.Default.Save();
        }

        private void buttonPlaySound_Click(object sender, EventArgs e)
        {
            var targetText = textBoxTargetText.Text;
            if (!String.IsNullOrWhiteSpace(targetText) || targetText.Length > 0)
                //if (Properties.Settings.Default.OutputDevice != -1)
                TextToMp3.Speak(targetText, "audio", Params.speakers[Properties.Settings.Default.Voice], Params.emotions[Properties.Settings.Default.Emotion], Properties.Settings.Default.Speed / 10f);
  
        }

        Point lastPoint;
        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelFormName_MouseMove(object sender, MouseEventArgs e)
        {
            panelTop_MouseMove(sender, e);
        }

        private void labelFormName_MouseDown(object sender, MouseEventArgs e)
        {
            panelTop_MouseDown(sender, e);
        }

        private void textBoxTargetText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void textBoxTargetText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPlaySound_Click(this, EventArgs.Empty);
            }
        }


        private void textBoxTargetText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
        }

        private void textBoxTargetText_TextChanged(object sender, EventArgs e)
        {
            // int caretPosition = ((TextBox)sender).SelectionStart;
        }

        // Close (move to tray)
        Color ColorOnMouseEnterToCloseWindow = Color.Red;
        Image ImageOnMouseEnterToCloseWindow = new Bitmap(Properties.Resources.close_white);
        Image ImageOnMouseLeaveToCloseWindow = new Bitmap(Properties.Resources.close_gray);
        private void buttonCloseWindow_MouseEnter(object sender, EventArgs e)
        {
            buttonCloseWindow.BackColor = buttonCloseWindow.FlatAppearance.BorderColor = ColorOnMouseEnterToCloseWindow;
            buttonCloseWindow.BackgroundImage = ImageOnMouseEnterToCloseWindow;
        }

        private void buttonCloseWindow_MouseLeave(object sender, EventArgs e)
        {
            buttonCloseWindow.BackColor = buttonCloseWindow.FlatAppearance.BorderColor = panelTop.BackColor;
            buttonCloseWindow.BackgroundImage = ImageOnMouseLeaveToCloseWindow;
        } 
        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Minimize
        Color ColorOnMouseEnterToMinimizeWindow = Color.FromArgb(255, 103, 105, 109);
        Image ImageOnMouseEnterToMinimizeWindow = new Bitmap(Properties.Resources.minimize_white);
        Image ImageOnMouseLeaveToMinimizeWindow = new Bitmap(Properties.Resources.minimize_gray);
        private void buttonMinimze_MouseEnter(object sender, EventArgs e)
        {
            buttonMinimze.BackColor = buttonMinimze.FlatAppearance.BorderColor = ColorOnMouseEnterToMinimizeWindow;
            buttonMinimze.BackgroundImage = ImageOnMouseEnterToMinimizeWindow;
        }

        private void buttonMinimze_MouseLeave(object sender, EventArgs e)
        {
            buttonMinimze.BackColor = buttonMinimze.FlatAppearance.BorderColor = panelTop.BackColor;
            buttonMinimze.BackgroundImage = ImageOnMouseLeaveToMinimizeWindow;
        }

        private void buttonMinimze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            ActiveControl = textBoxTargetText;
        }

        private void panelOpenSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new();
            form.ShowDialog();
        }

        Image ImageOnVoiceMute = new Bitmap(Properties.Resources.silence);
        Image ImageOnVoiceNotMute = new Bitmap(Properties.Resources.robot);
        private void panelVoiceMute_Click(object sender, EventArgs e)
        {
            // if (VoiceMuted && Properties.Settings.Default.VoiceVolume == 0)
            //     trackBarVoiceVolume.Value = 10;
            // else 
            if (VoiceMuted)
                trackBarVoiceVolume.Value = Properties.Settings.Default.VoiceVolume;
            else
                trackBarVoiceVolume.Value = 0;
        }

        private void trackBarVoiceVolume_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarVoiceVolume.Value == 0)
            {
                VoiceMuted = true;
                panelVoiceMute.BackgroundImage = ImageOnVoiceMute;
            }
            else if (VoiceMuted)
            {
                VoiceMuted = false;
                panelVoiceMute.BackgroundImage = ImageOnVoiceNotMute;
                Properties.Settings.Default.VoiceVolume = trackBarVoiceVolume.Value;

            }
        }

        private void trackBarVoiceVolume_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (trackBarVoiceVolume.Value != 0)
            Properties.Settings.Default.VoiceVolume = trackBarVoiceVolume.Value;
        }

        Image ImageOnSoundMute = new Bitmap(Properties.Resources.mute);
        Image ImageOnSoundNotMute = new Bitmap(Properties.Resources.headphones);
        private void panelSoundMute_Click(object sender, EventArgs e)
        {
            if (SoundMuted)
                trackBarSoundVolume.Value = Properties.Settings.Default.SoundVolume;
            else
                trackBarSoundVolume.Value = 0;
        }

        private void trackBarSoundVolume_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarSoundVolume.Value == 0)
            {
                SoundMuted = true;
                panelSoundMute.BackgroundImage = ImageOnSoundMute;
            }
            else if (SoundMuted)
            {
                SoundMuted = false;
                panelSoundMute.BackgroundImage = ImageOnSoundNotMute;
                Properties.Settings.Default.SoundVolume = trackBarSoundVolume.Value;

            }
        }

        private void trackBarSoundVolume_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (trackBarSoundVolume.Value != 0)
                Properties.Settings.Default.SoundVolume = trackBarSoundVolume.Value;
        }

        private bool turboMode = false;
        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.DemoOutput + "\n" + Mp3Player.isDeviceAvailable);
            if (turboMode)
                panel1.BackgroundImage = Properties.Resources.enter_gray;
            else
                panel1.BackgroundImage = Properties.Resources.thunder_512;
            turboMode = !turboMode;
        }
    }
}
