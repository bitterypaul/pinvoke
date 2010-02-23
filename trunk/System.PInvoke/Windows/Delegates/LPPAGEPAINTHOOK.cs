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
    /// The LPPAGEPAINTHOOK type defines a pointer to an application-defined or library-defined
    /// callback function used with the PageSetupDlg function. This function receives messages
    /// that allow you to customize drawing of the sample page in the Page Setup dialog box.
    /// </summary>
    /// <param name="hdlg">Handle to the Page Setup dialog box.</param>
    /// <param name="uiMsg">Identifies the message being received.</param>
    /// <param name="wParam">Specifies additional information about the message. The exact meaning
    /// depends on the value of the uiMsg parameter</param>
    /// <param name="lParam">Specifies additional information about the message. The exact meaning
    /// depends on the value of the uiMsg parameter</param>
    /// <returns>If the hook procedure returns true for any of the first three messages of a drawing
    /// sequence (WM_PSD_PAGESETUPDLG, WM_PSD_FULLPAGERECT, or WM_PSD_MINMARGINRECT), the dialog box
    /// sends no more messages and does not draw in the sample page until the next time the system 
    /// needs to redraw the sample page. If the hook procedure returns false for all three messages,
    /// the dialog box sends the remaining messages of the drawing sequence.</returns>
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LpPagePaintHook(IntPtr hdlg, uint uiMsg, IntPtr wParam, IntPtr lParam);
}