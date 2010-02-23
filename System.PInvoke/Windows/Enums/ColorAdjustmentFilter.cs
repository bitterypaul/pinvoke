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
    /// Specifies how the output image should be prepared
    /// </summary>
    [Flags]
    public enum ColorAdjustmentFilter : ushort
    {
        /// <summary>
        /// Specifies that the negative of the original image should be displayed
        /// </summary>
        CA_NEGATIVE = 1,
        /// <summary>
        /// Specifies that a logarithmic function should be applied to the final density 
        /// of the output colors. This will increase the color contrast when the luminance is low
        /// </summary>
        CA_LOG_FILTER = 2
    }
}