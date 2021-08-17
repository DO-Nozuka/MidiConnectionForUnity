using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace Dono.MidiConnectionForUnity.Base
{
    [CustomEditor(typeof(MidiInDevice), true)]
    public class MidiInDeviceEditor : Editor
    {
        private MidiInDevice _target;

        private void Awake()
        {
            _target = target as MidiInDevice;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            string str = "";
            str += $"FIXME:\r\n";
            str += $"MidiOutPort is shown,\r\n";
            str += $"but the MidiInDevice cannot use it.";
            //str += $"\r\n";
            EditorGUILayout.HelpBox(str, MessageType.Info);
        }
    }
}