
using Dono.Midi.Runtime;
using UnityEngine;


namespace Dono.MidiConnectionForUnity
{
    public class MessageStatusFilter : MidiInOutDevice
    {
        private bool[] _statusEnables = new bool[8];

        [Header("Status Enable")]
        [SerializeField] private bool NoteOff = true;
        [SerializeField] private bool NoteOn = true;
        [SerializeField] private bool PolyphonicKeyPressure = true;
        [SerializeField] private bool ControlChange = true;
        [SerializeField] private bool ProgramChange = true;
        [SerializeField] private bool ChannelPressure = true;
        [SerializeField] private bool PitchBend = true;
        [SerializeField] private bool System = true;
        public override string DefaultDeviceName => "MessageStatusFilter";

        public override void OnNext(MidiMessage value)
        {
            UpdateStatusEnables();
            if(_statusEnables[value.Status & 0b00000111])
            {
                subject.OnNext(value);
            }
        }

        public void SetAllEnable()
        {
            NoteOff = true;
            NoteOn = true;
            PolyphonicKeyPressure = true;
            ControlChange = true;
            ProgramChange = true;
            ChannelPressure = true;
            PitchBend = true;
            System = true;
        }

        public void SetAllDisable()
        {
            NoteOff = false;
            NoteOn = false;
            PolyphonicKeyPressure = false;
            ControlChange = false;
            ProgramChange = false;
            ChannelPressure = false;
            PitchBend = false;
            System = false;
        }

        private void UpdateStatusEnables()
        {
            _statusEnables[0] = NoteOff;
            _statusEnables[1] = NoteOn;
            _statusEnables[2] = PolyphonicKeyPressure;
            _statusEnables[3] = ControlChange;
            _statusEnables[4] = ProgramChange;
            _statusEnables[5] = ChannelPressure;
            _statusEnables[6] = PitchBend;
            _statusEnables[7] = System;
        }
    }
}