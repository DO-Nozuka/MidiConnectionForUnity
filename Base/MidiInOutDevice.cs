using Dono.MidiUtilities.Runtime;
using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Dono.MidiUtilities.UnityDevice
{
    public abstract class MidiInOutDevice : MidiOutDevice, IObserver<MidiMessage>
    {
        public virtual void OnNext(MidiMessage value) => subject.OnNext(value);
        public virtual void OnCompleted() => subject.OnCompleted();
        public virtual void OnError(Exception error) => subject.OnError(error);
    }
}