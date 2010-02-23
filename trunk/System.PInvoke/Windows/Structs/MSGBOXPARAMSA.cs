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
using System.PInvoke.Windows.Delegates;
using System.PInvoke.Windows.Enums;
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The MSGBOXPARAMSA structure contains information used to display a message box.
    /// The MessageBoxIndirect function uses this structure
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MsgBoxParamsA
    {
        /// <summary>
        /// Specifies the structure size, in bytes. 
        /// </summary>        
        public uint cbSize;

        /// <summary>
        /// Handle to the owner window. This member can be null.
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// Handle to the module that contains the icon resource identified by the lpszIcon member,
        /// and the string resource identified by the lpszText or lpszCaption member
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// Pointer to a null-terminated string, or the identifier of a string resource,
        /// that contains the message to be displayed. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpszText;

        /// <summary>
        /// Pointer to a null-terminated string, or the identifier of a string resource, that contains
        /// the message box title. If this member is null, the default title Error is used.
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpszCaption;

        /// <summary>
        /// Specifies the contents and behavior of the dialog box. This member can
        /// be a combination of flags described in MessageBoxStyle 
        /// </summary>
        public MessageBoxStyle dwStyle;

        /// <summary>
        /// Identifies an icon resource
        /// </summary>
        /// <remarks>To load one of the standard system-defined icons, set the hInstance member to null
        /// and set lpszIcon to one of the values listed with the LoadIcon function. 
        /// This member is ignored if the dwStyle member does not specify the MB_USERICON flag. 
        /// </remarks>
        [MarshalAs(UnmanagedType.LPStr)] public string lpszIcon;

        /// <summary>
        /// Identifies a help context. If a help event occurs, this value is specified in the HELPINFO
        /// structure that the message box sends to the owner window or callback function
        /// </summary>
        public uint dwContextHelpId;

        /// <summary>
        /// Pointer to the callback function that processes help events for the message box.
        /// If this member is null, the message box sends WindowsMessage.WM_HELP messages to
        /// the owner window when help events occur
        /// </summary>
        public MsgBoxCallBack lpfnMsgBoxCallback;

        /// <summary>
        /// Specifies the language in which to display the text contained in the predefined push buttons.
        /// This value must be in the form returned by the MAKELANGID macro. 
        /// </summary>
        public uint dwLanguageId;
    }
}