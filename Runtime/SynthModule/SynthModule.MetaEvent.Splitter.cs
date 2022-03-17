using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;


namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiDevice,
       IMidiModule
    {

        public virtual void MetaEventSplitter(MidiMessage message)
        {
            switch (message.metaEventType)
            {
                case MetaEventType.SequenceNumber:
                    OnSequenceNumber(message);
                    break;
                case MetaEventType.TextEvent:
                    OnTextEvent(message);
                    break;
                case MetaEventType.CopyrightNotice:
                    OnCopyrightNotice(message);
                    break;
                case MetaEventType.SequenceAndTrackName:
                    OnSequenceAndTrackName(message);
                    break;
                case MetaEventType.InstrumentName:
                    OnInstrumentName(message);
                    break;
                case MetaEventType.Lyric:
                    OnLyric(message);
                    break;
                case MetaEventType.Marker:
                    OnMarker(message);
                    break;
                case MetaEventType.CuePoint:
                    OnCuePoint(message);
                    break;
                case MetaEventType.ChannelPrefix:
                    OnChannelPrefix(message);
                    break;
                case MetaEventType.PortPrefix:
                    OnPortPrefix(message);
                    break;
                case MetaEventType.EndOfTrack:
                    OnEndOfTrack(message);
                    break;
                case MetaEventType.SetTempo:
                    OnSetTempo(message);
                    break;
                case MetaEventType.SMPTEOffset:
                    OnSMPTEOffset(message);
                    break;
                case MetaEventType.TimeSignature:
                    OnTimeSignature(message);
                    break;
                case MetaEventType.KeySignature:
                    OnKeySignature(message);
                    break;
                case MetaEventType.SequencerSpecificMetaEvent:
                    OnSequencerSpecificMetaEvent(message);
                    break;
            }
        }
    }
}