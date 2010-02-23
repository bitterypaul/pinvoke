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
    /// The PRINTPAGERANGE structure specifies a range of pages in a print job. 
    /// A print job can have more than one page range. This information is supplied in
    /// the PRINTDLGEX structure when calling the PrintDlgEx function.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PrintPageRange
    {
        /// <summary>
        /// Specifies the first page of the range. 
        /// </summary>
        public uint nFromPage;

        /// <summary>
        /// Specifies the last page of the range. 
        /// </summary>
        public uint nToPage;
    }
}