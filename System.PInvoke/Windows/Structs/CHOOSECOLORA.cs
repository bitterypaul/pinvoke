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
    /// The CHOOSECOLORA structure contains information the ChooseColor function uses
    /// to initialize the Color dialog box. After the user closes the dialog box, 
    /// the system returns information about the user's selection in this structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ChooseColorA
    {
        /// <summary>
        /// Specifies the length, in bytes, of the structure
        /// </summary>
        public uint lStructSize;

        /// <summary>
        /// Handle to the window that owns the dialog box. This member can be any valid
        /// window handle, or it can be null if the dialog box has no owner
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// If the ChooseColorInput.CC_ENABLETEMPLATEHANDLE flag is set in the Flags member,
        /// hInstance is a handle to a memory object containing a dialog box template.
        /// If the ChooseColorInput.CC_ENABLETEMPLATE flag is set, hInstance is a handle to a
        /// module that contains a dialog box template named by the lpTemplateName member. If
        /// neither ChooseColorInput.CC_ENABLETEMPLATEHANDLE nor ChooseColorInput.CC_ENABLETEMPLATE
        /// is set, this member is ignored. 
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// If the ChooseColorInput.CC_RGBINIT flag is set, rgbResult specifies the color initially
        /// selected when the dialog box is created. If the specified color value is not among the 
        /// available colors, the system selects the nearest solid color available. If rgbResult is 
        /// zero or ChooseColorInput.CC_RGBINIT is not set, the initially selected color is black. 
        /// If the user clicks the OK button, rgbResult specifies the user's color selection. 
        /// </summary>
        /// <remarks>Use RGB class to convert between a .Net Color and a Win32 color</remarks>
        public uint rgbResult;

        /// <summary>
        /// Pointer to an array of 16 values that contain red, green, blue (RGB) values for the custom
        /// color boxes in the dialog box. If the user modifies these colors, the system updates the array
        /// with the new RGB values. To preserve new custom colors between calls to the ChooseColor 
        /// function, you should allocate static memory for the array.
        /// </summary>
        /// <remarks>To create a color value use RGB class</remarks>
        public IntPtr lpCustColors;

        /// <summary>
        /// A set of bit flags that you can use to initialize the Color dialog box. When the dialog box
        /// returns, it sets these flags to indicate the user's input. This member can be a combination of
        /// the flags of ChooseColorInput enum.
        /// </summary>
        public ChooseColorInput Flags;

        /// <summary>
        /// Specifies application-defined data that the system passes to the hook procedure identified by
        /// the lpfnHook member. When the system sends the WindowsMessage.WM_INITDIALOG message to the hook procedure,
        /// the message's lParam parameter is a pointer to the CHOOSECOLOR structure specified when the
        /// dialog was created. The hook procedure can use this pointer to get the lCustData value.
        /// </summary>
        public int lCustData;

        /// <summary>
        /// Delegate to a hook procedure that can process messages intended for the dialog box. 
        /// This member is ignored unless the ChooseColorInput.CC_ENABLEHOOK flag is set in the Flags member. 
        /// </summary>
        public LpCCHookProc lpfnHook;

        /// <summary>
        /// Pointer to a null-terminated string that names the dialog box template resource in the module 
        /// identified by the hInstance member. This template is substituted for the standard dialog box 
        /// template. This member is ignored unless the ChooseColorInput.CC_ENABLETEMPLATE 
        /// flag is set in the Flags member. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpTemplateName;
    }
}