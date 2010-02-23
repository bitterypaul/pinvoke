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
    /// A set of bit flags that specify properties of the pixel buffer,
    /// The properties are generally not mutually exclusive; you can set
    /// any combination of bit flags, with the exceptions noted.
    /// </summary>
    [Flags]
    public enum PFDBitFlag
    {
        /// <summary>
        /// The buffer can draw to a window or device surface
        /// </summary>
        PFD_DRAW_TO_WINDOW = 4,
        /// <summary>
        /// The buffer can draw to a memory bitmap
        /// </summary>
        PFD_DRAW_TO_BITMAP = 8,
        /// <summary>
        /// The buffer supports GDI drawing. This flag and 
        /// PFD_DOUBLEBUFFER are mutually exclusive in the current generic implementation
        /// </summary>
        PFD_SUPPORT_GDI = 16,
        /// <summary>
        /// The buffer supports OpenGL drawing
        /// </summary>
        PFD_SUPPORT_OPENGL = 32,
        /// <summary>
        /// The pixel format is supported by a device driver that accelerates the generic 
        /// implementation. If this flag is clear and the PFD_GENERIC_FORMAT flag is set,
        /// the pixel format is supported by the generic implementation only
        /// </summary>
        PFD_GENERIC_ACCELERATED = 4096,
        /// <summary>
        /// The pixel format is supported by the GDI software implementation, which is also
        /// known as the generic implementation. If this bit is clear, the pixel format is
        /// supported by a device driver or hardware
        /// </summary>
        PFD_GENERIC_FORMAT = 64,
        /// <summary>
        /// The buffer uses RGBA pixels on a palette-managed device. A logical palette is 
        /// required to achieve the best results for this pixel type. Colors in the palette
        /// should be specified according to the values of the cRedBits, cRedShift, cGreenBits,
        /// cGreenShift, cBluebits, and cBlueShift members of PIXELFORMATDESCRIPTOR structure. The palette should be created and 
        /// realized in the device context before calling wglMakeCurrent
        /// </summary>
        PFD_NEED_PALETTE = 128,
        /// <summary>
        /// Defined in the pixel format descriptors of hardware that supports one hardware palette
        /// in 256-color mode only. For such systems to use hardware acceleration, the hardware palette
        /// must be in a fixed order (for example, 3-3-2) when in RGBA mode or must match the logical
        /// palette when in color-index mode. 
        /// When this flag is set, you must call SetSystemPaletteUse in your program to force a one-to-one
        /// mapping of the logical palette and the system palette. If your OpenGL hardware supports multiple
        /// hardware palettes and the device driver can allocate spare hardware palettes for OpenGL, this flag
        /// is typically clear.
        /// This flag is not set in the generic pixel formats
        /// </summary>
        PFD_NEED_SYSTEM_PALETTE = 256,
        /// <summary>
        /// The buffer is double-buffered. This flag and PFD_SUPPORT_GDI are mutually exclusive in the current 
        /// generic implementation
        /// </summary>
        PFD_DOUBLEBUFFER = 1,
        /// <summary>
        /// The buffer is stereoscopic. This flag is not supported in the current generic implementation
        /// </summary>
        PFD_STEREO = 2,
        /// <summary>
        /// Indicates whether a device can swap individual layer planes with pixel formats that include 
        /// double-buffered overlay or underlay planes. Otherwise all layer planes are swapped together 
        /// as a group. When this flag is set, wglSwapLayerBuffers is supported
        /// </summary>        
        PFD_SWAP_LAYER_BUFFERS = 2048,
        /// <summary>
        /// The requested pixel format can either have or not have a depth buffer. To select a pixel format
        /// without a depth buffer, you must specify this flag. The requested pixel format can be with or 
        /// without a depth buffer. Otherwise, only pixel formats with a depth buffer are considered
        /// </summary>
        /// <remarks>You can specify the following bit flags when calling ChoosePixelFormat</remarks>
        PFD_DEPTH_DONTCARE = 536870912,
        /// <summary>
        /// The requested pixel format can be either single- or double-buffered
        /// </summary>
        /// <remarks>You can specify the following bit flags when calling ChoosePixelFormat</remarks>
        PFD_DOUBLEBUFFER_DONTCARE = 1073741824,
        /// <summary>
        /// The requested pixel format can be either monoscopic or stereoscopic
        /// </summary>
        /// <remarks>You can specify the following bit flags when calling ChoosePixelFormat</remarks>
        PFD_STEREO_DONTCARE = -2147483648,
        /// <summary>
        /// Specifies the content of the back buffer in the double-buffered main color plane following
        /// a buffer swap. Swapping the color buffers causes the content of the back buffer to be copied
        /// to the front buffer. The content of the back buffer is not affected by the swap. PFD_SWAP_COPY
        /// is a hint only and might not be provided by a driver
        /// </summary>
        PFD_SWAP_COPY = 1024,
        /// <summary>
        /// Specifies the content of the back buffer in the double-buffered main color plane following a 
        /// buffer swap. Swapping the color buffers causes the exchange of the back buffer's content with 
        /// the front buffer's content. Following the swap, the back buffer's content contains the front 
        /// buffer's content before the swap. PFD_SWAP_EXCHANGE is a hint only and might not be provided by
        /// a driver 
        /// </summary>
        PFD_SWAP_EXCHANGE = 512,
        /// <summary>
        /// RGBA pixels. Each pixel has four components in this order: red, green, blue, and alpha
        /// </summary>
        PFD_TYPE_RGBA = 0,
        /// <summary>
        /// Color-index pixels. Each pixel uses a color-index value
        /// </summary>
        PFD_TYPE_COLORINDEX = 1
    }
}