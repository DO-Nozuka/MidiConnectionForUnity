using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
        MidiInDevice,
        IMidiModule
    {
        public override string DefaultDeviceName => "Synth Module";

        public override void OnNext(MidiMessage message)
        {
            base.OnNext(message);

            AnyMessageSplitter(message);
        }
    }
}