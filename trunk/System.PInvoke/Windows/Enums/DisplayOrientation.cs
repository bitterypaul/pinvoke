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
    /// The orientation at which images should be presented
    /// </summary>
    [Flags]
    public enum DisplayOrientation : uint
    {
        /// <summary>
        /// The display orientation is the natural orientation of 
        /// the display device; it should be used as the default. 
        /// </summary>
        DMDO_DEFAULT = 0,
        /// <summary>
        /// The display orientation is rotated 90 degrees (measured
        /// clockwise) from DMDO_DEFAULT.
        /// </summary>
        DMDO_90 = 1,
        /// <summary>
        /// The display orientation is rotated 180 degrees 
        /// (measured clockwise) from DMDO_DEFAULT
        /// </summary>
        DMDO_180 = 2,
        /// <summary>
        /// The display orientation is rotated 270 degrees (measured 
        /// clockwise) from DMDO_DEFAULT.
        /// </summary>
        DMDO_270 = 3
    }
}