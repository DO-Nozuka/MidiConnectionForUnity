using Dono.MidiConnectionForUnity.Base;
using Dono.MidiUtilities.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MidiConnectionForUnity.StandardDevice
{
    public class MessageChannelFilter : MidiInOutDevice
    {
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

        private bool[] _channelEnable = new bool[16];

        public override string DefaultDeviceName => "MessageChannelFilter";

        public override void OnNext(MidiMessage value)
        {
            UpdateChannelEnable();
            if (_channelEnable[value.Channel])
                subject.OnNext(value);            
        }

        public void UpdateChannelEnable()
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