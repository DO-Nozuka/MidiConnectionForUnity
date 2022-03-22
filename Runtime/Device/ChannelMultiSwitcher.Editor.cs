using Dono.Midi;
using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif


namespace Dono.MidiConnectionForUnity
{
    public partial class ChannelMultiSwitcher //: MidiDevice
    {
#if UNITY_EDITOR

        [CustomEditor(typeof(ChannelMultiSwitcher), true)]
        public class ChannelMultiSwitcherEditor : MidiDeviceEditor
        {
            public override void OnInspectorGUI()
            {
                var _target = target as ChannelMultiSwitcher;

                base.OnInspectorGUI();

                EditorGUILayout.Separator();
                EditorGUILayout.LabelField("Switch CC Number");
                _target.switchCCNum = (byte)EditorGUILayout.IntSlider(_target.switchCCNum, 0, 119);

                EditorGUILayout.Separator();
                EditorGUILayout.LabelField("Send Port");
                for(int i = 0; i < 16; i++)
                {
                    EditorGUILayout.LabelField($"Channel {i}:");
                    _target.channelToOutPort[i] = (byte)EditorGUILayout.IntSlider(_target.channelToOutPort[i], 0, _target.portCount - 1);
                }

                EditorGUILayout.Separator();
                EditorGUILayout.LabelField("Out Ports");
                EditorGUILayout.BeginHorizontal();
                if(GUILayout.Button("Add Port") && _target.portCount < maxPorts)
                {
                    _target.portCount++;
                }
                if(GUILayout.Button("Remove Port") && _target.portCount > 0)
                {
                    _target.portCount--;
                }
                if(GUILayout.Button("Remove All"))
                {
                    _target.portCount = 0;
                }
                EditorGUILayout.EndHorizontal();

                if(_target.portCount == 0)
                {
                    EditorGUILayout.LabelField("Port is Nothing");
                }
                for (int i = 0; i < _target.portCount; i++)
                {
                    EditorGUILayout.PropertyField(serializedObject.FindProperty($"outPorts{i}"), true);
                }
            }
        }
#endif
    }
}