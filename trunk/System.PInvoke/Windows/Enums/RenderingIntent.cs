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
    /// Rendering intent for bitmap
    /// </summary>
    [Flags]
    public enum RenderingIntent
    {
        /// <summary>
        /// Maintains the white point. Matches the colors to their 
        /// nearest color in the destination gamut.
        /// </summary>
        LCS_GM_ABS_COLORIMETRIC = 8,
        /// <summary>
        /// Maintains saturation. Used for business charts and other
        /// situations in which undithered colors are required.
        /// </summary>
        LCS_GM_BUSINESS = 1,
        /// <summary>
        /// Maintains colorimetric match. Used for graphic designs and named colors.
        /// </summary>
        LCS_GM_GRAPHICS = 2,
        /// <summary>
        /// Maintains contrast. Used for photographs and natural images
        /// </summary>
        LCS_GM_IMAGES = 4
    }
}