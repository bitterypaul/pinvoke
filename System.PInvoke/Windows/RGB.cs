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
using System.Drawing;

namespace System.PInvoke.Windows
{
    /// <summary>
    /// This helper class converts color values between System.Drawing.Color and Win32 color (COLORREF)
    /// </summary>
    public class RGB
    {
        /// <summary>
        /// This function converts a .Net color object to a Win32 color value
        /// </summary>
        /// <param name="color">System.Drawing.Color object</param>
        /// <returns>Win32 color value</returns>
        public static uint ToWin32Color(Color color)
        {
            return color.R + (((uint) color.G) << 8) + (((uint) color.B) << 16);
        }

        /// <summary>
        /// This function converts a Win32 color value to a System.Drawing.Color value
        /// </summary>
        /// <param name="color">win32 color value</param>
        /// <returns>Equivalent System.Drawing.Color value</returns>
        public static Color FromWin32Color(uint color)
        {
            return Color.FromArgb((int) (0x000000FFU & color),
                                  (int) (0x0000FF00U & color) >> 8, (int) (0x00FF0000U & color) >> 16);
        }
    }
}