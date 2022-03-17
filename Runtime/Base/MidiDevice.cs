using Dono.Midi.Runtime;
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
    public abstract class MidiDevice : MonoBehaviour, IMidiInDevice
    {
        //Common
        [SerializeField] public string DeviceName = "";
        [SerializeField] private bool showInLog;
        [SerializeField] private bool showOutLog;

        public abstract string DefaultDeviceName { get; }

        public string GetDeviceName() => DeviceName;
        
        public void Reset()
        {
            DeviceName = DefaultDeviceName;
        }

        // Midi In
        public virtual void OnNext(MidiMessage value)
        {
            if (IsInEnable())
                thruSubject.OnNext(value);

            if (showInLog && IsInEnable())
                Debug.Log(value);
        }
        public virtual void OnCompleted()
        {
            if (IsInEnable())
                thruSubject.OnCompleted();
            if (IsOutEnable())
                outSubject.OnCompleted();
        }
        public virtual void OnError(Exception error)
        {
            if (IsInEnable())
                thruSubject.OnError(error);
            if (IsOutEnable())
                outSubject.OnError(error);
        }


        // Midi Out
        [SerializeField] private List<MidiDevice> outPort;
        private Subject<MidiMessage> outSubject = new Subject<MidiMessage>();
        public void SendMessage(MidiMessage message)
        {
            outSubject.OnNext(message);

            if(showOutLog && IsOutEnable())
                Debug.Log(message);
        }
        private IDisposable outDisposable = null;

        private void UpdateOutPortSubscribe()
        {
            if (outPort != null)
            {
                for (int i = 0; i < outPort.Count; i++)
                {
                    if (outPort[i] == null)
                    {
                        continue;
                    }
                    //Enable  && Not Subscribed => Should subscribe.
                    if (outPort[i].isActiveAndEnabled && outPort[i].outDisposable == null)
                    {
                        outPort[i].outDisposable = outSubject.Subscribe(outPort[i]);
                    }
                    //Enable  &&     Subscribed => Do nothing
                    //Disable && Not Subscribed => Do nothing
                    //Disable &&     Subscribed => Should  dispose
                    else if (!outPort[i].isActiveAndEnabled && outPort[i].outDisposable != null)
                    {
                        outPort[i].outDisposable.Dispose();
                        outPort[i].outDisposable = null;
                    }
                }
            }
        }



        // Midi Thru
        [SerializeField] private List<MidiDevice> thruPort;
        private Subject<MidiMessage> thruSubject = new Subject<MidiMessage>();
        private IDisposable thruDisposable = null;

        private void UpdateThruPortSubscribe()
        {
            if (thruPort != null)
            {
                for (int i = 0; i < thruPort.Count; i++)
                {
                    //Enable  && Not Subscribed => Should subscribe.
                    if (thruPort[i].isActiveAndEnabled && thruPort[i].thruDisposable == null)
                    {
                        thruPort[i].thruDisposable = thruSubject.Subscribe(thruPort[i]);
                    }
                    //Enable  &&     Subscribed => Do nothing
                    //Disable && Not Subscribed => Do nothing
                    //Disable &&     Subscribed => Should  dispose
                    else if (!thruPort[i].isActiveAndEnabled && thruPort[i].thruDisposable != null)
                    {
                        thruPort[i].thruDisposable.Dispose();
                        thruPort[i].thruDisposable = null;
                    }
                }
            }
        }

        // Settings
        public abstract bool IsInEnable();
        public abstract bool IsOutEnable();

        // Unity
        public void Start()
        {
            UpdateOutPortSubscribe();
            UpdateThruPortSubscribe();
        }
        public void Update()
        {
            UpdateOutPortSubscribe();
            UpdateThruPortSubscribe();
        }

#if UNITY_EDITOR
        [CustomEditor(typeof(MidiDevice), true)]
        public class MidiDeviceEditor : Editor
        {
            public override void OnInspectorGUI()
            {
                var _target = target as MidiDevice;
                //base.OnInspectorGUI();

                // DeviceName(string)
                _target.DeviceName = EditorGUILayout.TextField("Device Name", _target.DeviceName);
                // Show In Log
                _target.showInLog = EditorGUILayout.Toggle("Show Input Log", _target.showInLog);
                // Show Out Log
                _target.showOutLog = EditorGUILayout.Toggle("Show Output Log", _target.showOutLog);

                // OutPort
                if(_target.IsOutEnable())
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("outPort"), true);
                // ThruPort
                if(_target.IsInEnable())
                    EditorGUILayout.PropertyField(serializedObject.FindProperty("thruPort"), true);
            }
        }
#endif
    }
}