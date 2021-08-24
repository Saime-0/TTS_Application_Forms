using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace TTS_Application_Forms
{
    public static class Speecher
    {
        public static readonly MusicPlayer musicDemoPlayer = new MusicPlayer();
        public static readonly MusicPlayer musicOutputPlayer = new MusicPlayer();
        private static string folder = "audio";


        public static async void Speak(string text, string voice, string emotion, float speed)
        {
            var fname = GenerateHashString(text + folder + voice + emotion + speed);
            string filePath = folder + "/" + fname + ".mp3";
            CreateFolderIfNotExists(folder);
            //DownloadIfNotExists
            var err = 0;
            if (!File.Exists(filePath))
            {
                // https://texttospeechrobot.com/tts/ru/sintezator-rechi-onlayn/
                string url = "https://tts.voicetech.yandex.net/generate?key=22fe10e2-aa2f-4a58-a934-54f2c1c4d908&text=" + System.Web.HttpUtility.UrlEncode(text) + "&format=mp3&lang=ru-RU&speed=" + speed.ToString("0.0") + "&emotion=" + emotion + "&speaker=" + voice + "&robot=1";
                WebClient Client = new();
                await Task.Run(() => 
                {
                    try
                    {
                        Client.DownloadFile(url, filePath);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Ошибка скачивания файла: " + ex);
                        err = 1;
                    }
                });
            }
            if (err == 0) {
                musicDemoPlayer.Open(filePath, DeviceManager.myDeviceDemoObject);
                musicDemoPlayer.Play();
                musicOutputPlayer.Open(filePath, DeviceManager.myDeviceOutputObject);
                musicOutputPlayer.Play();
            }

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
