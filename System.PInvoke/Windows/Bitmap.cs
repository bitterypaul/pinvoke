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
using System.Drawing;
using System.PInvoke.Windows.Enums;
using System.PInvoke.Windows.Interface;
using System.PInvoke.Windows.Structs;
using System.Runtime.InteropServices;
using Size = System.PInvoke.Windows.Structs.Size;

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signature of handling Bitmap files
    /// </summary>
    public class Bitmap
    {
        /// <summary>
        /// Flag for initializing the bitmap bits 
        /// </summary>
        public const int CBM_INIT = 4;

        /// <summary>
        /// If the pixel is outside of the current clipping region, GetPixel returns this
        /// </summary>
        public const int CLR_INVALID = -1;

        /// <summary>
        /// Creates a new image (icon, cursor, or bitmap) and copies the attributes 
        /// of the specified image to the new one. If necessary, the function stretches
        /// the bits to fit the desired size of the new image
        /// </summary>
        /// <param name="hImage">Handle to the image to be copied</param>
        /// <param name="type">Specifies the type of image to be copied</param>
        /// <param name="cxDesired">Specifies the desired width, in pixels, of the image. If this is zero,
        /// then the returned image will have the same width as the original hImage</param>
        /// <param name="cyDesired">Specifies the desired height, in pixels, of the image. If this is zero, 
        /// then the returned image will have the same height as the original hImage</param>
        /// <param name="flags">Image copy operation to be performed</param>
        /// <returns>If the function succeeds, the return value is the handle to the newly created image</returns>
        public static IntPtr CopyImage([In] IntPtr hImage, ImageCopyOption type, int cxDesired, int cyDesired,
                                       ImageCopyOperation flags)
        {
            return Native.CopyImage(hImage, type, cxDesired, cyDesired, flags);
        }

        /// <summary>
        /// The CreateBitmap function creates a bitmap with the specified width, height, 
        /// and color format (color planes and bits-per-pixel)
        /// </summary>
        /// <param name="nWidth">Specifies the bitmap width, in pixels</param>
        /// <param name="nHeight">Specifies the bitmap height, in pixels</param>
        /// <param name="nPlanes">Specifies the number of color planes used by the device</param>
        /// <param name="nBitCount">Specifies the number of bits required to identify the color of a single pixel</param>
        /// <param name="lpBits">Pointer to an array of color data used to set the colors in a rectangle of pixels. 
        /// Each scan line in the rectangle must be word aligned (scan lines that are not word aligned must be padded with zeros).
        /// If this parameter is null, the contents of the new bitmap is undefined</param>
        /// <returns>If the function succeeds, the return value is a handle to a bitmap, otherwise null</returns>
        public static IntPtr CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount, [In] IntPtr lpBits)
        {
            return Native.CreateBitmap(nWidth, nHeight, nPlanes, nBitCount, lpBits);
        }

        /// <summary>
        /// The CreateCompatibleBitmap function creates a bitmap compatible with the device that is 
        /// associated with the specified device context
        /// </summary>
        /// <param name="hdc">Handle to a device context</param>
        /// <param name="cx">Specifies the bitmap width, in pixels</param>
        /// <param name="cy">Specifies the bitmap height, in pixels</param>
        /// <returns>If the function succeeds, the return value is a handle to the compatible bitmap (DDB), otherwise null</returns>
        /// <remarks>The color format of the bitmap created by the CreateCompatibleBitmap 
        /// function matches the color format of the device identified by the hdc parameter. 
        /// This bitmap can be selected into any memory device context that is compatible with the original device.</remarks>
        public static IntPtr CreateCompatibleBitmap([In] IntPtr hdc, int cx, int cy)
        {
            return Native.CreateCompatibleBitmap(hdc, cx, cy);
        }

        /// <summary>
        /// The CreateDIBSection function creates a DIB that applications can write to directly. The function gives you a pointer to 
        /// the location of the bitmap bit values. You can supply a handle to a file-mapping object that the function will use to 
        /// create the bitmap, or you can let the system allocate the memory for the bitmap
        /// </summary>
        /// <param name="hdc">Handle to a device context. If the value of iUsage is DIB_PAL_COLORS, the function uses this device 
        /// context's logical palette to initialize the DIB colors.</param>
        /// <param name="pbmi">Pointer to a BITMAPINFO structure that specifies various attributes of the DIB, 
        /// including the bitmap dimensions and colors</param>
        /// <param name="iUsage">Specifies the type of data contained in the bmiColors array member of the BITMAPINFO structure pointed to 
        /// by pbmi (either logical palette indexes or literal RGB values)</param>
        /// <param name="ppvBits">Pointer to a variable that receives a pointer to the location of the DIB bit values</param>
        /// <param name="hSection">Handle to a file-mapping object that the function will use to create the DIB. This parameter can be null. 
        /// <para>If hSection is not null, it must be a handle to a file-mapping object created by calling the CreateFileMapping function with 
        /// the PAGE_READWRITE or PAGE_WRITECOPY flag. Read-only DIB sections are not supported. Handles created by other means will cause CreateDIBSection to fail. 
        /// </para>
        /// If hSection is not null, the CreateDIBSection function locates the bitmap bit values at offset dwOffset in the file-mapping object referred to by hSection.
        /// An application can later retrieve the hSection handle by calling the GetObject function with the HBITMAP returned by CreateDIBSection. 
        /// <para>
        /// If hSection is null, the system allocates memory for the DIB. In this case, the CreateDIBSection function ignores the dwOffset parameter. 
        /// An application cannot later obtain a handle to this memory. The dshSection member of the DIBSECTION structure filled in by calling the GetObject function will be null
        /// </para></param>
        /// <param name="dwOffset">Specifies the offset from the beginning of the file-mapping object referenced by hSection where storage for the bitmap bit values is to begin. This value is ignored if hSection is null.
        /// The bitmap bit values are aligned on doubleword boundaries, so dwOffset must be a multiple of the size of a DWORD</param>
        /// <returns></returns>
        public static IntPtr CreateDIBSection([In] IntPtr hdc, [In] ref BitmapInfo pbmi, DIBColorTable iUsage,
                                              ref IntPtr ppvBits, [In] IntPtr hSection, uint dwOffset)
        {
            return Native.CreateDIBSection(hdc, ref pbmi, iUsage, ref ppvBits, hSection, dwOffset);
        }

        /// <summary>
        /// The GetBitmapBits function copies the bitmap bits of a specified device-dependent bitmap into a buffer
        /// </summary>
        /// <param name="hbit">Handle to the device-dependent bitmap</param>
        /// <param name="cb">Specifies the number of bytes to copy from the bitmap into the buffer</param>
        /// <param name="lpvBits">Pointer to a buffer to receive the bitmap bits. The bits are stored as an array of byte values</param>
        /// <returns>If the function succeeds, the return value is the number of bytes copied to the buffer, 0 otherwise</returns>
        /// <remarks>This function is provided only for compatibility with 16-bit versions of Windows. 
        /// Applications should use the GetDIBits function</remarks>
        public static int GetBitmapBits([In] IntPtr hbit, int cb, IntPtr lpvBits)
        {
            return Native.GetBitmapBits(hbit, cb, lpvBits);
        }

        /// <summary>
        /// The GetDIBits function retrieves the bits of the specified compatible bitmap and copies them into
        /// a buffer as a DIB using the specified format
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="hbm">Handle to the bitmap. This must be a compatible bitmap (DDB)</param>
        /// <param name="start">Specifies the first scan line to retrieve</param>
        /// <param name="cLines">Specifies the number of scan lines to retrieve</param>
        /// <param name="lpvBits">Pointer to a buffer to receive the bitmap data. If this parameter is null, 
        /// the function passes the dimensions and format of the bitmap to the BITMAPINFO structure pointed to
        /// by the lpbmi parameter</param>
        /// <param name="lpbmi">Pointer to a BITMAPINFO structure that specifies the desired format for the DIB data</param>
        /// <param name="usage">Specifies the format of the bmiColors member of the BITMAPINFO structure.</param>
        /// <returns>If the lpvBits parameter is non-null and the function succeeds, the return value is the number of scan lines copied from the bitmap</returns>
        public static int GetDIBits([In] IntPtr hdc, [In] IntPtr hbm, uint start, uint cLines, IntPtr lpvBits,
                                    ref BitmapInfo lpbmi, DIBColorTable usage)
        {
            return Native.GetDIBits(hdc, hbm, start, cLines, lpvBits, ref lpbmi, usage);
        }


        /// <summary>
        /// The SetBitmapBits function sets the bits of color data for a bitmap to the specified values
        /// </summary>
        /// <param name="hbmp">Handle to the bitmap to be set. This must be a compatible bitmap (DDB)</param>
        /// <param name="cb">Specifies the number of bytes pointed to by the lpBits parameter</param>
        /// <param name="lpBits">Pointer to an array of bytes that contain color data for the specified bitmap</param>
        /// <returns>If the function succeeds, the return value is the number of bytes used in setting the bitmap bits, otherwise 0</returns>
        /// <remarks>This function is provided only for compatibility with 16-bit versions of Windows. Applications should use the SetDIBits function</remarks>
        public static int SetBitmapBits([In] IntPtr hbmp, uint cb, [In] IntPtr lpBits)
        {
            return Native.SetBitmapBits(hbmp, cb, lpBits);
        }

        /// <summary>
        /// The SetDIBitsToDevice function sets the pixels in the specified rectangle on the device that 
        /// is associated with the destination device context using color data from a DIB. 
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="xDest">Specifies the x-coordinate, in logical units, of the upper-left 
        /// corner of the destination rectangle</param>
        /// <param name="yDest">Specifies the y-coordinate, in logical units, of the upper-left
        /// corner of the destination rectangle</param>
        /// <param name="width">Specifies the width, in logical units, of the DIB</param>
        /// <param name="height">Specifies the height, in logical units, of the DIB</param>
        /// <param name="xSrc">Specifies the x-coordinate, in logical units, of the lower-left corner of the DIB</param>
        /// <param name="ySrc">Specifies the y-coordinate, in logical units, of the lower-left corner of the DIB</param>
        /// <param name="startScan">Specifies the starting scan line in the DIB</param>
        /// <param name="cLines">Specifies the number of DIB scan lines contained in the array pointed to by the lpvBits parameter</param>
        /// <param name="lpvBits">Pointer to DIB color data stored as an array of bytes. For more information, 
        /// see the following Remarks section</param>
        /// <param name="lpbmi">Pointer to a BITMAPINFO structure that contains information about the DIB</param>
        /// <param name="colorUse">Specifies whether the bmiColors member of the BITMAPINFO structure contains explicit red, green,
        /// blue (RGB) values or indexes into a palette.</param>
        /// <returns>If the function succeeds, the return value is the number of scan lines set.</returns>
        /// <remarks>Windows 98/Me, Windows 2000/XP: SetDIBitsToDevice has been extended to allow a JPEG or PNG 
        /// image to be passed as the source image</remarks>
        public static int SetDIBitsToDevice([In] IntPtr hdc, int xDest, int yDest, uint width, uint height, int xSrc,
                                            int ySrc, uint startScan, uint cLines, [In] IntPtr lpvBits,
                                            [In] ref BitmapInfo lpbmi, DIBColorTable colorUse)
        {
            return Native.SetDIBitsToDevice(hdc, xDest, yDest, width, height, xSrc, ySrc, startScan, cLines, lpvBits,
                                            ref lpbmi, colorUse);
        }

        /// <summary>
        /// The SetDIBits function sets the pixels in a compatible bitmap (DDB) using the color data found in the specified DIB 
        /// </summary>
        /// <param name="hdc">Handle to a device context</param>
        /// <param name="hbm">Handle to the compatible bitmap (DDB) that is to be altered using the color data from the specified DIB</param>
        /// <param name="start">Specifies the starting scan line for the device-independent color data in the array pointed to by the lpBits parameter</param>
        /// <param name="cLines">Specifies the number of scan lines found in the array containing device-independent color data</param>
        /// <param name="lpBits">Pointer to the DIB color data, stored as an array of bytes. The format of the bitmap values depends on the biBitCount member of the 
        /// BITMAPINFO structure pointed to by the lpbmi parameter</param>
        /// <param name="lpbmi">Pointer to a BITMAPINFO structure that contains information about the DIB</param>
        /// <param name="colorUse">Specifies whether the bmiColors member of the BITMAPINFO structure was provided and, if so, whether bmiColors contains explicit 
        /// red, green, blue (RGB) values or palette indexes.</param>
        /// <returns>If the function succeeds, the return value is the number of scan lines copied, 0 otherwise</returns>
        public static int SetDIBits([In] IntPtr hdc, [In] IntPtr hbm, uint start, uint cLines, [In] IntPtr lpBits,
                                    [In] ref BitmapInfo lpbmi, DIBColorTable colorUse)
        {
            return Native.SetDIBits(hdc, hbm, start, cLines, lpBits, ref lpbmi, colorUse);
        }

        /// <summary>
        /// The CreateBitmapIndirect function creates a bitmap with the specified width, height, and color format (color planes and bits-per-pixel)
        /// </summary>
        /// <param name="pbm">Pointer to a BITMAP structure that contains information about the bitmap. If an application sets the bmWidth or bmHeight 
        /// members to zero, CreateBitmapIndirect returns the handle to a 1-by-1 pixel, monochrome bitmap</param>
        /// <returns>If the function succeeds, the return value is a handle to the bitmap, else null</returns>
        public static IntPtr CreateBitmapIndirect([In] ref BITMAP pbm)
        {
            return Native.CreateBitmapIndirect(ref pbm);
        }

        /// <summary>
        /// The CreateDIBitmap function creates a compatible bitmap (DDB) from a DIB and, optionally, sets the bitmap bits
        /// </summary>
        /// <param name="hdc">Handle to a device context</param>
        /// <param name="pbmih">Pointer to a bitmap information header structure, which may be one of those shown as
        /// Windows NT 3.51 and earlier - BITMAPINFOHEADER
        /// Windows 95 and Windows NT 4.0 - BITMAPV4HEADER
        /// Windows 98/Me and Windows 2000 - BITMAPV5HEADER
        /// </param>
        /// <param name="flInit">Specifies how the system initializes the bitmap bits.
        /// If fdwInit is zero, the system does not initialize the bitmap bits</param>
        /// <remarks>CBM_INIT : If this flag is set, the system uses the data pointed to by the lpbInit and lpbmi parameters to initialize the bitmap bits.
        /// If this flag is clear, the data pointed to by those parameters is not used</remarks>
        /// <param name="pjBits">Pointer to an array of bytes containing the initial bitmap data. The format of the data depends on the biBitCount member of 
        /// the BITMAPINFO structure to which the lpbmi parameter points</param>
        /// <param name="pbmi">Pointer to a BITMAPINFO structure that describes the dimensions and color format of the array pointed to by the lpbInit parameter</param>
        /// <param name="iUsage">Specifies whether the bmiColors member of the BITMAPINFO structure was initialized and, if so, whether bmiColors contains explicit red, 
        /// green, blue (RGB) values or palette indexes</param>
        /// <returns>If the function succeeds, the return value is a handle to the compatible bitmap, else null</returns>
        public static IntPtr CreateDIBitmap([In] IntPtr hdc, ref IBitmapInfoHeader pbmih, uint flInit,
                                            [In] IntPtr pjBits, [In] ref BitmapInfo pbmi, DIBColorTable iUsage)
        {
            return Native.CreateDIBitmap(hdc, ref pbmih, flInit, pjBits, ref pbmi, iUsage);
        }

        /// <summary>
        /// The ExtFloodFill function fills an area of the display surface with the current brush
        /// </summary>
        /// <param name="hdc">Handle to a device context</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the point where filling is to start</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the point where filling is to start</param>
        /// <param name="color">Specifies the color of the boundary or of the area to be filled. The interpretation of
        /// color depends on the value of the fuFillType parameter. To create a COLORREF color value, use the RGB macro</param>
        /// <param name="fuFillType">Specifies the type of fill operation to be performed</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool ExtFloodFill([In] IntPtr hdc, int x, int y, Color color, FillType fuFillType)
        {
            return Native.ExtFloodFill(hdc, x, y, RGB.ToWin32Color(color), fuFillType);
        }

        /// <summary>
        /// The GetBitmapDimensionEx function retrieves the dimensions of a compatible bitmap. 
        /// The retrieved dimensions must have been set by the SetBitmapDimensionEx function. 
        /// </summary>
        /// <param name="hbit">Handle to a compatible bitmap (DDB)</param>
        /// <param name="lpsize">Pointer to a SIZE structure to receive the bitmap dimensions. For more information, see Remarks</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        /// <remarks>The function returns a data structure that contains fields for the height and width of the bitmap, in .01-mm units.
        /// If those dimensions have not yet been set, the structure that is returned will have zeroes in those fields</remarks>
        public static bool GetBitmapDimensionEx([In] IntPtr hbit, [Out] out Size lpsize)
        {
            return Native.GetBitmapDimensionEx(hbit, out lpsize);
        }

        /// <summary>
        /// The SetBitmapDimensionEx function assigns preferred dimensions to a bitmap. These dimensions can be used by applications
        /// however, they are not used by the system
        /// </summary>
        /// <param name="hbm">Handle to the bitmap. The bitmap cannot be a DIB-section bitmap</param>
        /// <param name="nWidth">Specifies the width, in 0.1-millimeter units, of the bitmap</param>
        /// <param name="nHeight">Specifies the height, in 0.1-millimeter units, of the bitmap</param>
        /// <param name="lpsz">Pointer to a SIZE structure to receive the previous dimensions of the bitmap. This pointer can be null</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool SetBitmapDimensionEx([In] IntPtr hbm, int nWidth, int nHeight, ref Size lpsz)
        {
            return Native.SetBitmapDimensionEx(hbm, nWidth, nHeight, ref lpsz);
        }

        /// <summary>
        /// The GetDIBColorTable function retrieves RGB (red, green, blue) color values from a range of entries in the color table of the
        /// DIB section bitmap that is currently selected into a specified device context
        /// </summary>
        /// <param name="hdc">Handle to a device context. A DIB section bitmap must be selected into this device context</param>
        /// <param name="uStartIndex">A zero-based color table index that specifies the first color table entry to retrieve</param>
        /// <param name="cEntries">Specifies the number of color table entries to retrieve</param>
        /// <param name="pColors">An array of RGBQUAD data structures containing color information from the DIB color table. The buffer must be 
        /// large enough to contain as many RGBQUAD data structures as the value of cEntries</param>
        /// <returns>If the function succeeds, the return value is the number of color table entries that the function retrieves, else 0</returns>
        /// <remarks>The GetDIBColorTable function should be called to retrieve the color table for DIB section bitmaps that use 1, 4, or 8 bpp. 
        /// The biBitCount member of a bitmap associated BITMAPINFOHEADER structure specifies the number of bits-per-pixel. DIB section bitmaps 
        /// with a biBitCount value greater than eight do not have a color table, but they do have associated color masks. Call the GetObject 
        /// function to retrieve those color masks</remarks>
        // HACK : Check if Attribute of pColors is ok or not in native call
        public static uint GetDIBColorTable(IntPtr hdc, uint uStartIndex, uint cEntries, [Out] RGBQuad[] pColors)
        {
            return Native.GetDIBColorTable(hdc, uStartIndex, cEntries, pColors);
        }

        /// <summary>
        /// The SetDIBColorTable function sets RGB (red, green, blue) color values in a range of entries in the color table of the DIB 
        /// that is currently selected into a specified device context.
        /// </summary>
        /// <param name="hdc">Specifies a device context. A DIB must be selected into this device context</param>
        /// <param name="iStart">A zero-based color table index that specifies the first color table entry to set</param>
        /// <param name="cEntries">Specifies the number of color table entries to set</param>
        /// <param name="prgbq">An array of RGBQUAD structures containing new color information for the DIB's color table</param>
        /// <returns>If the function succeeds, the return value is the number of color table entries that the function sets, else 0</returns>
        /// <remarks>This function should be called to set the color table for DIBs that use 1, 4, or 8 bpp. The BitCount member of a 
        /// bitmap's associated bitmap information header structure</remarks>
        public static uint SetDIBColorTable(IntPtr hdc, uint iStart, uint cEntries, RGBQuad[] prgbq)
        {
            return Native.SetDIBColorTable(hdc, iStart, cEntries, prgbq);
        }

        /// <summary>
        /// The GetPixel function retrieves the red, green, blue (RGB) color value of the pixel at the specified coordinates
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the pixel to be examined</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the pixel to be examined</param>
        /// <returns>The return value is the RGB value of the pixel. If the pixel is outside of the current clipping region, the return value is CLR_INVALID</returns>
        /// <remarks>The pixel must be within the boundaries of the current clipping region. 
        /// Not all devices support GetPixel. An application should call GetDeviceCaps to determine whether a specified device supports this function. 
        /// A bitmap must be selected within the device context, otherwise, CLR_INVALID is returned on all pixels.
        /// </remarks>
        public static Color GetPixel([In] IntPtr hdc, int x, int y)
        {
            return RGB.FromWin32Color(Native.GetPixel(hdc, x, y));
        }

        /// <summary>
        /// The SetPixel function sets the pixel at the specified coordinates to the specified color
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the point to be set</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the point to be set</param>
        /// <param name="color">Specifies the color to be used to paint the poin</param>
        /// <returns>If the function succeeds, the return value is the RGB value that the function sets 
        /// the pixel to. This value may differ from the color specified by crColor; that occurs when an
        /// exact match for the specified color cannot be found.
        /// If the function fails, the return value is 1. 
        /// </returns>
        public static uint SetPixel([In] IntPtr hdc, int x, int y, Color color)
        {
            return Native.SetPixel(hdc, x, y, RGB.ToWin32Color(color));
        }

        /// <summary>
        /// The SetPixelV function sets the pixel at the specified coordinates to the closest 
        /// approximation of the specified color. The point must be in the clipping region and 
        /// the visible part of the device surface
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the point to be set</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the point to be set</param>
        /// <param name="color">Specifies the color to be used to paint the point</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool SetPixelV([In] IntPtr hdc, int x, int y, Color color)
        {
            return Native.SetPixelV(hdc, x, y, RGB.ToWin32Color(color));
        }

        /// <summary>
        /// The GradientFill function fills rectangle and triangle structures
        /// </summary>
        /// <param name="hdc">Handle to the destination device contex</param>
        /// <param name="pVertex">Array of TRIVERTEX structures that each define a triangle vertex</param>
        /// <param name="nVertex">The number of vertices in pVertex</param>
        /// <param name="pMesh">Array of elements</param>
        /// <param name="nMesh">The number of elements in pMesh</param>
        /// <param name="ulMode">Specifies gradient fill mode</param>
        /// <returns>If the function succeeds, the return value is true, false</returns>
        public static bool GradientFill([In] IntPtr hdc, TriVertex[] pVertex, uint nVertex, uint[] pMesh, uint nMesh,
                                        GradientFillMode ulMode)
        {
            return Native.GradientFill(hdc, pVertex, nVertex, pMesh, nMesh, ulMode);
        }

        /// <summary>
        /// The GradientFill function fills rectangle and triangle structures
        /// </summary>
        /// <param name="hdc">Handle to the destination device contex</param>
        /// <param name="pVertex">Array of TRIVERTEX structures that each define a triangle vertex</param>
        /// <param name="nVertex">The number of vertices in pVertex</param>
        /// <param name="pMesh">Array of GRADIENT_TRIANGLE structures in triangle mode</param>
        /// <param name="nMesh">The number of elements in pMesh</param>
        /// <param name="ulMode">Specifies gradient fill mode</param>
        /// <returns>If the function succeeds, the return value is true, false</returns>
        public static bool GradientFill([In] IntPtr hdc, TriVertex[] pVertex, uint nVertex, GradientTriangle[] pMesh,
                                        uint nMesh, GradientFillMode ulMode)
        {
            return Native.GradientFill(hdc, pVertex, nVertex, pMesh, nMesh, ulMode);
        }

        /// <summary>
        /// The GradientFill function fills rectangle and triangle structures
        /// </summary>
        /// <param name="hdc">Handle to the destination device contex</param>
        /// <param name="pVertex">Array of TRIVERTEX structures that each define a triangle vertex</param>
        /// <param name="nVertex">The number of vertices in pVertex</param>
        /// <param name="pMesh">an array of GRADIENT_RECT structures in rectangle mode</param>
        /// <param name="nMesh">The number of elements in pMesh</param>
        /// <param name="ulMode">Specifies gradient fill mode</param>
        /// <returns>If the function succeeds, the return value is true, false</returns>
        public static bool GradientFill([In] IntPtr hdc, TriVertex[] pVertex, uint nVertex, GradientRect[] pMesh,
                                        uint nMesh, GradientFillMode ulMode)
        {
            return Native.GradientFill(hdc, pVertex, nVertex, pMesh, nMesh, ulMode);
        }

        /// <summary>
        /// The LoadBitmap function loads the specified bitmap resource from a module's executable file. This function has been superseded by the LoadImage function
        /// </summary>
        /// <param name="hInstance">Handle to the instance of the module whose executable file contains the bitmap to be loaded</param>
        /// <param name="lpBitmapName">Pointer to a null-terminated string that contains the name of the bitmap resource to be loaded. Alternatively, this parameter can 
        /// consist of the resource identifier in the low-order word and zero in the high-order word. The MAKEINTRESOURCE macro can be used to create this value</param>
        /// <returns>If the function succeeds, the return value is the handle to the specified bitmap, else null</returns>
        /// <remarks>If the bitmap pointed to by the lpBitmapName parameter does not exist or there is insufficient memory to load the bitmap, the function fails
        /// LoadBitmap creates a compatible bitmap of the display, which cannot be selected to a printer. To load a bitmap that you can select to a printer, call LoadImage
        /// and specify LR_CREATEDIBSECTION to create a DIB section. A DIB section can be selected to any device
        /// 
        /// An application can use the LoadBitmap function to access predefined bitmaps. To do so, use LoadBitmap(OEMBitmap uid) overloaded method.
        /// 
        /// The application must call the DeleteObject function to delete each bitmap handle returned by the LoadBitmap function
        /// </remarks>
        public static IntPtr LoadBitmap([In] IntPtr hInstance, [In] string lpBitmapName)
        {
            if (Environment.OSVersion.Platform >= PlatformID.Win32NT)
                Native.LoadBitmapW(hInstance, lpBitmapName);
            return Native.LoadBitmapA(hInstance, lpBitmapName);
        }

        /// <summary>
        /// The LoadBitmap function loads the specified bitmap resource from a module's executable file. This function has been superseded by the LoadImage function
        /// Application uses this function to access predefined bitmaps
        /// </summary>
        /// <param name="uID">Ids for predefined OEM Bitmaps</param>
        /// <returns>If the function succeeds, the return value is the handle to the specified bitmap, else null</returns>
        /// <remarks>Bitmap names that begin with OBM_OLD represent bitmaps used by 16-bit versions of Windows earlier than 3.0.
        /// Use of LoadBitmap to load OEM bitmaps is deprecated and is supported only for backward compatibility. 
        /// New applications should use DrawFrameControl to draw system elements.
        /// 
        /// The application must call the DeleteObject function to delete each bitmap handle returned by the LoadBitmap function
        /// </remarks>
        public static IntPtr LoadBitmap(OEMBitmap uID)
        {
            return Native.LoadBitmap((IntPtr) null, uID);
        }

        /// <summary>
        /// The GetPixelFormat function obtains the index of the currently selected pixel format of the specified device context
        /// </summary>
        /// <param name="hdc">Specifies the device context of the currently selected pixel format index returned by the function</param>
        /// <returns>If the function succeeds, the return value is the currently selected pixel format index of the specified device context.
        /// This is a positive, one-based index value. If the function fails, the return value is zero.</returns>
        /// <remarks>To obtain a detailed description of that pixel format use DescribePixelFormat function</remarks>
        public static int GetPixelFormat([In] IntPtr hdc)
        {
            return Native.GetPixelFormat(hdc);
        }

        /// <summary>
        /// The DescribePixelFormat function obtains information about the pixel format identified by iPixelFormat 
        /// of the device associated with hdc. The function sets the members of the PIXELFORMATDESCRIPTOR structure 
        /// pointed to by lpPixelFormatDescriptor with that pixel format data
        /// </summary>
        /// <param name="hdc">Specifies the device context</param>
        /// <param name="iPixelFormat">Index that specifies the pixel format. The pixel formats that a device context supports 
        /// are identified by positive one-based integer indexes</param>
        /// <param name="nBytes">The size, in bytes, of the structure pointed to by lpPixelFormatDescriptor. 
        /// The DescribePixelFormat function stores no more than nBytes bytes of data to that structure. 
        /// Set this value to sizeof(PIXELFORMATDESCRIPTOR)</param>
        /// <param name="lpPixelFormatDescriptor">Pointer to a PIXELFORMATDESCRIPTOR structure whose members the function sets 
        /// with pixel format data. The function stores the number of bytes copied to the structure in the structure's nSize member.
        /// If, upon entry, lpPixelFormatDescriptor is null, the function writes no data to the structure. This is useful when you only want to obtain 
        /// the maximum pixel format index of a device context</param>
        /// <returns>If the function succeeds, the return value is the maximum pixel format index of the device context. In addition, the function sets
        /// the members of the PIXELFORMATDESCRIPTOR structure pointed to by lpPixelFormatDescriptor according to the specified pixel format.
        /// </returns>
        public static int DescribePixelFormat(IntPtr hdc, int iPixelFormat, int nBytes,
                                              ref PixelFormatDescriptor lpPixelFormatDescriptor)
        {
            return Native.DescribePixelFormat(hdc, iPixelFormat, nBytes, ref lpPixelFormatDescriptor);
        }

        /// <summary>
        /// The ChoosePixelFormat function attempts to match an appropriate pixel format supported by a device context to a given pixel format specification
        /// </summary>
        /// <param name="hdc">Specifies the device context that the function examines to determine the best match for the pixel format descriptor pointed to by ppfd</param>
        /// <param name="ppfd">Pointer to a PIXELFORMATDESCRIPTOR structure that specifies the requested pixel format.</param>
        /// <returns>If the function succeeds, the return value is a pixel format index (one-based) that is the closest match to the given pixel format descriptor, else 0</returns>
        public static int ChoosePixelFormat([In] IntPtr hdc, [In] ref PixelFormatDescriptor ppfd)
        {
            return Native.ChoosePixelFormat(hdc, ref ppfd);
        }

        /// <summary>
        /// The SetPixelFormat function sets the pixel format of the specified device context to the format specified by the iPixelFormat index
        /// </summary>
        /// <param name="hdc">Specifies the device context whose pixel format the function attempts to set</param>
        /// <param name="format">Index that identifies the pixel format to set. The various pixel formats supported by a device context are
        /// identified by one-based indexes</param>
        /// <param name="ppfd">Pointer to a PIXELFORMATDESCRIPTOR structure that contains the logical pixel format specification. The system's metafile
        /// component uses this structure to record the logical pixel format specification. The structure has no other effect upon the behavior of the 
        /// SetPixelFormat function</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        /// <remarks>If hdc references a window, calling the SetPixelFormat function also changes the pixel format of the window. Setting the pixel format
        /// of a window more than once can lead to significant complications for the Window Manager and for multithread applications, so it is not allowed.
        /// An application can only set the pixel format of a window one time. Once a window's pixel format is set, it cannot be changed</remarks>
        public static bool SetPixelFormat([In] IntPtr hdc, int format, [In] ref PixelFormatDescriptor ppfd)
        {
            return Native.SetPixelFormat(hdc, format, ref ppfd);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("user32.dll", EntryPoint = "CopyImage", SetLastError = true)]
            public static extern IntPtr CopyImage([In] IntPtr hImage, ImageCopyOption type, int cx, int cy,
                                                  ImageCopyOperation flags);

            [DllImport("gdi32.dll", EntryPoint = "CreateBitmap", SetLastError = true)]
            public static extern IntPtr CreateBitmap(int nWidth, int nHeight, uint nPlanes, uint nBitCount,
                                                     [In] IntPtr lpBits);

            [DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap", SetLastError = true)]
            public static extern IntPtr CreateCompatibleBitmap([In] IntPtr hdc, int cx, int cy);

            [DllImport("gdi32.dll", EntryPoint = "CreateDIBSection", SetLastError = true)]
            public static extern IntPtr CreateDIBSection([In] IntPtr hdc, [In] ref BitmapInfo lpbmi, DIBColorTable usage,
                                                         ref IntPtr ppvBits, [In] IntPtr hSection, uint offset);

            [DllImport("gdi32.dll", EntryPoint = "GetBitmapBits", SetLastError = true)]
            public static extern int GetBitmapBits([In] IntPtr hbit, int cb, IntPtr lpvBits);

            [DllImport("gdi32.dll", EntryPoint = "GetDIBits", SetLastError = true)]
            public static extern int GetDIBits([In] IntPtr hdc, [In] IntPtr hbm, uint start, uint cLines, IntPtr lpvBits,
                                               ref BitmapInfo lpbmi, DIBColorTable usage);

            [DllImport("gdi32.dll", EntryPoint = "SetBitmapBits", SetLastError = true)]
            public static extern int SetBitmapBits([In] IntPtr hbm, uint cb, [In] IntPtr pvBits);

            [DllImport("gdi32.dll", EntryPoint = "SetDIBitsToDevice", SetLastError = true)]
            public static extern int SetDIBitsToDevice([In] IntPtr hdc, int xDest, int yDest, uint w, uint h, int xSrc,
                                                       int ySrc, uint startScan, uint cLines, [In] IntPtr lpvBits,
                                                       [In] ref BitmapInfo lpbmi, DIBColorTable colorUse);

            [DllImport("gdi32.dll", EntryPoint = "SetDIBits", SetLastError = true)]
            public static extern int SetDIBits([In] IntPtr hdc, [In] IntPtr hbm, uint start, uint cLines,
                                               [In] IntPtr lpBits, [In] ref BitmapInfo lpbmi, DIBColorTable colorUse);

            [DllImport("gdi32.dll", EntryPoint = "CreateBitmapIndirect", SetLastError = true)]
            public static extern IntPtr CreateBitmapIndirect([In] ref BITMAP pbm);

            [DllImport("gdi32.dll", EntryPoint = "CreateDIBitmap", SetLastError = true)]
            public static extern IntPtr CreateDIBitmap([In] IntPtr hdc, ref IBitmapInfoHeader pbmih, uint flInit,
                                                       [In] IntPtr pjBits, [In] ref BitmapInfo pbmi,
                                                       DIBColorTable iUsage);

            [DllImport("gdi32.dll", EntryPoint = "ExtFloodFill", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ExtFloodFill([In] IntPtr hdc, int x, int y, uint color, FillType type);

            [DllImport("gdi32.dll", EntryPoint = "GetBitmapDimensionEx", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetBitmapDimensionEx([In] IntPtr hbit, [Out] out Size lpsize);

            [DllImport("gdi32.dll", EntryPoint = "SetBitmapDimensionEx", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetBitmapDimensionEx([In] IntPtr hbm, int w, int h, ref Size lpsz);

            [DllImport("gdi32.dll", SetLastError = true)]
            public static extern uint GetDIBColorTable(IntPtr hdc, uint uStartIndex, uint cEntries,
                                                       [MarshalAs(UnmanagedType.LPArray,
                                                           ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] [Out] RGBQuad[] pColors);

            [DllImport("gdi32.dll", EntryPoint = "SetDIBColorTable", SetLastError = true)]
            public static extern uint SetDIBColorTable([In] IntPtr hdc, uint iStart, uint cEntries,
                                                       [MarshalAs(UnmanagedType.LPArray,
                                                           ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2)] RGBQuad[] prgbq);

            [DllImport("gdi32.dll", EntryPoint = "GetPixel", SetLastError = true)]
            public static extern uint GetPixel([In] IntPtr hdc, int x, int y);

            [DllImport("gdi32.dll", EntryPoint = "SetPixel", SetLastError = true)]
            public static extern uint SetPixel([In] IntPtr hdc, int x, int y, uint color);

            [DllImport("gdi32.dll", EntryPoint = "SetPixelV", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetPixelV([In] IntPtr hdc, int x, int y, uint color);

            [DllImport("msimg32.dll", EntryPoint = "GradientFill", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GradientFill([In] IntPtr hdc,
                                                   [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct
                                                       , SizeParamIndex = 2)] TriVertex[] pVertex, uint nVertex,
                                                   uint[] pMesh, uint nMesh, GradientFillMode ulMode);

            [DllImport("msimg32.dll", EntryPoint = "GradientFill", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GradientFill([In] IntPtr hdc,
                                                   [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct
                                                       , SizeParamIndex = 2)] TriVertex[] pVertex, uint nVertex,
                                                   GradientRect[] pMesh, uint nMesh, GradientFillMode ulMode);

            [DllImport("msimg32.dll", EntryPoint = "GradientFill", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GradientFill([In] IntPtr hdc,
                                                   [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct
                                                       , SizeParamIndex = 2)] TriVertex[] pVertex, uint nVertex,
                                                   GradientTriangle[] pMesh, uint nMesh, GradientFillMode ulMode);

            [DllImport("user32.dll", EntryPoint = "LoadBitmapW", SetLastError = true)]
            public static extern IntPtr LoadBitmapW([In] IntPtr hInstance,
                                                    [In] [MarshalAs(UnmanagedType.LPWStr)] string lpBitmapName);

            [DllImport("user32.dll", EntryPoint = "LoadBitmapA", SetLastError = true)]
            public static extern IntPtr LoadBitmapA([In] IntPtr hInstance,
                                                    [In] [MarshalAs(UnmanagedType.LPStr)] string lpBitmapName);

            [DllImport("User32.dll")]
            public static extern IntPtr LoadBitmap(IntPtr hInstance, OEMBitmap uID);

            [DllImport("gdi32.dll", EntryPoint = "GetPixelFormat", SetLastError = true)]
            public static extern int GetPixelFormat([In] IntPtr hdc);

            [DllImport("gdi32.dll", EntryPoint = "DescribePixelFormat", SetLastError = true)]
            public static extern int DescribePixelFormat(IntPtr hdc, int n, int un,
                                                         ref PixelFormatDescriptor lpPixelFormatDescriptor);

            [DllImport("gdi32.dll", EntryPoint = "ChoosePixelFormat", SetLastError = true)]
            public static extern int ChoosePixelFormat([In] IntPtr hdc, [In] ref PixelFormatDescriptor ppfd);

            [DllImport("gdi32.dll", EntryPoint = "SetPixelFormat", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetPixelFormat([In] IntPtr hdc, int format, [In] ref PixelFormatDescriptor ppfd);
        }

        #endregion
    }
}