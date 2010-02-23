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
    /// Specifies how the display presents a low-resolution mode on a higher-resolution display
    /// </summary>
    [Flags]
    public enum DisplayFixedOutput : uint
    {
        /// <summary>
        /// The display's default setting.
        /// </summary>
        DMDFO_DEFAULT = 0,
        /// <summary>
        /// The low-resolution image is centered in the larger screen space.
        /// </summary>
        DMDFO_CENTER = 2,
        /// <summary>
        /// The low-resolution image is stretched to fill the larger screen space.
        /// </summary>
        DMDFO_STRETCH = 1
    }
}