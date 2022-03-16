
using Dono.Midi.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Dono.MidiConnectionForUnity
{
    public class MidiDeviceSwitcher : MidiInOutDevice
    {
        public override string DefaultDeviceName => "MidiSwitcher";

        [SerializeField] private bool ToMainSwitch = true;
        [SerializeField] private List<MidiInDevice> SubMidiOutPort;
        protected Subject<MidiMessage> subSubject = new Subject<MidiMessage>();


        public new void Start()        //Caution: Hide base Start()
        {
            base.Start();

            if (SubMidiOutPort != null)
            {
                for (int i = 0; i < SubMidiOutPort.Count; i++)
                {
                    subSubject.Subscribe(SubMidiOutPort[i]);
                }
            }
        }

        public override void OnNext(MidiMessage value)
        {
            if (ToMainSwitch)
                subject.OnNext(value);
            else
                subSubject.OnNext(value);
        }

        public override void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public override void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
    }
}