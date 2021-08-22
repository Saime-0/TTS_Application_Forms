using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace TTS_Application_Forms
{

    public static class TextToMp3
    {
        private static ISoundEngine irrKlangEngine;
        public static ISoundDeviceList sdl;
        public static async void Speak(string text, string folder, string voice, string emotion, float speed)
        {
            var fname = GenerateHashString(text + folder + voice + emotion + speed);
            string filePath = folder + "/" + fname + ".mp3";
            CreateFolderIfNotExists(folder);
            //DownloadIfNotExists
            if (!File.Exists(filePath))
            {
                // https://texttospeechrobot.com/tts/ru/sintezator-rechi-onlayn/
                string url = "https://tts.voicetech.yandex.net/generate?key=22fe10e2-aa2f-4a58-a934-54f2c1c4d908&text=" + System.Web.HttpUtility.UrlEncode(text) + "&format=mp3&lang=ru-RU&speed=" + speed.ToString("0.0") + "&emotion=" + emotion + "&speaker=" + voice + "&robot=1";
                WebClient Client = new();
                await Task.Run(() => Client.DownloadFile(url, filePath));
            }
            irrKlangEngine.Play2D(filePath);

        }

        private static void ISoundEngineInitDevice()
        {
            sdl = new(SoundDeviceListType.PlaybackDevice);
            // sdl.getDeviceID()
            irrKlangEngine = new(SoundOutputDriver.AutoDetect, SoundEngineOptionFlag.DefaultOptions, sdl.getDeviceID(Properties.Settings.Default.OutputDevice));
        }

        private static string GenerateHashString(string str)
        {
            var md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            var hexString = BitConverter.ToString(hash);
            return hexString.Replace("-", "");
        }

        private static void CreateFolderIfNotExists(string folderName)
        {
            DirectoryInfo dirInfo = new(folderName);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }
    }

}
