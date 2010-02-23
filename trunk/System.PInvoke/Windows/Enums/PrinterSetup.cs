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
    /// Used to initialize the Print dialog box
    /// </summary>
    [Flags]
    public enum PrinterSetup : uint
    {
        /// <summary>
        /// The default flag that indicates that the All radio button
        /// is initially selected. This flag is used as a placeholder 
        /// to indicate that the PD_PAGENUMS and PD_SELECTION flags are
        /// not specified. 
        /// </summary>
        PD_ALLPAGES = 0,
        /// <summary>
        /// If this flag is set, the Collate check box is selected. If this flag 
        /// is set when the PrintDlg function returns, the application must simulate
        /// collation of multiple copies. For more information, see the description of the
        /// PD_USEDEVMODECOPIESANDCOLLATE flag.
        /// </summary>
        PD_COLLATE = 16,
        /// <summary>
        /// Disables the Print to File check box.
        /// </summary>
        PD_DISABLEPRINTTOFILE = 524288,
        /// <summary>
        /// Enables the hook procedure specified in the lpfnPrintHook member of PRINTDLG structure. 
        /// This enables the hook procedure for the Print dialog box.
        /// </summary>
        PD_ENABLEPRINTHOOK = 4096,
        /// <summary>
        /// Indicates that the hInstance and lpPrintTemplateName members of PRINTDLG specify a replacement 
        /// for the default Print dialog box template.
        /// </summary>
        PD_ENABLEPRINTTEMPLATE = 16384,
        /// <summary>
        /// Indicates that the hPrintTemplate member of PRINTDLG identifies a data block that 
        /// contains a preloaded dialog box template. This template replaces the default template
        /// for the Print dialog box. The system ignores the lpPrintTemplateName member of PRINTDLG
        /// if this flag is specified. 
        /// </summary>
        PD_ENABLEPRINTTEMPLATEHANDLE = 65536,
        /// <summary>
        /// Enables the hook procedure specified in the lpfnSetupHook of PRINTDLG member. This enables
        /// the hook procedure for the Print Setup dialog box.
        /// </summary>
        PD_ENABLESETUPHOOK = 8192,
        /// <summary>
        /// Indicates that the hInstance and lpSetupTemplateName members of PRINTDLG specify a 
        /// replacement for the default Print Setup dialog box template.
        /// </summary>
        PD_ENABLESETUPTEMPLATE = 32768,
        /// <summary>
        /// Indicates that the hSetupTemplate member of PRINTDLG identifies a data block that 
        /// contains a preloaded dialog box template. This template replaces the default template
        /// for the Print Setup dialog box. The system ignores the lpSetupTemplateName member of
        /// PRINTDLG if this flag is specified.
        /// </summary>
        PD_ENABLESETUPTEMPLATEHANDLE = 131072,
        /// <summary>
        /// Hides the Print to File check box.
        /// </summary>
        PD_HIDEPRINTTOFILE = 1048576,
        /// <summary>
        /// Hides and disables the Network button.
        /// </summary>
        PD_NONETWORKBUTTON = 2097152,
        /// <summary>
        /// Disables the Pages radio button and the associated edit controls. Also, 
        /// it causes the Collate check box to appear in the dialog.
        /// </summary>
        PD_NOPAGENUMS = 8,
        /// <summary>
        /// Disables the Selection radio button.
        /// </summary>
        PD_NOSELECTION = 4,
        /// <summary>
        /// Prevents the warning message from being displayed when there is no default printer.
        /// </summary>
        PD_NOWARNING = 128,
        /// <summary>
        /// If this flag is set, the Pages radio button is selected. If this flag is set when the 
        /// PrintDlg function returns, the nFromPage and nToPage members of PRINTDLG indicate the starting and
        /// ending pages specified by the user.
        /// </summary>
        PD_PAGENUMS = 2,
        /// <summary>
        /// Causes the system to display the Print Setup dialog box rather than the Print dialog box.
        /// </summary>
        PD_PRINTSETUP = 64,
        /// <summary>
        /// If this flag is set, the Print to File check box is selected. If this flag is set when
        /// the PrintDlg function returns, the offset indicated by the wOutputOffset member of the 
        /// DEVNAMES structure contains the string "FILE:". When you call the StartDoc function to 
        /// start the printing operation, specify this "FILE:" string in the lpszOutput member of 
        /// the DOCINFO structure. Specifying this string causes the print subsystem to query the 
        /// user for the name of the output file. 
        /// </summary>
        PD_PRINTTOFILE = 32,
        /// <summary>
        /// Causes PrintDlg to return a device context matching the selections the user made in 
        /// the dialog box. The device context is returned in hDC of PRINTDLG.
        /// </summary>
        PD_RETURNDC = 256,
        /// <summary>
        /// If this flag is set, the PrintDlg function does not display the dialog box. Instead,
        /// it sets the hDevNames and hDevMode members of PRINTDLG to handles to DEVMODE and 
        /// DEVNAMES structures that are initialized for the system default printer. Both hDevNames
        /// and hDevMode of PRINTDLG must be null, or PrintDlg returns an error. 
        /// </summary>
        PD_RETURNDEFAULT = 1024,
        /// <summary>
        /// Similar to the PD_RETURNDC flag, except this flag returns an information context rather
        /// than a device context. If neither PD_RETURNDC nor PD_RETURNIC is specified, hDC of PRINTDLG
        /// is undefined on output.
        /// </summary>
        PD_RETURNIC = 512,
        /// <summary>
        /// If this flag is set, the Selection radio button is selected. If neither PD_PAGENUMS nor 
        /// PD_SELECTION is set, the All radio button is selected
        /// </summary>
        PD_SELECTION = 1,
        /// <summary>
        /// Causes the dialog box to display the Help button. The hwndOwner member of PRINTDLG must specify the
        /// window to receive the HELPMSGSTRING registered messages that the dialog box sends when 
        /// the user clicks the Help button.
        /// </summary>
        PD_SHOWHELP = 2048,
        /// <summary>
        /// Same as PD_USEDEVMODECOPIESANDCOLLATE
        /// </summary>
        PD_USEDEVMODECOPIES = 262144,
        /// <summary>
        /// This flag indicates whether your application supports multiple copies and collation. Set this flag on
        /// input to indicate that your application does not support multiple copies and collation. In this case,
        /// the nCopies member of the PRINTDLG structure always returns 1, and PD_COLLATE is never set in the Flags member. 
        /// If this flag is not set, the application is responsible for printing and collating multiple copies. 
        /// In this case, the nCopies member of the PRINTDLG structure indicates the number of copies the user 
        /// wants to print, and the PD_COLLATE flag in the Flags member indicates whether the user wants collation. 
        /// Regardless of whether this flag is set, an application can determine from nCopies and PD_COLLATE how many
        /// copies to render and whether to print them collated.
        /// If this flag is set and the printer driver does not support multiple copies, the Copies edit control is
        /// disabled. Similarly, if this flag is set and the printer driver does not support collation, the Collate 
        /// check box is disabled.
        /// The dmCopies and dmCollate members of the DEVMODE structure contain the copies and collate information 
        /// used by the printer driver. If this flag is set and the printer driver supports multiple copies, the 
        /// dmCopies member indicates the number of copies requested by the user. If this flag is set and the printer
        /// driver supports collation, the dmCollate member of the DEVMODE structure indicates whether the user wants
        /// collation. If this flag is not set, the dmCopies member always returns 1, and the dmCollate member is 
        /// always zero.
        /// </summary>
        PD_USEDEVMODECOPIESANDCOLLATE = 262144
    }
}