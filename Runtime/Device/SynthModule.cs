using Dono.Midi;

#if UNITY_EDITOR
#endif

namespace Dono.MidiConnectionForUnity
{
    public abstract class SynthModule : MidiDevice
    {
        protected MidiModule midiModule = new MidiModule();

        public override void OnNext(MidiMessage value)
        {
            base.OnNext(value);

            midiModule.RecieveMessage(value);
        }
    }
}
