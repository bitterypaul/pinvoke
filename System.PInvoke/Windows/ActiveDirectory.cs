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

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signature of DsBrowseForContainer API
    /// </summary>
    public class ActiveDirectory
    {
        /// <summary>
        /// The DsBrowseForContainer function displays a dialog box used to browse for container 
        /// objects in Active Directory Domain Services.
        /// </summary>
        /// <param name="pInfo">Pointer to a DSBROWSEINFO structure that contains data about initializing
        /// the container browser dialog and receives data about the selected object.</param>
        /// <returns>
        /// The function returns one of the following values.
        ///
        /// -1
        ///
        /// An error occurred.
        /// IDCANCEL
        ///
        /// The user canceled the dialog box.
        /// IDOK
        ///
        /// The user selected an object in the dialog box and accepted the selection.
        /// </returns>
        public static DialogBoxResult DsBrowseForContainer([In] DSBrowseInfo pInfo)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.DsBrowseForContainerW(pInfo) : Native.DsBrowseForContainerA(pInfo);
        }

        #region Nested type: Native

        internal static class Native
        {
            [DllImport("dsuiext.dll", EntryPoint = "DsBrowseForContainerA", CharSet = CharSet.Auto, SetLastError = true)
            ]
            internal static extern DialogBoxResult DsBrowseForContainerA([In] DSBrowseInfo pInfo);

            [DllImport("dsuiext.dll", EntryPoint = "DsBrowseForContainerW", CharSet = CharSet.Auto, SetLastError = true)
            ]
            internal static extern DialogBoxResult DsBrowseForContainerW([In] DSBrowseInfo pInfo);
        }

        #endregion
    }
}