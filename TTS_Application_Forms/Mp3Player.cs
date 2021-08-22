using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrKlang;

namespace TTS_Application_Forms
{
    public static class Mp3Player
    {
        public delegate void MethodContainer(bool status);
        public static event MethodContainer onStatusDeviceAvailableChanged;


        private static ISoundEngine irrKlangEngine;
        private static ISoundDeviceList sdl;
        public static bool isDeviceAvailable = true;

        public static string deviceDemoDesc = Properties.Settings.Default.DemoOutput;

        public static void ISoundEngineInitDevice()
        {
            sdl = new(SoundDeviceListType.PlaybackDevice);
            irrKlangEngine = new(SoundOutputDriver.AutoDetect, SoundEngineOptionFlag.DefaultOptions, sdl.getDeviceID(Properties.Settings.Default.OutputDevice));
            DeviceListHandler();
        }

        private static async void DeviceListHandler()
        {
            var latestDeviceCount = sdl.DeviceCount;
            isDeviceAvailable = IsDeviceInDeviceList();
            await Task.Run(() => {
                while (true)
                {
                    sdl = new(SoundDeviceListType.PlaybackDevice);
                    Debug.WriteLine(latestDeviceCount+":last\ncount:"+sdl.DeviceCount);
                    if (latestDeviceCount != sdl.DeviceCount)
                    {
                        Debug.WriteLine("latestDeviceCount != sdl.DeviceCount");
                        if (IsDeviceInDeviceList() != isDeviceAvailable)
                        {
                            Debug.WriteLine("IsDeviceInDeviceList() != isDeviceAvailable");
                            isDeviceAvailable = !isDeviceAvailable;
                            if (!isDeviceAvailable)
                            {
                                Properties.Settings.Default.DemoOutput = sdl.getDeviceDescription(0);
                                Properties.Settings.Default.Save();
                            }

                            onStatusDeviceAvailableChanged(isDeviceAvailable); // event
                        }
                        deviceDemoDesc = Properties.Settings.Default.DemoOutput;

                        // onStatusChange if latest != current
                        latestDeviceCount = sdl.DeviceCount;
                    }
                    else if (isDeviceAvailable)
                    {
                        deviceDemoDesc = Properties.Settings.Default.DemoOutput;
                        Properties.Settings.Default.Save();
                    }
                    // onStatusDeviceAvailableChanged(isDeviceAvailable); // event
                    System.Threading.Thread.Sleep(1300);
                }
            });
        }

        private static bool IsDeviceInDeviceList()
        {
            for (int i = 0; i < sdl.DeviceCount; i++)
            { 
                if (deviceDemoDesc.Equals(sdl.getDeviceDescription(i)))
                {
                    return true;
                }
            }
            return false;
        }


    }   
}
