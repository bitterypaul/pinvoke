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
    /// The CHOOSEFONTA structure contains information that the ChooseFont 
    /// function uses to initialize the Font dialog box. After the user closes
    /// the dialog box, the system returns information about the user's selection
    /// in this structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ChooseFontA
    {
        /// <summary>
        /// Specifies the length, in bytes, of the structure. 
        /// </summary>
        public uint lStructSize;

        /// <summary>
        /// Handle to the window that owns the dialog box. This member can be any 
        /// valid window handle, or it can be null if the dialog box has no owner.
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// Handle to the device context (or information context) of the printer 
        /// whose fonts will be listed in the dialog box. This member is used only
        /// if the Flags member specifies the CF_PRINTERFONTS or CF_BOTH flag; 
        /// otherwise, this member is ignored. 
        /// </summary>
        public IntPtr hDC;

        /// <summary>
        /// Pointer to a structure. If you set the CF_INITTOLOGFONTSTRUCT flag in 
        /// the Flags member and initialize the LOGFONT members, the ChooseFont 
        /// function initializes the dialog box with a font that is the closest 
        /// possible match. If the user clicks the OK button, ChooseFont sets the 
        /// members of the LOGFONT structure based on the user's selections. 
        /// </summary>
        public IntPtr lpLogFont;

        /// <summary>
        /// Specifies the size of the selected font, in units of 1/10 of a point.
        /// The ChooseFont function sets this value after the user closes the dialog box. 
        /// </summary>
        public int iPointSize;

        /// <summary>
        /// A set of bit flags that you can use to initialize the Font dialog box. 
        /// When the dialog box returns, it sets these flags to indicate the user's input. 
        /// </summary>
        public ChooseFontOption Flags;

        /// <summary>
        /// If the CF_EFFECTS flag is set, rgbColors specifies the initial text color. 
        /// When ChooseFont returns successfully, this member contains the RGB value of 
        /// the text color the user selected. To create a Win32 color value, use the 
        /// RGB class.
        /// </summary>
        public uint rgbColors;

        /// <summary>
        /// Specifies application-defined data that the system passes to the hook procedure
        /// identified by the lpfnHook member. When the system sends the WM_INITDIALOG message
        /// to the hook procedure, the message's lParam parameter is a pointer to the CHOOSEFONT
        /// structure specified when the dialog was created. The hook procedure can use this 
        /// pointer to get the lCustData value. 
        /// </summary>
        public int lCustData;

        /// <summary>
        /// Pointer to a CFHookProc hook procedure that can process messages intended for the 
        /// dialog box. This member is ignored unless the CF_ENABLEHOOK flag is set in the Flags member. 
        /// </summary>
        public LpCFHookProc lpfnHook;

        /// <summary>
        /// Pointer to a null-terminated string that names the dialog box template resource in the module
        /// identified by the hInstance member. This template is substituted for the standard dialog box
        /// template. For numbered dialog box resources, lpTemplateName can be a value returned by the 
        /// MAKEINTRESOURCE macro. This member is ignored unless the CF_ENABLETEMPLATE flag is set in the
        /// Flags member. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpTemplateName;

        /// <summary>
        /// If the CF_ENABLETEMPLATEHANDLE flag is set in the Flags member, hInstance is a handle to a memory
        /// object containing a dialog box template. If the CF_ENABLETEMPLATE flag is set, hInstance is a handle
        /// to a module that contains a dialog box template named by the lpTemplateName member. If neither 
        /// CF_ENABLETEMPLATEHANDLE nor CF_ENABLETEMPLATE is set, this member is ignored. 
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// Pointer to a buffer that contains style data. If the CF_USESTYLE flag is specified, ChooseFont uses
        /// the data in this buffer to initialize the font style combo box. When the user closes the dialog box,
        /// ChooseFont copies the string in the font style combo box into this buffer. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpszStyle;

        /// <summary>
        /// Specifies the type of the selected font when ChooseFont returns.
        /// </summary>
        public FontType nFontType;

        /// <summary>
        /// For Alignment purpose only
        /// </summary>
        public ushort ___MISSING_ALIGNMENT__;

        /// <summary>
        /// Specifies the minimum point size a user can select. ChooseFont recognizes this member only if the
        /// CF_LIMITSIZE flag is specified. 
        /// </summary>
        public int nSizeMin;

        /// <summary>
        /// Specifies the maximum point size a user can select. ChooseFont recognizes this member
        /// only if the CF_LIMITSIZE flag is specified. 
        /// </summary>
        public int nSizeMax;
    }
}