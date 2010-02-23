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
    /// The BITMAP structure defines the type, width, height, color format, and bit values of a bitmap
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAP
    {
        /// <summary>
        /// Specifies the bitmap type. This member must be zero
        /// </summary>
        public int bmType;

        /// <summary>
        /// Specifies the width, in pixels, of the bitmap. The width must be greater than zero
        /// </summary>
        public int bmWidth;

        /// <summary>
        /// Specifies the height, in pixels, of the bitmap. The height must be greater than zero
        /// </summary>
        public int bmHeight;

        /// <summary>
        /// Specifies the number of bytes in each scan line. This value must be divisible by 2, 
        /// because the system assumes that the bit values of a bitmap form an array that is word aligned
        /// </summary>
        public int bmWidthBytes;

        /// <summary>
        /// Specifies the count of color planes
        /// </summary>
        public ushort bmPlanes;

        /// <summary>
        /// Specifies the number of bits required to indicate the color of a pixel
        /// </summary>
        public ushort bmBitsPixel;

        /// <summary>
        /// Pointer to the location of the bit values for the bitmap. The bmBits member
        /// must be a long pointer to an array of character (1-byte) values
        /// </summary>
        public IntPtr bmBits;
    }
}