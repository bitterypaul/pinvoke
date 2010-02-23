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

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signature of handling capture
    /// </summary>
    public class Capture
    {
        /// <summary>
        /// The ReleaseCapture function releases the mouse capture from a window in the
        /// current thread and restores normal mouse input processing. A window that has
        /// captured the mouse receives all mouse input, regardless of the position of 
        /// the cursor, except when a mouse button is clicked while the cursor hot spot 
        /// is in the window of another thread.
        /// </summary>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool ReleaseCapture()
        {
            return Native.ReleaseCapture();
        }

        /// <summary>
        /// The SetCapture function sets the mouse capture to the specified window belonging 
        /// to the current thread. SetCapture captures mouse input either when the mouse is 
        /// over the capturing window, or when the mouse button was pressed while the mouse 
        /// was over the capturing window and the button is still down. Only one window at a 
        /// time can capture the mouse.
        /// If the mouse cursor is over a window created by another thread, the system will 
        /// direct mouse input to the specified window only if a mouse button is down.
        /// </summary>
        /// <param name="hWnd">Handle to the window in the current thread that is to capture the mouse</param>
        /// <returns>The return value is a handle to the window that had previously captured the mouse. 
        /// If there is no such window, the return value is null</returns>
        public static IntPtr SetCapture([In] IntPtr hWnd)
        {
            return Native.SetCapture(hWnd);
        }

        /// <summary>
        /// The JoyReleaseCapture function releases the specified captured joystick.
        /// </summary>
        /// <param name="uJoyID">Identifier of the joystick to be released</param>
        /// <returns>Returns JOYERR_NOERROR if successful else the one of the following for error
        /// JoyStatus.MMSYSERR_NODRIVER
        /// JoyStatus.MMSYSERR_INVALIDPARAM
        /// JoyStatus.JOYERR_PARMS
        /// </returns>
        public static uint JoyReleaseCapture(uint uJoyID)
        {
            return Native.joyReleaseCapture(uJoyID);
        }

        /// <summary>
        /// The JoySetCature function captures a joystick by causing its messages to be sent to the specified window
        /// </summary>
        /// <param name="hwnd">Handle to the window to receive the joystick messages</param>
        /// <param name="uJoyID">Identifier of the joystick to be captured. Valid values for uJoyID range from zero (JOYSTICKID1)
        /// to 15, except for Windows NT 4.0. For Windows NT 4.0, valid values are limited to JOYSTICKID1 and JOYSTICKID2</param>
        /// <param name="uPeriod">Polling frequency, in milliseconds</param>
        /// <param name="fChanged">Change position flag. Specify true for this parameter to send 
        /// messages only when the position changes by a value greater than the joystick movement
        /// threshold. Otherwise, messages are sent at the polling frequency specified in uPeriod.
        /// </param>
        /// <returns>Returns JoyStatus.JOYERR_NOERROR if successful else other members</returns>
        public static JoyStatus JoySetCapture(IntPtr hwnd, uint uJoyID, uint uPeriod, bool fChanged)
        {
            return Native.joySetCapture(hwnd, uJoyID, uPeriod, fChanged);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("user32.dll", EntryPoint = "ReleaseCapture", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ReleaseCapture();

            [DllImport("user32.dll", EntryPoint = "SetCapture", SetLastError = true)]
            public static extern IntPtr SetCapture([In] IntPtr hWnd);

            [DllImport("winmm.dll", EntryPoint = "joyReleaseCapture", SetLastError = true)]
            public static extern uint joyReleaseCapture(uint uJoyID);

            [DllImport("winmm.dll", EntryPoint = "joySetCapture", SetLastError = true)]
            public static extern JoyStatus joySetCapture(IntPtr hwnd, uint uJoyID, uint uPeriod,
                                                         [MarshalAs(UnmanagedType.Bool)] bool fChanged);
        }

        #endregion
    }
}