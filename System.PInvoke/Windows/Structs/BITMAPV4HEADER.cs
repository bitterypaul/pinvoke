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
using System.PInvoke.Windows.Interface;
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The BITMAPV4HEADER structure is the bitmap information header file. 
    /// It is an extended version of the BITMAPINFOHEADER structure
    /// </summary>
    /// <remarks>Windows NT 3.51 and earlier: Applications should continue to use BITMAPINFOHEADER. 
    /// Windows 98/Me, Windows 2000/XP: Applications can use the BITMAPV5HEADER structure for added functionality
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPV4Header : IBitmapInfoHeader
    {
        /// <summary>
        /// Specifies the number of bytes required by the structure. Applications should use
        /// this member to determine which bitmap information header structure is being used
        /// </summary>
        public uint bV4Size;

        /// <summary>
        /// Specifies the width of the bitmap, in pixels
        /// </summary>
        /// <remarks>Windows 98/Me, Windows 2000/XP: If bV4Compression is BI_JPEG or BI_PNG, 
        /// bV4Width specifies the width of the JPEG or PNG image in pixels</remarks>
        public int bV4Width;

        /// <summary>
        /// Specifies the height of the bitmap, in pixels. If bV4Height is positive, the bitmap is a 
        /// bottom-up DIB and its origin is the lower-left corner. If bV4Height is negative, the bitmap
        /// is a top-down DIB and its origin is the upper-left corner. 
        /// If bV4Height is negative, indicating a top-down DIB, bV4Compression must be either BI_RGB or
        /// BI_BITFIELDS. Top-down DIBs cannot be compressed
        /// </summary>
        /// <remarks>Windows 98/Me, Windows 2000/XP: If bV4Compression is BI_JPEG or BI_PNG, bV4Height specifies
        /// the height of the JPEG or PNG image in pixels</remarks>
        public int bV4Height;

        /// <summary>
        /// Specifies the number of planes for the target device. This value must be set to 1
        /// </summary>
        public ushort bV4Planes;

        /// <summary>
        /// Specifies the number of bits-per-pixel. The bV4BitCount member of the BITMAPV4HEADER structure
        /// determines the number of bits that define each pixel and the maximum number of colors in the bitmap
        /// </summary>
        public BitCount bV4BitCount;

        /// <summary>
        /// Specifies the type of compression for a compressed bottom-up bitmap (top-down DIBs cannot be compressed)
        /// </summary>
        public BitmapCompression bV4V4Compression;

        /// <summary>
        /// Specifies the size, in bytes, of the image. This may be set to zero for BI_RGB bitmaps
        /// </summary>
        /// <remarks>Windows 98/Me, Windows 2000/XP: If bV4Compression is BI_JPEG or BI_PNG, bV4SizeImage
        /// is the size of the JPEG or PNG image buffer</remarks>
        public uint bV4SizeImage;

        /// <summary>
        /// Specifies the horizontal resolution, in pixels-per-meter, of the target device for the bitmap. 
        /// An application can use this value to select a bitmap from a resource group that best matches 
        /// the characteristics of the current device
        /// </summary>
        public int bV4XPelsPerMeter;

        /// <summary>
        /// Specifies the vertical resolution, in pixels-per-meter, of the target device for the bitmap
        /// </summary>
        public int bV4YPelsPerMeter;

        /// <summary>
        /// Specifies the number of color indexes in the color table that are actually used by the bitmap.
        /// If this value is zero, the bitmap uses the maximum number of colors corresponding to the value
        /// of the bV4BitCount member for the compression mode specified by bV4Compression. 
        /// If bV4ClrUsed is nonzero and the bV4BitCount member is less than 16, the bV4ClrUsed member 
        /// specifies the actual number of colors the graphics engine or device driver accesses. If bV4BitCount
        /// is 16 or greater, the bV4ClrUsed member specifies the size of the color table used to optimize 
        /// performance of the system color palettes. If bV4BitCount equals 16 or 32, the optimal color 
        /// palette starts immediately following the BITMAPV4HEADER
        /// </summary>
        public uint bV4ClrUsed;

        /// <summary>
        /// Specifies the number of color indexes that are required for displaying the bitmap. 
        /// If this value is zero, all colors are important
        /// </summary>
        public uint bV4ClrImportant;

        /// <summary>
        /// Color mask that specifies the red component of each pixel, valid only if bV4Compression 
        /// is set to BI_BITFIELDS
        /// </summary>
        public uint bV4RedMask;

        /// <summary>
        /// Color mask that specifies the green component of each pixel, valid only if bV4Compression 
        /// is set to BI_BITFIELDS
        /// </summary>
        public uint bV4GreenMask;

        /// <summary>
        /// Color mask that specifies the blue component of each pixel, valid only if bV4Compression 
        /// is set to BI_BITFIELDS
        /// </summary>
        public uint bV4BlueMask;

        /// <summary>
        /// Color mask that specifies the alpha component of each pixel
        /// </summary>
        public uint bV4AlphaMask;

        /// <summary>
        /// Specifies the color space of the DIB. The following table lists the value for bV4CSType
        /// 
        /// Uses only LCS_CALIBRATED_RGB
        /// </summary>
        public const uint BV4CsType = (uint) LogicalColorSpace.LCS_CALIBRATED_RGB;

        /// <summary>
        /// A CIEXYZTRIPLE structure that specifies the x, y, and z coordinates of the three colors
        /// that correspond to the red, green, and blue endpoints for the logical color space associated
        /// with the bitmap. This member is ignored unless the bV4CSType member specifies LCS_CALIBRATED_RGB
        /// </summary>
        public CEXYZTriple bV4Endpoints;

        /// <summary>
        /// Toned response curve for red. This member is ignored unless color values are calibrated RGB values
        /// and bV4CSType is set to LCS_CALIBRATED_RGB. Specified in 16^16 format
        /// </summary>
        public uint bV4GammaRed;

        /// <summary>
        /// Toned response curve for green. Used if bV4CSType is set to LCS_CALIBRATED_RGB. Specified as 16^16 format
        /// </summary>
        public uint bV4GammaGreen;

        /// <summary>
        /// Toned response curve for blue. Used if bV4CSType is set to LCS_CALIBRATED_RGB. Specified as 16^16 format
        /// </summary>
        public uint bV4GammaBlue;
    }
}