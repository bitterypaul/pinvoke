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
    /// Anonymous inner structure
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct InnerStruct2A
    {
        /// <summary>
        /// Windows 98/Me, Windows 2000/XP: For display devices only, a POINT structure that indicates 
        /// the positional coordinates of the display device in reference to the desktop area. The primary
        /// display device is always located at coordinates (0,0). 
        /// </summary>
        public Point dmPosition;

        /// <summary>
        /// Windows XP: For display devices only, the orientation at which images should be presented. 
        /// If DM_DISPLAYORIENTATION is not set, this member must be zero. If DM_DISPLAYORIENTATION is set, 
        /// this member must be one of the values of DisplayOrientation enum
        /// </summary>
        public DisplayOrientation dmDisplayOrientation;

        /// <summary>
        /// Windows XP: For fixed-resolution display devices only, how the display presents a low-resolution
        /// mode on a higher-resolution display. For example, if a display device's resolution is fixed at 
        /// 1024 x 768 pixels but its mode is set to 640 x 480 pixels, the device can either display a 
        /// 640 x 480 image somewhere in the interior of the 1024 x 768 screen space or stretch the 
        /// 640 x 480 image to fill the larger screen space. If DM_DISPLAYFIXEDOUTPUT is not set, this member
        /// must be zero. If DM_DISPLAYFIXEDOUTPUT is set, this member must be one of the following values. 
        /// </summary>
        public DisplayFixedOutput dmDisplayFixedOutput;
    }
}