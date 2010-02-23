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
    /// The LOGBRUSH structure defines the style, color, and pattern of a 
    /// physical brush. It is used by the CreateBrushIndirect and ExtCreatePen functions.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LogBrush
    {
        /// <summary>
        /// Specifies the brush style
        /// </summary>
        public BrushStyle lbStyle;

        /// <summary>
        /// Specifies the color in which the brush is to be drawn. 
        /// If lbStyle is the BS_HOLLOW or BS_PATTERN style, lbColor is ignored
        /// </summary>
        public DIBColorTable lbColor;

        /// <summary>
        /// Specifies a hatch style. The meaning depends on the brush style defined by lbStyle.
        /// 
        /// If lbStyle is BS_DIBPATTERN, the lbHatch member contains a handle to a packed DIB. 
        /// To obtain this handle, an application calls the GlobalAlloc function with GMEM_MOVEABLE
        /// (or LocalAlloc with LMEM_MOVEABLE) to allocate a block of memory and then fills the 
        /// memory with the packed DIB. A packed DIB consists of a BITMAPINFO structure immediately 
        /// followed by the array of bytes that define the pixels of the bitmap. 
        /// 
        /// If lbStyle is BS_DIBPATTERNPT, the lbHatch member contains a pointer to a packed DIB. 
        /// The pointer derives from the memory block created by LocalAlloc with LMEM_FIXED set 
        /// or by GlobalAlloc with GMEM_FIXED set, or it is the pointer returned by a call like 
        /// LocalLock (handle_to_the_dib). A packed DIB consists of a BITMAPINFO structure immediately
        /// followed by the array of bytes that define the pixels of the bitmap.
        /// 
        /// If lbStyle is BS_PATTERN, lbHatch is a handle to the bitmap that defines the pattern. 
        /// The bitmap cannot be a DIB section bitmap, which is created by the CreateDIBSection 
        /// function. 
        /// 
        /// If lbStyle is BS_SOLID or BS_HOLLOW, lbHatch is ignored
        /// </summary>
        public HatchStyle lbHatch;
    }
}