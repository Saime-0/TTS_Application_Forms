using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrKlang;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.SoundOut;
using CSCore.Streams;
using System.Collections.ObjectModel;

namespace TTS_Application_Forms
{
    public static class DeviceManager
    {
        // events
        public delegate void MethodContainer(bool status);
        public static event MethodContainer onStatusDeviceAvailableChanged;

        // new sound engine
        public static readonly ObservableCollection<MMDevice> deviceCollection = new ObservableCollection<MMDevice>();

        // fields
        public static bool isDeviceDemoAvailable = true;
        public static bool isDeviceOutputAvailable = true;
        public static string deviceDemoName = Properties.Settings.Default.DemoOutput;
        public static string deviceOutputName = Properties.Settings.Default.OutputDevice;
        public static MMDevice myDeviceDemoObject;
        public static MMDevice myDeviceOutputObject;

        public static int lastDevicesCount = 0;


        // methods
        public static void InitDeviceManager()
        {
            DeviceListUpdater();
        }

        public static void ReloadDeviceCollection() {
            lastDevicesCount = -1;
        }

        private static async void DeviceListUpdater()
        {
            await Task.Run(() => {

                using (var mmdeviceEnumerator = new MMDeviceEnumerator())
                {
                    
                    while (true)
                    {
                        using (var mmdeviceCollection = mmdeviceEnumerator.EnumAudioEndpoints(DataFlow.Render, DeviceState.Active))
                        {
                            if (lastDevicesCount != mmdeviceCollection.Count)
                            {
                                deviceCollection.Clear();
                                var matchFoundDemo = false;
                                var matchFoundOutput = false;
                                foreach (var device in mmdeviceCollection)
                                {
                                    if (device.FriendlyName == Properties.Settings.Default.DemoOutput) 
                                    { 
                                        matchFoundDemo = true;
                                        myDeviceDemoObject = device;
                                        deviceDemoName = Properties.Settings.Default.DemoOutput;
                                    } else if (device.FriendlyName == Properties.Settings.Default.OutputDevice)
                                    {
                                        matchFoundOutput = true;
                                        myDeviceOutputObject = device;
                                        deviceDemoName = Properties.Settings.Default.OutputDevice;
                                    }
                                    deviceCollection.Add(device);
                                }
                                isDeviceDemoAvailable = matchFoundDemo;
                                isDeviceOutputAvailable = matchFoundOutput;
                                if (!isDeviceDemoAvailable)
                                {
                                    myDeviceDemoObject = mmdeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                                    deviceDemoName = myDeviceDemoObject.FriendlyName;
                                }
                                if(!isDeviceOutputAvailable)
                                {
                                    myDeviceOutputObject = mmdeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                                    deviceOutputName = myDeviceOutputObject.FriendlyName;
                                }


                                lastDevicesCount = mmdeviceCollection.Count;
                                Debug.WriteLine("DemoDevice: " + deviceDemoName);
                                Debug.WriteLine("OutPut: " + deviceOutputName);
                            }

                        }
                        System.Threading.Thread.Sleep(200);
                    }

                        
                }

            });
        }
    }   
}
