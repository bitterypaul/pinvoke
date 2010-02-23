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
namespace System.PInvoke.Windows.Enums
{
    /// <summary>
    /// These are possible return values for joySetCapture functions
    /// </summary>
    [Flags]
    public enum JoyStatus : uint
    {
        /// <summary>
        /// Base value
        /// </summary>
        MMSYSERR_BASE = 0,
        /// <summary>
        /// The joystick driver is not present.
        /// </summary>
        MMSYSERR_NODRIVER = MMSYSERR_BASE + 6,
        /// <summary>
        /// Windows 95/98/Me: Invalid joystick ID or hwnd is null
        /// </summary>
        MMSYSERR_INVALPARAM = MMSYSERR_BASE + 11,
        /// <summary>
        /// Base value
        /// </summary>
        JOYERR_BASE = 160,
        /// <summary>
        /// Cannot capture joystick input because a required service
        /// (such as a Windows timer) is unavailable
        /// </summary>
        JOYERR_NOCANDO = JOYERR_BASE + 6,
        /// <summary>
        /// The specified joystick is not connected to the system
        /// </summary>
        JOYERR_UNPLUGGED = JOYERR_BASE + 7,
        /// <summary>
        /// Windows NT/2000/XP: Invalid joystick ID or hwnd is null
        /// </summary>
        JOYERR_PARMS = JOYERR_BASE + 5,
        /// <summary>
        /// Set capture success
        /// </summary>
        JOYERR_NOERROR = 0
    }
}