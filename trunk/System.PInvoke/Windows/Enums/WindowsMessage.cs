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
    /// Windows message
    /// </summary>
    [Flags]
    public enum WindowsMessage : uint
    {
        /// <summary>
        /// The WM_USER constant is used by applications to help define private 
        /// messages for use by private window classes, usually of the form WM_USER+X, 
        /// where X is an integer value.
        /// </summary>
        WM_USER = 0x400,

        /// <summary>
        /// This message enables or disables the OK command button in the dialog box. 
        /// </summary>
        BFFM_ENABLEOK = WM_USER + 101,

        /// <summary>
        /// This notification is sent after the dialog box is initialized.
        /// </summary>
        BFFM_INITIALIZED = 1,

        /// <summary>
        /// This notification is sent after the selection in the dialog box is changed.
        /// </summary>
        BFFM_SELCHANGED = 2,

        /// <summary>
        /// This message selects an item in the dialog box. (ANSI)
        /// </summary>
        BFFM_SETSELECTIONA = WM_USER + 102,

        /// <summary>
        /// This message selects an item in the dialog box. (UNICODE)
        /// </summary>
        BFFM_SETSELECTIONW = WM_USER + 103,

        /// <summary>
        /// Reserved.
        /// </summary>
        DSBM_CHANGEIMAGESTATE = 0x0066,

        /// <summary>
        /// This notification is sent when the dialog box receives a WM_CONTEXTMENU message.
        /// </summary>
        DSBM_CONTEXTMENU = 0x0068,

        /// <summary>
        /// This notification is sent when the dialog box receives a WM_HELP message.
        /// </summary>
        DSBM_HELP = 0x0067,

        /// <summary>
        /// This notification is sent prior to each container object being inserted into the tree. 
        /// The application can use this notification to modify the contents of the dialog box. (ANSI)
        /// </summary>
        DSBM_QUERYINSERTA = 0x0065,

        /// <summary>
        /// This notification is sent prior to each container object being inserted into the tree. 
        /// The application can use this notification to modify the contents of the dialog box. (UNICODE)
        /// </summary>
        DSBM_QUERYINSERTW = 0x0064,


        WM_RENDERFORMAT = 773,
        WM_RENDERALLFORMATS = 774,
        WM_ASKCBFORMATNAME = 780,
        WM_HSCROLLCLIPBOARD = 782,
        WM_PAINTCLIPBOARD = 777,
        WM_SIZECLIPBOARD = 779,
        WM_VSCROLLCLIPBOARD = 778,
        WM_DESTROYCLIPBOARD = 775,
        WM_DRAWCLIPBOARD = 776,
        WM_CHANGECBCHAIN = 781,
        WM_INITDIALOG = 272,
        WM_CTLCOLORDLG = 310,
        WM_CTLCOLORBTN = 309,
        WM_CTLCOLOREDIT = 307,
        WM_CTLCOLORMSGBOX = 306,
        WM_CTLCOLORSTATIC = 312,
        WM_CTLCOLORLISTBOX = 308,
        WM_CTLCOLORSCROLLBAR = 311,
        WM_COMMAND = 273,


        CDN_FIRST = unchecked(0u - 601u),
        CDN_LAST = unchecked(0u - 699u),
        CDN_HELP = CDN_FIRST - 4,
        CDN_FILEOK = CDN_FIRST - 5,
        CDN_INITDONE = CDN_FIRST - 0,
        CDN_SELCHANGE = CDN_FIRST - 1,
        CDN_TYPECHANGE = CDN_FIRST - 6,
        CDN_INCLUDEITEM = CDN_FIRST - 7,
        CDN_FOLDERCHANGE = CDN_FIRST - 2,
        CDN_SHAREVIOLATION = CDN_FIRST - 3
    }
}