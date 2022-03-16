using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;


namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        public virtual void ChannelModeSplitter(MidiMessage message)
        {
            switch (message.channelModeType)
            {
                case ChannelModeType.AllSoundOff:
                    OnAllSoundOff(message);
                    break;
                case ChannelModeType.ResetAllControllers:
                    OnResetAllControllers(message);
                    break;
                case ChannelModeType.LocalControl:
                    OnLocalControl(message);
                    break;
                case ChannelModeType.AllNotesOff:
                    OnAllNotesOff(message);
                    break;
                case ChannelModeType.OmniModeOff:
                    OnOmniModeOff(message);
                    break;
                case ChannelModeType.OmniModeOn:
                    OnOmniModeOn(message);
                    break;
                case ChannelModeType.MonoModeOn:
                    OnMonoModeOn(message);
                    break;
                case ChannelModeType.PolyModeOn:
                    OnPolyModeOn(message);
                    break;
            }
        }
    }
}