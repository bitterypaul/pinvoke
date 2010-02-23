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
    /// Used to initialize the Page Setup dialog box
    /// </summary>
    [Flags]
    public enum PageSetup : uint
    {
        /// <summary>
        /// Sets the minimum values that the user can specify for the page
        /// margins to be the minimum margins allowed by the printer. This 
        /// is the default. This flag is ignored if the PSD_MARGINS and PSD_MINMARGINS
        /// flags are also specified.
        /// </summary>
        PSD_DEFAULTMINMARGINS = 0,
        /// <summary>
        /// Disables the margin controls, preventing the user from setting the margins.
        /// </summary>
        PSD_DISABLEMARGINS = 16,
        /// <summary>
        /// Disables the orientation controls, preventing the user from setting the page orientation.
        /// </summary>
        PSD_DISABLEORIENTATION = 256,
        /// <summary>
        /// Prevents the dialog box from drawing the contents of the sample page. If you enable a 
        /// PagePaintHook hook procedure, you can still draw the contents of the sample page.
        /// </summary>
        PSD_DISABLEPAGEPAINTING = 524288,
        /// <summary>
        /// Disables the paper controls, preventing the user from setting page 
        /// parameters such as the paper size and source.
        /// </summary>
        PSD_DISABLEPAPER = 512,
        /// <summary>
        /// Obsolete. 
        /// Microsoft Windows XP and earlier: Disables the Printer button, preventing the user 
        /// from invoking a dialog box that contains additional printer setup information.
        /// </summary>
        PSD_DISABLEPRINTER = 32,
        /// <summary>
        /// Enables the hook procedure specified in the lpfnPagePaintHook member.
        /// </summary>
        PSD_ENABLEPAGEPAINTHOOK = 262144,
        /// <summary>
        /// Enables the hook procedure specified in the lpfnPageSetupHook member.
        /// </summary>
        PSD_ENABLEPAGESETUPHOOK = 8192,
        /// <summary>
        /// Indicates that the hInstance and lpPageSetupTemplateName members of PAGESETUPDLG structure 
        /// specify a dialog box template to use in place of the default template.
        /// </summary>
        PSD_ENABLEPAGESETUPTEMPLATE = 32768,
        /// <summary>
        /// Indicates that the hPageSetupTemplate member of PAGESETUPDLG structure identifies a data
        /// block that contains a preloaded dialog box template. The system ignores the 
        /// lpPageSetupTemplateName member of PAGESETUPDLG structure if this flag is specified. 
        /// </summary>
        PSD_ENABLEPAGESETUPTEMPLATEHANDLE = 131072,
        /// <summary>
        /// Indicates that hundredths of millimeters are the unit of measurement for margins and 
        /// paper size. The values in the rtMargin, rtMinMargin, and ptPaperSize of PAGESETUPDLG 
        /// structure members are in hundredths of millimeters. You can set this flag on input to
        /// override the default unit of measurement for the user's locale. When the function returns,
        /// the dialog box sets this flag to indicate the units used.
        /// </summary>
        PSD_INHUNDREDTHSOFMILLIMETERS = 8,
        /// <summary>
        /// Indicates that thousandths of inches are the unit of measurement for margins and paper 
        /// size. The values in the rtMargin, rtMinMargin, and ptPaperSize members are in thousandths
        /// of inches. You can set this flag on input to override the default unit of measurement for
        /// the user's locale. When the function returns, the dialog box sets this flag to indicate the
        /// units used.
        /// </summary>
        PSD_INTHOUSANDTHSOFINCHES = 4,
        /// <summary>
        /// Reserved.
        /// </summary>
        PSD_INWININIINTLMEASURE = 0,
        /// <summary>
        /// Causes the system to use the values specified in the rtMargin member of PAGESETUPDLG as the initial widths
        /// for the left, top, right, and bottom margins. If PSD_MARGINS is not set, the system sets 
        /// the initial widths to one inch for all margins. 
        /// </summary>
        PSD_MARGINS = 2,
        /// <summary>
        /// Causes the system to use the values specified in the rtMinMargin member of PAGESETUPDLG as the minimum 
        /// allowable widths for the left, top, right, and bottom margins. The system prevents the user
        /// from entering a width that is less than the specified minimum. If PSD_MINMARGINS is not 
        /// specified, the system sets the minimum allowable widths to those allowed by the printer. 
        /// </summary>
        PSD_MINMARGINS = 1,
        /// <summary>
        /// Hides and disables the Network button.
        /// </summary>
        PSD_NONETWORKBUTTON = 2097152,
        /// <summary>
        /// Prevents the system from displaying a warning message when there is no default printer.
        /// </summary>
        PSD_NOWARNING = 128,
        /// <summary>
        /// PageSetupDlg does not display the dialog box. Instead, it sets the hDevNames and hDevMode
        /// members of PAGESETUPDLG to handles to DEVMODE and DEVNAMES structures that are initialized
        /// for the system default printer. PageSetupDlg returns an error if either hDevNames or hDevMode
        /// is not null.
        /// </summary>
        PSD_RETURNDEFAULT = 1024,
        /// <summary>
        /// Causes the dialog box to display the Help button. The hwndOwner member of PAGESETUPDLG must 
        /// specify the window to receive the HELPMSGSTRING registered messages that the dialog box sends
        /// when the user clicks the Help button.
        /// </summary>
        PSD_SHOWHELP = 2048
    }
}