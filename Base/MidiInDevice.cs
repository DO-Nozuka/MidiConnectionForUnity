using Dono.MidiUtilities.Runtime;
using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Dono.MidiConnectionForUnity.Base
{
    [ExecuteAlways]
    public abstract class MidiInDevice : MidiInDeviceBase
    {
        private new void Update()
        {            
            if (MidiOutPort != null)
            {
                MidiOutPort.Clear();
                MidiOutPort = null;
            }  
        }
    }
}