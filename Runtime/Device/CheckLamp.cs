using Dono.Midi;
using UnityEngine;


#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Dono.MidiConnectionForUnity
{
    public class CheckLamp : MidiDevice
    {
        [SerializeField] GameObject lamp;

        [Header("Lamp Setting")]
        [SerializeField, Range(0.0f, 1.0f)] private float lifeTime = 0.1f;
        private float lampTime = 0.0f;

        public override string DefaultDeviceName => "CheckLamp";
        public override bool IsInEnable() => true;
        public override bool IsOutEnable() => false;

        public override void OnNext(MidiMessage value)
        {
            base.OnNext(value);

            lampTime = lifeTime;
        }

        public new void Start()
        {
            base.Start();
        }

        public new void Update()
        {
            base.Update();

            if (lamp == null)
                return;

            lampTime -= Time.deltaTime;
            if (lampTime <= 0.0f)
                lampTime = 0.0f;

            if (lampTime > 0)
                lamp.SetActive(true);
            else
                lamp.SetActive(false);
        }
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(CheckLamp), true)]
    public class MidiDeviceEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }
    }
#endif
}