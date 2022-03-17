using Dono.Midi.Runtime;
using System;

namespace Dono.MidiConnectionForUnity
{
    public interface IMidiInDevice : IObserver<MidiMessage> { }
}