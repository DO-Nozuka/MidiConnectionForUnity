using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;

namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        public virtual void OnTimingClock(MidiMessage message) { }
        public virtual void OnUndefinedF9(MidiMessage message) { }
        public virtual void OnStart(MidiMessage message) { }
        public virtual void OnContinue(MidiMessage message) { }
        public virtual void OnStop(MidiMessage message) { }
        public virtual void OnUndefinedFD(MidiMessage message) { }
        public virtual void OnActiveSensing(MidiMessage message) { }
        public virtual void OnReset(MidiMessage message) { }
    }
}