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



        #region OnChannelVoice

        public virtual void OnNoteOff(MidiMessage message) { }

        public virtual void OnNoteOn(MidiMessage message) { }

        public virtual void OnPolyphonicKeyPressure(MidiMessage message) { }

        #region OnControlChange

        public virtual void OnBankSelectMSB(MidiMessage message) { }
        public virtual void OnModulationMSB(MidiMessage message) { }
        public virtual void OnBreathControllerMSB(MidiMessage message) { }
        public virtual void OnUndefined03MSB(MidiMessage message) { }
        public virtual void OnFootControllerMSB(MidiMessage message) { }
        public virtual void OnPortamentoTimeMSB(MidiMessage message) { }
        public virtual void OnDataEntryMSB(MidiMessage message) { }
        public virtual void OnChannelVolumeMSB(MidiMessage message) { }
        public virtual void OnBalanceMSB(MidiMessage message) { }
        public virtual void OnUndefined09MSB(MidiMessage message) { }
        public virtual void OnPanMSB(MidiMessage message) { }
        public virtual void OnExpressionControllerMSB(MidiMessage message) { }
        public virtual void OnEffectControl1MSB(MidiMessage message) { }
        public virtual void OnEffectControl2MSB(MidiMessage message) { }
        public virtual void OnUndefined0EMSB(MidiMessage message) { }
        public virtual void OnUndefined0FMSB(MidiMessage message) { }
        public virtual void OnGeneralPurposeController1MSB(MidiMessage message) { }
        public virtual void OnGeneralPurposeController2MSB(MidiMessage message) { }
        public virtual void OnGeneralPurposeController3MSB(MidiMessage message) { }
        public virtual void OnGeneralPurposeController4MSB(MidiMessage message) { }
        public virtual void OnUndefined14MSB(MidiMessage message) { }
        public virtual void OnUndefined15MSB(MidiMessage message) { }
        public virtual void OnUndefined16MSB(MidiMessage message) { }
        public virtual void OnUndefined17MSB(MidiMessage message) { }
        public virtual void OnUndefined18MSB(MidiMessage message) { }
        public virtual void OnUndefined19MSB(MidiMessage message) { }
        public virtual void OnUndefined1AMSB(MidiMessage message) { }
        public virtual void OnUndefined1BMSB(MidiMessage message) { }
        public virtual void OnUndefined1CMSB(MidiMessage message) { }
        public virtual void OnUndefined1DMSB(MidiMessage message) { }
        public virtual void OnUndefined1EMSB(MidiMessage message) { }
        public virtual void OnUndefined1FMSB(MidiMessage message) { }
        public virtual void OnBankSelectLSB(MidiMessage message) { }
        public virtual void OnModulationWheelLSB(MidiMessage message) { }
        public virtual void OnBreathControllerLSB(MidiMessage message) { }
        public virtual void OnUndefined03LSB(MidiMessage message) { }
        public virtual void OnFootControllerLSB(MidiMessage message) { }
        public virtual void OnPortamentoTimeLSB(MidiMessage message) { }
        public virtual void OnDataEntryLSB(MidiMessage message) { }
        public virtual void OnChannelVolumeLSB(MidiMessage message) { }
        public virtual void OnBalanceLSB(MidiMessage message) { }
        public virtual void OnUndefined09LSB(MidiMessage message) { }
        public virtual void OnPanLSB(MidiMessage message) { }
        public virtual void OnExpressionControllerLSB(MidiMessage message) { }
        public virtual void OnEffectControl1LSB(MidiMessage message) { }
        public virtual void OnEffectControl2LSB(MidiMessage message) { }
        public virtual void OnUndefined0ELSB(MidiMessage message) { }
        public virtual void OnUndefined0FLSB(MidiMessage message) { }
        public virtual void OnGeneralPurposeController1LSB(MidiMessage message) { }
        public virtual void OnGeneralPurposeController2LSB(MidiMessage message) { }
        public virtual void OnGeneralPurposeController3LSB(MidiMessage message) { }
        public virtual void OnGeneralPurposeController4LSB(MidiMessage message) { }
        public virtual void OnUndefined14LSB(MidiMessage message) { }
        public virtual void OnUndefined15LSB(MidiMessage message) { }
        public virtual void OnUndefined16LSB(MidiMessage message) { }
        public virtual void OnUndefined17LSB(MidiMessage message) { }
        public virtual void OnUndefined18LSB(MidiMessage message) { }
        public virtual void OnUndefined19LSB(MidiMessage message) { }
        public virtual void OnUndefined1ALSB(MidiMessage message) { }
        public virtual void OnUndefined1BLSB(MidiMessage message) { }
        public virtual void OnUndefined1CLSB(MidiMessage message) { }
        public virtual void OnUndefined1DLSB(MidiMessage message) { }
        public virtual void OnUndefined1ELSB(MidiMessage message) { }
        public virtual void OnUndefined1FLSB(MidiMessage message) { }
        public virtual void OnHold(MidiMessage message) { }
        public virtual void OnPortamento(MidiMessage message) { }
        public virtual void OnSostenuto(MidiMessage message) { }
        public virtual void OnSoftPedal(MidiMessage message) { }
        public virtual void OnLegatoFootswitch(MidiMessage message) { }
        public virtual void OnHold2(MidiMessage message) { }
        public virtual void OnSoundController1(MidiMessage message) { }
        public virtual void OnSoundController2(MidiMessage message) { }
        public virtual void OnSoundController3(MidiMessage message) { }
        public virtual void OnSoundController4(MidiMessage message) { }
        public virtual void OnSoundController5(MidiMessage message) { }
        public virtual void OnSoundController6(MidiMessage message) { }
        public virtual void OnSoundController7(MidiMessage message) { }
        public virtual void OnSoundController8(MidiMessage message) { }
        public virtual void OnSoundController9(MidiMessage message) { }
        public virtual void OnSoundController10(MidiMessage message) { }
        public virtual void OnGeneralPurposeController5(MidiMessage message) { }
        public virtual void OnGeneralPurposeController6(MidiMessage message) { }
        public virtual void OnGeneralPurposeController7(MidiMessage message) { }
        public virtual void OnGeneralPurposeController8(MidiMessage message) { }
        public virtual void OnPortamentoControl(MidiMessage message) { }
        public virtual void OnUndefined55(MidiMessage message) { }
        public virtual void OnUndefined56(MidiMessage message) { }
        public virtual void OnUndefined57(MidiMessage message) { }
        public virtual void OnUndefined58(MidiMessage message) { }
        public virtual void OnUndefined59(MidiMessage message) { }
        public virtual void OnUndefined60(MidiMessage message) { }
        public virtual void OnEffects1Depth(MidiMessage message) { }
        public virtual void OnEffects2Depth(MidiMessage message) { }
        public virtual void OnEffects3Depth(MidiMessage message) { }
        public virtual void OnEffects4Depth(MidiMessage message) { }
        public virtual void OnEffects5Depth(MidiMessage message) { }
        public virtual void OnDataIncrement(MidiMessage message) { }
        public virtual void OnDataDecrement(MidiMessage message) { }
        public virtual void OnNonRegisteredParameterNumberLSB(MidiMessage message) { }
        public virtual void OnNonRegisteredParameterNumberMSB(MidiMessage message) { }
        public virtual void OnRegisteredParameterNumberLSB(MidiMessage message) { }
        public virtual void OnRegisteredParameterNumberMSB(MidiMessage message) { }
        public virtual void OnUndefined66(MidiMessage message) { }
        public virtual void OnUndefined67(MidiMessage message) { }
        public virtual void OnUndefined68(MidiMessage message) { }
        public virtual void OnUndefined69(MidiMessage message) { }
        public virtual void OnUndefined6A(MidiMessage message) { }
        public virtual void OnUndefined6B(MidiMessage message) { }
        public virtual void OnUndefined6C(MidiMessage message) { }
        public virtual void OnUndefined6D(MidiMessage message) { }
        public virtual void OnUndefined6E(MidiMessage message) { }
        public virtual void OnUndefined6F(MidiMessage message) { }
        public virtual void OnUndefined70(MidiMessage message) { }
        public virtual void OnUndefined71(MidiMessage message) { }
        public virtual void OnUndefined72(MidiMessage message) { }
        public virtual void OnUndefined73(MidiMessage message) { }
        public virtual void OnUndefined74(MidiMessage message) { }
        public virtual void OnUndefined75(MidiMessage message) { }
        public virtual void OnUndefined76(MidiMessage message) { }
        public virtual void OnUndefined77(MidiMessage message) { }
        #endregion

        public virtual void OnProgramChange(MidiMessage message) { }
        public virtual void OnChannelPressure(MidiMessage message) { }
        public virtual void OnPitchBendChange(MidiMessage message) { }
        #endregion

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

        #region OnSystemExclusive

        #endregion

        #region SystemCommon

        public virtual void OnMidiTimeCode(MidiMessage message) { }
        public virtual void OnSongPosition(MidiMessage message) { }
        public virtual void OnSongSelect(MidiMessage message) { }
        public virtual void OnUndefinedF4(MidiMessage message) { }
        public virtual void OnUndefinedF5(MidiMessage message) { }
        public virtual void OnTuneRequest(MidiMessage message) { }
        public virtual void OnEOX(MidiMessage message) { }
        #endregion

        #region OnSystemRealtime

        public virtual void OnTimingClock(MidiMessage message) { }
        public virtual void OnUndefinedF9(MidiMessage message) { }
        public virtual void OnStart(MidiMessage message) { }
        public virtual void OnContinue(MidiMessage message) { }
        public virtual void OnStop(MidiMessage message) { }
        public virtual void OnUndefinedFD(MidiMessage message) { }
        public virtual void OnActiveSensing(MidiMessage message) { }
        public virtual void OnReset(MidiMessage message) { }
        #endregion

        #region OnMetaEvent

        public virtual void OnSequenceNumber(MidiMessage message) { }
        public virtual void OnTextEvent(MidiMessage message) { }
        public virtual void OnCopyrightNotice(MidiMessage message) { }
        public virtual void OnSequenceAndTrackName(MidiMessage message) { }
        public virtual void OnInstrumentName(MidiMessage message) { }
        public virtual void OnLyric(MidiMessage message) { }
        public virtual void OnMarker(MidiMessage message) { }
        public virtual void OnCuePoint(MidiMessage message) { }
        public virtual void OnChannelPrefix(MidiMessage message) { }
        public virtual void OnPortPrefix(MidiMessage message) { }
        public virtual void OnEndOfTrack(MidiMessage message) { }
        public virtual void OnSetTempo(MidiMessage message) { }
        public virtual void OnSMPTEOffset(MidiMessage message) { }
        public virtual void OnTimeSignature(MidiMessage message) { }
        public virtual void OnKeySignature(MidiMessage message) { }
        public virtual void OnSequencerSpecificMetaEvent(MidiMessage message) { }
        #endregion

    }
}