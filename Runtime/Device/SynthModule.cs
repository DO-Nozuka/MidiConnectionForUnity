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
        public void SetProgram(byte ch, byte value) => channelState[ch].Program.SetValue(value);
        private void OnProgramChange(MidiMessage message)
        {
            var ch = message.Channel;
            var val = channelState[ch].Program;
            ProgramChangeCallback?.Invoke(val);
        }
        // CC:0x00 Bank
        public Action<Midi2ByteValue> BankChangeCallback;
        public Midi2ByteValue GetBank(byte ch) => channelState[ch].DoubleCC.BankSelect;
        public void SetBankMSB(byte ch, byte msb) => channelState[ch].DoubleCC.BankSelect.SetMsb(msb);
        public void SetBankLSB(byte ch, byte lsb) => channelState[ch].DoubleCC.BankSelect.SetLsb(lsb);
        private void OnBankChange(MidiMessage message)
        {
            var ch = message.Channel;
            var val = channelState[ch].DoubleCC.BankSelect;
            BankChangeCallback?.Invoke(val);
        }

        // CC:0x07 Volume 
        public Action<byte, int> VolumeChangeCallback;
        public Midi2ByteValue GetVolume(byte ch) => channelState[ch].DoubleCC.ChannelVolume;
        public void SetVolumeRate(byte ch, float rate) => channelState[ch].DoubleCC.ChannelVolume.SetRate(rate);
        public void SetVolumeValue(byte ch, int value) => channelState[ch].DoubleCC.ChannelVolume.SetValue(value);
        private void OnVolumeChange(MidiMessage message)
        {
            var ch = message.Channel;
            var val = channelState[ch].DoubleCC.ChannelVolume.Value;
            VolumeChangeCallback?.Invoke(ch, val);
        }

        // CC:0x0B Expression
        public Action<byte, int> ExpressionChangeCallback;
        public Midi2ByteValue GetExpression(byte ch) => channelState[ch].DoubleCC.ExpressionController;
        public void SetExpressionRate(byte ch, float rate) => channelState[ch].DoubleCC.ExpressionController.SetRate(rate);
        public void SetExpressionValue(byte ch, int value) => channelState[ch].DoubleCC.ExpressionController.SetValue(value);
        private void OnExpressionChange(MidiMessage message)
        {
            var ch = message.Channel;
            var val = channelState[ch].DoubleCC.ExpressionController.Value;
            ExpressionChangeCallback?.Invoke(ch, val);
        }

        // DataEntry
        private void OnDataEntryChange(MidiMessage message)
        {
            var ch = message.Channel;
            var RPNMSB = channelState[ch].SingleCC.RegisteredParameterNumberMSB.Value;
            var RPNLSB = channelState[ch].SingleCC.RegisteredParameterNumberLSB.Value;
            if (RPNMSB == 0x00 && RPNLSB == 0x00)    // PitchBendRange
            {
                var val = channelState[message.Channel].Parameter.PitchBendSensitivity.Value;
                PitchBendRangeChangeCallback?.Invoke(ch, val);
            }
        }

        // RPN
        public Action<byte, int> PitchBendRangeChangeCallback;
        public PitchBendSensitivity GetPitchBendRange(byte ch) => channelState[ch].Parameter.PitchBendSensitivity;
        public void SetPitchRange(byte ch, int value) => channelState[ch].Parameter.PitchBendSensitivity.SetValue(value);


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
