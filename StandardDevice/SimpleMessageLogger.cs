using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dono.MidiConnectionForUnity.Base;
using Dono.MidiUtilities.Runtime;

public class SimpleMessageLogger : MidiInDevice
{
    public override void OnNext(MidiMessage value)
    {
        Debug.Log(value);
    }
}
