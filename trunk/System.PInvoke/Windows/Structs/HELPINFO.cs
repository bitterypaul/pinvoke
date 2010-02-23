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
    /// Contains information about an item for which context-sensitive Help has been requested. 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct HelpInfo
    {
        /// <summary>
        /// The structure size, in bytes.
        /// </summary>
        public uint cbSize;

        /// <summary>
        /// The type of context for which Help is requested. This member can be one of the member
        /// of HelpContext
        /// </summary>
        public HelpContext iContextType;

        /// <summary>
        /// The identifier of the window or control if iContextType is HELPINFO_WINDOW, or identifier
        /// of the menu item if iContextType is HELPINFO_MENUITEM
        /// </summary>
        public int iCtrlId;

        /// <summary>
        /// The identifier of the child window or control if iContextType is HELPINFO_WINDOW, or 
        /// identifier of the associated menu if iContextType is HELPINFO_MENUITEM
        /// </summary>
        public IntPtr hItemHandle;

        /// <summary>
        /// The help context identifier of the window or control. 
        /// </summary>
        public uint dwContextId;

        /// <summary>
        /// The POINT structure that contains the screen coordinates of the mouse cursor. This is
        /// useful for providing Help based on the position of the mouse cursor
        /// </summary>
        public Point MousePos;
    }
}