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
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The PRINTDLGEXA structure contains information that the PrintDlgEx function uses to
    /// initialize the Print property sheet. After the user closes the property sheet, the
    /// system uses this structure to return information about the user's selections.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PrintDlgExA
    {
        /// <summary>
        /// Specifies the structure size, in bytes
        /// </summary>
        public uint lStructSize;

        /// <summary>
        /// Handle to the window that owns the property sheet.
        /// This member must be a valid window handle; it cannot be null. 
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// Handle to a movable global memory object that contains a DEVMODE structure. If hDevMode is not
        /// null on input, you must allocate a movable block of memory for the DEVMODE structure and 
        /// initialize its members. The PrintDlgEx function uses the input data to initialize the controls
        /// in the property sheet. When PrintDlgEx returns, the DEVMODE members indicate the user's input.
        /// If hDevMode is null on input, PrintDlgEx allocates memory for the DEVMODE structure, initializes
        /// its members to indicate the user's input, and returns a handle that identifies it. 
        /// </summary>
        public IntPtr hDevMode;

        /// <summary>
        /// Handle to a movable global memory object that contains a DEVNAMES structure. If hDevNames is not
        /// null on input, you must allocate a movable block of memory for the DEVNAMES structure and 
        /// initialize its members. The PrintDlgEx function uses the input datato initialize the controls
        /// in the property sheet. When PrintDlgEx returns, the DEVNAMES members contain information for the
        /// printer chosen by the user. You can use this information to create a device context or an 
        /// information context.
        /// The hDevNames member can be null, in which case, PrintDlgEx allocates memory for the DEVNAMES 
        /// structure, initializes its members to indicate the user's input, and returns a handle that 
        /// identifies it.
        /// </summary>
        public IntPtr hDevNames;

        /// <summary>
        /// Handle to a device context or an information context, depending on whether the Flags member 
        /// specifies the PD_RETURNDC or PC_RETURNIC flag. If neither flag is specified, the value of this
        /// member is undefined. If both flags are specified, PD_RETURNDC has priority. 
        /// </summary>
        public IntPtr hDC;

        /// <summary>
        /// A set of bit flags that you can use to initialize the Print property sheet. When the 
        /// PrintDlgEx function returns, it sets these flags to indicate the user's input.
        /// </summary>
        public PrinterSetup Flags;

        /// <summary>
        /// Reserved. Must be set to 0.
        /// </summary>
        public uint Flags2;

        /// <summary>
        /// A set of bit flags that can exclude items from the printer driver property pages in the Print 
        /// property sheet. This value is used only if the PD_EXCLUSIONFLAGS flag is set in the Flags member.
        /// Exclusion flags should be used only if the item to be excluded will be included on either the 
        /// General page or on an application-defined page in the Print property sheet. This member can specify
        /// the following flag. 
        /// <para>PD_EXCL_COPIESANDCOLLATE = InitializationFlag.DM_COPIES | InitializationFlag.DM_COLLATE</para>
        /// Excludes the Copies and Collate controls from the printer driver property pages in a Print property
        /// sheet. This flag should always be set when the application uses the default Copies and Collate 
        /// controls provided by the lower portion of the General page of the Print property sheet.
        /// </summary>
        public uint ExclusionFlags;

        /// <summary>
        /// On input, set this member to the initial number of page ranges specified in the lpPageRanges array.
        /// When the PrintDlgEx function returns, nPageRanges indicates the number of user-specified page ranges
        /// stored in the lpPageRanges array. If the PD_NOPAGENUMS flag is specified, this value is not valid.
        /// </summary>
        public uint nPageRanges;

        /// <summary>
        /// Specifies the size, in array elements, of the lpPageRanges buffer. This value indicates the maximum 
        /// number of page ranges that can be stored in the array. If the PD_NOPAGENUMS flag is specified, this
        /// value is not valid. If the PD_NOPAGENUMS flag is not specified, this value must be greater than zero.
        /// </summary>
        public uint nMaxPageRanges;

        /// <summary>
        /// Pointer to a buffer containing an array of PRINTPAGERANGE structures. On input, the array contains the
        /// initial page ranges to display in the Pages edit control. When the PrintDlgEx function returns, the 
        /// array contains the page ranges specified by the user. If the PD_NOPAGENUMS flag is specified, this value
        /// is not valid. If the PD_NOPAGENUMS flag is not specified, lpPageRanges must be non-null. 
        /// </summary>
        public IntPtr lpPageRanges;

        /// <summary>
        /// Specifies the minimum value for the page ranges specified in the Pages edit control.
        /// If the PD_NOPAGENUMS flag is specified, this value is not valid. 
        /// </summary>
        public uint nMinPage;

        /// <summary>
        /// Specifies the maximum value for the page ranges specified in the Pages edit control. 
        /// If the PD_NOPAGENUMS flag is specified, this value is not valid
        /// </summary>
        public uint nMaxPage;

        /// <summary>
        /// Contains the initial number of copies for the Copies edit control if hDevMode is null; 
        /// otherwise, the dmCopies member of the DEVMODE structure contains the initial value. 
        /// When PrintDlgEx returns, nCopies contains the actual number of copies the application must
        /// print. This value depends on whether the application or the printer driver is responsible 
        /// for printing multiple copies. If the PD_USEDEVMODECOPIESANDCOLLATE flag is set in the Flags
        /// member, nCopies is always 1 on return, and the printer driver is responsible for printing 
        /// multiple copies. If the flag is not set, the application is responsible for printing the 
        /// number of copies specified by nCopies
        /// </summary>
        public uint nCopies;

        /// <summary>
        /// If the PD_ENABLEPRINTTEMPLATE flag is set in the Flags member, hInstance is a handle to the 
        /// application or module instance that contains the dialog box template named by the lpPrintTemplateName
        /// member. If the PD_ENABLEPRINTTEMPLATEHANDLE flag is set in the Flags member, hInstance is a handle to
        /// a memory object containing a dialog box template. If neither of the template flags is set in the Flags
        /// member, hInstance should be null
        /// </summary>
        public IntPtr hInstance;

        /// <summary>
        /// Pointer to a null-terminated string that names a dialog box template resource in the module identified
        /// by the hInstance member. This template replaces the default dialog box template in the lower portion of
        /// the General page. The default template contains controls similar to those of the Print dialog box. This
        /// member is ignored unless the PD_ENABLEPRINTTEMPLATE flag is set in the Flags member
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public string lpPrintTemplateName;

        /// <summary>
        /// Pointer to an application-defined callback object. 
        /// The object should contain the IPrintDialogCallback class to receive messages for the child dialog box in
        /// the lower portion of the General page. 
        /// The callback object should also contain the IObjectWithSite class to receive a pointer to the 
        /// IPrintDialogServices interface. The PrintDlgEx function calls IUnknown::QueryInterface on the callback object
        /// for both IID_IPrintDialogCallback and IID_IObjectWithSite to determine which interfaces are supported. 
        /// If you do not want to retrieve any of the callback information, set lpCallback to null
        /// </summary>
        public IntPtr lpCallback;

        /// <summary>
        /// Specifies the number of property page handles in the lphPropertyPages array
        /// </summary>
        public uint nPropertyPages;

        /// <summary>
        /// Contains an array of property page handles to add to the Print property sheet. The additional property pages 
        /// follow the General page. Use the CreatePropertySheetPage function to create these additional pages. When the
        /// PrintDlgEx function returns, all the HPROPSHEETPAGE handles in the lphPropertyPages array have been destroyed.
        /// If nPropertyPages is zero, lphPropertyPages should be null
        /// </summary>
        public IntPtr lphPropertyPages;

        /// <summary>
        /// Specifies the property page that is initially displayed. To display the General page, specify 
        /// START_PAGE_GENERAL. Otherwise, specify the zero-based index of a property page in the array specified in the 
        /// lphPropertyPages member. For consistency, it is recommended that the property sheet always be started on the 
        /// General page
        /// </summary>
        public uint nStartPage;

        /// <summary>
        /// On input, set this member to zero. If the PrintDlgEx function returns S_OK, dwResultAction contains the outcome 
        /// of the dialog. If PrintDlgEx returns an error, this member should be ignored. 
        /// </summary>
        public PrintResultAction dwResultAction;
    }
}