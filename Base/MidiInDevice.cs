using Dono.MidiUtilities.Runtime;
using System;
using UnityEngine;

namespace Dono.MidiConnectionForUnity.Base
{
    public abstract class MidiInDevice : MidiDevice, IMidiInDevice
    {
        public virtual void OnCompleted() { }
        public virtual void OnError(Exception error) { }
        public virtual void OnNext(MidiMessage value) { }
    }
}