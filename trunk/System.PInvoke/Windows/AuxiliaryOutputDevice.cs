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
using System.PInvoke.Windows.Structs;
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signatures of Auxiliary Output Device
    /// </summary>
    public class AuxiliaryOutputDevice
    {
        /// <summary>
        /// Auxiliary audio mapper. The function returns an error if no auxiliary audio mapper is installed.
        /// </summary>
        public const int AUX_MAPPER = -1;

        /// <summary>
        /// This function retrieves the capabilities of a given auxiliary output device.
        /// </summary>
        /// <param name="uDeviceID">Identifier of the auxiliary output device to be queried.
        /// Specify a valid device identifier or use the following constant:
        /// AUX_MAPPER </param>
        /// <param name="lpCaps">AUXCAPS structure to be filled with information about 
        /// the capabilities of the device.</param>
        /// <param name="uSize">Size, in bytes, of the AUXCAPS structure.</param>
        /// <returns>Returns MMSYSERR_NOERROR if successful or an error otherwise. 
        /// Possible error values include the following: 
        /// MMSYSERR_BADDEVICEID</returns>
        /// <remarks>The device identifier in uDeviceID varies from zero to one less than 
        /// the number of devices present. AUX_MAPPER may also be used. Use the auxGetNumDevs 
        /// function to determine the number of auxiliary output devices present in the system.
        /// </remarks>
        public static MMResult AuxGetDevCaps(uint uDeviceID, ref AuxCaps lpCaps, uint uSize)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.auxGetDevCapsW(uDeviceID, ref lpCaps, uSize) : Native.auxGetDevCapsA(uDeviceID, ref lpCaps, uSize);
        }


        /// <summary>
        /// This function retrieves the number of auxiliary output devices present in the system.
        /// </summary>
        /// <returns>
        /// Returns the number of device. A return value of zero means that no devices are present 
        /// or that an error occurred.</returns>
        public static uint AuxGetNumDevs()
        {
            return Native.auxGetNumDevs();
        }

        /// <summary>
        /// This function retrieves the current volume setting of the specified auxiliary output device.
        /// </summary>
        /// <param name="uDeviceID">Identifier of the auxiliary output device to be queried.</param>
        /// <param name="lpdwVolume">Address of a variable to be filled with the current volume setting. 
        /// The low-order word of this location contains the left channel volume setting, and the high-order 
        /// word contains the right channel setting. A value of 0xFFFF represents full volume, and a value of 
        /// 0x0000 is silence. If a device does not support both left and right volume control, the low-order 
        /// word of the specified location contains the volume level. The full 16-bit setting(s) set with the 
        /// auxSetVolume function are returned, regardless of whether the device supports the full 16 bits of 
        /// volume-level control.</param>
        /// <returns>Returns MMSYSERR_NOERROR if successful or an error otherwise. 
        /// Possible error values include the following:
        /// MMSYSERR_BADDEVICEID</returns>
        /// <remarks>Not all devices support volume control. To determine whether a device supports volume control,
        /// use the AUXCAPS_VOLUME flag to test the dwSupport member of the AUXCAPS structure (filled by the 
        /// auxGetDevCaps function).To determine whether a device supports volume control on both the left and 
        /// right channels, use the AUXCAPS_LRVOLUME flag to test the dwSupport member of the AUXCAPS structure 
        /// (filled by auxGetDevCaps).</remarks>
        public static MMResult AuxGetVolume(uint uDeviceID, ref uint lpdwVolume)
        {
            return Native.auxGetVolume(uDeviceID, ref lpdwVolume);
        }

        /// <summary>
        /// This function sets the volume of the specified auxiliary output device.
        /// </summary>
        /// <param name="uDeviceID">Identifier of the auxiliary output device to be queried. Device identifiers 
        /// are determined implicitly from the number of devices present in the system. Device identifier values
        /// range from zero to one less than the number of devices present. Use the auxGetNumDevs function to 
        /// determine the number of auxiliary devices in the system.</param>
        /// <param name="dwVolume">Specifies the new volume setting. The low-order word specifies the left-channel 
        /// volume setting, and the high-order word specifies the right-channel setting. A value of 0xFFFF 
        /// represents full volume, and a value of 0x0000 is silence.If a device does not support both left 
        /// and right volume control, the low-order word of dwVolume specifies the volume level, and the high-order
        /// word is ignored.</param>
        /// <returns>Returns MMSYSERR_NOERROR if successful or an error otherwise. 
        /// Possible error values include the following:
        /// MMSYSERR_BADDEVICEID</returns>
        /// <remarks>Not all devices support volume control. To determine whether the device supports volume control,
        /// use the AUXCAPS_VOLUME flag to test the dwSupport member of the AUXCAPS structure (filled by the 
        /// auxGetDevCaps function).
        /// To determine whether the device supports volume control on both the left and right channels, 
        /// use the AUXCAPS_LRVOLUME flag to test the dwSupport member of the AUXCAPS structure (filled by 
        /// auxGetDevCaps).
        /// Most devices do not support the full 16 bits of volume-level control and will use only the high-order
        /// bits of the requested volume setting. For example, for a device that supports 4 bits of volume control,
        /// requested volume level values of 0x4000, 0x4FFF, and 0x43BE will produce the same physical volume 
        /// setting, 0x4000. The auxGetVolume function will return the full 16-bit setting set with auxSetVolume.
        /// Volume settings are interpreted logarithmically. This means the perceived volume increase is the same
        /// when increasing the volume level from 0x5000 to 0x6000 as it is from 0x4000 to 0x5000.
        /// </remarks>
        public static MMResult AuxSetVolume(uint uDeviceID, uint dwVolume)
        {
            return Native.auxSetVolume(uDeviceID, dwVolume);
        }

        #region Nested type: Native

        internal static class Native
        {
            [DllImport("winmm.dll", EntryPoint = "auxGetDevCapsA", SetLastError = true)]
            internal static extern MMResult auxGetDevCapsA([MarshalAs(UnmanagedType.SysUInt)] uint uDeviceID,
                                                           ref AuxCaps lpCaps, uint uSize);

            [DllImport("winmm.dll", EntryPoint = "auxGetDevCapsW", SetLastError = true)]
            internal static extern MMResult auxGetDevCapsW([MarshalAs(UnmanagedType.SysUInt)] uint uDeviceID,
                                                           ref AuxCaps lpCaps, uint uSize);

            [DllImport("winmm.dll", EntryPoint = "auxGetNumDevs", SetLastError = true)]
            internal static extern uint auxGetNumDevs();

            [DllImport("winmm.dll", EntryPoint = "auxGetVolume", SetLastError = true)]
            internal static extern MMResult auxGetVolume(uint uDeviceID, ref uint lpdwVolume);

            [DllImport("winmm.dll", EntryPoint = "auxSetVolume", SetLastError = true)]
            internal static extern MMResult auxSetVolume(uint uDeviceID, uint dwVolume);
        }

        #endregion
    }
}