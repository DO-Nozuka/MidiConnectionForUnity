# MidiConnectionForUnity
Midi Connection For Unity (with Dono.Minis)

## How to use
* Create "Device" that derived class from "MidiDevice"
(MidiDevice inherited MonoBehaviour)
* Attach Devices like a MIDI.
* SendMessage used by (Created class).SendMessage(MidiMessage message)

## "Devices"
* Switcher
  * Channel AB Switcher
  * Channel Multi Switcher
* Filter
  * Status Filter
  * Channel Filter
* Checker
  * Check Lamp
  * Message Generator(helpful)
* abstract
  * SynthModule

## varsion
  * 2.0.0 Renew All
  * 2.0.3 Add Check Lamp