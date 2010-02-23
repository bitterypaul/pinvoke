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
    /// The TRIVERTEX structure contains color information and position information
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct TriVertex
    {
        /// <summary>
        /// Specifies the x-coordinate, in logical units, of the upper-left corner of the rectangle
        /// </summary>
        public int x;

        /// <summary>
        /// Specifies the y-coordinate, in logical units, of the upper-left corner of the rectangle
        /// </summary>
        public int y;

        /// <summary>
        /// Indicates color information at the point of x, y
        /// </summary>
        public ushort Red;

        /// <summary>
        /// Indicates color information at the point of x, y
        /// </summary>
        public ushort Green;

        /// <summary>
        /// Indicates color information at the point of x, y
        /// </summary>
        public ushort Blue;

        /// <summary>
        /// Indicates color information at the point of x, y
        /// </summary>
        public ushort Alpha;
    }
}