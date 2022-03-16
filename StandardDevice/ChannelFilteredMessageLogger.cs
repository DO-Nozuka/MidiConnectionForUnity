
using Dono.Midi.Runtime;
using UnityEngine;

namespace Dono.MidiConnectionForUnity
{
    public class ChannelFilteredMessageLogger : MidiInDevice
    {
        private bool[] _channelEnable = new bool[16];

        [Header("Channel Enable")]
        [SerializeField] private bool channel1 = true;
        [SerializeField] private bool channel2 = true;
        [SerializeField] private bool channel3 = true;
        [SerializeField] private bool channel4 = true;
        [SerializeField] private bool channel5 = true;
        [SerializeField] private bool channel6 = true;
        [SerializeField] private bool channel7 = true;
        [SerializeField] private bool channel8 = true;
        [SerializeField] private bool channel9 = true;
        [SerializeField] private bool channel10 = true;
        [SerializeField] private bool channel11 = true;
        [SerializeField] private bool channel12 = true;
        [SerializeField] private bool channel13 = true;
        [SerializeField] private bool channel14 = true;
        [SerializeField] private bool channel15 = true;
        [SerializeField] private bool channel16 = true;
        public override string DefaultDeviceName => "ChannelFilteredMessageLogger";

        public override void OnNext(MidiMessage value)
        {
            string log = "";
            log += $"[{GetDeviceName()}]";
            log += $"Message:{value}";
            Debug.Log(log);
        }

        public void SetAllEnable()
        {
            channel1 = true;
            channel2 = true;
            channel3 = true;
            channel4 = true;
            channel5 = true;
            channel6 = true;
            channel7 = true;
            channel8 = true;
            channel9 = true;
            channel10 = true;
            channel11 = true;
            channel12 = true;
            channel13 = true;
            channel14 = true;
            channel15 = true;
            channel16 = true;
        }

        public void SetAllDisable()
        {
            channel1 = false;
            channel2 = false;
            channel3 = false;
            channel4 = false;
            channel5 = false;
            channel6 = false;
            channel7 = false;
            channel8 = false;
            channel9 = false;
            channel10 = false;
            channel11 = false;
            channel12 = false;
            channel13 = false;
            channel14 = false;
            channel15 = false;
            channel16 = false;
        }

        private void UpdateChannelEnable()
        {
            _channelEnable[0] = channel1;
            _channelEnable[1] = channel2;
            _channelEnable[2] = channel3;
            _channelEnable[3] = channel4;
            _channelEnable[4] = channel5;
            _channelEnable[5] = channel6;
            _channelEnable[6] = channel7;
            _channelEnable[7] = channel8;
            _channelEnable[8] = channel9;
            _channelEnable[9] = channel10;
            _channelEnable[10] = channel11;
            _channelEnable[11] = channel12;
            _channelEnable[12] = channel13;
            _channelEnable[13] = channel14;
            _channelEnable[14] = channel15;
            _channelEnable[15] = channel16;
        }
    }
}