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
using System.PInvoke.Windows.Structs;
using System.Runtime.InteropServices;
using System.Text;

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signature of Common Dialog APIs
    /// </summary>
    public class CommonDialog
    {
        /// <summary>
        /// Help message for common dialog
        /// </summary>
        public const string HELPMSGSTRING = "commdlg_help";

        /// <summary>
        /// The ANSI version of ChooseColor function creates a Color dialog 
        /// box that enables the user to select a color
        /// </summary>
        /// <param name="lpcc">Pointer to a CHOOSECOLORA structure that contains information
        /// used to initialize the dialog box. When ChooseColor returns, this structure contains
        /// information about the user's color selection</param>
        /// <returns>If the user clicks the OK button of the dialog box, the return value is true.
        /// The members of the CHOOSEFONT structure indicate the user's selections. If the user 
        /// cancels or closes the Font dialog box or an error occurs, the return value is false.
        /// To get extended error information, call the CommDlgExtendedError function
        /// </returns>
        public static bool ChooseColorA(ref ChooseColorA lpcc)
        {
            return Native.ChooseColorA(ref lpcc);
        }

        /// <summary>
        /// The UNICODE version of ChooseColor function creates a Color dialog 
        /// box that enables the user to select a color
        /// </summary>
        /// <param name="lpcc">Pointer to a CHOOSECOLORW structure that contains information
        /// used to initialize the dialog box. When ChooseColor returns, this structure contains
        /// information about the user's color selection</param>
        /// <returns>If the user clicks the OK button of the dialog box, the return value is true.
        /// The members of the CHOOSEFONT structure indicate the user's selections. If the user 
        /// cancels or closes the Font dialog box or an error occurs, the return value is false.
        /// To get extended error information, call the CommDlgExtendedError function
        /// </returns>
        public static bool ChooseColorW(ref ChooseColorW lpcc)
        {
            return Native.ChooseColorW(ref lpcc);
        }

        /// <summary>
        /// The ANSI version of ChooseFont function creates a Font dialog box that enables
        /// the user to choose attributes for a logical font. These attributes include a 
        /// typeface name, style (bold, italic, or regular), point size, effects 
        /// (underline, strikeout, and text color), and a script (or character set).
        /// </summary>
        /// <param name="lpcf">Pointer to a CHOOSEFONTA structure that contains information 
        /// used to initialize the dialog box. When ChooseFont returns, this structure contains
        /// information about the user's font selection</param>
        /// <returns>If the user clicks the OK button of the dialog box, the return value is 
        /// nonzero. The members of the CHOOSEFONTA structure indicate the user's selections. 
        /// If the user cancels or closes the Font dialog box or an error occurs, the return 
        /// value is zero. To get extended error information, call the CommDlgExtendedError 
        /// function </returns>
        public static bool ChooseFontA(ref ChooseFontA lpcf)
        {
            return Native.ChooseFontA(ref lpcf);
        }

        /// <summary>
        /// The UNICODE version of ChooseFont function creates a Font dialog box that enables
        /// the user to choose attributes for a logical font. These attributes include a 
        /// typeface name, style (bold, italic, or regular), point size, effects 
        /// (underline, strikeout, and text color), and a script (or character set).
        /// </summary>
        /// <param name="lpcf">Pointer to a CHOOSEFONTW structure that contains information 
        /// used to initialize the dialog box. When ChooseFont returns, this structure contains
        /// information about the user's font selection</param>
        /// <returns>If the user clicks the OK button of the dialog box, the return value is 
        /// nonzero. The members of the CHOOSEFONTW structure indicate the user's selections. 
        /// If the user cancels or closes the Font dialog box or an error occurs, the return 
        /// value is zero. To get extended error information, call the CommDlgExtendedError 
        /// function </returns>
        public static bool ChooseFontW(ref ChooseFontW lpcf)
        {
            return Native.ChooseFontW(ref lpcf);
        }

        /// <summary>
        /// The CommDlgExtendedError function returns a common dialog box error code. This code
        /// indicates the most recent error to occur during the execution of one of the common 
        /// dialog box functions.
        /// </summary>
        /// <returns>If the most recent call to a common dialog box function succeeded, the 
        /// return value is undefined. If the common dialog box function returned FALSE because
        /// the user closed or canceled the dialog box, the return value is zero. Otherwise, the
        /// return value is a nonzero error code.</returns>
        public static CommonDialogError CommDlgExtendedError()
        {
            return Native.CommDlgExtendedError();
        }

        /// <summary>
        /// The ANSI version of GetOpenFileName function creates an Open dialog box that lets 
        /// the user specify the drive, directory, and the name of a file or set of files to open. 
        /// </summary>
        /// <param name="lpofn">Pointer to an OPENFILENAMEA structure that contains information used
        /// to initialize the dialog box. When GetOpenFileName returns, this structure contains 
        /// information about the user's file selection.</param>
        /// <returns>If the user specifies a file name and clicks the OK button, the return value
        /// is nonzero. The buffer pointed to by the lpstrFile member of the OPENFILENAMEA structure
        /// contains the full path and file name specified by the user. If the user cancels or closes
        /// the Open dialog box or an error occurs, the return value is zero. To get extended error 
        /// information, call the CommDlgExtendedError function </returns>
        public static bool GetOpenFileNameA(ref OpenFileNameA lpofn)
        {
            return Native.GetOpenFileNameA(ref lpofn);
        }

        /// <summary>
        /// The UNICODE version of GetOpenFileName function creates an Open dialog box that lets 
        /// the user specify the drive, directory, and the name of a file or set of files to open. 
        /// </summary>
        /// <param name="lpofn">Pointer to an OPENFILENAMEW structure that contains information used
        /// to initialize the dialog box. When GetOpenFileName returns, this structure contains 
        /// information about the user's file selection.</param>
        /// <returns>If the user specifies a file name and clicks the OK button, the return value
        /// is nonzero. The buffer pointed to by the lpstrFile member of the OPENFILENAMEW structure
        /// contains the full path and file name specified by the user. If the user cancels or closes
        /// the Open dialog box or an error occurs, the return value is zero. To get extended error 
        /// information, call the CommDlgExtendedError function </returns>
        public static bool GetOpenFileNamW(ref OpenFileName lpofn)
        {
            return Native.GetOpenFileNameW(ref lpofn);
        }

        /// <summary>
        /// The ANSI version of GetSaveFileName function creates a Save dialog box that lets the user 
        /// specify the drive, directory, and name of a file to save.
        /// </summary>
        /// <param name="lpofn">Pointer to an OPENFILENAMEA structure that contains information used 
        /// to initialize the dialog box. When GetSaveFileName returns, this structure contains information
        /// about the user's file selection</param>
        /// <returns>If the user specifies a file name and clicks the OK button and the function is successful,
        /// the return value is nonzero. The buffer pointed to by the lpstrFile member of the OPENFILENAMEA 
        /// structure contains the full path and file name specified by the user. If the user cancels or 
        /// closes the Save dialog box or an error such as the file name buffer being too small occurs, the 
        /// return value is zero. To get extended error information, call the CommDlgExtendedError function</returns>
        public static bool GetSaveFileNameA(ref OpenFileNameA lpofn)
        {
            return Native.GetSaveFileNameA(ref lpofn);
        }

        /// <summary>
        /// The UNICODE version of GetSaveFileName function creates a Save dialog box that lets the user 
        /// specify the drive, directory, and name of a file to save.
        /// </summary>
        /// <param name="lpofn">Pointer to an OPENFILENAMEW structure that contains information used 
        /// to initialize the dialog box. When GetSaveFileName returns, this structure contains information
        /// about the user's file selection</param>
        /// <returns>If the user specifies a file name and clicks the OK button and the function is successful,
        /// the return value is nonzero. The buffer pointed to by the lpstrFile member of the OPENFILENAMEW 
        /// structure contains the full path and file name specified by the user. If the user cancels or 
        /// closes the Save dialog box or an error such as the file name buffer being too small occurs, the 
        /// return value is zero. To get extended error information, call the CommDlgExtendedError function</returns>
        public static bool GetSaveFileNameW(ref OpenFileName lpofn)
        {
            return Native.GetSaveFileNameW(ref lpofn);
        }

        /// <summary>
        /// The MessageBox function creates, displays, and operates a message box. The message box contains 
        /// an application-defined message and title, along with any combination of predefined icons and 
        /// push buttons.
        /// </summary>
        /// <param name="hWnd">Handle to the owner window of the message box to be created. If this parameter
        /// is null, the message box has no owner window</param>
        /// <param name="lpText">Pointer to a null-terminated string that contains the message to be displayed.</param>
        /// <param name="lpCaption">Pointer to a null-terminated string that contains the dialog box title. If 
        /// this parameter is null, the default title Error is used.</param>
        /// <param name="uType">Specifies the contents and behavior of the dialog box. This parameter can be a 
        /// combination of flags from the following groups of flags.</param>
        /// <returns>If a message box has a Cancel button, the function returns the IDCANCEL value if either 
        /// the ESC key is pressed or the Cancel button is selected. If the message box has no Cancel button,
        /// pressing ESC has no effect. If the function fails, the return value is zero. To get extended error
        /// information, call GetLastError. If the function succeeds, the return value is one of the value of DialogBoxResult
        /// </returns>
        public static DialogBoxResult MessageBox([In] IntPtr hWnd, [In] string lpText, [In] string lpCaption,
                                                 MessageBoxStyle uType)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.MessageBoxW(hWnd, lpText, lpCaption, uType) : Native.MessageBoxA(hWnd, lpText, lpCaption, uType);
        }

        /// <summary>
        /// The MessageBoxEx function creates, displays, and operates a message box. The message box contains an 
        /// application-defined message and title, plus any combination of predefined icons and push buttons. 
        /// The buttons are in the language of the system user interface. 
        /// </summary>
        /// <param name="hWnd">Handle to the owner window of the message box to be created. If this parameter is null,
        /// the message box has no owner window</param>
        /// <param name="lpText">Pointer to a null-terminated string that contains the message to be displayed.</param>
        /// <param name="lpCaption">Pointer to a null-terminated string that contains the dialog box title. If 
        /// this parameter is null, the default title Error is used.</param>
        /// <param name="uType">Specifies the contents and behavior of the dialog box. This parameter can be a combination 
        /// of flags from the following groups of flags</param>
        /// <param name="wLanguageId">Specifies the language for the text displayed in the message box button(s). Specifying
        /// a value of zero (0) indicates to display the button text in the default system language.</param>
        /// <returns>If a message box has a Cancel button, the function returns the IDCANCEL value if either 
        /// the ESC key is pressed or the Cancel button is selected. If the message box has no Cancel button,
        /// pressing ESC has no effect. 
        /// If the function fails, the return value is zero. To get extended error information, call 
        /// GetLastError. 
        /// If the function succeeds, the return value is one of memeber of DialogBoxResult</returns>
        public static DialogBoxResult MessageBoxEx([In] IntPtr hWnd, [In] string lpText, [In] string lpCaption,
                                                   MessageBoxStyle uType, ushort wLanguageId)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.MessageBoxExW(hWnd, lpText, lpCaption, uType, wLanguageId) : Native.MessageBoxExA(hWnd, lpText, lpCaption, uType, wLanguageId);
        }

        /// <summary>
        /// The ANSI version of MessageBoxIndirect function creates, displays, and operates a message box. The message box 
        /// contains application-defined message text and title, any icon, and any combination of predefined
        /// push buttons
        /// </summary>
        /// <param name="lpmbp">Pointer to a MSGBOXPARAMSA structure that contains information used to display
        /// the message box</param>
        /// <returns>If the function succeeds, the return value is one of the following menu-item values. If a
        /// message box has a Cancel button, the function returns the IDCANCEL value if either the ESC key is 
        /// pressed or the Cancel button is selected. If the message box has no Cancel button, pressing ESC 
        /// has no effect. If there is not enough memory to create the message box, the return value is zero.</returns>
        public static DialogBoxResult MessageBoxIndirectA([In] ref MsgBoxParamsA lpmbp)
        {
            return Native.MessageBoxIndirectA(ref lpmbp);
        }

        /// <summary>
        /// The UNICODE version of MessageBoxIndirect function creates, displays, and operates a message box. The message box 
        /// contains application-defined message text and title, any icon, and any combination of predefined
        /// push buttons
        /// </summary>
        /// <param name="lpmbp">Pointer to a MSGBOXPARAMSW structure that contains information used to display
        /// the message box</param>
        /// <returns>If the function succeeds, the return value is one of the following menu-item values. If a
        /// message box has a Cancel button, the function returns the IDCANCEL value if either the ESC key is 
        /// pressed or the Cancel button is selected. If the message box has no Cancel button, pressing ESC 
        /// has no effect. If there is not enough memory to create the message box, the return value is zero.</returns>
        public static DialogBoxResult MessageBoxIndirectW([In] ref MsgBoxParamsW lpmbp)
        {
            return Native.MessageBoxIndirectW(ref lpmbp);
        }

        /// <summary>
        /// The ANSI version of PageSetupDlg function creates a Page Setup dialog box that enables the user to specify the
        /// attributes of a printed page. These attributes include the paper size and source, the page 
        /// orientation (portrait or landscape), and the width of the page margins.
        /// </summary>
        /// <param name="lppsd">Pointer to a PAGESETUPDLGA structure that contains information used to initialize the dialog
        /// box. The structure receives information about the user's selections when the function returns</param>
        /// <returns>If the user clicks the OK button, the return value is nonzero. The members of the PAGESETUPDLGA structure
        /// pointed to by the lppsd parameter indicate the user's selections. If the user cancels or closes the Page
        /// Setup dialog box or an error occurs, the return value is zero. To get extended error information, use the 
        /// CommDlgExtendedError function </returns>
        public static bool PageSetupDlgA(ref PageSetupDlgA lppsd)
        {
            return Native.PageSetupDlgA(ref lppsd);
        }

        /// <summary>
        /// The UNICODE version of PageSetupDlg function creates a Page Setup dialog box that enables the user to specify the
        /// attributes of a printed page. These attributes include the paper size and source, the page 
        /// orientation (portrait or landscape), and the width of the page margins.
        /// </summary>
        /// <param name="lppsd">Pointer to a PAGESETUPDLGW structure that contains information used to initialize the dialog
        /// box. The structure receives information about the user's selections when the function returns</param>
        /// <returns>If the user clicks the OK button, the return value is nonzero. The members of the PAGESETUPDLGW structure
        /// pointed to by the lppsd parameter indicate the user's selections. If the user cancels or closes the Page
        /// Setup dialog box or an error occurs, the return value is zero. To get extended error information, use the 
        /// CommDlgExtendedError function </returns>
        public static bool PageSetupDlgW(ref PageSetupDlgW lppsd)
        {
            return Native.PageSetupDlgW(ref lppsd);
        }

        /// <summary>
        /// The ANSI version of PrintDlg function displays a Print Dialog Box. The Print dialog box enables the user to specify the
        /// properties of a particular print job. 
        /// Windows 2000/XP: The PrintDlg function has been superseded by the PrintDlgEx function. PrintDlgEx displays
        /// a Print Property Sheet, which has a General page containing controls similar to the Print dialog box
        /// </summary>
        /// <param name="lppd">Pointer to a PRINTDLGA structure that contains information used to initialize the dialog box. 
        /// When PrintDlg returns, this structure contains information about the user's selections</param>
        /// <returns>If the user clicks the OK button, the return value is nonzero. The members of the PRINTDLGA structure 
        /// pointed to by the lppd parameter indicate the user's selections.
        /// If the user canceled or closed the Print or Printer Setup dialog box or an error occurred, the return value
        /// is zero. To get extended error information, use the CommDlgExtendedError function. If the user canceled or
        /// closed the dialog box, CommDlgExtendedError returns zero; otherwise any value of CommonDialogError
        /// </returns>
        public static bool PrintDlgA(ref PrintDlgA lppd)
        {
            return Native.PrintDlgA(ref lppd);
        }

        /// <summary>
        /// The UNICODE version of PrintDlg function displays a Print Dialog Box. The Print dialog box enables the user to specify the
        /// properties of a particular print job. 
        /// Windows 2000/XP: The PrintDlg function has been superseded by the PrintDlgEx function. PrintDlgEx displays
        /// a Print Property Sheet, which has a General page containing controls similar to the Print dialog box
        /// </summary>
        /// <param name="lppd">Pointer to a PRINTDLGW structure that contains information used to initialize the dialog box. 
        /// When PrintDlg returns, this structure contains information about the user's selections</param>
        /// <returns>If the user clicks the OK button, the return value is nonzero. The members of the PRINTDLGW structure 
        /// pointed to by the lppd parameter indicate the user's selections.
        /// If the user canceled or closed the Print or Printer Setup dialog box or an error occurred, the return value
        /// is zero. To get extended error information, use the CommDlgExtendedError function. If the user canceled or
        /// closed the dialog box, CommDlgExtendedError returns zero; otherwise any value of CommonDialogError
        /// </returns>
        public static bool PrintDlgW(ref PrintDlgW lppd)
        {
            return Native.PrintDlgW(ref lppd);
        }

        /// <summary>
        /// The ANSI version of PrintDlgEx function displays a Print property sheet that enables the user to specify
        /// the properties of a particular print job. A Print property sheet has a General page containing controls 
        /// similar to the Print dialog box. The property sheet can also have additional application-specific and 
        /// driver-specific property pages following the General page
        /// </summary>
        /// <param name="lppd">Pointer to a PRINTDLGEXA structure that contains information used to initialize the 
        /// property sheet. When PrintDlgEx returns, this structure contains information about the user's selections.
        /// </param>
        /// <returns>If the function succeeds, the return value is S_OK and the dwResultAction member of the PRINTDLGEXA 
        /// structure contains one of the </returns>
        public static PrintDialogResult PrintDlgExA(ref PrintDlgExA lppd)
        {
            return Native.PrintDlgExA(ref lppd);
        }

        /// <summary>
        /// The UNICODE version of PrintDlgEx function displays a Print property sheet that enables the user to specify
        /// the properties of a particular print job. A Print property sheet has a General page containing controls 
        /// similar to the Print dialog box. The property sheet can also have additional application-specific and 
        /// driver-specific property pages following the General page
        /// </summary>
        /// <param name="lppd">Pointer to a PRINTDLGEXW structure that contains information used to initialize the 
        /// property sheet. When PrintDlgEx returns, this structure contains information about the user's selections.
        /// </param>
        /// <returns>If the function succeeds, the return value is S_OK and the dwResultAction member of the PRINTDLGEXW 
        /// structure contains one of the </returns>
        public static PrintDialogResult PrintDlgExW(ref PrintDlgExW lppd)
        {
            return Native.PrintDlgExW(ref lppd);
        }

        /// <summary>
        /// Displays a ShellAbout dialog box
        /// </summary>
        /// <param name="hWnd">A window handle to a parent window. This parameter can be null</param>
        /// <param name="szApp">A pointer to a null-terminated string containing text that will be displayed in the title bar
        /// of the ShellAbout dialog box and on the first line of the dialog box after the text "Microsoft". If the text 
        /// contains a separator (#) dividing it into two parts, the function displays the first part in the title bar and
        /// the second part on the first line after the text "Microsoft</param>
        /// <param name="szOtherStuff">A pointer to a null-terminated string containing text that will be displayed
        /// in the dialog box after the version and copyright information. This parameter can be null</param>
        /// <param name="hIcon">An icon that the function displays in the dialog box. If this parameter is null, the function
        /// displays the Microsoft Windows or Microsoft Windows NT icon. </param>
        /// <returns>Returns true if successful, or false otherwise</returns>
        public static int ShellAbout(IntPtr hWnd, [In] string szApp, [In] string szOtherStuff, IntPtr hIcon)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.ShellAboutW(hWnd, szApp, szOtherStuff, hIcon) : Native.ShellAboutA(hWnd, szApp, szOtherStuff, hIcon);
        }

        /// <summary>
        /// The ANSI version of FindText function creates a system-defined modeless Find dialog box that lets the user specify a string to 
        /// search for and options to use when searching for text in a document.
        /// </summary>
        /// <param name="lpfr">Pointer to a FINDREPLACEA structure that contains information used to initialize
        /// the dialog box. The dialog box uses this structure to send information about the user's input to your
        /// application. For more information, see the following Remarks section</param>
        /// <returns>If the function succeeds, the return value is the window handle to the dialog box. You can use
        /// the window handle to communicate with or to close the dialog box. 
        /// If the function fails, the return value is null. To get extended error information, call the 
        /// CommDlgExtendedError function
        /// </returns>
        public static IntPtr FindTextA(ref FindReplaceA lpfr)
        {
            return Native.FindTextA(ref lpfr);
        }

        /// <summary>
        /// The UNICODE version of FindText function creates a system-defined modeless Find dialog box that lets the user specify a string to 
        /// search for and options to use when searching for text in a document.
        /// </summary>
        /// <param name="lpfr">Pointer to a FINDREPLACEW structure that contains information used to initialize
        /// the dialog box. The dialog box uses this structure to send information about the user's input to your
        /// application. For more information, see the following Remarks section</param>
        /// <returns>If the function succeeds, the return value is the window handle to the dialog box. You can use
        /// the window handle to communicate with or to close the dialog box. 
        /// If the function fails, the return value is null. To get extended error information, call the 
        /// CommDlgExtendedError function
        /// </returns>        
        public static IntPtr FindTextW(ref FindReplaceW lpfr)
        {
            return Native.FindTextW(ref lpfr);
        }

        /// <summary>
        /// The GetFileTitle function retrieves the name of the specified file
        /// </summary>
        /// <param name="lpszFile">Pointer to the name and location of a file</param>
        /// <param name="lpszTitle">Pointer to a buffer that receives the name of the file</param>
        /// <param name="cbBuf">Specifies the length of the buffer pointed to by the lpszTitle parameter.
        /// For the ANSI version of the function, this is in bytes; for the Unicode version, 
        /// this is in characters</param>
        /// <returns>If the function succeeds, the return value is zero. 
        /// If the file name is invalid, the return value is unknown. If there is an error, the return value is
        /// a negative number.
        /// If the buffer pointed to by the lpszTitle parameter is too small, the return value is a positive 
        /// integer that specifies the required buffer size, in TCHARs. The required buffer size includes the 
        /// terminating null character. 
        /// </returns>
        public static short GetFileTitle([In] string lpszFile, StringBuilder lpszTitle, ushort cbBuf)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.GetFileTitleW(lpszFile, lpszTitle, cbBuf) : Native.GetFileTitleA(lpszFile, lpszTitle, cbBuf);
        }

        /// <summary>
        /// The ANSI version of ReplaceText function creates a system-defined modeless dialog box that lets the
        /// user specify a string to search for and a replacement string, as well as options to control the find
        /// and replace operations
        /// </summary>
        /// <param name="lpfr">Pointer to a FINDREPLACEA structure that contains information used to initialize the
        /// dialog box. The dialog box uses this structure to send information about the user's input to your 
        /// application.</param>
        /// <returns>If the function succeeds, the return value is the window handle to the dialog box. You can use
        /// the window handle to communicate with the dialog box or close it. 
        /// If the function fails, the return value is null. To get extended error information, call the 
        /// CommDlgExtendedError function
        /// </returns>
        public static IntPtr ReplaceTextA(ref FindReplaceA lpfr)
        {
            return Native.ReplaceTextA(ref lpfr);
        }

        /// <summary>
        /// The UNICODE version of ReplaceText function creates a system-defined modeless dialog box that lets the
        /// user specify a string to search for and a replacement string, as well as options to control the find
        /// and replace operations
        /// </summary>
        /// <param name="lpfr">Pointer to a FINDREPLACEW structure that contains information used to initialize the
        /// dialog box. The dialog box uses this structure to send information about the user's input to your 
        /// application.</param>
        /// <returns>If the function succeeds, the return value is the window handle to the dialog box. You can use
        /// the window handle to communicate with the dialog box or close it. 
        /// If the function fails, the return value is null. To get extended error information, call the 
        /// CommDlgExtendedError function
        /// </returns>
        public static IntPtr ReplaceTextW(ref FindReplaceW lpfr)
        {
            return Native.ReplaceTextW(ref lpfr);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("comdlg32.dll", EntryPoint = "ChooseColorA", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ChooseColorA(ref ChooseColorA lpcc);

            [DllImport("comdlg32.dll", EntryPoint = "ChooseColorW", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ChooseColorW(ref ChooseColorW lpcc);

            [DllImport("comdlg32.dll", EntryPoint = "ChooseFontA", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ChooseFontA(ref ChooseFontA param0);

            [DllImport("comdlg32.dll", EntryPoint = "ChooseFontW", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ChooseFontW(ref ChooseFontW param0);

            [DllImport("comdlg32.dll", EntryPoint = "CommDlgExtendedError", SetLastError = true)]
            public static extern CommonDialogError CommDlgExtendedError();

            [DllImport("comdlg32.dll", EntryPoint = "GetOpenFileNameA", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetOpenFileNameA(ref OpenFileNameA param0);

            [DllImport("comdlg32.dll", EntryPoint = "GetOpenFileNameW", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetOpenFileNameW(ref OpenFileName param0);

            [DllImport("comdlg32.dll", EntryPoint = "GetSaveFileNameA", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetSaveFileNameA(ref OpenFileNameA param0);

            [DllImport("comdlg32.dll", EntryPoint = "GetSaveFileNameW", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetSaveFileNameW(ref OpenFileName param0);

            [DllImport("user32.dll", EntryPoint = "MessageBoxA", SetLastError = true)]
            public static extern DialogBoxResult MessageBoxA([In] IntPtr hWnd,
                                                             [In] [MarshalAs(UnmanagedType.LPStr)] string lpText,
                                                             [In] [MarshalAs(UnmanagedType.LPStr)] string lpCaption,
                                                             MessageBoxStyle uType);

            [DllImport("user32.dll", EntryPoint = "MessageBoxW", SetLastError = true)]
            public static extern DialogBoxResult MessageBoxW([In] IntPtr hWnd,
                                                             [In] [MarshalAs(UnmanagedType.LPWStr)] string lpText,
                                                             [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCaption,
                                                             MessageBoxStyle uType);

            [DllImport("user32.dll", EntryPoint = "MessageBoxExA", SetLastError = true)]
            public static extern DialogBoxResult MessageBoxExA([In] IntPtr hWnd,
                                                               [In] [MarshalAs(UnmanagedType.LPStr)] string lpText,
                                                               [In] [MarshalAs(UnmanagedType.LPStr)] string lpCaption,
                                                               MessageBoxStyle uType, ushort wLanguageId);

            [DllImport("user32.dll", EntryPoint = "MessageBoxExW", SetLastError = true)]
            public static extern DialogBoxResult MessageBoxExW([In] IntPtr hWnd,
                                                               [In] [MarshalAs(UnmanagedType.LPWStr)] string lpText,
                                                               [In] [MarshalAs(UnmanagedType.LPWStr)] string lpCaption,
                                                               MessageBoxStyle uType, ushort wLanguageId);

            [DllImport("user32.dll", EntryPoint = "MessageBoxIndirectA", SetLastError = true)]
            public static extern DialogBoxResult MessageBoxIndirectA([In] ref MsgBoxParamsA lpmbp);

            [DllImport("user32.dll", EntryPoint = "MessageBoxIndirectW", SetLastError = true)]
            public static extern DialogBoxResult MessageBoxIndirectW([In] ref MsgBoxParamsW lpmbp);

            [DllImport("comdlg32.dll", EntryPoint = "PageSetupDlgA", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PageSetupDlgA(ref PageSetupDlgA param0);

            [DllImport("comdlg32.dll", EntryPoint = "PageSetupDlgW", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PageSetupDlgW(ref PageSetupDlgW param0);

            [DllImport("comdlg32.dll", EntryPoint = "PrintDlgA", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PrintDlgA(ref PrintDlgA param0);

            [DllImport("comdlg32.dll", EntryPoint = "PrintDlgW", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool PrintDlgW(ref PrintDlgW param0);

            [DllImport("comdlg32.dll", EntryPoint = "PrintDlgExA", SetLastError = true)]
            public static extern PrintDialogResult PrintDlgExA(ref PrintDlgExA param0);

            [DllImport("comdlg32.dll", EntryPoint = "PrintDlgExW", SetLastError = true)]
            public static extern PrintDialogResult PrintDlgExW(ref PrintDlgExW param0);

            [DllImport("shell32.dll", EntryPoint = "ShellAboutA", CallingConvention = CallingConvention.StdCall,
                SetLastError = true)]
            public static extern int ShellAboutA(IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPStr)] string szApp,
                                                 [In] [MarshalAs(UnmanagedType.LPStr)] string szOtherStuff, IntPtr hIcon);

            [DllImport("shell32.dll", EntryPoint = "ShellAboutW", CallingConvention = CallingConvention.StdCall,
                SetLastError = true)]
            public static extern int ShellAboutW(IntPtr hWnd, [In] [MarshalAs(UnmanagedType.LPWStr)] string szApp,
                                                 [In] [MarshalAs(UnmanagedType.LPWStr)] string szOtherStuff,
                                                 IntPtr hIcon);

            [DllImport("comdlg32.dll", EntryPoint = "FindTextA", SetLastError = true)]
            public static extern IntPtr FindTextA(ref FindReplaceA param0);

            [DllImport("comdlg32.dll", EntryPoint = "FindTextW", SetLastError = true)]
            public static extern IntPtr FindTextW(ref FindReplaceW param0);

            [DllImport("comdlg32.dll", EntryPoint = "GetFileTitleA", SetLastError = true)]
            public static extern short GetFileTitleA([In] [MarshalAs(UnmanagedType.LPStr)] string param0,
                                                     [MarshalAs(UnmanagedType.LPStr)] StringBuilder param1,
                                                     ushort param2);

            [DllImport("comdlg32.dll", EntryPoint = "GetFileTitleW", SetLastError = true)]
            public static extern short GetFileTitleW([In] [MarshalAs(UnmanagedType.LPWStr)] string param0,
                                                     [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param1,
                                                     ushort param2);

            [DllImport("comdlg32.dll", EntryPoint = "ReplaceTextA", SetLastError = true)]
            public static extern IntPtr ReplaceTextA(ref FindReplaceA param0);

            [DllImport("comdlg32.dll", EntryPoint = "ReplaceTextW", SetLastError = true)]
            public static extern IntPtr ReplaceTextW(ref FindReplaceW param0);
        }

        #endregion
    }
}