using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        public SynthModuleChannelState[] ChannelState { get; internal set; } = new SynthModuleChannelState[16];
    }

    public class SynthModuleChannelState
    {
        //Note On / Off
        public bool[] IsNoteOn { get; internal set; } = new bool[128];
        //Note Velocity(Record Off Velocity too)
        public byte[] Velocity { get; internal set; } = new byte[128];
        //PolyphonicKeyPressure
        public byte[] KeyPressure { get; internal set; } = new byte[128];
        //ProgramChange
        public byte Program { get; internal set; }
        //ChannelPressure
        public byte ChannelPressure { get; internal set; }
        //PitchBend
        public short PitchBend { get; internal set; }

        //and more...
    }
}