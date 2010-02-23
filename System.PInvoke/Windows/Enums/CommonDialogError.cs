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
    /// Error codes for any of the common dialog box functions,
    /// some them are specific for specific function.
    /// </summary>
    [Flags]
    public enum CommonDialogError : uint
    {
        /************************************************************************/
        /******************** GENERAL ERROR CODES *******************************/
        /************************************************************************/

        /// <summary>
        /// The dialog box could not be created. The common dialog box function's
        /// call to the DialogBox function failed. For example, this error occurs
        /// if the common dialog box call specifies an invalid window handle.
        /// </summary>
        CDERR_DIALOGFAILURE = 65535,
        /// <summary>
        /// The common dialog box function failed to find a specified resource.
        /// </summary>
        CDERR_FINDRESFAILURE = 6,
        /// <summary>
        /// The common dialog box function failed during initialization. 
        /// This error often occurs when sufficient memory is not available.
        /// </summary>
        CDERR_INITIALIZATION = 2,
        /// <summary>
        /// The common dialog box function failed to load a specified resource.
        /// </summary>
        CDERR_LOADRESFAILURE = 7,
        /// <summary>
        /// The common dialog box function failed to load a specified string.
        /// </summary>
        CDERR_LOADSTRFAILURE = 5,
        /// <summary>
        /// The common dialog box function failed to lock a specified resource.
        /// </summary>
        CDERR_LOCKRESFAILURE = 8,
        /// <summary>
        /// The common dialog box function was unable to allocate memory for internal structures.
        /// </summary>
        CDERR_MEMALLOCFAILURE = 9,
        /// <summary>
        /// The common dialog box function was unable to lock the memory associated with a handle.
        /// </summary>
        CDERR_MEMLOCKFAILURE = 10,
        /// <summary>
        /// The ENABLETEMPLATE flag was set in the Flags member of the initialization structure for
        /// the corresponding common dialog box, but you failed to provide a corresponding instance handle.
        /// </summary>
        CDERR_NOHINSTANCE = 4,
        /// <summary>
        /// The ENABLEHOOK flag was set in the Flags member of the initialization structure for the 
        /// corresponding common dialog box, but you failed to provide a pointer to a corresponding
        /// hook procedure.
        /// </summary>
        CDERR_NOHOOK = 11,
        /// <summary>
        /// The ENABLETEMPLATE flag was set in the Flags member of the initialization structure for
        /// the corresponding common dialog box, but you failed to provide a corresponding template.
        /// </summary>
        CDERR_NOTEMPLATE = 3,
        /// <summary>
        /// The RegisterWindowMessage function returned an error code when it was called by the common
        /// dialog box function.
        /// </summary>
        CDERR_REGISTERMSGFAIL = 12,
        /// <summary>
        /// The lStructSize member of the initialization structure for the corresponding common dialog
        /// box is invalid.
        /// </summary>
        CDERR_STRUCTSIZE = 1,


        /************************************************************************/
        /***************** PRINT DIALOG ERROR CODES *****************************/
        /************************************************************************/

        /// <summary>
        /// The PrintDlg function failed when it attempted to create an information context.
        /// </summary>
        PDERR_CREATEICFAILURE = 4106,
        /// <summary>
        /// You called the PrintDlg function with the DN_DEFAULTPRN flag specified in the 
        /// wDefault member of the DEVNAMES structure, but the printer described by the other
        /// structure members did not match the current default printer. (This error occurs when
        /// you store the DEVNAMES structure and the user changes the default printer by using
        /// the Control Panel.)
        /// To use the printer described by the DEVNAMES structure, clear the DN_DEFAULTPRN
        /// flag and call PrintDlg again. 
        /// To use the default printer, replace the DEVNAMES structure (and the structure, 
        /// if one exists) with null; and call PrintDlg again.
        /// </summary>
        PDERR_DEFAULTDIFFERENT = 4108,
        /// <summary>
        /// The data in the DEVMODE and DEVNAMES structures describes two different printers.
        /// </summary>
        PDERR_DNDMMISMATCH = 4105,
        /// <summary>
        /// The printer driver failed to initialize a DEVMODE structure. 
        /// </summary>
        PDERR_GETDEVMODEFAIL = 4101,
        /// <summary>
        /// The PrintDlg function failed during initialization, and there is no more specific
        /// extended error code to describe the failure. This is the generic default error code
        /// for the function.
        /// </summary>
        PDERR_INITFAILURE = 4102,
        /// <summary>
        /// The PrintDlg function failed to load the device driver for the specified printer.
        /// </summary>
        PDERR_LOADDRVFAILURE = 4100,
        /// <summary>
        /// A default printer does not exist.
        /// </summary>
        PDERR_NODEFAULTPRN = 4104,
        /// <summary>
        /// No printer drivers were found.
        /// </summary>
        PDERR_NODEVICES = 4103,
        /// <summary>
        /// The PrintDlg function failed to parse the strings in the [devices] section of the WIN.INI file.
        /// </summary>
        PDERR_PARSEFAILURE = 4098,
        /// <summary>
        /// The [devices] section of the WIN.INI file did not contain an entry for the requested printer.
        /// </summary>
        PDERR_PRINTERNOTFOUND = 4107,
        /// <summary>
        /// The PD_RETURNDEFAULT flag was specified in the Flags member of the PRINTDLG structure, but
        /// the hDevMode or hDevNames member was not null.
        /// </summary>
        PDERR_RETDEFFAILURE = 4099,
        /// <summary>
        /// The PrintDlg function failed to load the required resources.
        /// </summary>
        PDERR_SETUPFAILURE = 4097,


        /************************************************************************/
        /****************** FONT DIALOG ERROR CODES *****************************/
        /************************************************************************/

        /// <summary>
        /// The size specified in the nSizeMax member of the CHOOSEFONT structure is less than the size
        /// specified in the nSizeMin member.
        /// </summary>
        CFERR_MAXLESSTHANMIN = 8194,
        /// <summary>
        /// No fonts exist.
        /// </summary>
        CFERR_NOFONTS = 8193,


        /************************************************************************/
        /****************** FILE DIALOG ERROR CODES *****************************/
        /************************************************************************/

        /// <summary>
        /// The buffer pointed to by the lpstrFile member of the OPENFILENAME structure is too small
        /// for the file name specified by the user. The first two bytes of the lpstrFile buffer contain
        /// an integer value specifying the size, in TCHARs, required to receive the full name. 
        /// </summary>
        FNERR_BUFFERTOOSMALL = 12291,
        /// <summary>
        /// A file name is invalid.
        /// </summary>
        FNERR_INVALIDFILENAME = 12290,
        /// <summary>
        /// An attempt to subclass a list box failed because sufficient memory was not available.
        /// </summary>
        FNERR_SUBCLASSFAILURE = 12289,


        /************************************************************************/
        /************ FIND & REPLACE TEXT DIALOG ERROR CODES ********************/
        /************************************************************************/

        /// <summary>
        /// A member of the FINDREPLACE structure points to an invalid buffer. 
        /// </summary>
        FRERR_BUFFERLENGTHZERO = 16385
    }
}