using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;

using System.Collections.Generic;

namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiDevice,
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
        public int Undefined17 { get; internal set; }
        public int Undefined18 { get; internal set; }
        public int Undefined19 { get; internal set; }
        public int Undefined1A { get; internal set; }
        public int Undefined1B { get; internal set; }
        public int Undefined1C { get; internal set; }
        public int Undefined1D { get; internal set; }
        public int Undefined1E { get; internal set; }
        public int Undefined1F { get; internal set; }
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
        public byte Undefined5A { get; internal set; }
        public byte Effects1Depth { get; internal set; }
        public byte Effects2Depth { get; internal set; }
        public byte Effects3Depth { get; internal set; }
        public byte Effects4Depth { get; internal set; }
        public byte Effects5Depth { get; internal set; }
        //public byte DataIncrement { get; internal set; }
        //public byte DataDecrement { get; internal set; }
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


        public int Get2ByteCC(byte ccNumber)
        {
            switch (ccNumber)
            {
                case 0x00:                    
                case 0x20:
                    return BankSelect;
                case 0x01:                    
                case 0x21:
                    return Modulation;
                case 0x02:                    
                case 0x22:
                    return BreathController;
                case 0x03:                    
                case 0x23:
                    return Undefined03;
                case 0x04:                    
                case 0x24:
                    return FootController;
                case 0x05:                    
                case 0x25:
                    return PortamentoTime;
                case 0x06:                    
                case 0x26:
                    return DataEntry;
                case 0x07:                    
                case 0x27:
                    return ChannelVolume;
                case 0x08:                    
                case 0x28:
                    return Balance;
                case 0x09:                    
                case 0x29:
                    return Undefined09;
                case 0x0A:                    
                case 0x2A:
                    return Pan;
                case 0x0B:                    
                case 0x2B:
                    return ExpressionController;
                case 0x0C:                    
                case 0x2C:
                    return EffectControl1;
                case 0x0D:                    
                case 0x2D:                
                    return EffectControl2;
                case 0x0E:                    
                case 0x2E:
                    return Undefined0E;
                case 0x0F:                    
                case 0x2F:
                    return Undefined0F;
                case 0x10:                    
                case 0x30:
                    return GeneralPurposeController1;
                case 0x11:                    
                case 0x31:                    
                    return GeneralPurposeController2;
                case 0x12:                    
                case 0x32:                    
                    return GeneralPurposeController3;
                case 0x13:                    
                case 0x33:                    
                    return GeneralPurposeController4;
                case 0x14:                    
                case 0x34:
                    return Undefined14;
                case 0x15:                    
                case 0x35:                    
                    return Undefined15;
                case 0x16:                    
                case 0x36:                    
                    return Undefined16;
                case 0x17:                    
                case 0x37:                    
                    return Undefined17;
                case 0x18:                    
                case 0x38:                   
                    return Undefined18;
                case 0x19:                    
                case 0x39:                    
                    return Undefined19;
                case 0x1A:                    
                case 0x3A:                    
                    return Undefined1A;
                case 0x1B:                    
                case 0x3B:                    
                    return Undefined1B;
                case 0x1C:                    
                case 0x3C:                    
                    return Undefined1C;
                case 0x1D:                    
                case 0x3D:                    
                    return Undefined1D;
                case 0x1E:                    
                case 0x3E:                    
                    return Undefined1E;
                case 0x1F:                    
                case 0x3F:                    
                    return Undefined1F;
                default: return 0;
            }
        }
        public byte Get1ByteCC(byte ccNumber)
        {
            if(ccNumber < 0x20)
            {
                return (byte)((Get2ByteCC(ccNumber) >> 7) & 0b01111111);
            }
            else if(ccNumber < 0x40)
            {
                return (byte)(Get2ByteCC(ccNumber) & 0b01111111);
            }

            switch(ccNumber)
            {
                /* 7bit data */
                case 0x40: return Hold;
                case 0x41: return Portamento;
                case 0x42: return Sostenuto;
                case 0x43: return SoftPedal;
                case 0x44: return LegatoFootswitch;
                case 0x45: return Hold2;
                case 0x46: return SoundController1;
                case 0x47: return SoundController2;
                case 0x48: return SoundController3;
                case 0x49: return SoundController4;
                case 0x4A: return SoundController5;
                case 0x4B: return SoundController6;
                case 0x4C: return SoundController7;
                case 0x4D: return SoundController8;
                case 0x4E: return SoundController9;
                case 0x4F: return SoundController10;
                case 0x50: return GeneralPurposeController5;
                case 0x51: return GeneralPurposeController6;
                case 0x52: return GeneralPurposeController7;
                case 0x53: return GeneralPurposeController8;
                case 0x54: return PortamentoControl;
                case 0x55: return Undefined55;
                case 0x56: return Undefined56;
                case 0x57: return Undefined57;
                case 0x58: return Undefined58;
                case 0x59: return Undefined59;
                case 0x5A: return Undefined5A;
                case 0x5B: return Effects1Depth;
                case 0x5C: return Effects2Depth;
                case 0x5D: return Effects3Depth;
                case 0x5E: return Effects4Depth;
                case 0x5F: return Effects5Depth;
                case 0x60: return 0;
                case 0x61: return 0;
                case 0x62: return NonRegisteredParameterNumberLSB;
                case 0x63: return NonRegisteredParameterNumberMSB;
                case 0x64: return RegisteredParameterNumberLSB;
                case 0x65: return RegisteredParameterNumberMSB;
                case 0x66: return Undefined66;
                case 0x67: return Undefined67;
                case 0x68: return Undefined68;
                case 0x69: return Undefined69;
                case 0x6A: return Undefined6A;
                case 0x6B: return Undefined6B;
                case 0x6C: return Undefined6C;
                case 0x6D: return Undefined6D;
                case 0x6E: return Undefined6E;
                case 0x6F: return Undefined6F;
                case 0x70: return Undefined70;
                case 0x71: return Undefined71;
                case 0x72: return Undefined72;
                case 0x73: return Undefined73;
                case 0x74: return Undefined74;
                case 0x75: return Undefined75;
                case 0x76: return Undefined76;
                case 0x77: return Undefined77;
                default: return 0;
            }
        }


        // RegisteredParameter / NonRegisterdParamater
        /// <summary>
        /// ’l‚Ìİ’è‚ğRegisteredParameter‚É‚·‚é‚©‚Ç‚¤‚©
        /// </summary>
        public bool IsTargetRegisterdParameter = true;
        /// <summary>
        /// MSB:0x00, LSB:0x00
        /// </summary>
        public int PitchBendSensitivity { get; internal set; }
        public float PitchBendSensitivityByCent
        {
            get
            {
                var PitchBendSensitivityMSB = PitchBendSensitivity >> 7;
                var PitchBendSensitivityLSB = PitchBendSensitivity & 0b01111111;

                return PitchBendSensitivityMSB * 100f + PitchBendSensitivityLSB * 100f / 127f;
            }
        }
        /// <summary>
        /// MSB:0x00, LSB:0x01
        /// </summary>
        public int FineTuning { get; internal set; }
        /// <summary>
        /// MSB:0x00, LSB:0x02
        /// </summary>
        public int CoarseTuning { get; internal set; }
        public Dictionary<int, int> NonRegisterdParameter = new Dictionary<int, int>();
        //and more...
    }
}