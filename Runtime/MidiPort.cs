using System;
using System.Collections.Generic;

#if UNITY_EDITOR
#endif

namespace Dono.MidiConnectionForUnity
{
    [Serializable]
    public class MidiPort : List<MidiDevice> { };
}