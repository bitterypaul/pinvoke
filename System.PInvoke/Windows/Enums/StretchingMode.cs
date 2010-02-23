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
    /// Return value for GetStretchBltMode function as currrent stretching mode
    /// </summary>
    [Flags]
    public enum StretchingMode
    {
        /// <summary>
        /// Performs a Boolean AND operation using the color values for the eliminated 
        /// and existing pixels. If the bitmap is a monochrome bitmap, this mode preserves
        /// black pixels at the expense of white pixels.
        /// </summary>
        BLACKONWHITE = 1,
        /// <summary>
        /// Deletes the pixels. This mode deletes all eliminated lines of pixels 
        /// without trying to preserve their information
        /// </summary>
        COLORONCOLOR = 3,
        /// <summary>
        /// Maps pixels from the source rectangle into blocks of pixels in the destination rectangle.
        /// The average color over the destination block of pixels approximates the color of the source pixels. 
        /// This option is not supported on Windows 95/98/Me
        /// </summary>
        HALFTONE = 4,
        /// <summary>
        /// Performs a Boolean AND operation using the color values for the eliminated 
        /// and existing pixels. If the bitmap is a monochrome bitmap, this mode preserves
        /// black pixels at the expense of white pixels (same as BLACKONWHITE)
        /// </summary>
        STRETCH_ANDSCANS = 1,
        /// <summary>
        /// Deletes the pixels. This mode deletes all eliminated lines of pixels 
        /// without trying to preserve their information (same as COLORONCOLOR)
        /// </summary>
        STRETCH_DELETESCANS = 3,
        /// <summary>
        /// Maps pixels from the source rectangle into blocks of pixels in the destination rectangle.
        /// The average color over the destination block of pixels approximates the color of the source pixels. 
        /// This option is not supported on Windows 95/98/Me (same as HALFTONE)
        /// </summary>
        STRETCH_HALFTONE = 4,
        /// <summary>
        /// Performs a Boolean OR operation using the color values for the eliminated and existing pixels.
        /// If the bitmap is a monochrome bitmap, this mode preserves white pixels at the expense of 
        /// black pixels(same as WHITEONBLACK)
        /// </summary>
        STRETCH_ORSCANS = 2,
        /// <summary>
        /// Performs a Boolean OR operation using the color values for the eliminated and existing pixels.
        /// If the bitmap is a monochrome bitmap, this mode preserves white pixels at the expense of black pixels.
        /// </summary>
        WHITEONBLACK = 2,
        /// <summary>
        /// Fail to stretch
        /// </summary>
        ERROR = 0
    }
}