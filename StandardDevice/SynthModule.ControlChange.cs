using Dono.Midi.Runtime;
using Dono.Midi.Runtime.Types;
using Dono.MidiConnectionForUnity.Base;

namespace MidiConnectionForUnity.StandardDevice
{
    public partial class SynthModule :
       MidiInDevice,
       IMidiModule
    {

        public virtual void OnBankSelectMSB(MidiMessage message)
        {
            ChannelState[message.Channel].BankSelect = (message.Data2 << 7) + (ChannelState[message.Channel].BankSelect & 0b01111111);
        }
        public virtual void OnModulationMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Modulation = (message.Data2 << 7) + (ChannelState[message.Channel].Modulation & 0b01111111);
        }
        public virtual void OnBreathControllerMSB(MidiMessage message)
        {
            ChannelState[message.Channel].BreathController = (message.Data2 << 7) + (ChannelState[message.Channel].BreathController & 0b01111111);
        }
        public virtual void OnUndefined03MSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined03 = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined03 & 0b01111111);
        }
        public virtual void OnFootControllerMSB(MidiMessage message)
        {
            ChannelState[message.Channel].FootController = (message.Data2 << 7) + (ChannelState[message.Channel].FootController & 0b01111111);
        }
        public virtual void OnPortamentoTimeMSB(MidiMessage message)
        {
            ChannelState[message.Channel].PortamentoTime = (message.Data2 << 7) + (ChannelState[message.Channel].PortamentoTime & 0b01111111);
        }
        public virtual void OnDataEntryMSB(MidiMessage message)
        {
            ChannelState[message.Channel].DataEntry = (message.Data2 << 7) + (ChannelState[message.Channel].DataEntry & 0b01111111);
        }
        public virtual void OnChannelVolumeMSB(MidiMessage message)
        {
            ChannelState[message.Channel].ChannelVolume = (message.Data2 << 7) + (ChannelState[message.Channel].ChannelVolume & 0b01111111);
        }
        public virtual void OnBalanceMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Balance = (message.Data2 << 7) + (ChannelState[message.Channel].Balance & 0b01111111);
        }
        public virtual void OnUndefined09MSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined09 = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined09 & 0b01111111);
        }
        public virtual void OnPanMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Pan = (message.Data2 << 7) + (ChannelState[message.Channel].Pan & 0b01111111);
        }
        public virtual void OnExpressionControllerMSB(MidiMessage message)
        {
            ChannelState[message.Channel].ExpressionController = (message.Data2 << 7) + (ChannelState[message.Channel].ExpressionController & 0b01111111);
        }
        public virtual void OnEffectControl1MSB(MidiMessage message)
        {
            ChannelState[message.Channel].EffectControl1 = (message.Data2 << 7) + (ChannelState[message.Channel].EffectControl1 & 0b01111111);
        }
        public virtual void OnEffectControl2MSB(MidiMessage message)
        {
            ChannelState[message.Channel].EffectControl2 = (message.Data2 << 7) + (ChannelState[message.Channel].EffectControl2 & 0b01111111);
        }
        public virtual void OnUndefined0EMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined0E = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined0E & 0b01111111);
        }
        public virtual void OnUndefined0FMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined0F = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined0F & 0b01111111);
        }
        public virtual void OnGeneralPurposeController1MSB(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController1 = (message.Data2 << 7) + (ChannelState[message.Channel].GeneralPurposeController1 & 0b01111111);
        }
        public virtual void OnGeneralPurposeController2MSB(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController2 = (message.Data2 << 7) + (ChannelState[message.Channel].GeneralPurposeController2 & 0b01111111);
        }
        public virtual void OnGeneralPurposeController3MSB(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController3 = (message.Data2 << 7) + (ChannelState[message.Channel].GeneralPurposeController3 & 0b01111111);
        }
        public virtual void OnGeneralPurposeController4MSB(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController4 = (message.Data2 << 7) + (ChannelState[message.Channel].GeneralPurposeController4 & 0b01111111);
        }
        public virtual void OnUndefined14MSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined14 = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined14 & 0b01111111);
        }
        public virtual void OnUndefined15MSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined15 = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined15 & 0b01111111);
        }
        public virtual void OnUndefined16MSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined16 = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined16 & 0b01111111);
        }
        public virtual void OnUndefined17MSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined17 = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined17 & 0b01111111);
        }
        public virtual void OnUndefined18MSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined18 = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined18 & 0b01111111);
        }
        public virtual void OnUndefined19MSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined19 = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined19 & 0b01111111);
        }
        public virtual void OnUndefined1AMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1A = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined1A & 0b01111111);
        }
        public virtual void OnUndefined1BMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1B = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined1B & 0b01111111);
        }
        public virtual void OnUndefined1CMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1C = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined1C & 0b01111111);
        }
        public virtual void OnUndefined1DMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1D = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined1D & 0b01111111);
        }
        public virtual void OnUndefined1EMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1E = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined1E & 0b01111111);
        }
        public virtual void OnUndefined1FMSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1F = (message.Data2 << 7) + (ChannelState[message.Channel].Undefined1F & 0b01111111);
        }
        public virtual void OnBankSelectLSB(MidiMessage message)
        {
            ChannelState[message.Channel].BankSelect = (ChannelState[message.Channel].BankSelect & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnModulationWheelLSB(MidiMessage message)
        {
            ChannelState[message.Channel].Modulation = (ChannelState[message.Channel].Modulation & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnBreathControllerLSB(MidiMessage message)
        {
            ChannelState[message.Channel].BreathController = (ChannelState[message.Channel].BreathController & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined03LSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined03 = (ChannelState[message.Channel].Undefined03 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnFootControllerLSB(MidiMessage message)
        {
            ChannelState[message.Channel].FootController = (ChannelState[message.Channel].FootController & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnPortamentoTimeLSB(MidiMessage message)
        {
            ChannelState[message.Channel].PortamentoTime = (ChannelState[message.Channel].PortamentoTime & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnDataEntryLSB(MidiMessage message)
        {
            ChannelState[message.Channel].DataEntry = (ChannelState[message.Channel].DataEntry & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnChannelVolumeLSB(MidiMessage message)
        {
            ChannelState[message.Channel].ChannelVolume = (ChannelState[message.Channel].ChannelVolume & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnBalanceLSB(MidiMessage message)
        {
            ChannelState[message.Channel].Balance = (ChannelState[message.Channel].Balance & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined09LSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined09 = (ChannelState[message.Channel].Undefined09 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnPanLSB(MidiMessage message)
        {
            ChannelState[message.Channel].Pan = (ChannelState[message.Channel].Pan & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnExpressionControllerLSB(MidiMessage message)
        {
            ChannelState[message.Channel].ExpressionController = (ChannelState[message.Channel].ExpressionController & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnEffectControl1LSB(MidiMessage message)
        {
            ChannelState[message.Channel].EffectControl1 = (ChannelState[message.Channel].EffectControl1 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnEffectControl2LSB(MidiMessage message)
        {
            ChannelState[message.Channel].EffectControl2 = (ChannelState[message.Channel].EffectControl2 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined0ELSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined0E = (ChannelState[message.Channel].Undefined0E & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined0FLSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined0F = (ChannelState[message.Channel].Undefined0F & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnGeneralPurposeController1LSB(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController1 = (ChannelState[message.Channel].GeneralPurposeController1 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnGeneralPurposeController2LSB(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController2 = (ChannelState[message.Channel].GeneralPurposeController2 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnGeneralPurposeController3LSB(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController3 = (ChannelState[message.Channel].GeneralPurposeController3 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnGeneralPurposeController4LSB(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController4 = (ChannelState[message.Channel].GeneralPurposeController4 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined14LSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined14 = (ChannelState[message.Channel].Undefined14 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined15LSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined15 = (ChannelState[message.Channel].Undefined15 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined16LSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined16 = (ChannelState[message.Channel].Undefined16 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined17LSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined17 = (ChannelState[message.Channel].Undefined17 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined18LSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined18 = (ChannelState[message.Channel].Undefined18 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined19LSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined19 = (ChannelState[message.Channel].Undefined19 & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined1ALSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1A = (ChannelState[message.Channel].Undefined1A & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined1BLSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1B = (ChannelState[message.Channel].Undefined1B & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined1CLSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1C = (ChannelState[message.Channel].Undefined1C & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined1DLSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1D = (ChannelState[message.Channel].Undefined1D & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined1ELSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1E = (ChannelState[message.Channel].Undefined1E & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnUndefined1FLSB(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined1F = (ChannelState[message.Channel].Undefined1F & 0b0011111110000000) + message.Data2;
        }
        public virtual void OnHold(MidiMessage message)
        {
            ChannelState[message.Channel].Hold = message.Data2;
        }
        public virtual void OnPortamento(MidiMessage message)
        {
            ChannelState[message.Channel].Portamento = message.Data2;
        }
        public virtual void OnSostenuto(MidiMessage message)
        {
            ChannelState[message.Channel].Sostenuto = message.Data2;
        }
        public virtual void OnSoftPedal(MidiMessage message)
        {
            ChannelState[message.Channel].SoftPedal = message.Data2;
        }
        public virtual void OnLegatoFootswitch(MidiMessage message)
        {
            ChannelState[message.Channel].LegatoFootswitch = message.Data2;
        }
        public virtual void OnHold2(MidiMessage message)
        {
            ChannelState[message.Channel].Hold2 = message.Data2;
        }
        public virtual void OnSoundController1(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController1 = message.Data2;
        }
        public virtual void OnSoundController2(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController2 = message.Data2;
        }
        public virtual void OnSoundController3(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController3 = message.Data2;
        }
        public virtual void OnSoundController4(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController4 = message.Data2;
        }
        public virtual void OnSoundController5(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController5 = message.Data2;
        }
        public virtual void OnSoundController6(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController6 = message.Data2;
        }
        public virtual void OnSoundController7(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController7 = message.Data2;
        }
        public virtual void OnSoundController8(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController8 = message.Data2;
        }
        public virtual void OnSoundController9(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController9 = message.Data2;
        }
        public virtual void OnSoundController10(MidiMessage message)
        {
            ChannelState[message.Channel].SoundController10 = message.Data2;
        }
        public virtual void OnGeneralPurposeController5(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController5 = message.Data2;
        }
        public virtual void OnGeneralPurposeController6(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController6 = message.Data2;
        }
        public virtual void OnGeneralPurposeController7(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController7 = message.Data2;
        }
        public virtual void OnGeneralPurposeController8(MidiMessage message)
        {
            ChannelState[message.Channel].GeneralPurposeController8 = message.Data2;
        }
        public virtual void OnPortamentoControl(MidiMessage message)
        {
            ChannelState[message.Channel].PortamentoControl = message.Data2;
        }
        public virtual void OnUndefined55(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined55 = message.Data2;
        }
        public virtual void OnUndefined56(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined56 = message.Data2;
        }
        public virtual void OnUndefined57(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined57 = message.Data2;
        }
        public virtual void OnUndefined58(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined58 = message.Data2;
        }
        public virtual void OnUndefined59(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined59 = message.Data2;
        }
        public virtual void OnUndefined60(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined60 = message.Data2;
        }
        public virtual void OnEffects1Depth(MidiMessage message)
        {
            ChannelState[message.Channel].Effects1Depth = message.Data2;
        }
        public virtual void OnEffects2Depth(MidiMessage message)
        {
            ChannelState[message.Channel].Effects2Depth = message.Data2;
        }
        public virtual void OnEffects3Depth(MidiMessage message)
        {
            ChannelState[message.Channel].Effects3Depth = message.Data2;
        }
        public virtual void OnEffects4Depth(MidiMessage message)
        {
            ChannelState[message.Channel].Effects4Depth = message.Data2;
        }
        public virtual void OnEffects5Depth(MidiMessage message)
        {
            ChannelState[message.Channel].Effects5Depth = message.Data2;
        }
        public virtual void OnDataIncrement(MidiMessage message)
        {
            ChannelState[message.Channel].DataIncrement = message.Data2;
        }
        public virtual void OnDataDecrement(MidiMessage message)
        {
            ChannelState[message.Channel].DataDecrement = message.Data2;
        }
        public virtual void OnNonRegisteredParameterNumberLSB(MidiMessage message)
        {
            ChannelState[message.Channel].NonRegisteredParameterNumberLSB = message.Data2;
        }
        public virtual void OnNonRegisteredParameterNumberMSB(MidiMessage message)
        {
            ChannelState[message.Channel].NonRegisteredParameterNumberMSB = message.Data2;
        }
        public virtual void OnRegisteredParameterNumberLSB(MidiMessage message)
        {
            ChannelState[message.Channel].RegisteredParameterNumberLSB = message.Data2;
        }
        public virtual void OnRegisteredParameterNumberMSB(MidiMessage message)
        {
            ChannelState[message.Channel].RegisteredParameterNumberMSB = message.Data2;
        }
        public virtual void OnUndefined66(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined66 = message.Data2;
        }
        public virtual void OnUndefined67(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined67 = message.Data2;
        }
        public virtual void OnUndefined68(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined68 = message.Data2;
        }
        public virtual void OnUndefined69(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined69 = message.Data2;
        }
        public virtual void OnUndefined6A(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined6A = message.Data2;
        }
        public virtual void OnUndefined6B(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined6B = message.Data2;
        }
        public virtual void OnUndefined6C(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined6C = message.Data2;
        }
        public virtual void OnUndefined6D(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined6D = message.Data2;
        }
        public virtual void OnUndefined6E(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined6E = message.Data2;
        }
        public virtual void OnUndefined6F(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined6F = message.Data2;
        }
        public virtual void OnUndefined70(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined70 = message.Data2;
        }
        public virtual void OnUndefined71(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined71 = message.Data2;
        }
        public virtual void OnUndefined72(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined72 = message.Data2;
        }
        public virtual void OnUndefined73(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined73 = message.Data2;
        }
        public virtual void OnUndefined74(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined74 = message.Data2;
        }
        public virtual void OnUndefined75(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined75 = message.Data2;
        }
        public virtual void OnUndefined76(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined76 = message.Data2;
        }
        public virtual void OnUndefined77(MidiMessage message)
        {
            ChannelState[message.Channel].Undefined77 = message.Data2;
        }
    }
}