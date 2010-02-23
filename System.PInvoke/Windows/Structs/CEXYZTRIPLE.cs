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
    /// The CIEXYZTRIPLE structure contains the x, y, and z coordinates
    /// of the three colors that correspond to the red, green, and blue
    /// endpoints for a specified logical color space
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CEXYZTriple
    {
        /// <summary>
        /// The xyz coordinates of red endpoint. 
        /// </summary>
        public CIEXYZ ciexyzRed;

        /// <summary>
        /// The xyz coordinates of green endpoint. 
        /// </summary>
        public CIEXYZ ciexyzGreen;

        /// <summary>
        /// The xyz coordinates of blue endpoint. 
        /// </summary>
        public CIEXYZ ciexyzBlue;
    }
}