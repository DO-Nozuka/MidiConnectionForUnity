using Dono.MidiUtilities.Runtime;
using System;

namespace Dono.MidiConnectionForUnity.Base
{
    public abstract class MidiInOutDevice : MidiOutDevice, IObserver<MidiMessage>
    {
        public virtual void OnNext(MidiMessage value) => subject.OnNext(value);
        public virtual void OnCompleted() => subject.OnCompleted();
        public virtual void OnError(Exception error) => subject.OnError(error);
    }
}