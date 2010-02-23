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
using System.Text;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The DSBROWSEINFO structure is used with the DsBrowseForContainer function to supply 
    /// and return data about the Active Directory container browser dialog box.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct DSBrowseInfo
    {
        /// <summary>
        /// Contains the size, in bytes, of the DSBROWSEINFO structure.
        /// This is used by the DsBrowseForContainer function for versioning purposes.
        /// </summary>
        public uint cbStruct;

        /// <summary>
        /// Handle of the window used as the parent of the container browser dialog box.
        /// </summary>
        public IntPtr hwndOwner;

        /// <summary>
        /// Pointer to a null-terminated string that contains the caption of the dialog box.
        /// If this member is null, a default caption is used.
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public String pszCaption;

        /// <summary>
        /// Pointer to a null-terminated string that contains additional text to be displayed
        /// in the dialog box above the tree control. If this member is null, no additional 
        /// text is displayed.
        /// </summary>
        [MarshalAs(UnmanagedType.LPStr)] public String pszTitle;

        /// <summary>
        /// Pointer to a null-terminated Unicode string that contains the ADsPath of the 
        /// container placed at the root of the dialog box. The user cannot navigate above 
        /// this level using the dialog box.
        /// </summary>
        public String pszRoot;

        /// <summary>
        /// Pointer to a null-terminated Unicode string that receives the ADsPath of the container
        /// selected in the dialog. This string will always be null-terminated even if cchPath is 
        /// not large enough to hold the entire path. If dwFlags contains the DSBI_EXPANDONOPEN flag, 
        /// this member contains the ADsPath of the container that should be initially selected in 
        /// the dialog box.
        /// </summary>
        public StringBuilder pszPath;

        /// <summary>
        /// Contains the size, in WCHAR characters, of the pszPath buffer.
        /// </summary>
        public ulong cchPath;

        /// <summary>
        /// Contains a set of flags that define the behavior of the dialog box.
        /// This can be zero or a combination of one or more of the following values.
        /// </summary>
        public DialogBoxBehavior dwFlags;

        /// <summary>
        /// Pointer to an application-defined BFFCallBack callback function that 
        /// receives notifications from the container browser dialog box. Set this member to null if it is not used.
        /// </summary>
        [MarshalAs(UnmanagedType.FunctionPtr)] public BFFCallBack pfnCallback;

        /// <summary>
        /// Contains an application-defined 32-bit value passed as the lpData parameter in all calls to pfnCallback.
        /// This member is ignored if pfnCallback is null.
        /// </summary>
        public IntPtr lParam;

        /// <summary>
        /// Contains one of the ADS_FORMAT enumeration values that specifies the format that 
        /// the ADSI path returned in pszPath will accept.
        /// </summary>
        public PathValueType dwReturnFormat;

        /// <summary>
        /// Pointer to a Unicode string that contains the user name used for the credentials. 
        /// This member is ignored if dwFlags does not have the DSBI_HASCREDENTIALS flag set. 
        /// If this member is null, the currently logged on user name is used.
        /// </summary>
        public String pUserName;

        /// <summary>
        /// Pointer to a Unicode string that contains the password used for 
        /// the credentials. This member is ignored if dwFlags does not have 
        /// the DSBI_HASCREDENTIALS flag set. If this member is null, the 
        /// password of the currently logged on user is used.
        /// </summary>
        public String pPassword;

        /// <summary>
        /// Pointer to a Unicode string buffer that receives the class string 
        /// of the selected. This member is ignored if dwFlags of DSBROWSEINFO structure does not have the 
        /// DSBI_RETURNOBJECTCLASS flag set.
        /// </summary>
        public StringBuilder pszObjectClass;

        /// <summary>
        /// Contains the size, in WCHAR characters, of the pszObjectClass buffer of DSBROWSEINFO structure.
        /// </summary>
        public ulong cchObjectClass;
    }
}