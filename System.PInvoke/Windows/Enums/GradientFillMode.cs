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
    /// Specifies gradient fill mode
    /// </summary>
    [Flags]
    public enum GradientFillMode : uint
    {
        /// <summary>
        /// In this mode, two endpoints describe a rectangle. The rectangle is defined
        /// to have a constant color (specified by the TRIVERTEX structure) for the 
        /// left and right edges. GDI interpolates the color from the left to right 
        /// edge and fills the interior
        /// </summary>
        GRADIENT_FILL_RECT_H = 0,
        /// <summary>
        /// In this mode, two endpoints describe a rectangle. The rectangle is
        /// defined to have a constant color (specified by the TRIVERTEX structure)
        /// for the top and bottom edges. GDI interpolates the color from the top 
        /// to bottom edge and fills the interior
        /// </summary>
        GRADIENT_FILL_RECT_V = 1,
        /// <summary>
        /// In this mode, an array of TRIVERTEX structures is passed to GDI
        /// along with a list of array indexes that describe separate triangles.
        /// GDI performs linear interpolation between triangle vertices and fills
        /// the interior. Drawing is done directly in 24- and 32-bpp modes. 
        /// Dithering is performed in 16-, 8-, 4-, and 1-bpp mode
        /// </summary>
        GRADIENT_FILL_TRIANGLE = 2
    }
}