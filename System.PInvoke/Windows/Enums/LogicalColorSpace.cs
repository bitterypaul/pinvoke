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
    /// Specifies the color space of the DIB
    /// </summary>
    [Flags]
    public enum LogicalColorSpace : uint
    {
        /// <summary>
        /// This value implies that endpoints and gamma values are given in the appropriate fields
        /// </summary>
        LCS_CALIBRATED_RGB = 0,
        /// <summary>
        /// Specifies that the bitmap is in sRGB color space
        /// </summary>
        LCS_SRGB = 1,
        /// <summary>
        /// This value indicates that the bitmap is in the system default color space, sRGB
        /// </summary>
        LCS_WINDOWS_COLOR_SPACE = 2,
        /// <summary>
        /// This value indicates that bV5ProfileData points to the file name of the profile to
        /// use (gamma and endpoints values are ignored). 
        /// </summary>
        PROFILE_LINKED = 3,
        /// <summary>
        /// This value indicates that bV5ProfileData points to a memory buffer that 
        /// contains the profile to be used (gamma and endpoints values are ignored).
        /// </summary>
        PROFILE_EMBEDDED = 4
    }
}