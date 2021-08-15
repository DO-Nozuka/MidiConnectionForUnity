using Dono.MidiConnectionForUnity.Base;
using Dono.MidiUtilities.Runtime;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace MidiConnectionForUnity.StandardDevice
{
    public class MidiDeviceSwitcher : MidiInOutDevice
    {
        [SerializeField] private bool ToMainSwitch;
        [SerializeField] private List<MidiInDevice> SubMidiOutPort;
        protected Subject<MidiMessage> subSubject;

        public new void Start()        //Caution: Hide base Start()
        {
            base.Start();

            if (SubMidiOutPort != null)
            {
                for (int i = 0; i < SubMidiOutPort.Count; i++)
                {
                    subject.Subscribe(SubMidiOutPort[i]);
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
    }
}