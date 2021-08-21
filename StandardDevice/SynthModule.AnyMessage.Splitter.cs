using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        public void AnyMessageSplitter(MidiMessage message)
        {
            switch (message.messageType)
            {
                case MessageType.ChannelVoice:
                    ChannelVoiceSplitter(message);
                    break;
                case MessageType.ChannelMode:
                    ChannelModeSplitter(message);
                    break;
                case MessageType.SystemExclusive:
                    SystemExclusiveSplitter(message);
                    break;
                case MessageType.SystemCommon:
                    SystemCommonSplitter(message);
                    break;
                case MessageType.SystemRealtime:
                    SystemRealtimeSplitter(message);
                    break;
                case MessageType.MetaEvent:
                    MetaEventSplitter(message);
                    break;
            }
        }
    }
}