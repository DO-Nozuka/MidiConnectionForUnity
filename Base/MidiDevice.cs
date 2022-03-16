using Dono.Midi.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Dono.MidiConnectionForUnity
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
        private IDisposable _disposable = null;

        public void Start()
        {
            UpdateSubscribe();
        }
        public void Update()
        {
            UpdateSubscribe();
        }

        //Midi In
        public virtual void OnNext(MidiMessage value) { subject.OnNext(value); }
        public virtual void OnCompleted() { subject.OnCompleted(); }
        public virtual void OnError(Exception error) { subject.OnError(error); }

        private void UpdateSubscribe()
        {
            if (MidiOutPort != null)
            {
                for (int i = 0; i < MidiOutPort.Count; i++)
                {
                    //Enable  && Not Subscribed => Should subscribe.
                    if (MidiOutPort[i].isActiveAndEnabled && MidiOutPort[i]._disposable == null)
                    {
                        MidiOutPort[i]._disposable = subject.Subscribe(MidiOutPort[i]);
                    }
                    //Enable  &&     Subscribed => Do nothing
                    //Disable && Not Subscribed => Do nothing
                    //Disable &&     Subscribed => Should  dispose
                    else if (!MidiOutPort[i].isActiveAndEnabled && MidiOutPort[i]._disposable != null)
                    {
                        MidiOutPort[i]._disposable.Dispose();
                        MidiOutPort[i]._disposable = null;
                    }
                }
            }
        }
    }
}