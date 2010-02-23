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
    /// The BITMAPV5HEADER structure is the bitmap information header file.
    /// It is an extended version of the BITMAPINFOHEADER structure
    /// </summary>
    /// <remarks>Windows 95 and Windows NT 4.0: Applications can use the BITMAPV4HEADER structure. 
    /// Windows NT 3.51 and earlier: Applications should continue to use BITMAPINFOHEADER.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct BITMAPV5Header : IBitmapInfoHeader
    {
        /// <summary>
        /// Specifies the number of bytes required by the structure. Applications should use this member
        /// to determine which bitmap information header structure is being used
        /// </summary>
        public uint bV5Size;

        /// <summary>
        /// Specifies the width of the bitmap, in pixels. 
        /// If bV5Compression is BI_JPEG or BI_PNG, the bV5Width member specifies the width of the 
        /// decompressed JPEG or PNG image in pixels
        /// </summary>
        public int bV5Width;

        /// <summary>
        /// Specifies the height of the bitmap, in pixels. If the value of bV5Height is positive, 
        /// the bitmap is a bottom-up DIB and its origin is the lower-left corner. If bV5Height value is
        /// negative, the bitmap is a top-down DIB and its origin is the upper-left corner. 
        /// If bV5Height is negative, indicating a top-down DIB, bV5Compression must be either BI_RGB 
        /// or BI_BITFIELDS. Top-down DIBs cannot be compressed. 
        /// If bV5Compression is BI_JPEG or BI_PNG, the bV5Height member specifies the height of the 
        /// decompressed JPEG or PNG image in pixels
        /// </summary>
        public int bV5Height;

        /// <summary>
        /// Specifies the number of planes for the target device. This value must be set to 1.
        /// </summary>
        public ushort bV5Planes;

        /// <summary>
        /// Specifies the number of bits that define each pixel and the maximum number of colors in the bitmap
        /// </summary>
        public BitCount bV5BitCount;

        /// <summary>
        /// Specifies that the bitmap is not compressed. The bV5RedMask, bV5GreenMask, and bV5BlueMask members 
        /// specify the red, green, and blue components of each pixel. This is valid when used with 16- and 32-bpp bitmaps
        /// </summary>
        public BitmapCompression bV5Compression;

        /// <summary>
        /// Specifies the size, in bytes, of the image. This may be set to zero for BI_RGB bitmaps. 
        /// If bV5Compression is BI_JPEG or BI_PNG, bV5SizeImage is the size of the JPEG or PNG image buffer
        /// </summary>
        public uint bV5SizeImage;

        /// <summary>
        /// Specifies the horizontal resolution, in pixels-per-meter, of the target device for the bitmap.
        /// An application can use this value to select a bitmap from a resource group that best matches the 
        /// characteristics of the current device
        /// </summary>
        public int bV5XPelsPerMeter;

        /// <summary>
        /// Specifies the vertical resolution, in pixels-per-meter, of the target device for the bitmap
        /// </summary>
        public int bV5YPelsPerMeter;

        /// <summary>
        /// Specifies the number of color indexes in the color table that are actually used by the bitmap.
        /// If this value is zero, the bitmap uses the maximum number of colors corresponding to the value
        /// of the bV5BitCount member for the compression mode specified by bV5Compression. 
        /// If bV5ClrUsed is nonzero and bV5BitCount is less than 16, the bV5ClrUsed member specifies the 
        /// actual number of colors the graphics engine or device driver accesses. If bV5BitCount is 16 or
        /// greater, the bV5ClrUsed member specifies the size of the color table used to optimize performance
        /// of the system color palettes. If bV5BitCount equals 16 or 32, the optimal color palette starts 
        /// immediately following the BITMAPV5HEADER. If bV5ClrUsed is nonzero, the color table is used on 
        /// palettized devices, and bV5ClrUsed specifies the number of entries
        /// </summary>
        public uint bV5ClrUsed;

        /// <summary>
        /// Specifies the number of color indexes that are required for displaying the bitmap. 
        /// If this value is zero, all colors are required
        /// </summary>
        public uint bV5ClrImportant;

        /// <summary>
        /// Color mask that specifies the red component of each pixel, valid only if bV5Compression is set to BI_BITFIELDS
        /// </summary>
        public uint bV5RedMask;

        /// <summary>
        /// Color mask that specifies the green component of each pixel, valid only if bV5Compression is set to BI_BITFIELDS
        /// </summary>
        public uint bV5GreenMask;

        /// <summary>
        /// Color mask that specifies the blue component of each pixel, valid only 
        /// if bV5Compression is set to BI_BITFIELDS
        /// </summary>
        public uint bV5BlueMask;

        /// <summary>
        /// Color mask that specifies the alpha component of each pixel
        /// </summary>
        public uint bV5AlphaMask;

        /// <summary>
        /// Specifies the color space of the DIB
        /// </summary>
        public LogicalColorSpace bV5CSType;

        /// <summary>
        /// A CIEXYZTRIPLE structure that specifies the x, y, and z coordinates of 
        /// the three colors that correspond to the red, green, and blue endpoints for the 
        /// logical color space associated with the bitmap. This member is ignored unless 
        /// the bV5CSType member specifies LCS_CALIBRATED_RGB
        /// </summary>
        public CEXYZTriple bV5Endpoints;

        /// <summary>
        /// Toned response curve for red. Used if bV5CSType is set
        /// to LCS_CALIBRATED_RGB. Specified in 16^16 format.
        /// </summary>
        public uint bV5GammaRed;

        /// <summary>
        /// Toned response curve for green. Used if bV5CSType is
        /// set to LCS_CALIBRATED_RGB. Specified in 16^16 format.
        /// </summary>
        public uint bV5GammaGreen;

        /// <summary>
        /// Toned response curve for blue. Used if bV5CSType is 
        /// set to LCS_CALIBRATED_RGB. Specified in 16^16 format. 
        /// </summary>
        public uint bV5GammaBlue;

        /// <summary>
        /// Rendering intent for bitmap
        /// </summary>
        public RenderingIntent bV5Intent;

        /// <summary>
        /// The offset, in bytes, from the beginning of the BITMAPV5HEADER
        /// structure to the start of the profile data. If the profile is 
        /// embedded, profile data is the actual profile, and it is linked. 
        /// (The profile data is the null-terminated file name of the profile.) 
        /// This cannot be a Unicode string. It must be composed exclusively of 
        /// characters from the Windows character set (code page 1252). 
        /// These profile members are ignored unless the bV5CSType member specifies
        /// PROFILE_LINKED or PROFILE_EMBEDDED
        /// </summary>
        public uint bV5ProfileData;

        /// <summary>
        /// Size, in bytes, of embedded profile data. 
        /// </summary>
        public uint bV5ProfileSize;

        /// <summary>
        /// This member has been reserved. Its value should be set to zero
        /// </summary>
        public uint bV5Reserved;
    }
}