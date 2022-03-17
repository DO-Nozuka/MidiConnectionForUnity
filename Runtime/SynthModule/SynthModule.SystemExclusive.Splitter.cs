using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;


namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiDevice,
       IMidiModule
    {
        public virtual void SystemExclusiveSplitter(MidiMessage message)
        {

        }
    }
}