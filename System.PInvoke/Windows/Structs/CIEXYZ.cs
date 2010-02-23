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
    /// The CIEXYZ structure contains the x, y, and z coordinates 
    /// of a specific color in a specified color space. 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CIEXYZ
    {
        /// <summary>
        /// The x coordinate in fix point (2.30)
        /// </summary>
        public int ciexyzX;

        /// <summary>
        /// The y coordinate in fix point (2.30). 
        /// </summary>
        public int ciexyzY;

        /// <summary>
        /// The z coordinate in fix point (2.30). 
        /// </summary>
        public int ciexyzZ;
    }
}