using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        #region OnChannelMode

        public virtual void OnAllSoundOff(MidiMessage message) { }
        public virtual void OnResetAllControllers(MidiMessage message) { }
        public virtual void OnLocalControl(MidiMessage message) { }
        public virtual void OnAllNotesOff(MidiMessage message) { }
        public virtual void OnOmniModeOff(MidiMessage message) { }
        public virtual void OnOmniModeOn(MidiMessage message) { }
        public virtual void OnMonoModeOn(MidiMessage message) { }
        public virtual void OnPolyModeOn(MidiMessage message) { }
        #endregion
    }
}