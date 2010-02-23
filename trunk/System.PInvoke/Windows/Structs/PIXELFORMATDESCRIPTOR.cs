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
    /// The PIXELFORMATDESCRIPTOR structure describes the pixel format of a drawing surface
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct PixelFormatDescriptor
    {
        /// <summary>
        /// Specifies the size of this data structure. This value should be set to sizeof(PIXELFORMATDESCRIPTOR).
        /// </summary>
        public ushort nSize;

        /// <summary>
        /// Specifies the version of this data structure. This value should be set to 1.
        /// </summary>
        public ushort nVersion;

        /// <summary>
        /// A set of bit flags that specify properties of the pixel buffer
        /// </summary>
        public PFDBitFlag dwFlags;

        /// <summary>
        /// Specifies the type of pixel data
        /// </summary>
        public PixelType iPixelType;

        /// <summary>
        /// Specifies the number of color bitplanes in each color buffer. For RGBA pixel types, it is the size of
        /// the color buffer, excluding the alpha bitplanes. For color-index pixels, it is the size of the color-index buffer
        /// </summary>
        public byte cColorBits;

        /// <summary>
        /// Specifies the number of red bitplanes in each RGBA color buffer
        /// </summary>
        public byte cRedBits;

        /// <summary>
        /// Specifies the shift count for red bitplanes in each RGBA color buffer
        /// </summary>
        public byte cRedShift;

        /// <summary>
        /// Specifies the number of green bitplanes in each RGBA color buffer
        /// </summary>
        public byte cGreenBits;

        /// <summary>
        /// Specifies the shift count for green bitplanes in each RGBA color buffer
        /// </summary>
        public byte cGreenShift;

        /// <summary>
        /// Specifies the shift count for green bitplanes in each RGBA color buffer
        /// </summary>
        public byte cBlueBits;

        /// <summary>
        /// Specifies the shift count for blue bitplanes in each RGBA color buffer
        /// </summary>
        public byte cBlueShift;

        /// <summary>
        /// Specifies the number of alpha bitplanes in each RGBA color buffer. 
        /// Alpha bitplanes are not supported
        /// </summary>
        public byte cAlphaBits;

        /// <summary>
        /// Specifies the shift count for alpha bitplanes in each RGBA color buffer. 
        /// Alpha bitplanes are not supported
        /// </summary>
        public byte cAlphaShift;

        /// <summary>
        /// Specifies the total number of bitplanes in the accumulation buffer
        /// </summary>
        public byte cAccumBits;

        /// <summary>
        /// Specifies the number of red bitplanes in the accumulation buffer
        /// </summary>
        public byte cAccumRedBits;

        /// <summary>
        /// Specifies the number of green bitplanes in the accumulation buffer
        /// </summary>
        public byte cAccumGreenBits;

        /// <summary>
        /// Specifies the number of blue bitplanes in the accumulation buffer
        /// </summary>
        public byte cAccumBlueBits;

        /// <summary>
        /// Specifies the number of alpha bitplanes in the accumulation buffer
        /// </summary>
        public byte cAccumAlphaBits;

        /// <summary>
        /// Specifies the depth of the depth (z-axis) buffer
        /// </summary>
        public byte cDepthBits;

        /// <summary>
        /// Specifies the depth of the stencil buffer
        /// </summary>
        public byte cStencilBits;

        /// <summary>
        /// Specifies the number of auxiliary buffers. Auxiliary buffers are not supported
        /// </summary>
        public byte cAuxBuffers;

        /// <summary>
        /// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used
        /// </summary>
        public byte iLayerType;

        /// <summary>
        /// Specifies the number of overlay and underlay planes. Bits 0 through 3 specify up to 15 
        /// overlay planes and bits 4 through 7 specify up to 15 underlay planes
        /// </summary>
        public byte bReserved;

        /// <summary>
        /// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used
        /// </summary>
        public uint dwLayerMask;

        /// <summary>
        /// Specifies the transparent color or index of an underlay plane. When the pixel type is RGBA,
        /// dwVisibleMask is a transparent RGB color value. When the pixel type is color index, it is a
        /// transparent index value
        /// </summary>
        public uint dwVisibleMask;

        /// <summary>
        /// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used
        /// </summary>
        public uint dwDamageMask;
    }
}