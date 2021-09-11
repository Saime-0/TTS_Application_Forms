using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace TTS_Application_Forms
{
    public static class Speecher
    {
        public static readonly MusicPlayer musicDemoPlayer = new();
        public static readonly MusicPlayer musicOutputPlayer = new();
        public struct Preset
        {
            public string speechText;
            public string speechVoice;
            public string speechEmotion;
            public float speechSpeed;
            public int speechSoundVolume;
            public int speechVoiceVolume;

            public void Speak()
            {
                Speecher.Speak(speechText, speechVoice, speechEmotion, speechSpeed, speechSoundVolume, speechVoiceVolume);
            }
        }

        private static async void Speak(string text, string voice, string emotion, float speed, int soundVolume, int voiceVolume)
        {
            var fname = GenerateHashString(text + Params.folder + voice + emotion + speed);
            string filePath = Params.folder + "/" + fname + ".mp3";
            CreateFolderIfNotExists(Params.folder);
            //DownloadIfNotExists
            var err = 0;
            if (!File.Exists(filePath))
            {
                // https://texttospeechrobot.com/tts/ru/sintezator-rechi-onlayn/
                string url = string.Format("http://tts.voicetech.yandex.net/tts?&format=mp3&lang=ru_RU&speed={0}&emotion={1}&speaker={2}&robot=1&text={3}",
                    speed.ToString("0.0").Replace(",", "."), emotion, voice, System.Web.HttpUtility.UrlEncode(text));
                WebClient Client = new();
                await Task.Run(() => 
                {
                    try
                    {
                        Debug.WriteLine(url);
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
                musicDemoPlayer.Volume = soundVolume;
                musicDemoPlayer.Play();
                musicOutputPlayer.Open(filePath, DeviceManager.myDeviceOutputObject);
                musicOutputPlayer.Volume = voiceVolume;
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
