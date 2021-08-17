using Dono.MidiUtilities.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Dono.MidiConnectionForUnity.Base
{
    public abstract class MidiDevice : MonoBehaviour, IMidiInDevice
    {
        //Common
        [SerializeField] public string DeviceName = "";

        public abstract string DefaultDeviceName { get; }

        public string GetDeviceName() => DeviceName;
        public void Reset()
        {
            DeviceName = DefaultDeviceName;
        }



        //Midi Out
        [SerializeField] protected List<MidiInDeviceBase> MidiOutPort;
        protected Subject<MidiMessage> subject = new Subject<MidiMessage>();

        public void Start()
        {
            if (MidiOutPort != null)
            {
                for (int i = 0; i < MidiOutPort.Count; i++)
                {
                    subject.Subscribe(MidiOutPort[i]);
                }
            }
        }

        //Midi In
        public virtual void OnNext(MidiMessage value) { subject.OnNext(value); }
        public virtual void OnCompleted() { subject.OnCompleted(); }
        public virtual void OnError(Exception error) { subject.OnError(error); }
    }
}