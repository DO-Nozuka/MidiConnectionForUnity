using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {
        public virtual void ControlChangeSplitter(MidiMessage message)
        {
            switch (message.controlChangeType)
            {
                case ControlChangeType.BankSelectMSB:
                    OnBankSelectMSB(message);
                    break;
                case ControlChangeType.ModulationMSB:
                    OnModulationMSB(message);
                    break;
                case ControlChangeType.BreathControllerMSB:
                    OnBreathControllerMSB(message);
                    break;
                case ControlChangeType.Undefined03MSB:
                    OnUndefined03MSB(message);
                    break;
                case ControlChangeType.FootControllerMSB:
                    OnFootControllerMSB(message);
                    break;
                case ControlChangeType.PortamentoTimeMSB:
                    OnPortamentoTimeMSB(message);
                    break;
                case ControlChangeType.DataEntryMSB:
                    OnDataEntryMSB(message);
                    break;
                case ControlChangeType.ChannelVolumeMSB:
                    OnChannelVolumeMSB(message);
                    break;
                case ControlChangeType.BalanceMSB:
                    OnBalanceMSB(message);
                    break;
                case ControlChangeType.Undefined09MSB:
                    OnUndefined09MSB(message);
                    break;
                case ControlChangeType.PanMSB:
                    OnPanMSB(message);
                    break;
                case ControlChangeType.ExpressionControllerMSB:
                    OnExpressionControllerMSB(message);
                    break;
                case ControlChangeType.EffectControl1MSB:
                    OnEffectControl1MSB(message);
                    break;
                case ControlChangeType.EffectControl2MSB:
                    OnEffectControl2MSB(message);
                    break;
                case ControlChangeType.Undefined0EMSB:
                    OnUndefined0EMSB(message);
                    break;
                case ControlChangeType.Undefined0FMSB:
                    OnUndefined0FMSB(message);
                    break;
                case ControlChangeType.GeneralPurposeController1MSB:
                    OnGeneralPurposeController1MSB(message);
                    break;
                case ControlChangeType.GeneralPurposeController2MSB:
                    OnGeneralPurposeController2MSB(message);
                    break;
                case ControlChangeType.GeneralPurposeController3MSB:
                    OnGeneralPurposeController3MSB(message);
                    break;
                case ControlChangeType.GeneralPurposeController4MSB:
                    OnGeneralPurposeController4MSB(message);
                    break;
                case ControlChangeType.Undefined14MSB:
                    OnUndefined14MSB(message);
                    break;
                case ControlChangeType.Undefined15MSB:
                    OnUndefined15MSB(message);
                    break;
                case ControlChangeType.Undefined16MSB:
                    OnUndefined16MSB(message);
                    break;
                case ControlChangeType.Undefined17MSB:
                    OnUndefined17MSB(message);
                    break;
                case ControlChangeType.Undefined18MSB:
                    OnUndefined18MSB(message);
                    break;
                case ControlChangeType.Undefined19MSB:
                    OnUndefined19MSB(message);
                    break;
                case ControlChangeType.Undefined1AMSB:
                    OnUndefined1AMSB(message);
                    break;
                case ControlChangeType.Undefined1BMSB:
                    OnUndefined1BMSB(message);
                    break;
                case ControlChangeType.Undefined1CMSB:
                    OnUndefined1CMSB(message);
                    break;
                case ControlChangeType.Undefined1DMSB:
                    OnUndefined1DMSB(message);
                    break;
                case ControlChangeType.Undefined1EMSB:
                    OnUndefined1EMSB(message);
                    break;
                case ControlChangeType.Undefined1FMSB:
                    OnUndefined1FMSB(message);
                    break;
                case ControlChangeType.BankSelectLSB:
                    OnBankSelectLSB(message);
                    break;
                case ControlChangeType.ModulationWheelLSB:
                    OnModulationLSB(message);
                    break;
                case ControlChangeType.BreathControllerLSB:
                    OnBreathControllerLSB(message);
                    break;
                case ControlChangeType.Undefined03LSB:
                    OnUndefined03LSB(message);
                    break;
                case ControlChangeType.FootControllerLSB:
                    OnFootControllerLSB(message);
                    break;
                case ControlChangeType.PortamentoTimeLSB:
                    OnPortamentoTimeLSB(message);
                    break;
                case ControlChangeType.DataEntryLSB:
                    OnDataEntryLSB(message);
                    break;
                case ControlChangeType.ChannelVolumeLSB:
                    OnChannelVolumeLSB(message);
                    break;
                case ControlChangeType.BalanceLSB:
                    OnBalanceLSB(message);
                    break;
                case ControlChangeType.Undefined09LSB:
                    OnUndefined09LSB(message);
                    break;
                case ControlChangeType.PanLSB:
                    OnPanLSB(message);
                    break;
                case ControlChangeType.ExpressionControllerLSB:
                    OnExpressionControllerLSB(message);
                    break;
                case ControlChangeType.EffectControl1LSB:
                    OnEffectControl1LSB(message);
                    break;
                case ControlChangeType.EffectControl2LSB:
                    OnEffectControl2LSB(message);
                    break;
                case ControlChangeType.Undefined0ELSB:
                    OnUndefined0ELSB(message);
                    break;
                case ControlChangeType.Undefined0FLSB:
                    OnUndefined0FLSB(message);
                    break;
                case ControlChangeType.GeneralPurposeController1LSB:
                    OnGeneralPurposeController1LSB(message);
                    break;
                case ControlChangeType.GeneralPurposeController2LSB:
                    OnGeneralPurposeController2LSB(message);
                    break;
                case ControlChangeType.GeneralPurposeController3LSB:
                    OnGeneralPurposeController3LSB(message);
                    break;
                case ControlChangeType.GeneralPurposeController4LSB:
                    OnGeneralPurposeController4LSB(message);
                    break;
                case ControlChangeType.Undefined14LSB:
                    OnUndefined14LSB(message);
                    break;
                case ControlChangeType.Undefined15LSB:
                    OnUndefined15LSB(message);
                    break;
                case ControlChangeType.Undefined16LSB:
                    OnUndefined16LSB(message);
                    break;
                case ControlChangeType.Undefined17LSB:
                    OnUndefined17LSB(message);
                    break;
                case ControlChangeType.Undefined18LSB:
                    OnUndefined18LSB(message);
                    break;
                case ControlChangeType.Undefined19LSB:
                    OnUndefined19LSB(message);
                    break;
                case ControlChangeType.Undefined1ALSB:
                    OnUndefined1ALSB(message);
                    break;
                case ControlChangeType.Undefined1BLSB:
                    OnUndefined1BLSB(message);
                    break;
                case ControlChangeType.Undefined1CLSB:
                    OnUndefined1CLSB(message);
                    break;
                case ControlChangeType.Undefined1DLSB:
                    OnUndefined1DLSB(message);
                    break;
                case ControlChangeType.Undefined1ELSB:
                    OnUndefined1ELSB(message);
                    break;
                case ControlChangeType.Undefined1FLSB:
                    OnUndefined1FLSB(message);
                    break;
                case ControlChangeType.Hold:
                    OnHold(message);
                    break;
                case ControlChangeType.Portamento:
                    OnPortamento(message);
                    break;
                case ControlChangeType.Sostenuto:
                    OnSostenuto(message);
                    break;
                case ControlChangeType.SoftPedal:
                    OnSoftPedal(message);
                    break;
                case ControlChangeType.LegatoFootswitch:
                    OnLegatoFootswitch(message);
                    break;
                case ControlChangeType.Hold2:
                    OnHold2(message);
                    break;
                case ControlChangeType.SoundController1:
                    OnSoundController1(message);
                    break;
                case ControlChangeType.SoundController2:
                    OnSoundController2(message);
                    break;
                case ControlChangeType.SoundController3:
                    OnSoundController3(message);
                    break;
                case ControlChangeType.SoundController4:
                    OnSoundController4(message);
                    break;
                case ControlChangeType.SoundController5:
                    OnSoundController5(message);
                    break;
                case ControlChangeType.SoundController6:
                    OnSoundController6(message);
                    break;
                case ControlChangeType.SoundController7:
                    OnSoundController7(message);
                    break;
                case ControlChangeType.SoundController8:
                    OnSoundController8(message);
                    break;
                case ControlChangeType.SoundController9:
                    OnSoundController9(message);
                    break;
                case ControlChangeType.SoundController10:
                    OnSoundController10(message);
                    break;
                case ControlChangeType.GeneralPurposeController5:
                    OnGeneralPurposeController5(message);
                    break;
                case ControlChangeType.GeneralPurposeController6:
                    OnGeneralPurposeController6(message);
                    break;
                case ControlChangeType.GeneralPurposeController7:
                    OnGeneralPurposeController7(message);
                    break;
                case ControlChangeType.GeneralPurposeController8:
                    OnGeneralPurposeController8(message);
                    break;
                case ControlChangeType.PortamentoControl:
                    OnPortamentoControl(message);
                    break;
                case ControlChangeType.Undefined55:
                    OnUndefined55(message);
                    break;
                case ControlChangeType.Undefined56:
                    OnUndefined56(message);
                    break;
                case ControlChangeType.Undefined57:
                    OnUndefined57(message);
                    break;
                case ControlChangeType.Undefined58:
                    OnUndefined58(message);
                    break;
                case ControlChangeType.Undefined59:
                    OnUndefined59(message);
                    break;
                case ControlChangeType.Undefined5A:
                    OnUndefined5A(message);
                    break;
                case ControlChangeType.Effects1Depth:
                    OnEffects1Depth(message);
                    break;
                case ControlChangeType.Effects2Depth:
                    OnEffects2Depth(message);
                    break;
                case ControlChangeType.Effects3Depth:
                    OnEffects3Depth(message);
                    break;
                case ControlChangeType.Effects4Depth:
                    OnEffects4Depth(message);
                    break;
                case ControlChangeType.Effects5Depth:
                    OnEffects5Depth(message);
                    break;
                case ControlChangeType.DataIncrement:
                    OnDataIncrement(message);
                    break;
                case ControlChangeType.DataDecrement:
                    OnDataDecrement(message);
                    break;
                case ControlChangeType.NonRegisteredParameterNumberLSB:
                    OnNonRegisteredParameterNumberLSB(message);
                    break;
                case ControlChangeType.NonRegisteredParameterNumberMSB:
                    OnNonRegisteredParameterNumberMSB(message);
                    break;
                case ControlChangeType.RegisteredParameterNumberLSB:
                    OnRegisteredParameterNumberLSB(message);
                    break;
                case ControlChangeType.RegisteredParameterNumberMSB:
                    OnRegisteredParameterNumberMSB(message);
                    break;
                case ControlChangeType.Undefined66:
                    OnUndefined66(message);
                    break;
                case ControlChangeType.Undefined67:
                    OnUndefined67(message);
                    break;
                case ControlChangeType.Undefined68:
                    OnUndefined68(message);
                    break;
                case ControlChangeType.Undefined69:
                    OnUndefined69(message);
                    break;
                case ControlChangeType.Undefined6A:
                    OnUndefined6A(message);
                    break;
                case ControlChangeType.Undefined6B:
                    OnUndefined6B(message);
                    break;
                case ControlChangeType.Undefined6C:
                    OnUndefined6C(message);
                    break;
                case ControlChangeType.Undefined6D:
                    OnUndefined6D(message);
                    break;
                case ControlChangeType.Undefined6E:
                    OnUndefined6E(message);
                    break;
                case ControlChangeType.Undefined6F:
                    OnUndefined6F(message);
                    break;
                case ControlChangeType.Undefined70:
                    OnUndefined70(message);
                    break;
                case ControlChangeType.Undefined71:
                    OnUndefined71(message);
                    break;
                case ControlChangeType.Undefined72:
                    OnUndefined72(message);
                    break;
                case ControlChangeType.Undefined73:
                    OnUndefined73(message);
                    break;
                case ControlChangeType.Undefined74:
                    OnUndefined74(message);
                    break;
                case ControlChangeType.Undefined75:
                    OnUndefined75(message);
                    break;
                case ControlChangeType.Undefined76:
                    OnUndefined76(message);
                    break;
                case ControlChangeType.Undefined77:
                    OnUndefined77(message);
                    break;
            }
        }

    }
}