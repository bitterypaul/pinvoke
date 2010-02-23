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
    /// The BLENDFUNCTION structure controls blending by specifying the blending functions for source and destination bitmaps. 
    /// </summary>
    /// <remarks>When the AlphaFormat parameter is AC_SRC_ALPHA, the source bitmap must be 32 bpp. 
    /// If it is not, the AlphaBlend function will fail. 
    /// When the BlendOp parameter is AC_SRC_OVER , the source bitmap is placed over the destination 
    /// bitmap based on the alpha values of the source pixels. 
    /// If the source bitmap has no per-pixel alpha value (that is, AC_SRC_ALPHA is not set), the 
    /// SourceConstantAlpha value determines the blend of the source and destination bitmaps, as shown
    /// in the following table. Note that SCA is used for SourceConstantAlpha here. Also, SCA is divided
    /// by 255 because it has a value that ranges from 0 to 255.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct BlendFunction
    {
        /// <summary>
        /// Specifies the source blend operation. Currently, the only source and 
        /// destination blend operation that has been defined is AC_SRC_OVER. 
        /// </summary>
        public byte BlendOp;

        /// <summary>
        /// Must be zero. 
        /// </summary>
        public byte BlendFlags;

        /// <summary>
        /// Specifies an alpha transparency value to be used on the entire source bitmap.
        /// The SourceConstantAlpha value is combined with any per-pixel alpha values in 
        /// the source bitmap. If you set SourceConstantAlpha to 0, it is assumed that your
        /// image is transparent. Set the SourceConstantAlpha value to 255 (opaque) when you
        /// only want to use per-pixel alpha values. 
        /// </summary>
        public byte SourceConstantAlpha;

        /// <summary>
        /// This member controls the way the source and destination bitmaps are interpreted. 
        /// AlphaFormat has the following value.
        /// AC_SRC_ALPHA
        /// </summary>
        public byte AlphaFormat;
    }
}