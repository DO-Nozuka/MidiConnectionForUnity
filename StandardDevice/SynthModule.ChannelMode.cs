using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        public virtual void OnAllSoundOff(MidiMessage message)
        {
            OnAllNotesOff(message);
        }
        public virtual void OnResetAllControllers(MidiMessage message)
        {
            OnAllNotesOff(message);
            // ChannelState
            for (int channel = 0; channel < 16; channel++)
            {
                for (int note = 0; note < 128; note++)
                {
                    //Note On / Off
                    ChannelState[channel].IsNoteOn[note] = false;
                    //Note Velocity(Record Off Velocity too)
                    ChannelState[channel].Velocity[note] = 0;
                    //PolyphonicKeyPressure
                    ChannelState[channel].KeyPressure[note] = 0;
                }
                //ProgramChange
                ChannelState[channel].Program = 0x00;
                //ChannelPressure
                ChannelState[channel].ChannelPressure = 0x00;
                //PitchBend
                ChannelState[channel].PitchBend = 0x00;

                //Control Change
                /* 14bit data */
                ChannelState[channel].BankSelect = 0x00;
                ChannelState[channel].Modulation = 0x00;
                ChannelState[channel].BreathController = 0x00;
                ChannelState[channel].Undefined03 = 0x00;
                ChannelState[channel].FootController = 0x00;
                ChannelState[channel].PortamentoTime = 0x00;
                ChannelState[channel].DataEntry = 0x00;
                ChannelState[channel].ChannelVolume = 0x00;
                ChannelState[channel].Balance = 0x00;
                ChannelState[channel].Undefined09 = 0x00;
                ChannelState[channel].Pan = 0x00;
                ChannelState[channel].ExpressionController = 0x00;
                ChannelState[channel].EffectControl1 = 0x00;
                ChannelState[channel].EffectControl2 = 0x00;
                ChannelState[channel].Undefined0E = 0x00;
                ChannelState[channel].Undefined0F = 0x00;
                ChannelState[channel].GeneralPurposeController1 = 0x00;
                ChannelState[channel].GeneralPurposeController2 = 0x00;
                ChannelState[channel].GeneralPurposeController3 = 0x00;
                ChannelState[channel].GeneralPurposeController4 = 0x00;
                ChannelState[channel].Undefined14 = 0x00;
                ChannelState[channel].Undefined15 = 0x00;
                ChannelState[channel].Undefined16 = 0x00;
                ChannelState[channel].Undefined1F = 0x00;
                ChannelState[channel].Undefined17 = 0x00;
                ChannelState[channel].Undefined18 = 0x00;
                ChannelState[channel].Undefined19 = 0x00;
                ChannelState[channel].Undefined1A = 0x00;
                ChannelState[channel].Undefined1B = 0x00;
                ChannelState[channel].Undefined1C = 0x00;
                ChannelState[channel].Undefined1D = 0x00;
                ChannelState[channel].Undefined1E = 0x00;

                /* 7bit data */
                ChannelState[channel].Hold = 0x00;
                ChannelState[channel].Portamento = 0x00;
                ChannelState[channel].Sostenuto = 0x00;
                ChannelState[channel].SoftPedal = 0x00;
                ChannelState[channel].LegatoFootswitch = 0x00;
                ChannelState[channel].Hold2 = 0x00;
                ChannelState[channel].SoundController1 = 0x00;
                ChannelState[channel].SoundController2 = 0x00;
                ChannelState[channel].SoundController3 = 0x00;
                ChannelState[channel].SoundController4 = 0x00;
                ChannelState[channel].SoundController5 = 0x00;
                ChannelState[channel].SoundController6 = 0x00;
                ChannelState[channel].SoundController7 = 0x00;
                ChannelState[channel].SoundController8 = 0x00;
                ChannelState[channel].SoundController9 = 0x00;
                ChannelState[channel].SoundController10 = 0x00;
                ChannelState[channel].GeneralPurposeController5 = 0x00;
                ChannelState[channel].GeneralPurposeController6 = 0x00;
                ChannelState[channel].GeneralPurposeController7 = 0x00;
                ChannelState[channel].GeneralPurposeController8 = 0x00;
                ChannelState[channel].PortamentoControl = 0x00;
                ChannelState[channel].Undefined55 = 0x00;
                ChannelState[channel].Undefined56 = 0x00;
                ChannelState[channel].Undefined57 = 0x00;
                ChannelState[channel].Undefined58 = 0x00;
                ChannelState[channel].Undefined59 = 0x00;
                ChannelState[channel].Undefined60 = 0x00;
                ChannelState[channel].Effects1Depth = 0x00;
                ChannelState[channel].Effects2Depth = 0x00;
                ChannelState[channel].Effects3Depth = 0x00;
                ChannelState[channel].Effects4Depth = 0x00;
                ChannelState[channel].Effects5Depth = 0x00;
                ChannelState[channel].DataIncrement = 0x00;
                ChannelState[channel].DataDecrement = 0x00;
                ChannelState[channel].NonRegisteredParameterNumberLSB = 0x00;
                ChannelState[channel].NonRegisteredParameterNumberMSB = 0x00;
                ChannelState[channel].RegisteredParameterNumberLSB = 0x00;
                ChannelState[channel].RegisteredParameterNumberMSB = 0x00;
                ChannelState[channel].Undefined66 = 0x00;
                ChannelState[channel].Undefined67 = 0x00;
                ChannelState[channel].Undefined68 = 0x00;
                ChannelState[channel].Undefined69 = 0x00;
                ChannelState[channel].Undefined6A = 0x00;
                ChannelState[channel].Undefined6B = 0x00;
                ChannelState[channel].Undefined6C = 0x00;
                ChannelState[channel].Undefined6D = 0x00;
                ChannelState[channel].Undefined6E = 0x00;
                ChannelState[channel].Undefined6F = 0x00;
                ChannelState[channel].Undefined70 = 0x00;
                ChannelState[channel].Undefined71 = 0x00;
                ChannelState[channel].Undefined72 = 0x00;
                ChannelState[channel].Undefined73 = 0x00;
                ChannelState[channel].Undefined74 = 0x00;
                ChannelState[channel].Undefined75 = 0x00;
                ChannelState[channel].Undefined76 = 0x00;
                ChannelState[channel].Undefined77 = 0x00;
            }

            // ChannelModeMessage
            LocalControl = true;
            OmniOn = false;
            MonoMode = false;
            MonoChMin = 0;
            MonoChMax = 15;
        }
        public virtual void OnLocalControl(MidiMessage message)
        {
            if (message.Data2 == 0x00)
                LocalControl = false;
            else if (message.Data2 == 0x7F)
                LocalControl = true;
        }
        public virtual void OnAllNotesOff(MidiMessage message)
        {
            for (int channel = 0; channel < 16; channel++)
            {
                for (int note = 0; note < 128; note++)
                {
                    ChannelState[channel].IsNoteOn[note] = false;
                    ChannelState[channel].Velocity[note] = 0;
                    ChannelState[channel].KeyPressure[note] = 0;
                }
            }
        }
        public virtual void OnOmniModeOff(MidiMessage message) 
        {
            OmniOn = false;
        }
        public virtual void OnOmniModeOn(MidiMessage message) 
        {
            OmniOn = true;
        }
        public virtual void OnMonoModeOn(MidiMessage message) 
        {
            MonoMode = true;
            MonoChMin = message.Channel;
            if (message.Data2 == 0)
                MonoChMax = 15;
            else
            {
                MonoChMax = (byte)(MonoChMin + message.Data2);
                if (MonoChMax > 15)
                    MonoChMax = 15;
            }
        }
        public virtual void OnPolyModeOn(MidiMessage message) 
        {
            MonoMode = false;
        }
    }
}