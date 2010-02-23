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
    /// The OPENFILENAMEW structure contains information that the GetOpenFileName and
    /// GetSaveFileName functions use to initialize an Open or Save As dialog box. 
    /// After the user closes the dialog box, the system returns information about the
    /// user's selection in this structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct OpenFileName
    {
        /// <summary>
        /// Specifies the length, in bytes, of the structure. 
        /// </summary>
        public uint lStructSize;

        /// <summary>
        /// Handle to the window that owns the dialog box. This member can be any valid
        /// window handle, or it can be null if the dialog box has no owner.
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// If the OFN_ENABLETEMPLATEHANDLE flag is set in the Flags member, hInstance
        /// is a handle to a memory object containing a dialog box template. If the 
        /// OFN_ENABLETEMPLATE flag is set, hInstance is a handle to a module that contains
        /// a dialog box template named by the lpTemplateName member. If neither flag is set,
        /// this member is ignored. If the OFN_EXPLORER flag is set, the system uses the 
        /// specified template to create a dialog box that is a child of the default 
        /// Explorer-style dialog box. If the OFN_EXPLORER flag is not set, the system uses the
        /// template to create an old-style dialog box that replaces the default dialog box.
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// Pointer to a buffer containing pairs of null-terminated filter strings. The last string
        /// in the buffer must be terminated by two null characters. 
        /// </summary>
        /// <remarks>The first string in each pair is a display string that describes the filter 
        /// (for example, "Text Files"), and the second string specifies the filter pattern (for 
        /// example, "*.TXT"). To specify multiple filter patterns for a single display string, use
        /// a semicolon to separate the patterns (for example, "*.TXT;*.DOC;*.BAK"). A pattern string
        /// can be a combination of valid file name characters and the asterisk (*) wildcard character.
        /// Do not include spaces in the pattern string.
        /// The system does not change the order of the filters. It displays them in the File Types combo
        /// box in the order specified in lpstrFilter. If lpstrFilter is null, the dialog box does not 
        /// display any filters.
        /// </remarks>
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrFilter;

        /// <summary>
        /// Pointer to a static buffer that contains a pair of null-terminated filter strings for preserving
        /// the filter pattern chosen by the user. The first string is your display string that describes the
        /// custom filter, and the second string is the filter pattern selected by the user. The first time 
        /// your application creates the dialog box, you specify the first string, which can be any nonempty
        /// string. When the user selects a file, the dialog box copies the current filter pattern to the 
        /// second string. The preserved filter pattern can be one of the patterns specified in the lpstrFilter
        /// buffer, or it can be a filter pattern typed by the user. The system uses the strings to initialize 
        /// the user-defined file filter the next time the dialog box is created. If the nFilterIndex member is
        /// zero, the dialog box uses the custom filter.
        /// </summary>
        /// <remarks>If this member is null, the dialog box does not preserve user-defined filter patterns.</remarks>
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrCustomFilter;

        /// <summary>
        /// Specifies the size of the buffer identified by lpstrCustomFilter. For the ANSI version,
        /// this is the number of bytes; for the Unicode version, this is the number of characters. This buffer
        /// should be at least 40 characters long. This member is ignored if lpstrCustomFilter is null or points
        /// to a null string.
        /// </summary>
        public uint nMaxCustFilter;

        /// <summary>
        /// Specifies the index of the currently selected filter in the File Types control. The buffer pointed
        /// to by lpstrFilter contains pairs of strings that define the filters. The first pair of strings has
        /// an index value of 1, the second pair 2, and so on. An index of zero indicates the custom filter 
        /// specified by lpstrCustomFilter. You can specify an index on input to indicate the initial filter 
        /// description and filter pattern for the dialog box. When the user selects a file, nFilterIndex returns
        /// the index of the currently displayed filter. If nFilterIndex is zero and lpstrCustomFilter is null, 
        /// the system uses the first filter in the lpstrFilter buffer. If all three members are zero or null, 
        /// the system does not use any filters and does not show any files in the file list control of the dialog box.
        /// </summary>
        public uint nFilterIndex;

        /// <summary>
        /// Pointer to a buffer that contains a file name used to initialize the File Name edit control. The first 
        /// character of this buffer must be null if initialization is not necessary. When the GetOpenFileName
        /// or GetSaveFileName function returns successfully, this buffer contains the drive designator, path, 
        /// file name, and extension of the selected file.
        /// </summary>
        /// <remarks>If the OFN_ALLOWMULTISELECT flag is set and the user selects multiple files, the buffer 
        /// contains the current directory followed by the file names of the selected files. For Explorer-style 
        /// dialog boxes, the directory and file name strings are null separated, with an extra null character 
        /// after the last file name. For old-style dialog boxes, the strings are space separated and the function
        /// uses short file names for file names with spaces. You can use the FindFirstFile function to convert 
        /// between long and short file names. If the user selects only one file, the lpstrFile string does not 
        /// have a separator between the path and file name.
        /// If the buffer is too small, the function returns false and the CommDlgExtendedError function returns 
        /// FNERR_BUFFERTOOSMALL. In this case, the first two bytes of the lpstrFile buffer contain the required 
        /// size, in bytes or characters.
        /// </remarks>
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrFile;

        /// <summary>
        /// Specifies the size of the buffer pointed to by lpstrFile. For the ANSI version, this is the number of
        /// bytes; for the Unicode version, this is the number of characters. The buffer must be large enough to 
        /// store the path and file name string or strings, including the terminating null character. The 
        /// GetOpenFileName and GetSaveFileName functions return false if the buffer is too small to contain the
        /// file information. The buffer should be at least 256 characters long.
        /// </summary>
        public uint nMaxFile;

        /// <summary>
        /// Pointer to a buffer that receives the file name and extension (without path information) of the selected
        /// file. This member can be null.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrFileTitle;

        /// <summary>
        /// Specifies the size of the buffer pointed to by lpstrFileTitle. For the ANSI version, this is the number
        /// of bytes; for the Unicode version, this is the number of characters. This member is ignored if 
        /// lpstrFileTitle is null.
        /// </summary>
        public uint nMaxFileTitle;

        /// <summary>
        /// Pointer to a null terminated string that can specify the initial directory. The algorithm for selecting
        /// the initial directory varies on different platforms.
        /// </summary>
        /// <remarks>
        /// 
        /// Windows 2000/XP:<para>
        /// If lpstrFile contains a path, that path is the initial directory.<para>
        /// Otherwise, lpstrInitialDir specifies the initial directory.<para>
        /// Otherwise, if the application has used an Open or Save As dialog box in the past, the path most 
        /// recently used is selected as the initial directory. However, if an application is not run for a
        /// long time, its saved selected path is discarded.<para>
        /// If lpstrInitialDir is null and the current directory contains any files of the specified filter
        /// types, the initial directory is the current directory.<para>
        /// Otherwise, the initial directory is the personal files directory of the current user.<para>
        /// Otherwise, the initial directory is the Desktop folder.<para>
        /// </para>
        /// Windows 98/Me:
        /// </para>
        /// lpstrInitialDir specifies the initial directory.
        /// </para>
        /// If lpstrInitialDir is null and lpstrFile contains a path, that path is the initial directory
        /// </para>
        /// Otherwise, if the current directory contains any files of the specified filter types, the initial
        /// directory is the current directory.
        /// </para>
        /// Otherwise, the initial directory is the personal files directory of the current user.
        /// </para>
        /// Earlier versions of Windows and Windows NT:
        /// </para>
        /// lpstrInitialDir specifies the initial directory.<para>
        /// If lpstrInitialDir is null and lpstrFile contains a path, that path is the initial directory.
        /// </para>
        /// Otherwise, the initial directory is the current directory.
        /// </remarks>
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrInitialDir;

        /// <summary>
        /// Pointer to a string to be placed in the title bar of the dialog box. If this member is null, 
        /// the system uses the default title (that is, Save As or Open).
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrTitle;

        /// <summary>
        /// A set of bit flags you can use to initialize the dialog box. When the dialog box returns,
        /// it sets these flags to indicate the user's input. 
        /// </summary>
        public FileDialogOption Flags;

        /// <summary>
        /// Specifies the zero-based offset from the beginning of the path to the file name
        /// in the string pointed to by lpstrFile. For the ANSI version, this is the number of bytes; 
        /// for the Unicode version, this is the number of characters. For example, if lpstrFile points
        /// to the following string, "c:\dir1\dir2\file.ext", this member contains the value 13 to indicate
        /// the offset of the "file.ext" string. If the user selects more than one file, nFileOffset is 
        /// the offset to the first file name.
        /// </summary>
        public ushort nFileOffset;

        /// <summary>
        /// Specifies the zero-based offset from the beginning of the path to the file name 
        /// extension in the string pointed to by lpstrFile. For the ANSI version, this is the number of 
        /// bytes; for the Unicode version, this is the number of characters. For example, if lpstrFile 
        /// points to the following string, "c:\dir1\dir2\file.ext", this member contains the value 18. 
        /// If the user did not type an extension and lpstrDefExt is null, this member specifies an offset
        /// to the terminating null character. If the user typed "." as the last character in the file name,
        /// this member specifies zero.
        /// </summary>
        public ushort nFileExtension;

        /// <summary>
        /// Pointer to a buffer that contains the default extension. GetOpenFileName and GetSaveFileName
        /// append this extension to the file name if the user fails to type an extension. This string can
        /// be any length, but only the first three characters are appended. The string should not contain
        /// a period (.). If this member is null and the user fails to type an extension, no extension is 
        /// appended.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] public string lpstrDefExt;

        /// <summary>
        /// Specifies application-defined data that the system passes to the hook procedure identified by
        /// the lpfnHook member. When the system sends the WM_INITDIALOG message to the hook procedure, 
        /// the message's lParam parameter is a pointer to the OPENFILENAME structure specified when the 
        /// dialog box was created. The hook procedure can use this pointer to get the lCustData value.
        /// </summary>
        public int lCustData;

        /// <summary>
        /// Pointer to a hook procedure. This member is ignored unless the Flags member includes 
        /// the OFN_ENABLEHOOK flag. 
        /// </summary>
        /// <remarks>If the OFN_EXPLORER flag is not set in the Flags member, lpfnHook is a pointer to
        /// an OFNHookProcOldStyle hook procedure that receives messages intended for the dialog box. 
        /// The hook procedure returns false to pass a message to the default dialog box procedure or 
        /// true to discard the message</remarks>
        public LpOFNHookProc lpfnHook;

        /// <summary>
        /// Pointer to a null-terminated string that names a dialog template resource in the module 
        /// identified by the hInstance member. For numbered dialog box resources, this can be a value 
        /// returned by the MAKEINTRESOURCE macro. This member is ignored unless the OFN_ENABLETEMPLATE
        /// flag is set in the Flags member. If the OFN_EXPLORER flag is set, the system uses the specified
        /// template to create a dialog box that is a child of the default Explorer-style dialog box. 
        /// If the OFN_EXPLORER flag is not set, the system uses the template to create an old-style 
        /// dialog box that replaces the default dialog box.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)] public string lpTemplateName;

        /// <summary>
        /// Reserved. Must be set to null.
        /// </summary>
        public IntPtr pvReserved;

        /// <summary>
        /// Reserved. Must be set to 0.
        /// </summary>
        public uint dwReserved;

        /// <summary>
        /// Windows 2000/XP: A set of bit flags you can use to initialize the dialog box. Currently, 
        /// this member can be zero or the following flag. OFN_EX_NOPLACESBAR If this flag is set, the 
        /// places bar is not displayed. If this flag is not set, Explorer-style dialog boxes include a
        /// places bar containing icons for commonly-used folders, such as Favorites and Desktop.
        /// </summary>
        public uint FlagsEx;
    }
}