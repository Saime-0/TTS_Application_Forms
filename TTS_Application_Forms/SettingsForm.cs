using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTS_Application_Forms
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();

            for (int i = 0; i < Params.speakers.Length; i++)
            {
                comboBoxVoice.Items.Add(Params.speakers[i] + "\n");
            }
            for (int i = 0; i < Params.emotions.Length; i++)
            {
                comboBoxEmotion.Items.Add(Params.emotions[i] + "\n");
            }
            foreach (var device in DeviceManager.deviceCollection)
            {
                comboBoxDemoOutput.Items.Add(device.FriendlyName + "\n");
                comboBoxOutputDevice.Items.Add(device.FriendlyName + "\n");
            }
            //comboBoxDemoOutput.DataSource = Mp3Player._devices;
        }

        private void LoadSettings()
        {
            // params
            comboBoxVoice.SelectedIndex = Properties.Settings.Default.Voice;
            comboBoxEmotion.SelectedIndex = Properties.Settings.Default.Emotion;
            trackBarSpeed.Value = Properties.Settings.Default.Speed;

			// devices
			comboBoxDemoOutput.SelectedIndex = comboBoxDemoOutput.Items.IndexOf((object) DeviceManager.deviceDemoName + "\n");
            comboBoxOutputDevice.SelectedIndex = comboBoxOutputDevice.Items.IndexOf((object)DeviceManager.deviceOutputName + "\n");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
			// devices
			Properties.Settings.Default.DemoOutput = DeviceManager.deviceDemoName = comboBoxDemoOutput.SelectedItem.ToString().Trim();
            Properties.Settings.Default.OutputDevice = DeviceManager.deviceOutputName = comboBoxOutputDevice.SelectedItem.ToString().Trim();
            DeviceManager.ReloadDeviceCollection(); // reload stats

            // params
            Properties.Settings.Default.Voice = comboBoxVoice.SelectedIndex;          
            Properties.Settings.Default.Emotion = comboBoxEmotion.SelectedIndex;        
            Properties.Settings.Default.Speed = trackBarSpeed.Value;
            
            Properties.Settings.Default.Save();
            // MessageBox.Show(comboBoxDemoOutput.Items.IndexOf((object)comboBoxDemoOutput.SelectedItem.ToString()) + "\n" + comboBoxDemoOutput.SelectedItem.ToString());
            Hide();
        }

        private void buttonCancelSettings_Click(object sender, EventArgs e)
        {
            Hide();
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

        private void comboBoxDemoOutput_SelectedValueChanged(object sender, EventArgs e)
        {
            // Debug.WriteLine(comboBoxDemoOutput.SelectedItem.ToString());
        }
    }
}
