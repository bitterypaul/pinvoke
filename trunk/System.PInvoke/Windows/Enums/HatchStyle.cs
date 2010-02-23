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
    /// Specifies a hatch style.
    /// </summary>
    [Flags]
    public enum HatchStyle
    {
        /// <summary>
        /// A 45-degree upward, left-to-right hatch
        /// </summary>
        HS_BDIAGONAL = 3,
        /// <summary>
        /// Horizontal and vertical cross-hatch
        /// </summary>
        HS_CROSS = 4,
        /// <summary>
        /// 45-degree crosshatch
        /// </summary>
        HS_DIAGCROSS = 5,
        /// <summary>
        /// A 45-degree downward, left-to-right hatch
        /// </summary>
        HS_FDIAGONAL = 2,
        /// <summary>
        /// Horizontal hatch
        /// </summary>
        HS_HORIZONTAL = 0,
        /// <summary>
        /// Vertical hatch
        /// </summary>
        HS_VERTICAL = 1
    }
}