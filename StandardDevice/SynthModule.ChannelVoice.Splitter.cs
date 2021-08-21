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
        public virtual void ChannelVoiceSplitter(MidiMessage message)
        {
            switch (message.channelVoiceType)
            {
                case ChannelVoiceType.NoteOff:
                    OnNoteOff(message);
                    break;
                case ChannelVoiceType.NoteOn:
                    OnNoteOn(message);
                    break;
                case ChannelVoiceType.PolyphonicKeyPressure:
                    OnPolyphonicKeyPressure(message);
                    break;
                case ChannelVoiceType.ControlChange:
                    ControlChangeSplitter(message);
                    break;
                case ChannelVoiceType.ProgramChange:
                    OnProgramChange(message);
                    break;
                case ChannelVoiceType.ChannelPressure:
                    OnChannelPressure(message);
                    break;
                case ChannelVoiceType.PitchBendChange:
                    OnPitchBendChange(message);
                    break;
            }
        }
    }
}