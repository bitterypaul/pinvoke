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
    /// Specifies which color matching method, or intent, should be used by default
    /// </summary>
    [Flags]
    public enum ColorMatchingOption : uint
    {
        /// <summary>
        /// Color matching should optimize to match the exact color requested without 
        /// white point mapping. This value is most appropriate for use with proofing.
        /// </summary>
        DMICM_ABS_COLORIMETRIC = 4,
        /// <summary>
        /// Color matching should optimize to match the exact color requested. This 
        /// value is most appropriate for use with business logos or other images when
        /// an exact color match is desired.
        /// </summary>
        DMICM_COLORIMETRIC = 3,
        /// <summary>
        /// Color matching should optimize for color contrast. This value is the most 
        /// appropriate choice for scanned or photographic images when dithering is desired.
        /// </summary>
        DMICM_CONTRAST = 2,
        /// <summary>
        /// Color matching should optimize for color saturation. This value is the most 
        /// appropriate choice for business graphs when dithering is not desired.
        /// </summary>
        DMICM_SATURATE = 1
    }
}