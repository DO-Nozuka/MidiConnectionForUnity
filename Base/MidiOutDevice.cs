using Dono.MidiUtilities.Runtime;
using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Dono.MidiConnectionForUnity.Base
{
    public abstract class MidiOutDevice : MidiDevice
    {
        [SerializeField] protected List<MidiInDevice> MidiOutPort;
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
    }
}