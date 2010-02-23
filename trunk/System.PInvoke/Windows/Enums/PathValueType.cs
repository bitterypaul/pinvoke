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
    /// The PathValueType (ADS_FORMAT_ENUM) enumeration specifies the available path value types used by the IADsPathname.Retrieve() method.
    /// </summary>
    [Flags]
    public enum PathValueType : uint
    {
        /// <summary>
        /// Returns the full path in Windows format, for example, "LDAP://servername/o=internet/…/cn=bar".
        /// </summary>
        ADS_FORMAT_WINDOWS = 1,
        /// <summary>
        /// Returns Windows format without server, for example, "LDAP://o=internet/…/cn=bar".
        /// </summary>
        ADS_FORMAT_WINDOWS_NO_SERVER = 2,
        /// <summary>
        /// Returns Windows format of the distinguished name only, for example, "o=internet/…/cn=bar".
        /// </summary>
        ADS_FORMAT_WINDOWS_DN = 3,
        /// <summary>
        /// Returns Windows format of Parent only, for example, "o=internet/…".
        /// </summary>
        ADS_FORMAT_WINDOWS_PARENT = 4,
        /// <summary>
        /// Returns the full path in X.500 format, for example, "LDAP://servername/cn=bar,…,o=internet".
        /// </summary>
        ADS_FORMAT_X500 = 5,
        /// <summary>
        /// Returns the path without server in X.500 format, for example, "LDAP://cn=bar,…,o=internet".
        /// </summary>
        ADS_FORMAT_X500_NO_SERVER = 6,
        /// <summary>
        /// Returns only the distinguished name in X.500 format. For example, "cn=bar,…,o=internet".
        /// </summary>
        ADS_FORMAT_X500_DN = 7,
        /// <summary>
        /// Returns only the parent in X.500 format, for example, "…,o=internet".
        /// </summary>
        ADS_FORMAT_X500_PARENT = 8,
        /// <summary>
        /// Returns the server name, for example, "servername".
        /// </summary>
        ADS_FORMAT_SERVER = 9,
        /// <summary>
        /// Returns the name of the provider, for example, "LDAP".
        /// </summary>
        ADS_FORMAT_PROVIDER = 10,
        /// <summary>
        /// Returns the name of the leaf, for example, "cn=bar".
        /// </summary>
        ADS_FORMAT_LEAF = 11
    }
}