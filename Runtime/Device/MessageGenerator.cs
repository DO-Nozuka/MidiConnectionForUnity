using UnityEngine;
using Dono.Midi;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Dono.MidiConnectionForUnity
{
    public class MessageGenerator : MidiDevice
    {
        public override string DefaultDeviceName => "MessageGenerator";
        public override bool IsInEnable() => false;
        public override bool IsOutEnable() => true;

        // Common
        private byte channel;

        // NoteOff Message(0x8n)
        // NoteOn Message(0x9n)
        private byte noteOffVelocity = 100;
        private byte noteOnVelocity = 100;
        private byte noteNumber = 48;
        public void SendNoteOff(byte num, byte vel)
            => SendMessage(MidiUtilities.GenerateNoteOffMessage(num, vel, channel));
        public void SendNoteOn(byte num, byte vel)
            => SendMessage(MidiUtilities.GenerateNoteOnMessage(num, vel, channel));


        // TODO Other Messages

        // Control Change(1byte)
        private byte _1ccNumber;
        private byte _1ccValue;
        public void Send1ByteCC(byte num, byte val)
            => SendMessage(MidiUtilities.GenerateControlChangeMessage((ControlChangeType)num, val, channel));

        private byte _2ccNumber;
        private byte _2ccMsbValue;
        private byte _2ccLsbValue;
        public void Send2ByteCC(byte msbNum, byte msbVal, byte lsbVal)
        {
            Send1ByteCC(msbNum, msbVal);
            Send1ByteCC((byte)(msbNum + 32), lsbVal);
        }

        // Program Change
        private byte pcNumber;
        public void SendPC(byte num)
        {
            SendMessage(MidiUtilities.GenerateChannelVoiceMessage(ChannelVoiceType.ProgramChange, num, 0, channel));
        }


#if UNITY_EDITOR
        [CustomEditor(typeof(MessageGenerator), true)]
        public class MessageGeneratorEditor : MidiDeviceEditor
        {
            public override void OnInspectorGUI()
            {
                MessageGenerator _target = target as MessageGenerator;

                base.OnInspectorGUI();

                EditorGUILayout.Separator();

                EditorGUILayout.LabelField("Common Settings");
                _target.channel = (byte)EditorGUILayout.IntSlider("Channel", _target.channel, 0, 15);

                EditorGUILayout.Separator();

                // Note On/Off
                EditorGUILayout.LabelField("Note Off", "0x8n kk vv");
                EditorGUILayout.LabelField("Note On", "0x9n kk vv");
                _target.noteOffVelocity = (byte)EditorGUILayout.IntSlider("Velocity", _target.noteOffVelocity, 0, 127);
                _target.noteNumber = (byte)EditorGUILayout.IntSlider("Key Number", _target.noteNumber, 0, 127);
                _target.noteOnVelocity = (byte)EditorGUILayout.IntSlider("Velocity", _target.noteOnVelocity, 0, 127);
                if (GUILayout.Button("Note Off"))
                {
                    _target.SendNoteOff(_target.noteNumber, _target.noteOffVelocity);
                }
                if (GUILayout.Button("Note On"))
                {
                    _target.SendNoteOn(_target.noteNumber, _target.noteOnVelocity);
                }

                EditorGUILayout.Separator();

                // 1Byte CC
                EditorGUILayout.LabelField("1Byte CC", "0xBn cc vv");
                _target._1ccNumber = (byte)EditorGUILayout.IntSlider("Number", _target._1ccNumber, 0, 119);
                _target._1ccValue = (byte)EditorGUILayout.IntSlider("Value", _target._1ccValue, 0, 127);
                if (GUILayout.Button("Send 1Byte CC"))
                {
                    _target.Send1ByteCC(_target._1ccNumber, _target._1ccValue);
                }

                EditorGUILayout.Separator();

                // 2Byte CC
                EditorGUILayout.LabelField("2Byte CC", "0xBn cc vv 0xBn cc+32 vv");
                _target._2ccNumber = (byte)EditorGUILayout.IntSlider("Number", _target._2ccNumber, 0, 31);
                _target._2ccMsbValue = (byte)EditorGUILayout.IntSlider("MSB", _target._2ccMsbValue, 0, 127);
                _target._2ccLsbValue = (byte)EditorGUILayout.IntSlider("LSB", _target._2ccLsbValue, 0, 127);
                if (GUILayout.Button("Send 2Byte CC"))
                {
                    _target.Send2ByteCC(_target._2ccNumber, _target._2ccMsbValue, _target._2ccLsbValue);
                }

                EditorGUILayout.Separator();
                EditorGUILayout.LabelField("Program Change", "0xCn pp");
                _target.pcNumber = (byte)EditorGUILayout.IntSlider("Number", _target.pcNumber, 0, 127);
                if (GUILayout.Button("Send Program Change"))
                {
                    _target.SendPC(_target.pcNumber);
                }
            }
        }
#endif
    }
}