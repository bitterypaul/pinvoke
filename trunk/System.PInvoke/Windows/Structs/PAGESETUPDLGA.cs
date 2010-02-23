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
    /// The PAGESETUPDLGA structure contains information the PageSetupDlgA function uses
    /// to initialize the Page Setup dialog box. After the user closes the dialog box, the
    /// system returns information about the user-defined page parameters in this structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PageSetupDlgA
    {
        /// <summary>
        /// Specifies the size, in bytes, of this structure.
        /// </summary>
        public uint lStructSize;

        /// <summary>
        /// Handle to the window that owns the dialog box. This member can be any valid 
        /// window handle, or it can be null if the dialog box has no owner.
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// Handle to a global memory object that contains a DEVMODEA structure. On input,
        /// if a handle is specified, the values in the corresponding DEVMODEA structure are
        /// used to initialize the controls in the dialog box. On output, the dialog box sets
        /// hDevMode to a global memory handle to a DEVMODEA structure that contains values 
        /// specifying the user's selections. If the user's selections are not available, 
        /// the dialog box sets hDevMode to null. 
        /// </summary>
        public IntPtr hDevMode;

        /// <summary>
        /// Handle to a global memory object that contains a DEVNAMES structure. This structure
        /// contains three strings that specify the driver name, the printer name, and the 
        /// output port name. On input, if a handle is specified, the strings in the corresponding
        /// DEVNAMES structure are used to initialize controls in the dialog box. On output, the 
        /// dialog box sets hDevNames to a global memory handle to a DEVNAMES structure that 
        /// contains strings specifying the user's selections. If the user's selections are not 
        /// available, the dialog box sets hDevNames to null. 
        /// </summary>
        public IntPtr hDevNames;

        /// <summary>
        /// A set of bit flags that you can use to initialize the Page Setup dialog box. When the
        /// dialog box returns, it sets these flags to indicate the user's input.
        /// </summary>
        public PageSetup Flags;

        /// <summary>
        /// Specifies the dimensions of the paper selected by the user. The PSD_INTHOUSANDTHSOFINCHES
        /// or PSD_INHUNDREDTHSOFMILLIMETERS flag indicates the units of measurement.
        /// </summary>
        public Point ptPaperSize;

        /// <summary>
        /// Specifies the minimum allowable widths for the left, top, right, and bottom margins. The 
        /// system ignores this member if the PSD_MINMARGINS flag is not set. These values must be 
        /// less than or equal to the values specified in the rtMargin member. The PSD_INTHOUSANDTHSOFINCHES
        /// or PSD_INHUNDREDTHSOFMILLIMETERS flag indicates the units of measurement. 
        /// </summary>
        public Rect rtMinMargin;

        /// <summary>
        /// Specifies the widths of the left, top, right, and bottom margins. If you set the PSD_MARGINS flag,
        /// rtMargin specifies the initial margin values. When PageSetupDlg returns, rtMargin contains the 
        /// margin widths selected by the user. The PSD_INHUNDREDTHSOFMILLIMETERS or PSD_INTHOUSANDTHSOFINCHES
        /// flag indicates the units of measurement. 
        /// </summary>
        public Rect rtMargin;

        /// <summary>
        /// If the PSD_ENABLEPAGESETUPTEMPLATE flag is set in the Flags member, hInstance is a handle to the 
        /// application or module instance that contains the dialog box template named by the lpPageSetupTemplateName member. 
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// Specifies application-defined data that the system passes to the hook procedure identified by the 
        /// lpfnPageSetupHook member. When the system sends the WM_INITDIALOG message to the hook procedure,
        /// the message's lParam parameter is a pointer to the PAGESETUPDLG structure specified when the dialog
        /// was created. The hook procedure can use this pointer to get the lCustData value. 
        /// </summary>
        public int lCustData;

        /// <summary>
        /// Pointer to a PageSetupHook hook procedure that can process messages intended for the dialog box.
        /// This member is ignored unless the PSD_ENABLEPAGESETUPHOOK flag is set in the Flags member. 
        /// </summary>
        public LpPageSetupHook lpfnPageSetupHook;

        /// <summary>
        /// Pointer to a PagePaintHook hook procedure that receives WM_PSD_* messages from the dialog box 
        /// whenever the sample page is redrawn. By processing the messages, the hook procedure can customize
        /// the appearance of the sample page. This member is ignored unless the PSD_ENABLEPAGEPAINTHOOK flag
        /// is set in the Flags member. 
        /// </summary>
        public LpPagePaintHook lpfnPagePaintHook;

        /// <summary>
        /// Pointer to a null-terminated string that names the dialog box template resource in the module 
        /// identified by the hInstance member. This template is substituted for the standard dialog box 
        /// template. This member is ignored unless the PSD_ENABLEPAGESETUPTEMPLATE flag is set in the Flags
        /// member. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpPageSetupTemplateName;

        /// <summary>
        /// If the PSD_ENABLEPAGESETUPTEMPLATEHANDLE flag is set in the Flags member, hPageSetupTemplate is a
        /// handle to a memory object containing a dialog box template. 
        /// </summary>
        public IntPtr hPageSetupTemplate;
    }
}