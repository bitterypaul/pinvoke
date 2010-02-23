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
    /// Specifies the brush style
    /// </summary>
    [Flags]
    public enum BrushStyle : uint
    {
        /// <summary>
        /// A pattern brush defined by a device-independent bitmap (DIB) specification.
        /// </summary>
        BS_DIBPATTERN = 5,
        /// <summary>
        /// A pattern brush defined by a device-independent bitmap (DIB) specification.
        /// </summary>
// ReSharper disable InconsistentNaming
        BS_DIBPATTERN8X8 = 8,
// ReSharper restore InconsistentNaming
        /// <summary>
        /// A pattern brush defined by a device-independent bitmap (DIB) specification
        /// </summary>
        BS_DIBPATTERNPT = 6,
        /// <summary>
        /// Hatched brush
        /// </summary>
        BS_HATCHED = 2,
        /// <summary>
        /// Hollow brush
        /// </summary>
        BS_NULL = 1,
        /// <summary>
        /// Hollow brush
        /// </summary>
        BS_HOLLOW = BS_NULL,
        /// <summary>
        /// Pattern brush defined by a memory bitmap
        /// </summary>
        BS_PATTERN = 3,
        /// <summary>
        /// Pattern brush defined by a memory bitmap
        /// </summary>
// ReSharper disable InconsistentNaming
        BS_PATTERN8X8 = 7,
// ReSharper restore InconsistentNaming
        /// <summary>
        /// Solid brush
        /// </summary>
        BS_SOLID = 0
    }
}