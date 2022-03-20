using Dono.Midi;
using Dono.Midi.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;


namespace Dono.MidiConnectionForUnity
{
    public partial class ChannelMultiSwitcher : MidiDevice
    {
        public override string DefaultDeviceName => "ChannelMultiSwitcher";
        public override bool IsInEnable() => true;
        public override bool IsOutEnable() => false;

        private List<Subject<MidiMessage>> outPortSubjects = new List<Subject<MidiMessage>>();

        [SerializeField] private byte switchCCNum = 90;

        public override void OnNext(MidiMessage value)
        {
            if (!value.IsChannelMessage)
            {
                foreach(var outport in outPortSubjects)
                {
                    outport.OnNext(value);
                }
            }
            else
            {
                if(value.controlChangeType == (ControlChangeType)switchCCNum)
                {
                    channelToOutPort[value.Channel] = value.Data2;
                }
                if (channelToOutPort[value.Channel] < outPortSubjects.Count)
                    outPortSubjects[channelToOutPort[value.Channel]].OnNext(value);
            }
        }

        public override void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public override void OnError(Exception error)
        {
            throw new NotImplementedException();
        }



        public new void Start()        //Caution: Hide base Start()
        {
            base.Start();
            if(outPortSubjects == null)
            {
                outPortSubjects = new List<Subject<MidiMessage>>(); 
            }
            else
            {
                for(int i = 0; i < outPortSubjects.Count; i++)
                {
                    outPortSubjects[i].OnCompleted();
                    outPortSubjects[i].Dispose();
                }
                outPortSubjects.Clear();
            }

            for(int i = 0; i < portCount; i++)
            {
                outPortSubjects.Add(new Subject<MidiMessage>());

                var outPort = outPorts(i);
                for(int j = 0; j < outPort.Count; j++)
                {
                    outPortSubjects[i].Subscribe(outPort[j]);
                }
            }
        }
    }
}