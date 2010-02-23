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
    /// The PRINTER_NOTIFY_OPTIONS structure specifies options 
    /// for a change notification object that monitors a printer or print server
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class PrinterNotifyOptions
    {
        /// <summary>
        /// Specifies the version of this structure. Set this member to 2
        /// </summary>
        public Int32 dwVersion;

        /// <summary>
        /// Contains a bit flag. If you set it to 1 in a call to the FindNextPrinterChangeNotification
        /// function, the function provides current data for all monitored printer information fields.
        /// The FindFirstPrinterChangeNotification function ignores the Flags member
        /// </summary>
        public Int32 dwFlags;

        /// <summary>
        /// Specifies the number of elements in the pTypes array
        /// </summary>
        public Int32 Count;

        /// <summary>
        /// Pointer to an array of PRINTER_NOTIFY_OPTIONS_TYPE structures. Use one element of this array
        /// to specify the printer information fields to monitor, and one element to specify the job 
        /// information fields to monitor. You can monitor either printer information, job information, 
        /// or both
        /// </summary>
        public IntPtr pTypes;

        /// <summary>
        /// Instantiate a PRINTER_NOTIFY_OPTIONS object
        /// </summary>
        /// <param name="refresh">If true dwFlags will be set 1, else 0</param>
        public PrinterNotifyOptions(bool refresh)
        {
            dwVersion = 2;
            dwFlags = refresh ? 1 : 0;
            Count = 2;

            var type1 = new PrinterNotifyOptionsType();
            var num1 = Marshal.SizeOf(type1);
            pTypes = Marshal.AllocHGlobal(num1);
            Marshal.StructureToPtr(type1, pTypes, true);
        }

        ~PrinterNotifyOptions()
        {
            if (pTypes != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(pTypes);
            }
        }
    }
}