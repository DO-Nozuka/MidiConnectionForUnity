using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;

namespace Dono.MidiConnectionForUnity
{
    public partial class SynthModule :
       MidiDevice,
       IMidiModule
    {

        public virtual void SystemRealtimeSplitter(MidiMessage message)
        {
            switch (message.systemRealtimeType)
            {
                case SystemRealTimeType.TimingClock:
                    OnTimingClock(message);
                    break;
                case SystemRealTimeType.UndefinedF9:
                    OnUndefinedF9(message);
                    break;
                case SystemRealTimeType.Start:
                    OnStart(message);
                    break;
                case SystemRealTimeType.Continue:
                    OnContinue(message);
                    break;
                case SystemRealTimeType.Stop:
                    OnStop(message);
                    break;
                case SystemRealTimeType.UndefinedFD:
                    OnUndefinedFD(message);
                    break;
                case SystemRealTimeType.ActiveSensing:
                    OnActiveSensing(message);
                    break;
                case SystemRealTimeType.Reset:
                    OnReset(message);
                    break;
            }
        }
    }
}