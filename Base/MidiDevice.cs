using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dono.MidiConnectionForUnity.Base
{
    public abstract class MidiDevice : MonoBehaviour
    {
        [SerializeField] private string DeviceName = "";
        public abstract string DefaultDeviceName { get; }

        public string GetDeviceName() => DeviceName;

        public void Reset()
        {
            DeviceName = DefaultDeviceName;
        }
    }
}