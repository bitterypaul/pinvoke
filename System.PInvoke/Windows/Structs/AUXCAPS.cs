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
using System.PInvoke.Windows.Enums;
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The AUXCAPS structure describes the capabilities of an auxiliary output device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct AuxCaps
    {
        /// <summary>
        /// Manufacturer identifier for the device driver for the auxiliary audio device.
        /// </summary>
        public ManufacturerID wMid;

        /// <summary>
        /// Product identifier for the auxiliary audio device. Currently, 
        /// no product identifiers are defined for auxiliary audio devices.
        /// </summary>
        public ushort wPid;

        /// <summary>
        /// Version number of the device driver for the auxiliary audio device.  
        /// The high-order byte is the major version number, and the low-order byte 
        /// is the minor version number.
        /// </summary>
        public uint vDriverVersion;

        /// <summary>
        /// Product name in a null-terminated string.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string szPname;

        /// <summary>
        /// Type of the auxiliary audio output:
        ///
        /// AUXCAPS_AUXIN
        /// AUXCAPS_CDAUDIO
        /// AUXCAPS_MASTER
        /// AUXCAPS_MIC
        /// AUXCAPS_MIDI
        /// AUXCAPS_PCSPEAKER
        /// AUXCAPS_WAVE
        /// </summary>
        public AuxiliaryAudioOutput wTechnology;

        /// <summary>
        /// padding
        /// </summary>
        public ushort wReserved1;

        /// <summary>
        /// Describes optional functionality supported by the auxiliary audio device.
        ///
        /// AUXCAPS_LRVOLUME
        /// AUXCAPS_VOLUME
        /// 
        /// If a device supports volume changes, the AUXCAPS_VOLUME flag will be set. If a device supports separate volume changes on the left and right channels, both AUXCAPS_VOLUME and the AUXCAPS_LRVOLUME will be set.
        /// </summary>
        public VolumeSupport dwSupport;
    }
}