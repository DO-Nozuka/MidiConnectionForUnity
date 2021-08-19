using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dono.MidiConnectionForUnity.Base;
using Dono.Midi.Runtime;
using System;

namespace MidiConnectionForUnity.StandardDevice
{
    public class SimpleMessageLogger : MidiInDevice
    {
        public override string DefaultDeviceName => "SimpleMessageLogger";

        public override void OnNext(MidiMessage value)
        {
            string log = "";
            log += $"[{GetDeviceName()}]";
            log += $"Message:{value}";
            Debug.Log(log);
        }
    }
}