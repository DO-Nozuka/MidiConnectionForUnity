using Dono.MidiUtilities.Runtime;
using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Dono.MidiUtilities.UnityDevice
{
    public abstract class MidiOutDevice : MonoBehaviour
    {
        [SerializeField] private List<IObserver<MidiMessage>> MidiOutPort;
        protected Subject<MidiMessage> subject;

        private void Start()
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