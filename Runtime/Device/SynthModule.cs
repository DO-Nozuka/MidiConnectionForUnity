using Dono.Midi;
using System;

#if UNITY_EDITOR
#endif

namespace Dono.MidiConnectionForUnity
{
    public abstract class SynthModule : MidiDevice
    {
        protected MidiModule midiModule = new MidiModule();
        private ChannelState[] channelState => midiModule.ChannelState;

        public abstract string GetPatchName(byte channel);
        public override void OnNext(MidiMessage value)
        {
            base.OnNext(value);

            midiModule.RecieveMessage(value);
        }

        /* インターフェース */
        // 0xCn Program
        public Action<Midi1ByteValue> ProgramChangeCallback;
        public Midi1ByteValue GetProgramChange(byte ch) => channelState[ch].Program;
        public void SetProgram(byte ch, byte value)
        {
            channelState[ch].Program.SetValue(value);
            var val = channelState[ch].Program;
            ProgramChangeCallback?.Invoke(val);
        }
        private void OnProgramChange(MidiMessage message)
        {
            var ch = message.Channel;
            var val = channelState[ch].Program;
            ProgramChangeCallback?.Invoke(val);
        }
        // CC:0x00 Bank
        public Action<Midi2ByteValue> BankChangeCallback;
        public Midi2ByteValue GetBank(byte ch) => channelState[ch].DoubleCC.BankSelect;
        public void SetBankMSB(byte ch, byte msb)
        {
            channelState[ch].DoubleCC.BankSelect.SetMsb(msb);
            var val = channelState[ch].DoubleCC.BankSelect;
            BankChangeCallback?.Invoke(val);
        }
        public void SetBankLSB(byte ch, byte lsb)
        {
            channelState[ch].DoubleCC.BankSelect.SetLsb(lsb);
            var val = channelState[ch].DoubleCC.BankSelect;
            BankChangeCallback?.Invoke(val);
        }
        private void OnBankChange(MidiMessage message)
        {
            var ch = message.Channel;
            var val = channelState[ch].DoubleCC.BankSelect;
            BankChangeCallback?.Invoke(val);
        }

        // CC:0x07 Volume 
        public Action<byte, Midi2ByteValue> VolumeChangeCallback;
        public Midi2ByteValue GetVolume(byte ch) => channelState[ch].DoubleCC.ChannelVolume;
        public void SetVolumeRate(byte ch, float rate)
        {
            channelState[ch].DoubleCC.ChannelVolume.SetRate(rate);
            VolumeChangeCallback?.Invoke(ch, channelState[ch].DoubleCC.ChannelVolume);
        }
        public void SetVolumeValue(byte ch, int value)
        {
            channelState[ch].DoubleCC.ChannelVolume.SetValue(value);
            VolumeChangeCallback?.Invoke(ch, channelState[ch].DoubleCC.ChannelVolume);
        }
        private void OnVolumeChange(MidiMessage message)
        {
            var ch = message.Channel;
            VolumeChangeCallback?.Invoke(ch, channelState[ch].DoubleCC.ChannelVolume);
        }

        // CC:0x0B Expression
        public Action<byte, Midi2ByteValue> ExpressionChangeCallback;
        public Midi2ByteValue GetExpression(byte ch) => channelState[ch].DoubleCC.ExpressionController;
        public void SetExpressionRate(byte ch, float rate)
        {
            channelState[ch].DoubleCC.ExpressionController.SetRate(rate);
            ExpressionChangeCallback?.Invoke(ch, channelState[ch].DoubleCC.ExpressionController);
        }
        public void SetExpressionValue(byte ch, int value)
        {
            channelState[ch].DoubleCC.ExpressionController.SetValue(value);
            ExpressionChangeCallback?.Invoke(ch, channelState[ch].DoubleCC.ExpressionController);
        }
        private void OnExpressionChange(MidiMessage message)
        {
            var ch = message.Channel;
            ExpressionChangeCallback?.Invoke(ch, channelState[ch].DoubleCC.ExpressionController);
        }

        // DataEntry
        private void OnDataEntryChange(MidiMessage message)
        {
            var ch = message.Channel;
            var RPNMSB = channelState[ch].SingleCC.RegisteredParameterNumberMSB.Value;
            var RPNLSB = channelState[ch].SingleCC.RegisteredParameterNumberLSB.Value;
            if (RPNMSB == 0x00 && RPNLSB == 0x00)    // PitchBendRange
            {
                PitchBendRangeChangeCallback?.Invoke(ch, channelState[ch].Parameter.PitchBendSensitivity);
            }
        }

        // RPN
        public Action<byte, PitchBendSensitivity> PitchBendRangeChangeCallback;
        public PitchBendSensitivity GetPitchBendRange(byte ch) => channelState[ch].Parameter.PitchBendSensitivity;
        public void SetPitchRange(byte ch, int value)
        {
            channelState[ch].Parameter.PitchBendSensitivity.SetValue(value);
            var val = channelState[ch].Parameter.PitchBendSensitivity.Value;
            PitchBendRangeChangeCallback?.Invoke(ch, channelState[ch].Parameter.PitchBendSensitivity);
        }


        public SynthModule()
        {
            midiModule.OnProgramChange += OnProgramChange;
            midiModule.OnBankSelectChange += OnBankChange;
            midiModule.OnChannelVolumeChange += OnVolumeChange;
            midiModule.OnExpressionControllerChange += OnExpressionChange;
            midiModule.OnDataEntryChange += OnDataEntryChange;
        }
        ~SynthModule()
        {
            midiModule.OnProgramChange -= OnProgramChange;
            midiModule.OnBankSelectChange -= OnBankChange;
            midiModule.OnChannelVolumeChange -= OnVolumeChange;
            midiModule.OnExpressionControllerChange -= OnExpressionChange;
            midiModule.OnDataEntryChange -= OnDataEntryChange;
        }
    }
}
