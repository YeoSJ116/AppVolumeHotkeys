﻿using CSCore.CoreAudioAPI;
using System.Collections.Generic;

namespace AppVolumeHotkeys
{
    class VolumeMixer
    {
        AudioSessionEnumerator audioSessionEnumerator;

        public VolumeMixer()
        {

        }

        public List<string> GetEndpointNames()
        {
            List<string> endpointNames = new List<string>();

            foreach (MMDevice endpoint in MMDeviceEnumerator.EnumerateDevices(DataFlow.Render, DeviceState.Active))
            {
                endpointNames.Add(endpoint.FriendlyName);
            }

            return endpointNames;
        }

        public List<string> GetSessionNames()
        {
            List<string> sessionNames = new List<string>();

            foreach (AudioSessionControl session in audioSessionEnumerator)
            {
                AudioSessionControl2 sessionControl2 = session.QueryInterface<AudioSessionControl2>();
                if (sessionControl2.DisplayName.ToLower().Contains("audiosrv.dll"))
                    sessionNames.Add("[System Sounds]");
                else
                    sessionNames.Add("[" + sessionControl2.Process.ProcessName + "] " + sessionControl2.Process.MainWindowTitle);
            }

            return sessionNames;
        }

        public void SetEndpoint(int index)
        {
            AudioSessionManager2 audioSessionManager = AudioSessionManager2.FromMMDevice(MMDeviceEnumerator.EnumerateDevices(DataFlow.Render, DeviceState.Active)[index]);
            audioSessionEnumerator = audioSessionManager.GetSessionEnumerator();
        }

        public int GetApplicationVolume(int index)
        {
            return (int)(audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().MasterVolume * 100);
        }

        public bool GetApplicationMute(int index)
        {
            return audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().IsMuted;
        }

        /// <summary>
        /// 이 함수에 버그가 있음
        /// 절전 상태에서 깨어나는 순간 마스터 볼륨에서 예외가 발생하게 됨.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="volume"></param>
        public void SetApplicationVolume(int index, int volume)
        {
            if (volume <= 0)
                audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().MasterVolume = 0;
            else if (volume >= 100)
                audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().MasterVolume = 1;
            else
                audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().MasterVolume = volume / 100f;
        }

        public void SetApplicationMute(int index, bool state)
        {
            audioSessionEnumerator.GetSession(index).QueryInterface<SimpleAudioVolume>().IsMuted = state;
        }
    }
}
