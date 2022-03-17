using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;


namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
        MidiDevice,
        IMidiModule
    {
        public override string DefaultDeviceName => "Synth Module";

        public override void OnNext(MidiMessage message)
        {
            base.OnNext(message);

            AnyMessageSplitter(message);
        }

        public SynthModule()
        {
            for (int i = 0; i < 16; i++)
            {
                ChannelState[i] = new SynthModuleChannelState();
            }
        }
    }
}