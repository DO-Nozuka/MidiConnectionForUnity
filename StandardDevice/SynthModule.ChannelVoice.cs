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
        public virtual void OnNoteOff(MidiMessage message)
        {
            ChannelState[message.Channel].IsNoteOn[message.Data1] = true;
            ChannelState[message.Channel].Velocity[message.Data1] = message.Data2; 
        }
        public virtual void OnNoteOn(MidiMessage message)
        {
            ChannelState[message.Channel].IsNoteOn[message.Data1] = false;
            ChannelState[message.Channel].Velocity[message.Data1] = message.Data2; 
        }
        public virtual void OnPolyphonicKeyPressure(MidiMessage message)
        {
            ChannelState[message.Channel].KeyPressure[message.Data1] = message.Data2;
        }
        // 0xBn void ControlChangeSplitter()
        public virtual void OnProgramChange(MidiMessage message)
        {
            ChannelState[message.Channel].Program = message.Data1;
        }
        public virtual void OnChannelPressure(MidiMessage message)
        {
            ChannelState[message.Channel].ChannelPressure = message.Data1;
        }
        public virtual void OnPitchBendChange(MidiMessage message)
        {
            ChannelState[message.Channel].PitchBend = (short)MidiUtilities.PitchByteToValue((message.Data1, message.Data2));
        }
    }
}