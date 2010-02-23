#region Copyright Notice
// 
// 
// Copyright (c) 2009-2010 Anindya Chatterjee
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// 
// 
#endregion
namespace System.PInvoke.Windows.Enums
{
    /// <summary>
    /// Auxiliary audio device type
    /// </summary>
    [Flags]
    public enum AuxiliaryAudioOutput : ushort
    {
        /// <summary>
        /// Audio from auxiliary input jacks
        /// </summary>
        AUXCAPS_AUXIN = 0x2,
        /// <summary>
        /// Audio from internal CD-ROM drive
        /// </summary>
        AUXCAPS_CDAUDIO = 0x1,
        /// <summary>
        /// Master audio device.
        /// </summary>
        AUXCAPS_MASTER = 0x8,
        /// <summary>
        /// Microphone audio device. 
        /// </summary>
        AUXCAPS_MIC = 0x4,
        /// <summary>
        /// MIDI audio device. 
        /// </summary>
        AUXCAPS_MIDI = 0x40,
        /// <summary>
        /// PC speaker audio device. 
        /// </summary>
        AUXCAPS_PCSPEAKER = 0x10,
        /// <summary>
        /// Waveform audio device. 
        /// </summary>
        AUXCAPS_WAVE = 0x20
    }
}