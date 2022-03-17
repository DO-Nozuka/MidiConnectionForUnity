using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;


namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiDevice,
       IMidiModule
    {
        #region SystemCommon
        public virtual void OnMidiTimeCode(MidiMessage message) { }
        public virtual void OnSongPosition(MidiMessage message) { }
        public virtual void OnSongSelect(MidiMessage message) { }
        public virtual void OnUndefinedF4(MidiMessage message) { }
        public virtual void OnUndefinedF5(MidiMessage message) { }
        public virtual void OnTuneRequest(MidiMessage message) { }
        public virtual void OnEOX(MidiMessage message) { }
        #endregion
    }
}