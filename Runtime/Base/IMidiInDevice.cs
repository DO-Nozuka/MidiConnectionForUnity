using Dono.Midi;
using System;

namespace Dono.MidiConnectionForUnity
{
    public interface IMidiInDevice : IObserver<MidiMessage> { }
}