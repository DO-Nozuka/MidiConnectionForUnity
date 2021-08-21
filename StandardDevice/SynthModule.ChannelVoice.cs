using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
 #region OnChannelVoice

        public virtual void OnNoteOff(MidiMessage message) { }
        public virtual void OnNoteOn(MidiMessage message) { }
        public virtual void OnPolyphonicKeyPressure(MidiMessage message) { }
        // 0xBn void ControlChangeSplitter()
        public virtual void OnProgramChange(MidiMessage message) { }
        public virtual void OnChannelPressure(MidiMessage message) { }
        public virtual void OnPitchBendChange(MidiMessage message) { }
        #endregion
    }
}