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
    /// The LPCCHOOKPROC type defines a pointer to an application-defined 
    /// or library-defined callback function that is used with the ChooseColor function.
    /// The hook procedure receives messages or notifications intended for the default 
    /// dialog box procedure of the Color dialog box. 
    /// </summary>
    /// <param name="hdlg">Handle to the Color dialog box for which the message is intended</param>
    /// <param name="uiMsg">Identifies the message being received</param>
    /// <param name="wParam">Specifies additional information about the message. The exact meaning 
    /// depends on the value of the uiMsg parameter</param>
    /// <param name="lParam">Specifies additional information about the message. The exact meaning
    /// depends on the value of the uiMsg parameter. If the uiMsg parameter indicates the WindowsMessage.WM_INITDIALOG
    /// message, lParam is a pointer to a CHOOSECOLOR structure containing the values specified when the dialog
    /// was created. 
    /// </param>
    /// <returns>If the hook procedure returns zero, the default dialog box procedure processes the message.
    /// If the hook procedure returns a nonzero value, the default dialog box procedure ignores the message
    /// </returns>
    /// <remarks>
    /// When you use the ChooseColor function to create a Color dialog box, you can provide a CCHookProc hook
    /// procedure to process messages or notifications intended for the dialog box procedure. To enable the 
    /// hook procedure, use the CHOOSECOLOR structure that you passed to the dialog creation function. 
    /// Specify the address of the hook procedure in the lpfnHook member and specify the CC_ENABLEHOOK flag in
    /// the Flags member.
    /// The default dialog box procedure processes the WindowsMessage.WM_INITDIALOG message before passing it to the hook 
    /// procedure. For all other messages, the hook procedure receives the message first. Then, the return 
    /// value of the hook procedure determines whether the default dialog procedure processes the message or
    /// ignores it.
    /// If the hook procedure processes the WindowsMessage.WM_CTLCOLORDLG message, it must return a valid brush handle to 
    /// painting the background of the dialog box. In general, if the hook procedure processes any WindowsMessage.WM_CTLCOLOR*
    /// message, it must return a valid brush handle to painting the background of the specified control.
    /// Do not call the EndDialog function from the hook procedure. Instead, the hook procedure can call the 
    /// PostMessage function to post a WindowsMessage.WM_COMMAND message with the DialogBoxResult.IDABORT value to the dialog box procedure. 
    /// Posting DialogBoxResult.IDABORT closes the dialog box and causes the dialog box function to return false. If you need 
    /// to know why the hook procedure closed the dialog box, you must provide your own communication mechanism
    /// between the hook procedure and your application.
    /// You can subclass the standard controls of a common dialog box. However, the dialog box procedure may 
    /// also subclass the controls. Because of this, you should subclass controls when your hook procedure 
    /// processes the WindowsMessage.WM_INITDIALOG message. This ensures that your subclass procedure receives the control-specific
    /// messages before the subclass procedure set by the dialog box procedure. 
    /// </remarks>
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LpCCHookProc(IntPtr hdlg, uint uiMsg, IntPtr wParam, IntPtr lParam);
}