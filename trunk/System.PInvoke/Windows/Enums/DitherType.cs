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
    /// Specifies how dithering is to be done.
    /// </summary>
    [Flags]
    public enum DitherType : uint
    {
        /// <summary>
        /// No dithering.
        /// </summary>
        DMDITHER_NONE = 1,
        /// <summary>
        /// Dithering with a coarse brush.
        /// </summary>
        DMDITHER_COARSE = 2,
        /// <summary>
        /// Dithering with a fine brush.
        /// </summary>
        DMDITHER_FINE = 3,
        /// <summary>
        /// Line art dithering, a special dithering method that produces well defined
        /// borders between black, white, and gray scaling. It is not suitable for images
        /// that include continuous graduations in intensity and hue, such as scanned 
        /// photographs.
        /// </summary>
        DMDITHER_LINEART = 4,
        /// <summary>
        /// Windows 95/98/Me: Dithering in which an algorithm is used to spread, or diffuse,
        /// the error of approximating a specified color over adjacent pixels. In contrast,
        /// DMDITHER_COARSE, DMDITHER_FINE, and DMDITHER_LINEART use patterned halftoning 
        /// to approximate a color.
        /// </summary>
        DMDITHER_ERRORDIFFUSION = 5,
        /// <summary>
        /// Device does gray scaling.
        /// </summary>
        DMDITHER_GRAYSCALE = 10
    }
}