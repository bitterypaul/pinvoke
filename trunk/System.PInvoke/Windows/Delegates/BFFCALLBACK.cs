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

namespace System.PInvoke.Windows.Delegates
{
    /// <summary>
    /// The BFFCallBack function is an application-defined callback function that receives event
    /// notifications from the Active Directory Domain Services container browser dialog box. 
    /// A pointer to this function is supplied to the container browser dialog box in the pfnCallback 
    /// member of the DSBROWSEINFO structure when the DsBrowseForContainer function is called. 
    /// BFFCallBack is a placeholder for the application-defined function name.
    /// </summary>
    /// <param name="hwnd">Contains the window handle of the browse dialog box. This handle is used to 
    /// send messages to the browse dialog box using the SendMessage function.</param>
    /// <param name="uMsg">Specifies one of the following browse messages.
    /// WindowsMessage.BFFM_INITIALIZED
    /// WindowsMessage.BFFM_SELCHANGED
    /// WindowsMessage.DSBM_CHANGEIMAGESTATE
    /// WindowsMessage.DSBM_CONTEXTMENU
    /// WindowsMessage.DSBM_HELP
    /// WindowsMessage.DSBM_QUERYINSERT
    /// </param>
    /// <param name="lParam">The value and meaning of this parameter is determined by the notification received.
    /// For more information, see the notification message descriptions under the uMsg parameter.</param>
    /// <param name="lpData">Contains a pointer to the DSBROWSEINFO structure passed to the DsBrowseForContainer 
    /// function. This is true for all notification messages.</param>
    /// <returns>The meaning of the return value is determined by the notification received.
    /// WindowsMessage.BFFM_INITIALIZED        : The return value from this notification is ignored
    /// WindowsMessage.BFFM_SELCHANGED         : The return value from this notification is ignored.
    /// WindowsMessage.DSBM_CHANGEIMAGESTATE   : 
    /// WindowsMessage.DSBM_CONTEXTMENU        : The return value from this notification is ignored
    /// WindowsMessage.DSBM_HELP               : The return value from this notification is ignored
    /// WindowsMessage.DSBM_QUERYINSERT        : Return a non-zero value from this notification if data in the DSBITEM structure changes. Return zero if the time should be inserted unchanged
    /// </returns>
    public delegate int BFFCallBack(IntPtr hwnd, WindowsMessage uMsg, IntPtr lParam, IntPtr lpData);
}