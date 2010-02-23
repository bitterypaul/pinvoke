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

namespace System.PInvoke.Windows
{
    public class Caret
    {
        /// <summary>
        /// Indiactes Caret does not blink.
        /// </summary>
        public const int INFINITE = -1;

        /// <summary>
        /// The CreateCaret function creates a new shape for the system caret and 
        /// assigns ownership of the caret to the specified window. The caret shape 
        /// can be a line, a block, or a bitmap
        /// </summary>
        /// <param name="hWnd">Handle to the window that owns the caret</param>
        /// <param name="hBitmap">Handle to the bitmap that defines the caret shape. 
        /// If this parameter is null, the caret is solid. If this parameter is (HBITMAP) 1, 
        /// the caret is gray. If this parameter is a bitmap handle, the caret is the specified
        /// bitmap. The bitmap handle must have been created by the CreateBitmap, CreateDIBitmap,
        /// or LoadBitmap function.
        /// If hBitmap is a bitmap handle, CreateCaret ignores the nWidth and nHeight parameters; 
        /// the bitmap defines its own width and height.
        /// </param>
        /// <param name="nWidth">Specifies the width of the caret in logical units. If this parameter
        /// is zero, the width is set to the system-defined window border width. If hBitmap is a bitmap
        /// handle, CreateCaret ignores this parameter.
        /// </param>
        /// <param name="nHeight">Specifies the height, in logical units, of the caret. If this parameter
        /// is zero, the height is set to the system-defined window border height. If hBitmap is a bitmap
        /// handle, CreateCaret ignores this parameter</param>
        /// <returns>If the function succeeds, the return value is true, otherwise false</returns>
        public static bool CreateCaret([In] IntPtr hWnd, [In] IntPtr hBitmap, int nWidth, int nHeight)
        {
            return Native.CreateCaret(hWnd, hBitmap, nWidth, nHeight);
        }

        /// <summary>
        /// The DestroyCaret function destroys the caret's current shape, 
        /// frees the caret from the window, and removes the caret from the screen
        /// </summary>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool DestroyCaret()
        {
            return Native.DestroyCaret();
        }

        /// <summary>
        /// The GetCaretBlinkTime function returns the time required to invert the caret's pixels.
        /// The user can set this value. 
        /// </summary>
        /// <returns>If the function succeeds, the return value is the blink time, in milliseconds
        /// A return value of INFINITE indicates that the caret does not blink
        /// A return value is zero indicates that the function has failed.</returns>
        public static int GetCaretBlinkTime()
        {
            return Native.GetCaretBlinkTime();
        }

        /// <summary>
        /// The HideCaret function removes the caret from the screen. Hiding a caret does not destroy
        /// its current shape or invalidate the insertion point
        /// </summary>
        /// <param name="hWnd">Handle to the window that owns the caret. If this parameter is null, 
        /// HideCaret searches the current task for the window that owns the caret</param>
        /// <returns>If the function succeeds, the return value true, else false</returns>
        /// <remarks>HideCaret hides the caret only if the specified window owns the caret. 
        /// If the specified window does not own the caret, HideCaret does nothing and returns false. 
        /// </remarks>
        public static bool HideCaret([In] IntPtr hWnd)
        {
            return Native.HideCaret(hWnd);
        }

        /// <summary>
        /// The SetCaretBlinkTime function sets the caret blink time to the specified number of 
        /// milliseconds. The blink time is the elapsed time, in milliseconds, required to invert 
        /// the caret's pixels
        /// </summary>
        /// <param name="uMSeconds">Specifies the new blink time, in milliseconds</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool SetCaretBlinkTime(uint uMSeconds)
        {
            return Native.SetCaretBlinkTime(uMSeconds);
        }

        /// <summary>
        /// The ShowCaret function makes the caret visible on the screen at the caret's current position. 
        /// When the caret becomes visible, it begins flashing automatically
        /// </summary>
        /// <param name="hWnd">Handle to the window that owns the caret. If this parameter is null, 
        /// ShowCaret searches the current task for the window that owns the caret</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool ShowCaret([In] IntPtr hWnd)
        {
            return Native.ShowCaret(hWnd);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("user32.dll", EntryPoint = "CreateCaret", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool CreateCaret([In] IntPtr hWnd, [In] IntPtr hBitmap, int nWidth, int nHeight);

            [DllImport("user32.dll", EntryPoint = "DestroyCaret", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool DestroyCaret();

            [DllImport("user32.dll", EntryPoint = "GetCaretBlinkTime", SetLastError = true)]
            public static extern int GetCaretBlinkTime();

            [DllImport("user32.dll", EntryPoint = "HideCaret", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool HideCaret([In] IntPtr hWnd);

            [DllImport("user32.dll", EntryPoint = "SetCaretBlinkTime", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SetCaretBlinkTime(uint uMSeconds);

            [DllImport("user32.dll", EntryPoint = "ShowCaret", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ShowCaret([In] IntPtr hWnd);
        }

        #endregion
    }
}