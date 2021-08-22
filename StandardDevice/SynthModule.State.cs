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


        // ChannelModeMessage
        public bool LocalControl { get; internal set; }
        public bool OmniOn { get; internal set; }
        public bool MonoMode { get; internal set; }
        public byte MonoChMin { get; internal set; }
        public byte MonoChMax { get; internal set; }

        
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
        public int PitchBend { get; internal set; }

        //Control Change
        /* 14bit data */
        public int BankSelect { get; internal set; }
        public int Modulation { get; internal set; }
        public int BreathController { get; internal set; }
        public int Undefined03 { get; internal set; }
        public int FootController { get; internal set; }
        public int PortamentoTime { get; internal set; }
        public int DataEntry { get; internal set; }
        public int ChannelVolume { get; internal set; }
        public int Balance { get; internal set; }
        public int Undefined09 { get; internal set; }
        public int Pan { get; internal set; }
        public int ExpressionController { get; internal set; }
        public int EffectControl1 { get; internal set; }
        public int EffectControl2 { get; internal set; }
        public int Undefined0E { get; internal set; }
        public int Undefined0F { get; internal set; }
        public int GeneralPurposeController1 { get; internal set; }
        public int GeneralPurposeController2 { get; internal set; }
        public int GeneralPurposeController3 { get; internal set; }
        public int GeneralPurposeController4 { get; internal set; }
        public int Undefined14 { get; internal set; }
        public int Undefined15 { get; internal set; }
        public int Undefined16 { get; internal set; }
        public int Undefined1F { get; internal set; }
        public int Undefined17 { get; internal set; }
        public int Undefined18 { get; internal set; }
        public int Undefined19 { get; internal set; }
        public int Undefined1A { get; internal set; }
        public int Undefined1B { get; internal set; }
        public int Undefined1C { get; internal set; }
        public int Undefined1D { get; internal set; }
        public int Undefined1E { get; internal set; }
        /* 7bit data */
        public byte Hold { get; internal set; }
        public byte Portamento { get; internal set; }
        public byte Sostenuto { get; internal set; }
        public byte SoftPedal { get; internal set; }
        public byte LegatoFootswitch { get; internal set; }
        public byte Hold2 { get; internal set; }
        public byte SoundController1 { get; internal set; }
        public byte SoundController2 { get; internal set; }
        public byte SoundController3 { get; internal set; }
        public byte SoundController4 { get; internal set; }
        public byte SoundController5 { get; internal set; }
        public byte SoundController6 { get; internal set; }
        public byte SoundController7 { get; internal set; }
        public byte SoundController8 { get; internal set; }
        public byte SoundController9 { get; internal set; }
        public byte SoundController10 { get; internal set; }
        public byte GeneralPurposeController5 { get; internal set; }
        public byte GeneralPurposeController6 { get; internal set; }
        public byte GeneralPurposeController7 { get; internal set; }
        public byte GeneralPurposeController8 { get; internal set; }
        public byte PortamentoControl { get; internal set; }
        public byte Undefined55 { get; internal set; }
        public byte Undefined56 { get; internal set; }
        public byte Undefined57 { get; internal set; }
        public byte Undefined58 { get; internal set; }
        public byte Undefined59 { get; internal set; }
        public byte Undefined60 { get; internal set; }
        public byte Effects1Depth { get; internal set; }
        public byte Effects2Depth { get; internal set; }
        public byte Effects3Depth { get; internal set; }
        public byte Effects4Depth { get; internal set; }
        public byte Effects5Depth { get; internal set; }
        public byte DataIncrement { get; internal set; }
        public byte DataDecrement { get; internal set; }
        public byte NonRegisteredParameterNumberLSB { get; internal set; }
        public byte NonRegisteredParameterNumberMSB { get; internal set; }
        public byte RegisteredParameterNumberLSB { get; internal set; }
        public byte RegisteredParameterNumberMSB { get; internal set; }
        public byte Undefined66 { get; internal set; }
        public byte Undefined67 { get; internal set; }
        public byte Undefined68 { get; internal set; }
        public byte Undefined69 { get; internal set; }
        public byte Undefined6A { get; internal set; }
        public byte Undefined6B { get; internal set; }
        public byte Undefined6C { get; internal set; }
        public byte Undefined6D { get; internal set; }
        public byte Undefined6E { get; internal set; }
        public byte Undefined6F { get; internal set; }
        public byte Undefined70 { get; internal set; }
        public byte Undefined71 { get; internal set; }
        public byte Undefined72 { get; internal set; }
        public byte Undefined73 { get; internal set; }
        public byte Undefined74 { get; internal set; }
        public byte Undefined75 { get; internal set; }
        public byte Undefined76 { get; internal set; }
        public byte Undefined77 { get; internal set; }



        //and more...
    }
}