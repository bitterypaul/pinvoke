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
    /// The PRINTDLGA structure contains information that the PrintDlgA function uses to 
    /// initialize the Print Dialog Box. After the user closes the dialog box, the system
    /// uses this structure to return information about the user's selections.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PrintDlgA
    {
        /// <summary>
        /// Specifies the structure size, in bytes.
        /// </summary>
        public uint lStructSize;

        /// <summary>
        /// Handle to the window that owns the dialog box. This member can be any valid 
        /// window handle, or it can be null if the dialog box has no owner. 
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// Handle to a movable global memory object that contains a DEVMODEA structure.
        /// If hDevMode is not null on input, you must allocate a movable block of memory 
        /// for the DEVMODEA structure and initialize its members. The PrintDlg function uses 
        /// the input data to initialize the controls in the dialog box. When PrintDlg returns,
        /// the DEVMODEA members indicate the user's input. If hDevMode is null on input, PrintDlg
        /// allocates memory for the DEVMODE structure, initializes its members to indicate 
        /// the user's input, and returns a handle that identifies it. If the device driver for
        /// the specified printer does not support extended device modes, hDevMode is null when
        /// PrintDlg returns. If the device name (specified by the dmDeviceName member of the 
        /// DEVMODEA structure) does not appear in the [devices] section of WIN.INI, PrintDlg returns
        /// an error. 
        /// </summary>
        public IntPtr hDevMode;

        /// <summary>
        /// Handle to a movable global memory object that contains a DEVNAMES structure. If 
        /// hDevNames is not null on input, you must allocate a movable block of memory for the 
        /// DEVNAMES structure and initialize its members. The PrintDlg function uses the input
        /// data to initialize the controls in the dialog box. When PrintDlg returns, the DEVNAMES
        /// members contain information for the printer chosen by the user. You can use this 
        /// information to create a device context or an information context. The hDevNames member
        /// can be null, in which case, PrintDlg allocates memory for the DEVNAMES structure, 
        /// initializes its members to indicate the user's input, and returns a handle that 
        /// identifies it. 
        /// </summary>
        public IntPtr hDevNames;

        /// <summary>
        /// Handle to a device context or an information context, depending on whether the Flags 
        /// member specifies the PD_RETURNDC or PC_RETURNIC flag. If neither flag is specified, the
        /// value of this member is undefined. If both flags are specified, PD_RETURNDC has priority. 
        /// </summary>
        public IntPtr hDC;

        /// <summary>
        /// A set of bit flags that you can use to initialize the Print dialog box. When the dialog
        /// box returns, it sets these flags to indicate the user's input
        /// </summary>
        public PrinterSetup Flags;

        /// <summary>
        /// Specifies the initial value for the starting page edit control. 
        /// When PrintDlg returns, nFromPage is the starting page specified by the user. If the Pages
        /// radio button is selected when the user clicks the Okay button, PrintDlg sets the PD_PAGENUMS
        /// flag and does not return until the user enters a starting page value that is within the 
        /// minimum to maximum page range. 
        /// </summary>
        public ushort nFromPage;

        /// <summary>
        /// Specifies the initial value for the ending page edit control. When PrintDlg returns, 
        /// nToPage is the ending page specified by the user. If the Pages radio button is selected when
        /// the use clicks the Okay button, PrintDlg sets the PD_PAGENUMS flag and does not return until
        /// the user enters an ending page value that is within the minimum to maximum page range
        /// </summary>
        public ushort nToPage;

        /// <summary>
        /// Specifies the minimum value for the page range specified in the From and To page edit controls.
        /// If nMinPage equals nMaxPage, the Pages radio button and the starting and ending page edit
        /// controls are disabled
        /// </summary>
        public ushort nMinPage;

        /// <summary>
        /// Specifies the maximum value for the page range specified in the From and To page edit controls. 
        /// </summary>
        public ushort nMaxPage;

        /// <summary>
        /// Contains the initial number of copies for the Copies edit control if hDevMode is null; otherwise,
        /// the dmCopies member of the DEVMODE structure contains the initial value. When PrintDlg returns, 
        /// nCopies contains the actual number of copies to print. This value depends on whether the application
        /// or the printer driver is responsible for printing multiple copies. If the PrinterSetup.PD_USEDEVMODECOPIESANDCOLLATE
        /// flag is set in the Flags member, nCopies is always 1 on return, and the printer driver is 
        /// responsible for printing multiple copies. If the flag is not set, the application is responsible
        /// for printing the number of copies specified by nCopies. For more information, see the description of
        /// the PrinterSetup.PD_USEDEVMODECOPIESANDCOLLATE flag.
        /// </summary>
        public ushort nCopies;

        /// <summary>
        /// If the PD_ENABLEPRINTTEMPLATE or PD_ENABLESETUPTEMPLATE flag is set in the Flags member, hInstance is a
        /// handle to the application or module instance that contains the dialog box template named by the 
        /// lpPrintTemplateName or lpSetupTemplateName member. 
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// Specifies application-defined data that the system passes to the hook procedure identified by the lpfnPrintHook or 
        /// lpfnSetupHook member. When the system sends the WM_INITDIALOG message to the hook procedure, the message's lParam
        /// parameter is a pointer to the PRINTDLG structure specified when the dialog was created. The hook procedure can use
        /// this pointer to get the lCustData value.
        /// </summary>
        public int lCustData;

        /// <summary>
        /// Pointer to a PrintHookProc hook procedure that can process messages intended for the Print dialog box. This member
        /// is ignored unless the PD_ENABLEPRINTHOOK flag is set in the Flags member
        /// </summary>
        public LpPrintHookProc lpfnPrintHook;

        /// <summary>
        /// Pointer to a SetupHookProc hook procedure that can process messages intended for the Print Setup dialog box. 
        /// This member is ignored unless the PD_ENABLESETUPHOOK flag is set in the Flags member
        /// </summary>
        public LpSetupHookProc lpfnSetupHook;

        /// <summary>
        /// Pointer to a null-terminated string that names a dialog box template resource in the module identified by 
        /// the hInstance member. This template replaces the default Print dialog box template. This member is ignored
        /// unless the PD_ENABLEPRINTTEMPLATE flag is set in the Flags member
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpPrintTemplateName;

        /// <summary>
        /// Pointer to a null-terminated string that names a dialog box template resource in the module identified by
        /// the hInstance member. This template replaces the default Print Setup dialog box template. This member is
        /// ignored unless the PD_ENABLESETUPTEMPLATE flag is set in the Flags member
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpSetupTemplateName;

        /// <summary>
        /// If the PD_ENABLEPRINTTEMPLATEHANDLE flag is set in the Flags member, hPrintTemplate is a handle to a memory
        /// object containing a dialog box template. This template replaces the default Print dialog box template
        /// </summary>
        public IntPtr hPrintTemplate;

        /// <summary>
        /// If the PD_ENABLESETUPTEMPLATEHANDLE flag is set in the Flags member, hSetupTemplate is a handle to a 
        /// memory object containing a dialog box template. This template replaces the default Print Setup dialog
        /// box template
        /// </summary>
        public IntPtr hSetupTemplate;
    }
}