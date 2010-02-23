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
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The DEVNAMES structure contains strings that identify the driver,
    /// device, and output port names for a printer. The PrintDlgEx and PrintDlg
    /// functions use these strings to initialize the system-defined Print Property
    /// Sheet or Print Dialog Box. When the user closes the property sheet or 
    /// dialog box, information about the selected printer is returned in this structure. 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct DevNames
    {
        /// <summary>
        /// Offset, in characters, from the beginning of this structure to a null-terminated
        /// string that contains the file name (without the extension) of the device driver. 
        /// On input, this string is used to determine the printer to display initially in the
        /// dialog box.
        /// </summary>
        public ushort wDriverOffset;

        /// <summary>
        /// Offset, in characters, from the beginning of this structure to the null-terminated 
        /// string that contains the name of the device.
        /// </summary>
        public ushort wDeviceOffset;

        /// <summary>
        /// Offset, in characters, from the beginning of this structure to the null-terminated
        /// string that contains the device name for the physical output medium (output port). 
        /// </summary>
        public ushort wOutputOffset;

        /// <summary>
        /// Indicates whether the strings contained in the DEVNAMES structure identify the 
        /// default printer. This string is used to verify that the default printer has not 
        /// changed since the last print operation. If any of the strings do not match, a 
        /// warning message is displayed informing the user that the document may need to 
        /// be reformatted. On output, the wDefault member is changed only if the Print 
        /// Setup dialog box was displayed and the user chose the OK button. The DN_DEFAULTPRN
        /// flag is used if the default printer was selected. If a specific printer is selected,
        /// the flag is not used. All other flags in this member are reserved for internal use 
        /// by the dialog box procedure for the Print property sheet or Print dialog box.
        /// </summary>
        public ushort wDefault;
    }
}