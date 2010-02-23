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
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// Contains information about a file that the OpenFile function opened or attempted to open
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct OFStruct
    {
        /// <summary>
        /// The size of the structure, in bytes
        /// </summary>
        public byte cBytes;

        /// <summary>
        /// If this member is nonzero, the file is on a hard (fixed) disk. Otherwise, it is not
        /// </summary>
        public byte fFixedDisk;

        /// <summary>
        /// The MS-DOS error code if the OpenFile function failed
        /// </summary>
        public ushort nErrCode;

        /// <summary>
        /// Reserved; do not use
        /// </summary>
        public ushort Reserved1;

        /// <summary>
        /// Reserved; do not use
        /// </summary>
        public ushort Reserved2;

        /// <summary>
        /// The path and file name of the file
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string szPathName;
    }
}