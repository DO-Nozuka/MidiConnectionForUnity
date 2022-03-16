using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;


namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        #region OnMetaEvent
        public virtual void OnSequenceNumber(MidiMessage message) { }
        public virtual void OnTextEvent(MidiMessage message) { }
        public virtual void OnCopyrightNotice(MidiMessage message) { }
        public virtual void OnSequenceAndTrackName(MidiMessage message) { }
        public virtual void OnInstrumentName(MidiMessage message) { }
        public virtual void OnLyric(MidiMessage message) { }
        public virtual void OnMarker(MidiMessage message) { }
        public virtual void OnCuePoint(MidiMessage message) { }
        public virtual void OnChannelPrefix(MidiMessage message) { }
        public virtual void OnPortPrefix(MidiMessage message) { }
        public virtual void OnEndOfTrack(MidiMessage message) { }
        public virtual void OnSetTempo(MidiMessage message) { }
        public virtual void OnSMPTEOffset(MidiMessage message) { }
        public virtual void OnTimeSignature(MidiMessage message) { }
        public virtual void OnKeySignature(MidiMessage message) { }
        public virtual void OnSequencerSpecificMetaEvent(MidiMessage message) { }
        #endregion
    }
}