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
    /// A set of bit flags you can use to initialize the dialog box.
    /// </summary>
    [Flags]
    public enum FileDialogOption : uint
    {
        /// <summary>
        /// Specifies that the File Name list box allows multiple selections. If you also set the 
        /// OFN_EXPLORER flag, the dialog box uses the Explorer-style user interface; otherwise, 
        /// it uses the old-style user interface. 
        /// </summary>
        /// <remarks>If the user selects more than one file, the lpstrFile buffer returns the path
        /// to the current directory followed by the file names of the selected files. The nFileOffset
        /// member is the offset, in bytes or characters, to the first file name, and the 
        /// nFileExtension member of OPENFILENAME structure is not used. For Explorer-style dialog boxes,
        /// the directory and file name strings are null separated, with an extra null character after the
        /// last file name. 
        /// This format enables the Explorer-style dialog boxes to return long file names that include
        /// spaces. For old-style dialog boxes, the directory and file name strings are separated by 
        /// spaces and the function uses short file names for file names with spaces. You can use the 
        /// FindFirstFile function to convert between long and short file names.
        /// If you specify a custom template for an old-style dialog box, the definition of the File 
        /// Name list box must contain the LBS_EXTENDEDSEL value.
        /// </remarks>
        OFN_ALLOWMULTISELECT = 512,
        /// <summary>
        /// If the user specifies a file that does not exist, this flag causes the dialog box to prompt
        /// the user for permission to create the file. If the user chooses to create the file, the dialog
        /// box closes and the function returns the specified name; otherwise, the dialog box remains open.
        /// If you use this flag with the OFN_ALLOWMULTISELECT flag, the dialog box allows the user to 
        /// specify only one nonexistent file.
        /// </summary>
        OFN_CREATEPROMPT = 8192,
        /// <summary>
        /// Windows 2000/XP: Prevents the system from adding a link to the selected file in the file system
        /// directory that contains the user's most recently used documents. 
        /// </summary>
        OFN_DONTADDTORECENT = 33554432,
        /// <summary>
        /// Enables the hook function specified in the lpfnHook member of OPENFILENAME structure.
        /// </summary>
        OFN_ENABLEHOOK = 32,
        /// <summary>
        /// Windows 2000/XP: Causes the dialog box to send CDN_INCLUDEITEM notification messages to your 
        /// OFNHookProc hook procedure when the user opens a folder. The dialog box sends a notification for 
        /// each item in the newly opened folder. These messages enable you to control which items the dialog
        /// box displays in the folder's item list.
        /// </summary>
        OFN_ENABLEINCLUDENOTIFY = 4194304,
        /// <summary>
        /// Windows 2000/XP, Windows 98/Me: Enables the Explorer-style dialog box to be resized using either
        /// the mouse or the keyboard. By default, the Explorer-style Open and Save As dialog boxes allow the
        /// dialog box to be resized regardless of whether this flag is set. This flag is necessary only if you
        /// provide a hook procedure or custom template. The old-style dialog box does not permit resizing.
        /// </summary>
        OFN_ENABLESIZING = 8388608,
        /// <summary>
        /// Indicates that the lpTemplateName member of OPENFILENAME structure is a pointer to the name of a 
        /// dialog template resource in the module identified by the hInstance member. If the OFN_EXPLORER flag
        /// is set, the system uses the specified template to create a dialog box that is a child of the default
        /// Explorer-style dialog box. If the OFN_EXPLORER flag is not set, the system uses the template to create
        /// an old-style dialog box that replaces the default dialog box.
        /// </summary>
        OFN_ENABLETEMPLATE = 64,
        /// <summary>
        /// Indicates that the hInstance member of OPENFILENAME structure identifies a data block that contains a 
        /// preloaded dialog box template. The system ignores lpTemplateName member of OPENFILENAME structure if this
        /// flag is specified. If the OFN_EXPLORER flag is set, the system uses the specified template to create a 
        /// dialog box that is a child of the default Explorer-style dialog box. If the OFN_EXPLORER flag is not set,
        /// the system uses the template to create an old-style dialog box that replaces the default dialog box.
        /// </summary>
        OFN_ENABLETEMPLATEHANDLE = 128,
        /// <summary>
        /// Indicates that any customizations made to the Open or Save As dialog box use the new Explorer-style 
        /// customization methods. For more information, see Explorer-Style Hook Procedures and Explorer-Style Custom
        /// Templates. 
        /// </summary>
        /// <remarks> By default, the Open and Save As dialog boxes use the Explorer-style user interface regardless
        /// of whether this flag is set. This flag is necessary only if you provide a hook procedure or custom template,
        /// or set the OFN_ALLOWMULTISELECT flag.
        /// </remarks>
        OFN_EXPLORER = 524288,
        /// <summary>
        /// Specifies that the user typed a file name extension that differs from the extension specified by lpstrDefExt
        /// of OPENFILENAME structure. The function does not use this flag if lpstrDefExt member of OPENFILENAME structure
        /// is null.
        /// </summary>
        OFN_EXTENSIONDIFFERENT = 1024,
        /// <summary>
        /// Specifies that the user can type only names of existing files in the File Name entry field. If this flag 
        /// is specified and the user enters an invalid name, the dialog box procedure displays a warning in a message
        /// box. If this flag is specified, the OFN_PATHMUSTEXIST flag is also used. This flag can be used in an Open
        /// dialog box. It cannot be used with a Save As dialog box.
        /// </summary>
        OFN_FILEMUSTEXIST = 4096,
        /// <summary>
        /// Windows 2000/XP: Forces the showing of system and hidden files, thus overriding the user setting to show or
        /// not show hidden files. However, a file that is marked both system and hidden is not shown.
        /// </summary>
        OFN_FORCESHOWHIDDEN = 268435456,
        /// <summary>
        /// Hides the Read Only check box.
        /// </summary>
        OFN_HIDEREADONLY = 4,
        /// <summary>
        /// For old-style dialog boxes, this flag causes the dialog box to use long file names. If this flag is not
        /// specified, or if the OFN_ALLOWMULTISELECT flag is also set, old-style dialog boxes use short file names
        /// (8.3 format) for file names with spaces. Explorer-style dialog boxes ignore this flag and always display
        /// long file names.
        /// </summary>
        OFN_LONGNAMES = 2097152,
        /// <summary>
        /// Restores the current directory to its original value if the user changed the directory while searching
        /// for files.
        /// </summary>
        OFN_NOCHANGEDIR = 8,
        /// <summary>
        /// Directs the dialog box to return the path and file name of the selected shortcut (.LNK) file. If this 
        /// value is not specified, the dialog box returns the path and file name of the file referenced by the 
        /// shortcut.
        /// </summary>
        OFN_NODEREFERENCELINKS = 1048576,
        /// <summary>
        /// For old-style dialog boxes, this flag causes the dialog box to use short file names (8.3 format).
        /// Explorer-style dialog boxes ignore this flag and always display long file names.
        /// </summary>
        OFN_NOLONGNAMES = 262144,
        /// <summary>
        /// Hides and disables the Network button.
        /// </summary>
        OFN_NONETWORKBUTTON = 131072,
        /// <summary>
        /// Specifies that the returned file does not have the Read Only check box selected and is 
        /// not in a write-protected directory
        /// </summary>
        OFN_NOREADONLYRETURN = 32768,
        /// <summary>
        /// Specifies that the file is not created before the dialog box is closed. This flag should
        /// be specified if the application saves the file on a create-nonmodify network share. When an
        /// application specifies this flag, the library does not check for write protection, a full disk,
        /// an open drive door, or network protection. Applications using this flag must perform file 
        /// operations carefully, because a file cannot be reopened once it is closed
        /// </summary>
        OFN_NOTESTFILECREATE = 65536,
        /// <summary>
        /// Specifies that the common dialog boxes allow invalid characters in the returned file name. 
        /// Typically, the calling application uses a hook procedure that checks the file name by using 
        /// the FILEOKSTRING message. If the text box in the edit control is empty or contains nothing but
        /// spaces, the lists of files and directories are updated. If the text box in the edit control 
        /// contains anything else, nFileOffset and nFileExtension of OPENFILENAME structure are set to values
        /// generated by parsing the text. No default extension is added to the text, nor is text copied to 
        /// the buffer specified by lpstrFileTitle of OPENFILENAME structure. If the value specified by nFileOffset
        /// member of OPENFILENAME structure is less than zero, the file name is invalid. Otherwise, the file name
        /// is valid, and nFileExtension and nFileOffset can be used as if the OFN_NOVALIDATE flag had not been
        /// specified.
        /// </summary>
        OFN_NOVALIDATE = 256,
        /// <summary>
        /// Causes the Save As dialog box to generate a message box if the selected file already exists. The user
        /// must confirm whether to overwrite the file.
        /// </summary>
        OFN_OVERWRITEPROMPT = 2,
        /// <summary>
        /// Specifies that the user can type only valid paths and file names. If this flag is used and the user
        /// types an invalid path and file name in the File Name entry field, the dialog box function displays
        /// a warning in a message box.
        /// </summary>
        OFN_PATHMUSTEXIST = 2048,
        /// <summary>
        ///  Causes the Read Only check box to be selected initially when the dialog box is created. This flag
        ///  indicates the state of the Read Only check box when the dialog box is closed.
        /// </summary>
        OFN_READONLY = 1,
        /// <summary>
        /// Specifies that if a call to the OpenFile function fails because of a network sharing violation, 
        /// the error is ignored and the dialog box returns the selected file name. If this flag is not set,
        /// the dialog box notifies your hook procedure when a network sharing violation occurs for the file
        /// name specified by the user. If you set the OFN_EXPLORER flag, the dialog box sends the 
        /// WindowsMessage.CDN_SHAREVIOLATION message to the hook procedure. If you do not set OFN_EXPLORER,
        /// the dialog box sends the SHAREVISTRING registered message to the hook procedure.
        /// </summary>
        OFN_SHAREAWARE = 16384,
        /// <summary>
        /// Causes the dialog box to display the Help button. The hwndOwner member of OPENFILENAME structure 
        /// must specify the window to receive the HELPMSGSTRING registered messages that the 
        /// dialog box sends when the user clicks the Help button. An Explorer-style dialog box 
        /// sends a CDN_HELP notification message to your hook procedure when the user clicks the
        /// Help button.
        /// </summary>
        OFN_SHOWHELP = 16,
        /// <summary>
        /// Do not use
        /// </summary>
        OFN_USESHELLITEM
    }
}