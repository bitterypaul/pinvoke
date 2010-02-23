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
    /// Contains information about the initialization and environment of a printer or a display device
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DevModeW
    {
        /// <summary>
        /// A zero-terminated character array that specifies the "friendly" name of the printer or display;
        /// for example, "PCL/HP LaserJet" in the case of PCL/HP LaserJet. This string is unique among device
        /// drivers. Note that this name may be truncated to fit in the dmDeviceName array. 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string dmDeviceName;

        /// <summary>
        /// Specifies the version number of the initialization data specification on which the structure 
        /// is based. To ensure the correct version is used for any operating system, use DM_SPECVERSION. 
        /// </summary>
        public ushort dmSpecVersion;

        /// <summary>
        /// Specifies the driver version number assigned by the driver developer. 
        /// </summary>
        public ushort dmDriverVersion;

        /// <summary>
        /// Specifies the size, in bytes, of the DEVMODEA structure, not including any private driver-specific
        /// data that might follow the structure's public members. Set this member to sizeof(DEVMODEA) to 
        /// indicate the version of the DEVMODEA structure being used. 
        /// </summary>
        public ushort dmSize;

        /// <summary>
        /// Contains the number of bytes of private driver-data that follow this structure. If a device 
        /// driver does not use device-specific information, set this member to zero.
        /// </summary>
        public ushort dmDriverExtra;

        /// <summary>
        /// Specifies whether certain members of the DEVMODEA structure have been initialized. If a member
        /// is initialized, its corresponding bit is set, otherwise the bit is clear. A driver supports 
        /// only those DEVMODEA members that are appropriate for the printer or display technology. 
        /// </summary>
        public InitializationFlag dmFields;

        /// <summary>
        /// Anonymous union, see the fields for details
        /// </summary>
        public Union1W Union1;

        /// <summary>
        /// Switches between color and monochrome on color printers
        /// </summary>
        public PrinterColorMode dmColor;

        /// <summary>
        /// Selects duplex or double-sided printing for printers capable of duplex printing
        /// </summary>
        public PrinterDuplexMode dmDuplex;

        /// <summary>
        /// Specifies the y-resolution, in dots per inch, of the printer. If the printer initializes
        /// this member, the dmPrintQuality member specifies the x-resolution, in dots per inch, of 
        /// the printer.
        /// </summary>
        public short dmYResolution;

        /// <summary>
        /// Specifies how TrueType fonts should be printed.
        /// </summary>
        public TrueTypeOption dmTTOption;

        /// <summary>
        /// Specifies whether collation should be used when printing multiple copies. (This member is ignored
        /// unless the printer driver indicates support for collation by setting the dmFields member to 
        /// DM_COLLATE.)
        /// </summary>
        public CollationOption dmCollate;

        /// <summary>
        /// Windows NT/2000/XP: A zero-terminated character array that specifies the name of the form to use;
        /// for example, "Letter" or "Legal". A complete set of names can be retrieved by using the EnumForms
        /// function.
        /// Windows 95/98/Me: Printer drivers do not use this member. 
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string dmFormName;

        /// <summary>
        /// Specifies the number of pixels per logical inch. Printer drivers do not use this member. 
        /// </summary>
        public ushort dmLogPixels;

        /// <summary>
        /// Specifies the color resolution, in bits per pixel, of the display device (for example: 4 bits
        /// for 16 colors, 8 bits for 256 colors, or 16 bits for 65,536 colors). Display drivers use this 
        /// member, for example, in the ChangeDisplaySettings function. Printer drivers do not use this 
        /// member. 
        /// </summary>
        public uint dmBitsPerPel;

        /// <summary>
        /// Specifies the width, in pixels, of the visible device surface. Display drivers use this member,
        /// for example, in the ChangeDisplaySettings function. Printer drivers do not use this member.
        /// </summary>
        public uint dmPelsWidth;

        /// <summary>
        /// Specifies the height, in pixels, of the visible device surface. Display drivers use this member,
        /// for example, in the ChangeDisplaySettings function. Printer drivers do not use this member.
        /// </summary>
        public uint dmPelsHeight;

        /// <summary>
        /// Anonymous union, see the fields for details
        /// </summary>
        public Union2W Union2;

        /// <summary>
        /// Specifies the frequency, in hertz (cycles per second), of the display device in a particular mode.
        /// This value is also known as the display device's vertical refresh rate. Display drivers use this 
        /// member. It is used, for example, in the ChangeDisplaySettings function. Printer drivers do not use
        /// this member.
        /// </summary>
        public uint dmDisplayFrequency;

        /// <summary>
        /// Windows 95/98/Me; Windows 2000/XP: Specifies how ICM is handled. For a non-ICM application, this member
        /// determines if ICM is enabled or disabled. For ICM applications, the system examines this member 
        /// to determine how to handle ICM support. This member can be one of the following predefined values,
        /// or a driver-defined value greater than or equal to the value of DMICMMETHOD_USER.
        /// </summary>
        public ICMHandlingOption dmICMMethod;

        /// <summary>
        /// Windows 95/98/Me, Windows 2000/XP: Specifies which color matching method, or intent, should be used by 
        /// default. This member is primarily for non-ICM applications. ICM applications can establish intents by 
        /// using the ICM functions. This member can be one of the following predefined values, or a driver 
        /// defined value greater than or equal to the value of DMICM_USER. 
        /// </summary>
        public ColorMatchingOption dmICMIntent;

        /// <summary>
        /// Windows 95/98/Me, Windows 2000/XP: Specifies the type of media being printed on. The member can be one of
        /// the following predefined values, or a driver-defined value greater than or equal to the value of
        /// DMMEDIA_USER. 
        /// </summary>
        public PrintingMedia dmMediaType;

        /// <summary>
        /// Windows 95/98/Me, Windows 2000/XP: Specifies how dithering is to be done. The member can be one of the
        /// following predefined values, or a driver-defined value greater than or equal to the value of 
        /// DMDITHER_USER. 
        /// </summary>
        public DitherType dmDitherType;

        /// <summary>
        /// Windows 95/98/Me, Windows 2000/XP: Not used; must be zero
        /// </summary>
        public uint dmReserved1;

        /// <summary>
        /// Windows 95/98/Me, Windows 2000/XP: Not used; must be zero.
        /// </summary>
        public uint dmReserved2;

        /// <summary>
        /// Windows NT/2000/XP: This member must be zero. 
        /// Windows 95/98/Me: This member is not supported.
        /// </summary>
        public uint dmPanningWidth;

        /// <summary>
        /// Windows NT/2000/XP: This member must be zero. 
        /// Windows 95/98/Me: This member is not supported.
        /// </summary>
        public uint dmPanningHeight;
    }
}