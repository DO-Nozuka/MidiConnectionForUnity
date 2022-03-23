using Dono.Midi;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Dono.MidiConnectionForUnity
{
    public class ChannelFilter : MidiDevice
    {
        public override string DefaultDeviceName => "ChannelFilter";
        public override bool IsInEnable() => false;
        public override bool IsOutEnable() => true;

        // [Header("Channel Enable")]
        [SerializeField] private bool[] _channelEnable = new bool[16];

        // [Header("Option")]
        [SerializeField] private bool nonChannelMessageOutput = false;

        public override void OnNext(MidiMessage value)
        {
            if (value.messageType == Midi.MessageType.ChannelMode
                || value.messageType == Midi.MessageType.ChannelVoice)
            {
                byte channel = value.Channel;
                if (_channelEnable[channel])
                    SendMessage(value);
            }
            else
            {
                if (nonChannelMessageOutput)
                    SendMessage(value);
            }
        }

        public void SetAllToMain()
        {
            for (int i = 0; i < _channelEnable.Length; i++)
                _channelEnable[i] = true;
        }

        public void SetAllToSub()
        {
            for (int i = 0; i < _channelEnable.Length; i++)
                _channelEnable[i] = false;
        }


#if UNITY_EDITOR
        [CustomEditor(typeof(ChannelFilter), true)]
        public class ChannelFilterEditor : MidiDeviceEditor
        {
            public override void OnInspectorGUI()
            {
                var _target = target as ChannelFilter;

                base.OnInspectorGUI();

                EditorGUILayout.LabelField("Channel Enable");
                for (int i = 0; i < _target._channelEnable.Length; i++)
                    _target._channelEnable[i] = EditorGUILayout.Toggle($"Channel {i + 1}", _target._channelEnable[i]);

                EditorGUILayout.LabelField("Option");
                _target.nonChannelMessageOutput = EditorGUILayout.Toggle("Channel", _target.nonChannelMessageOutput);
            }
        }
#endif
    }
}
