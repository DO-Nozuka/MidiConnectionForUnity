using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;


namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        public virtual void SystemExclusiveSplitter(MidiMessage message)
        {

        }
    }
}