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
    /// Specifies the new clipping region's type for IntersectClipRect function
    /// </summary>
    [Flags]
    public enum ClippingRegionType
    {
        /// <summary>
        /// Region is empty
        /// </summary>
        NULLREGION = 1,
        /// <summary>
        /// Region is a single rectangle
        /// </summary>
        SIMPLEREGION = 2,
        /// <summary>
        /// Region is more than one rectangle
        /// </summary>
        COMPLEXREGION = 3,
        /// <summary>
        /// An error occurred. (The current clipping region is unaffected.)
        /// </summary>
        ERROR = 0
    }
}