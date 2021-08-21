using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        public virtual void SystemCommonSplitter(MidiMessage message)
        {
            switch (message.systemCommonType)
            {
                case SystemCommonType.MidiTimeCode:
                    OnMidiTimeCode(message);
                    break;
                case SystemCommonType.SongPosition:
                    OnSongPosition(message);
                    break;
                case SystemCommonType.SongSelect:
                    OnSongSelect(message);
                    break;
                case SystemCommonType.UndefinedF4:
                    OnUndefinedF4(message);
                    break;
                case SystemCommonType.UndefinedF5:
                    OnUndefinedF5(message);
                    break;
                case SystemCommonType.TuneRequest:
                    OnTuneRequest(message);
                    break;
                case SystemCommonType.EOX:
                    OnEOX(message);
                    break;
            }
        }

    }
}