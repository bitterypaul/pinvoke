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
    /// The FINDREPLACEA structure contains information that the FindText and ReplaceText functions 
    /// use to initialize the Find and Replace dialog boxes. The FINDMSGSTRING registered message 
    /// uses this structure to pass the user's search or replacement input to the owner window of a 
    /// Find or Replace dialog box
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct FindReplaceA
    {
        /// <summary>
        /// Specifies the length, in bytes, of the structure
        /// </summary>
        public uint lStructSize;

        /// <summary>
        /// Handle to the window that owns the dialog box. The window procedure of the specified window
        /// receives FINDMSGSTRING messages from the dialog box. This member can be any valid window handle,
        /// but it must not be null
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// If the FR_ENABLETEMPLATEHANDLE flag is set in the Flags, hInstance is a handle to a memory object
        /// containing a dialog box template. If the FR_ENABLETEMPLATE flag is set, hInstance is a handle to
        /// a module that contains a dialog box template named by the lpTemplateName member. If neither flag 
        /// is set, this member is ignored
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// A set of bit flags that you can use to initialize the dialog box. The dialog box sets these flags
        /// when it sends the FINDMSGSTRING registered message to indicate the user's input.
        /// </summary>
        public FindReplaceFlag Flags;

        /// <summary>
        /// Pointer to a buffer that a FINDMSGSTRING message uses to pass the null terminated search string that
        /// the user typed in the Find What edit control. You must dynamically allocate the buffer or use a global
        /// or static array so it does not go out of scope before the dialog box closes. The buffer should be at
        /// least 80 characters long. If the buffer contains a string when you initialize the dialog box, the 
        /// string is displayed in the Find What edit control. If a FINDMSGSTRING message specifies the FR_FINDNEXT
        /// flag, lpstrFindWhat contains the string to search for. The FR_DOWN, FR_WHOLEWORD, and FR_MATCHCASE 
        /// flags indicate the direction and type of search. If a FINDMSGSTRING message specifies the FR_REPLACE
        /// or FR_REPLACE flags, lpstrFindWhat contains the string to be replaced
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpstrFindWhat;

        /// <summary>
        /// Pointer to a buffer that a FINDMSGSTRING message uses to pass the null terminated replacement string 
        /// that the user typed in the Replace With edit control. You must dynamically allocate the buffer or use
        /// a global or static array so it does not go out of scope before the dialog box closes. If the buffer 
        /// contains a string when you initialize the dialog box, the string is displayed in the Replace With edit
        /// control. 
        /// If a FINDMSGSTRING message specifies the FR_REPLACE or FR_REPLACEALL flags, lpstrReplaceWith contains
        /// the replacement string. 
        /// The FindText function ignores this member. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpstrReplaceWith;

        /// <summary>
        /// Specifies the length, in bytes, of the buffer pointed to by the lpstrFindWhat member
        /// </summary>
        public ushort wFindWhatLen;

        /// <summary>
        /// Specifies the length, in bytes, of the buffer pointed to by the lpstrReplaceWith member
        /// </summary>
        public ushort wReplaceWithLen;

        /// <summary>
        /// Specifies application-defined data that the system passes to the hook procedure identified by the 
        /// lpfnHook member. When the system sends the WM_INITDIALOG message to the hook procedure, the message's
        /// lParam parameter is a pointer to the FINDREPLACE structure specified when the dialog was created. 
        /// The hook procedure can use this pointer to get the lCustData value
        /// </summary>
        public int lCustData;

        /// <summary>
        /// Pointer to an FRHookProc hook procedure that can process messages intended for the dialog box. 
        /// This member is ignored unless the FR_ENABLEHOOK flag is set in the Flags member. If the hook procedure
        /// returns false in response to the WM_INITDIALOG message, the hook procedure must display the dialog box
        /// or else the dialog box will not be shown. To do this, first perform any other paint operations, and 
        /// then call the ShowWindow and UpdateWindow functions
        /// </summary>
        public LpFRHookProc lpfnHook;

        /// <summary>
        /// Pointer to a null-terminated string that names the dialog box template resource in the module identified
        /// by the hInstance member. This template is substituted for the standard dialog box template. For numbered
        /// dialog box resources, this can be a value returned by the MAKEINTRESOURCE macro. This member is ignored 
        /// unless the FR_ENABLETEMPLATE flag is set in the Flags member
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpTemplateName;
    }
}