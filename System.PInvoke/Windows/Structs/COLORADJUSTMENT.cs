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
using System.PInvoke.Windows.Enums;
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The COLORADJUSTMENT structure defines the color adjustment values used by the StretchBlt
    /// and StretchDIBits functions when the stretch mode is HALFTONE. You can set the color 
    /// adjustment values by calling the SetColorAdjustment function
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ColorAdjustment
    {
        /// <summary>
        /// Specifies the size, in bytes, of the structure
        /// </summary>
        public ushort caSize;

        /// <summary>
        /// Specifies how the output image should be prepared. 
        /// This member may be set to null or any of the enum values
        /// </summary>
        public ColorAdjustmentFilter caFlags;

        /// <summary>
        /// Specifies the type of standard light source under which the image is viewed.
        /// </summary>
        public LightSource caIlluminantIndex;

        /// <summary>
        /// Specifies the nth power gamma-correction value for the red primary of the source colors. 
        /// The value must be in the range from 2500 to 65,000. A value of 10,000 means no gamma correction
        /// </summary>
        public ushort caRedGamma;

        /// <summary>
        /// Specifies the nth power gamma-correction value for the green primary of the source colors.
        /// The value must be in the range from 2500 to 65,000. A value of 10,000 means no gamma correction
        /// </summary>
        public ushort caGreenGamma;

        /// <summary>
        /// Specifies the nth power gamma-correction value for the blue primary of the source colors. 
        /// The value must be in the range from 2500 to 65,000. A value of 10,000 means no gamma correction
        /// </summary>
        public ushort caBlueGamma;

        /// <summary>
        /// Specifies the black reference for the source colors. Any colors that are darker than this 
        /// are treated as black. The value must be in the range from 0 to 4000
        /// </summary>
        public ushort caReferenceBlack;

        /// <summary>
        /// Specifies the white reference for the source colors. Any colors that are lighter 
        /// than this are treated as white. The value must be in the range from 6000 to 10,000
        /// </summary>
        public ushort caReferenceWhite;

        /// <summary>
        /// Specifies the amount of contrast to be applied to the source object. The value must be
        /// in the range from 100 to 100. A value of 0 means no contrast adjustment
        /// </summary>
        public short caContrast;

        /// <summary>
        /// Specifies the amount of brightness to be applied to the source object. 
        /// The value must be in the range from 100 to 100. A value of 0 means no brightness adjustment
        /// </summary>
        public short caBrightness;

        /// <summary>
        /// Specifies the amount of colorfulness to be applied to the source object. The value must be
        /// in the range from 100 to 100. A value of 0 means no colorfulness adjustment
        /// </summary>
        public short caColorfulness;

        /// <summary>
        /// Specifies the amount of red or green tint adjustment to be applied to the source object. 
        /// The value must be in the range from 100 to 100. Positive numbers adjust towards red and 
        /// negative numbers adjust towards green. Zero means no tint adjustment
        /// </summary>
        public short caRedGreenTint;
    }
}