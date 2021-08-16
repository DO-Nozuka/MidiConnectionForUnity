using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dono.MidiConnectionForUnity.Base;
using Dono.MidiUtilities.Runtime;

namespace MidiConnectionForUnity.StandardDevice
{
    public class SimpleMessageLogger : MidiInDevice
    {
        public override string DefaultDeviceName => "SimpleMessageLogger";
        public override void OnNext(MidiMessage value)
        {
            string log = "";
            log += $"[{GetDeviceName()}]";
            log += $"msg;{value}";
            Debug.Log(log);
        }



    }
}