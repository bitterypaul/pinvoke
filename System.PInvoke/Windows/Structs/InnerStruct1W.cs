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
    /// Anonymous inner structure
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct InnerStruct1W
    {
        /// <summary>
        /// For printer devices only, selects the orientation of the paper. 
        /// This member can be either DMORIENT_PORTRAIT (1) or DMORIENT_LANDSCAPE (2). 
        /// </summary>
        public short dmOrientation;

        /// <summary>
        /// For printer devices only, selects the size of the paper to print on. This member
        /// can be set to zero if the length and width of the paper are both set by the dmPaperLength
        /// and dmPaperWidth members. Otherwise, the dmPaperSize member can be set to a device specific
        /// value greater than or equal to DMPAPER_USER or to one of the value in PaperSize enum
        /// </summary>
        public PaperSize dmPaperSize;

        /// <summary>
        /// For printer devices only, overrides the length of the paper specified by the dmPaperSize member,
        /// either for custom paper sizes or for devices such as dot-matrix printers that can print on a 
        /// page of arbitrary length. These values, along with all other values in this structure that specify
        /// a physical length, are in tenths of a millimeter.
        /// </summary>
        public short dmPaperLength;

        /// <summary>
        /// For printer devices only, overrides the width of the paper specified by the dmPaperSize member. 
        /// </summary>
        public short dmPaperWidth;

        /// <summary>
        /// Specifies the factor by which the printed output is to be scaled. The apparent page size is scaled
        /// from the physical page size by a factor of dmScale/100. For example, a letter-sized page with a 
        /// dmScale value of 50 would contain as much data as a page of 17- by 22-inches because the output 
        /// text and graphics would be half their original height and width.
        /// </summary>
        public short dmScale;

        /// <summary>
        /// Selects the number of copies printed if the device supports multiple-page copies. 
        /// </summary>
        public short dmCopies;

        /// <summary>
        /// Specifies the paper source. To retrieve a list of the available paper sources for a printer, 
        /// use the DeviceCapabilities function with the DC_BINS flag.
        /// </summary>
        public PaperSource dmDefaultSource;

        /// <summary>
        /// Specifies the printer resolution. If a positive value is specified, it specifies the number of 
        /// dots per inch (DPI) and is therefore device dependent
        /// </summary>
        public PrintQuality dmPrintQuality;
    }
}