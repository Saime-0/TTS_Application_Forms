using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS_Application_Forms
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();

            IrrKlang.ISoundDeviceList sdl = new(IrrKlang.SoundDeviceListType.PlaybackDevice);

            for (int i = 0; i < sdl.DeviceCount; i++)
            {
                comboBoxDemoOutput.Items.Add(sdl.getDeviceDescription(i) + "\n");
                comboBoxOutputDevice.Items.Add(sdl.getDeviceDescription(i) + "\n");
            }
            for (int i = 0; i < Params.speakers.Length; i++)
            {
                comboBoxVoice.Items.Add(Params.speakers[i] + "\n");
            }
            for (int i = 0; i < Params.emotions.Length; i++)
            {
                comboBoxEmotion.Items.Add(Params.emotions[i] + "\n");
            }
            
        }

        //функция которая будет вызывать при загрузке приложения
        //юудет заполнять элементы на форме, а так же применять их значения
        private void LoadSettings()
        {
            comboBoxVoice.SelectedIndex = Properties.Settings.Default.Voice;
            comboBoxEmotion.SelectedIndex = Properties.Settings.Default.Emotion;
            trackBarSpeed.Value = Properties.Settings.Default.Speed;
            // if (Properties.Settings.Default.DemoOutput >= comboBoxDemoOutput.Items.Count || Properties.Settings.Default.DemoOutput == -1)
            //{
            //    Properties.Settings.Default.DemoOutput = 0;
            //}
            comboBoxDemoOutput.SelectedIndex = comboBoxDemoOutput.Items.IndexOf((object) Properties.Settings.Default.DemoOutput+"\n");
            //if (Properties.Settings.Default.OutputDevice >= comboBoxDemoOutput.Items.Count || Properties.Settings.Default.OutputDevice == -1)
            // {
            //     Properties.Settings.Default.OutputDevice = 0;
            //}
            comboBoxOutputDevice.SelectedIndex = Properties.Settings.Default.OutputDevice;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
            //  MessageBox.Show(comboBoxDemoOutput.Items.IndexOf((object)comboBoxDemoOutput.SelectedItem.ToString()) + "\n" + comboBoxDemoOutput.SelectedItem.ToString());
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Voice = comboBoxVoice.SelectedIndex;          
            Properties.Settings.Default.Emotion = comboBoxEmotion.SelectedIndex;        
            Properties.Settings.Default.Speed = trackBarSpeed.Value;
            Properties.Settings.Default.DemoOutput = comboBoxDemoOutput.SelectedItem.ToString().Trim();
            Properties.Settings.Default.OutputDevice  = comboBoxOutputDevice.SelectedIndex;  
            Properties.Settings.Default.Save();
            MessageBox.Show(comboBoxDemoOutput.Items.IndexOf((object)comboBoxDemoOutput.SelectedItem.ToString()) + "\n" + comboBoxDemoOutput.SelectedItem.ToString());
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

        }
    }
}
