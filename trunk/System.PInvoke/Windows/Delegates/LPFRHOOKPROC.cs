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

namespace System.PInvoke.Windows.Delegates
{
    /// <summary>
    /// The LPFRHOOKPROC type defines a pointer to an application-defined or library-defined callback 
    /// function that is used with the FindText or ReplaceText function. The hook procedure receives 
    /// messages or notifications intended for the default dialog box procedure of the Find or Replace
    /// dialog box
    /// </summary>
    /// <param name="hdlg">Handle to the Find or Replace dialog box for which the message is intended</param>
    /// <param name="uiMsg">Identifies the message being received</param>
    /// <param name="wParam">Specifies additional information about the message. The exact meaning depends on the 
    /// value of the uiMsg parameter</param>
    /// <param name="lParam">Specifies additional information about the message. The exact meaning depends on the 
    /// value of the uiMsg parameter. 
    /// If the uiMsg parameter indicates the WM_INITDIALOG message, lParam is a pointer to a FINDREPLACE structure
    /// containing the values specified when the dialog box was created
    /// </param>
    /// <returns>If the hook procedure returns zero, the default dialog box procedure processes the message. 
    /// If the hook procedure returns a nonzero value, the default dialog box procedure ignores the message
    /// </returns>
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LpFRHookProc(IntPtr hdlg, uint uiMsg, IntPtr wParam, IntPtr lParam);
}