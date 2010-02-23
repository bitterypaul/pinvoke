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
using System.PInvoke.Windows.Structs;
using System.Runtime.InteropServices;
using Point = System.PInvoke.Windows.Structs.Point;

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signatures for bit block transfer
    /// </summary>
    public class BitBlockTransfer
    {
        /// <summary>
        /// This flag is set when the bitmap has an Alpha channel 
        /// (that is, per-pixel alpha). Note that the APIs use premultiplied alpha, 
        /// which means that the red, green and blue channel values in the bitmap 
        /// must be premultiplied with the alpha channel value. For example, if the
        /// alpha channel value is x, the red, green and blue channels must be 
        /// multiplied by x and divided by 0xff prior to the call.
        /// </summary>
        public const int AC_SRC_ALPHA = 1;

        /// <summary>
        /// When the BlendOp parameter is AC_SRC_OVER , the source bitmap is placed
        /// over the destination bitmap based on the alpha values of the source pixels.
        /// </summary>
        public const int AC_SRC_OVER = 0;

        /// <summary>
        /// The AlphaBlend function displays bitmaps that have transparent or semitransparent pixels.
        /// </summary>
        /// <param name="hdcDest">Handle to the destination device context.</param>
        /// <param name="xoriginDest">Specifies the x-coordinate, in logical units, 
        /// of the upper-left corner of the destination rectangle</param>
        /// <param name="yoriginDest">Specifies the y-coordinate, in logical units, 
        /// of the upper-left corner of the destination rectangle</param>
        /// <param name="wDest">Specifies the width, in logical units, of the destination rectangle</param>
        /// <param name="hDest">Specifies the height, in logical units, of the destination rectangle</param>
        /// <param name="hdcSrc">Handle to the source device context</param>
        /// <param name="xoriginSrc">Specifies the x-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="yoriginSrc">Specifies the y-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="wSrc">Specifies the width, in logical units, of the source rectangle</param>
        /// <param name="hSrc">Specifies the height, in logical units, of the source rectangle</param>
        /// <param name="ftn">Specifies the alpha-blending function for source and destination bitmaps, a global alpha value to be 
        /// applied to the entire source bitmap, and format information for the source bitmap. The source and destination blend 
        /// functions are currently limited to AC_SRC_OVER.</param>
        /// <returns>If the function succeeds, the return value is true.
        /// If the function fails, the return value is FALSE. </returns>
        public static bool AlphaBlend(IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest,
                                      IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc,
                                      BlendFunction ftn)
        {
            return Native.AlphaBlend(hdcDest, xoriginDest, yoriginDest, wDest, hDest, hdcSrc, xoriginSrc, yoriginSrc,
                                     wSrc, hSrc, ftn);
        }

        /// <summary>
        /// The BitBlt function performs a bit-block transfer of the color data corresponding to a 
        /// rectangle of pixels from the specified source device context into a destination device context.
        /// </summary>
        /// <param name="hdc">Handle to the destination device context.</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the upper-left corner of the destination rectangle</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the upper-left corner of the destination rectangle</param>
        /// <param name="cx">Specifies the width, in logical units, of the source and destination rectangles</param>
        /// <param name="cy">Specifies the height, in logical units, of the source and the destination rectangles</param>
        /// <param name="hdcSrc">Handle to the source device context</param>
        /// <param name="x1">Specifies the x-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="y1">Specifies the y-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="rop">Specifies a raster-operation code. These codes define how the color data for the source rectangle 
        /// is to be combined with the color data for the destination rectangle to achieve the final color</param>
        /// <returns>If the function succeeds, the return value is true.
        /// If the function fails, the return value is false.</returns>
        public static bool BitBlt(IntPtr hdc, int x, int y, int cx, int cy, IntPtr hdcSrc, int x1, int y1,
                                  RasterOperation rop)
        {
            return Native.BitBlt(hdc, x, y, cx, cy, hdcSrc, x1, y1, rop);
        }

        /// <summary>
        /// The GdiAlphaBlend function displays bitmaps that have transparent or semitransparent pixels.
        /// </summary>
        /// <param name="hdcDest">Handle to the destination device context.</param>
        /// <param name="nXOriginDest">Specifies the x-coordinate, in logical units, 
        /// of the upper-left corner of the destination rectangle</param>
        /// <param name="nYOriginDest">Specifies the y-coordinate, in logical units, 
        /// of the upper-left corner of the destination rectangle</param>
        /// <param name="nWidthDest">Specifies the width, in logical units, of the destination rectangle</param>
        /// <param name="nHeightDest">Specifies the height, in logical units, of the destination rectangle</param>
        /// <param name="hdcSrc">Handle to the source device context</param>
        /// <param name="nXOriginSrc">Specifies the x-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="nYOriginSrc">Specifies the y-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="nWidthSrc">Specifies the width, in logical units, of the source rectangle</param>
        /// <param name="nHeightSrc">Specifies the height, in logical units, of the source rectangle</param>
        /// <param name="blendFunction">Specifies the alpha-blending function for source and destination bitmaps, a global alpha value to be 
        /// applied to the entire source bitmap, and format information for the source bitmap. The source and destination blend 
        /// functions are currently limited to AC_SRC_OVER.</param>
        /// <returns>If the function succeeds, the return value is true.
        /// If the function fails, the return value is false.</returns>
        public static bool GdiAlphaBlend(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest,
                                         int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc,
                                         int nHeightSrc, BlendFunction blendFunction)
        {
            return Native.GdiAlphaBlend(hdcDest, nXOriginDest, nYOriginDest, nWidthDest, nHeightDest, hdcSrc,
                                        nXOriginSrc, nYOriginSrc, nWidthSrc, nHeightSrc, blendFunction);
        }

        /// <summary>
        /// The TransparentBlt function performs a bit-block transfer of the color data corresponding to a rectangle
        /// of pixels from the specified source device context into a destination device context
        /// </summary>
        /// <param name="hdcDest">Handle to the destination device context</param>
        /// <param name="xoriginDest">Specifies the x-coordinate, in logical units, of the upper-left corner of the destination rectangle</param>
        /// <param name="yoriginDest">Specifies the y-coordinate, in logical units, of the upper-left corner of the destination rectangle</param>
        /// <param name="wDest">Specifies the width, in logical units, of the destination rectangle</param>
        /// <param name="hDest">Handle to the height, in logical units, of the destination rectangle</param>
        /// <param name="hdcSrc">Handle to the source device context</param>
        /// <param name="xoriginSrc">Specifies the x-coordinate, in logical units, of the source rectangle</param>
        /// <param name="yoriginSrc">Specifies the y-coordinate, in logical units, of the source rectangle</param>
        /// <param name="wSrc">Specifies the width, in logical units, of the source rectangle</param>
        /// <param name="hSrc">Specifies the height, in logical units, of the source rectangle</param>
        /// <param name="crTransparent">The RGB color in the source bitmap to treat as transparent</param>
        /// <returns>If the function succeeds, the return value is true, otherwise false</returns>
        public static bool TransparentBlt(IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest,
                                          IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc,
                                          Color crTransparent)
        {
            return Native.TransparentBlt(hdcDest, xoriginDest, yoriginDest, wDest, hDest, hdcSrc, xoriginSrc, yoriginSrc,
                                         wSrc, hSrc, RGB.ToWin32Color(crTransparent));
        }

        /// <summary>
        /// The GetColorAdjustment function retrieves the color adjustment
        /// values for the specified device context (DC)
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="lpca">Pointer to a COLORADJUSTMENT structure that receives the color adjustment values</param>
        /// <returns>If the function succeeds, the return true, otherwise false.</returns>
        public static bool GetColorAdjustment([In] IntPtr hdc, [Out] out ColorAdjustment lpca)
        {
            return Native.GetColorAdjustment(hdc, out lpca);
        }

        /// <summary>
        /// The GetStretchBltMode function retrieves the current stretching mode. The stretching mode defines how 
        /// color data is added to or removed from bitmaps that are stretched or compressed when the StretchBlt 
        /// function is called.
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <returns></returns>
        public static StretchingMode GetStretchBltMode(IntPtr hdc)
        {
            return Native.GetStretchBltMode(hdc);
        }

        /// <summary>
        /// The PatBlt function paints the specified rectangle using the brush that is currently 
        /// selected into the specified device context. The brush color and the surface color or 
        /// colors are combined by using the specified raster operation
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the upper-left corner of the rectangle to be filled</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the upper-left corner of the rectangle to be filled</param>
        /// <param name="w">Specifies the width, in logical units, of the rectangle</param>
        /// <param name="h">Specifies the height, in logical units, of the rectangle</param>
        /// <param name="rop">Specifies the raster operation code. This code can be one of the following values
        /// PATCOPY
        /// PATINVERT
        /// DSTINVERT
        /// BLACKNESS
        /// WHITENESS
        /// </param>
        /// <returns>If the function succeeds, the return value is true, otherwise false</returns>
        public static bool PatBlt(IntPtr hdc, int x, int y, int w, int h, RasterOperation rop)
        {
            return Native.PatBlt(hdc, x, y, w, h, rop);
        }

        /// <summary>
        /// The PlgBlt function performs a bit-block transfer of the bits of color data from the 
        /// specified rectangle in the source device context to the specified parallelogram in the
        /// destination device context. If the given bitmask handle identifies a valid monochrome 
        /// bitmap, the function uses this bitmap to mask the bits of color data from the source rectangle.
        /// </summary>
        /// <param name="hdcDest">Handle to the destination device context</param>
        /// <param name="lpPoint">Pointer to an array of three points in logical space that identify three 
        /// corners of the destination parallelogram. The upper-left corner of the source rectangle is mapped
        /// to the first point in this array, the upper-right corner to the second point in this array, 
        /// and the lower-left corner to the third point. The lower-right corner of the source rectangle 
        /// is mapped to the implicit fourth point in the parallelogram</param>
        /// <param name="hdcSrc">Handle to the source device context</param>
        /// <param name="xSrc">Specifies the x-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="ySrc">Specifies the y-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="width">Specifies the width, in logical units, of the source rectangle</param>
        /// <param name="height">Specifies the height, in logical units, of the source rectangle</param>
        /// <param name="hbmMask">Handle to an optional monochrome bitmap that is used to mask the colors of the source rectangle</param>
        /// <param name="xMask">Specifies the x-coordinate, in logical units, of the upper-left corner of the monochrome bitmap</param>
        /// <param name="yMask">Specifies the y-coordinate, in logical units, of the upper-left corner of the monochrome bitmap</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool PlgBlt(IntPtr hdcDest, Point[] lpPoint, IntPtr hdcSrc, int xSrc, int ySrc, int width,
                                  int height, IntPtr hbmMask, int xMask, int yMask)
        {
            return Native.PlgBlt(hdcDest, lpPoint, hdcSrc, xSrc, ySrc, width, height, hbmMask, xMask, yMask);
        }

        /// <summary>
        /// The SetColorAdjustment function sets the color adjustment values for a device context (DC) using the specified values
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="lpca">Pointer to a COLORADJUSTMENT structure containing the color adjustment values</param>
        /// <returns>If the function succeeds, the return value is nonzero, otherwise 0</returns>
        public static bool SetColorAdjustment(IntPtr hdc, ref ColorAdjustment lpca)
        {
            return Native.SetColorAdjustment(hdc, ref lpca);
        }

        /// <summary>
        /// The SetStretchBltMode function sets the bitmap stretching mode in the specified device context
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="mode">Specifies the stretching mode</param>
        /// <returns>If the function succeeds, the return value is the previous stretching mode</returns>
        public static StretchingMode SetStretchBltMode([In] IntPtr hdc, StretchingMode mode)
        {
            return Native.SetStretchBltMode(hdc, mode);
        }


        /// <summary>
        /// The StretchBlt function copies a bitmap from a source rectangle into a destination rectangle, stretching or
        /// compressing the bitmap to fit the dimensions of the destination rectangle, if necessary. The system stretches
        /// or compresses the bitmap according to the stretching mode currently set in the destination device context. 
        /// </summary>
        /// <param name="hdcDest">Handle to the destination device context</param>
        /// <param name="xDest">Specifies the x-coordinate, in logical units, of the upper-left corner of the destination rectangle</param>
        /// <param name="yDest">Specifies the y-coordinate, in logical units, of the upper-left corner of the destination rectangle</param>
        /// <param name="wDest">Specifies the width, in logical units, of the destination rectangle</param>
        /// <param name="hDest">Specifies the height, in logical units, of the destination rectangle</param>
        /// <param name="hdcSrc">Handle to the source device context</param>
        /// <param name="xSrc">Specifies the x-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="ySrc">Specifies the y-coordinate, in logical units, of the upper-left corner of the source rectangle</param>
        /// <param name="wSrc">Specifies the width, in logical units, of the source rectangle</param>
        /// <param name="hSrc">Specifies the height, in logical units, of the source rectangle</param>
        /// <param name="rop">Specifies the raster operation to be performed. Raster operation codes define how the system combines colors in 
        /// output operations that involve a brush, a source bitmap, and a destination bitmap</param>
        /// <returns>If the function succeeds, the return value is nonzero, otherwise zero</returns>
        public static bool StretchBlt([In] IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest,
                                      [In] IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, RasterOperation rop)
        {
            return Native.StretchBlt(hdcDest, xDest, yDest, wDest, hDest, hdcSrc, xSrc, ySrc, wSrc, hSrc, rop);
        }

        /// <summary>
        /// The MaskBlt function combines the color data for the source and 
        /// destination bitmaps using the specified mask and raster operation
        /// </summary>
        /// <param name="hdcDest">Handle to the destination device context</param>
        /// <param name="xDest">Specifies the x-coordinate, in logical units, of the 
        /// upper-left corner of the destination rectangle</param>
        /// <param name="yDest">Specifies the y-coordinate, in logical units, of the
        /// upper-left corner of the destination rectangle</param>
        /// <param name="width">Specifies the width, in logical units, of the 
        /// destination rectangle and source bitmap</param>
        /// <param name="height">Specifies the height, in logical units, of the destination rectangle and source bitmap</param>
        /// <param name="hdcSrc">Handle to the device context from which the bitmap is to be copied. It must be zero if the dwRop parameter 
        /// specifies a raster operation that does not include a source</param>
        /// <param name="xSrc">Specifies the x-coordinate, in logical units, of the upper-left corner of the source bitmap</param>
        /// <param name="ySrc">Specifies the y-coordinate, in logical units, of the upper-left corner of the source bitmap</param>
        /// <param name="hbmMask">Handle to the monochrome mask bitmap combined with the color bitmap in the source device context</param>
        /// <param name="xMask">Specifies the horizontal pixel offset for the mask bitmap specified by the hbmMask parameter</param>
        /// <param name="yMask">Specifies the vertical pixel offset for the mask bitmap specified by the hbmMask parameter</param>
        /// <param name="rop">Specifies both foreground and background ternary raster operation codes (ROPs) that the function uses to 
        /// control the combination of source and destination data. The background raster operation code is stored in the high-order byte
        /// of the high-order word of this value; the foreground raster operation code is stored in the low-order byte of the high-order word
        /// of this value; the low-order word of this value is ignored, and should be zero</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool MaskBlt([In] IntPtr hdcDest, int xDest, int yDest, int width, int height, [In] IntPtr hdcSrc,
                                   int xSrc, int ySrc, [In] IntPtr hbmMask, int xMask, int yMask, RasterOperation rop)
        {
            return Native.MaskBlt(hdcDest, xDest, yDest, width, height, hdcSrc, xSrc, ySrc, hbmMask, xMask, yMask, rop);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("msimg32.dll", EntryPoint = "AlphaBlend", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AlphaBlend([In] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest,
                                                 int hDest, [In] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc,
                                                 int hSrc, BlendFunction ftn);

            [DllImport("gdi32.dll", EntryPoint = "BitBlt", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool BitBlt([In] IntPtr hdc, int x, int y, int cx, int cy, [In] IntPtr hdcSrc, int x1,
                                             int y1, RasterOperation rop);

            [DllImport("gdi32.dll", EntryPoint = "GdiAlphaBlend", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GdiAlphaBlend(IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest,
                                                    int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc,
                                                    int nWidthSrc, int nHeightSrc, BlendFunction blendFunction);

            [DllImport("msimg32.dll", EntryPoint = "TransparentBlt", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool TransparentBlt([In] IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest,
                                                     int hDest, [In] IntPtr hdcSrc, int xoriginSrc, int yoriginSrc,
                                                     int wSrc, int hSrc, uint crTransparent);

            [DllImport("gdi32.dll", EntryPoint = "GetStretchBltMode", SetLastError = true)]
            public static extern StretchingMode GetStretchBltMode([In] IntPtr hdc);

            [DllImport("gdi32.dll", EntryPoint = "PatBlt", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PatBlt([In] IntPtr hdc, int x, int y, int w, int h, RasterOperation rop);

            [DllImport("gdi32.dll", EntryPoint = "PlgBlt", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PlgBlt([In] IntPtr hdcDest,
                                             [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct,
                                                 SizeConst = 3)] Point[] lpPoint, [In] IntPtr hdcSrc, int xSrc, int ySrc,
                                             int width, int height, [In] IntPtr hbmMask, int xMask, int yMask);

            [DllImport("gdi32.dll", EntryPoint = "SetColorAdjustment", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetColorAdjustment([In] IntPtr hdc, [In] ref ColorAdjustment lpca);

            [DllImport("gdi32.dll", EntryPoint = "SetStretchBltMode", SetLastError = true)]
            public static extern StretchingMode SetStretchBltMode([In] IntPtr hdc, StretchingMode mode);

            [DllImport("gdi32.dll", EntryPoint = "StretchBlt", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool StretchBlt([In] IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest,
                                                 [In] IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc,
                                                 RasterOperation rop);

            [DllImport("gdi32.dll", EntryPoint = "MaskBlt", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool MaskBlt([In] IntPtr hdcDest, int xDest, int yDest, int width, int height,
                                              [In] IntPtr hdcSrc, int xSrc, int ySrc, [In] IntPtr hbmMask, int xMask,
                                              int yMask, RasterOperation rop);

            [DllImport("gdi32.dll", EntryPoint = "GetColorAdjustment", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetColorAdjustment([In] IntPtr hdc, [Out] out ColorAdjustment lpca);
        }

        #endregion
    }
}