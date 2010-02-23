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

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signature of handling Brush
    /// </summary>
    public class Brush
    {
        private const int ClrInvalid = -1;

        /// <summary>
        /// The CreateBrushIndirect function creates a logical brush that has the specified style, color, and pattern
        /// </summary>
        /// <param name="plbrush">Pointer to a LOGBRUSH structure that contains information about the brush</param>
        /// <returns>If the function succeeds, the return value identifies a logical brush, else null</returns>
        /// <remarks>After an application creates a brush by calling CreateBrushIndirect, it can select it into any device context by calling the SelectObject function. 
        /// </remarks>
        public static IntPtr CreateBrushIndirect([In] ref LogBrush plbrush)
        {
            return Native.CreateBrushIndirect(ref plbrush);
        }

        /// <summary>
        /// The CreateDIBPatternBrushPt function creates a logical brush that has the pattern specified by the device-independent bitmap (DIB).
        /// </summary>
        /// <param name="lpPackedDIB">Pointer to a packed DIB consisting of a BITMAPINFO structure immediately followed by an array of bytes defining the pixels of the bitmap</param>
        /// <param name="iUsage">Specifies whether the bmiColors member of the BITMAPINFO structure contains a valid color table and, if so, whether the entries in this color 
        /// table contain explicit red, green, blue (RGB) values or palette indexes</param>
        /// <returns>If the function succeeds, the return value identifies a logical brush, else false</returns>
        public static IntPtr CreateDIBPatternBrushPt([In] IntPtr lpPackedDIB, DIBColorTable iUsage)
        {
            return Native.CreateDIBPatternBrushPt(lpPackedDIB, iUsage);
        }

        /// <summary>
        /// The CreateHatchBrush function creates a logical brush that has the specified hatch pattern and color. 
        /// </summary>
        /// <param name="iHatch">Specifies the hatch style of the brush</param>
        /// <param name="color">Specifies the foreground color of the brush that is used for the hatches</param>
        /// <returns></returns>
        public static IntPtr CreateHatchBrush(HatchStyle iHatch, Color color)
        {
            return Native.CreateHatchBrush(iHatch, RGB.ToWin32Color(color));
        }

        /// <summary>
        /// The CreateSolidBrush function creates a logical brush that has the specified solid color
        /// </summary>
        /// <param name="color">Specifies the color of the brush</param>
        /// <returns>If the function succeeds, the return value identifies a logical brush, else null</returns>
        public static IntPtr CreateSolidBrush(Color color)
        {
            return Native.CreateSolidBrush(RGB.ToWin32Color(color));
        }

        /// <summary>
        /// The GetSysColorBrush function retrieves a handle identifying a logical brush that corresponds to the specified color index
        /// </summary>
        /// <param name="nIndex">Specifies a color index. This value corresponds to the color used to paint one of the window elements</param>
        /// <returns>The return value identifies a logical brush if the nIndex parameter is supported by the current platform. Otherwise, it returns null</returns>
        public static IntPtr GetSysColorBrush(int nIndex)
        {
            return Native.GetSysColorBrush(nIndex);
        }

        /// <summary>
        /// The SetBrushOrgEx function sets the brush origin that GDI assigns to the next brush an application selects into the specified device context
        /// </summary>
        /// <param name="hdc">Handle to the device context.</param>
        /// <param name="x">Specifies the x-coordinate, in device units, of the new brush origin. If this value is greater than the brush width, 
        /// its value is reduced using the modulus operator (x mod brush width). </param>
        /// <param name="y">Specifies the y-coordinate, in device units, of the new brush origin. If this value is greater than the brush height,
        /// its value is reduced using the modulus operator (y mod brush height). </param>
        /// <param name="lppt">Pointer to a POINT structure that receives the previous brush origin. 
        /// This parameter can be null if the previous brush origin is not required</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool SetBrushOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt)
        {
            return Native.SetBrushOrgEx(hdc, x, y, lppt);
        }

        /// <summary>
        /// SetDCBrushColor function sets the current device context (DC) brush color to the specified color value. If the device cannot 
        /// represent the specified color value, the color is set to the nearest physical color
        /// </summary>
        /// <param name="hdc">Handle to the DC</param>
        /// <param name="color">Specifies the new brush color</param>
        /// <returns>If the function succeeds, the return value specifies the previous DC brush color as a Color value.
        /// If the function fails, the return value is Color.Empty (null color)</returns>
        public static Color SetDCBrushColor([In] IntPtr hdc, Color color)
        {
            long result = Native.SetDCBrushColor(hdc, RGB.ToWin32Color(color));
            return result == ClrInvalid ? Color.Empty : RGB.FromWin32Color((uint) result);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("gdi32.dll", EntryPoint = "CreateBrushIndirect", SetLastError = true)]
            public static extern IntPtr CreateBrushIndirect([In] ref LogBrush plbrush);

            [DllImport("gdi32.dll", EntryPoint = "CreateDIBPatternBrushPt", SetLastError = true)]
            public static extern IntPtr CreateDIBPatternBrushPt([In] IntPtr lpPackedDIB, DIBColorTable iUsage);

            [DllImport("gdi32.dll", EntryPoint = "CreateHatchBrush", SetLastError = true)]
            public static extern IntPtr CreateHatchBrush(HatchStyle iHatch, uint color);

            [DllImport("gdi32.dll", EntryPoint = "CreateSolidBrush", SetLastError = true)]
            public static extern IntPtr CreateSolidBrush(uint color);

            [DllImport("user32.dll", EntryPoint = "GetSysColorBrush", SetLastError = true)]
            public static extern IntPtr GetSysColorBrush(int nIndex);

            [DllImport("gdi32.dll", EntryPoint = "SetBrushOrgEx", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetBrushOrgEx([In] IntPtr hdc, int x, int y, IntPtr lppt);

            [DllImport("gdi32.dll", EntryPoint = "SetDCBrushColor", SetLastError = true)]
            public static extern uint SetDCBrushColor([In] IntPtr hdc, uint color);
        }

        #endregion
    }
}