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
    /// Specifies the clipping operation to be performed
    /// </summary>
    [Flags]
    public enum ClippingOperationMode
    {
        /// <summary>
        /// The new clipping region combines the overlapping
        /// areas of the current clipping region and the region identified by hrgn
        /// parameter of ExtSelectClipRgn function
        /// </summary>
        RGN_AND = 1,
        /// <summary>
        /// The new clipping region combines the current clipping region and the
        /// region identified by hrgn parameter of ExtSelectClipRgn function
        /// </summary>
        RGN_OR = 2,
        /// <summary>
        /// The new clipping region combines the current clipping region and the region
        /// identified by hrgn parameter of ExtSelectClipRgn function but excludes any
        /// overlapping areas
        /// </summary>
        RGN_XOR = 3,
        /// <summary>
        /// The new clipping region combines the areas of the current clipping region
        /// with those areas excluded from the region identified by hrgn parameter of 
        /// ExtSelectClipRgn function
        /// </summary>
        RGN_DIFF = 4,
        /// <summary>
        /// The new clipping region is a copy of the region identified by hrgn. This
        /// is identical to SelectClipRgn. If the region identified by hrgn is null, 
        /// the new clipping region is the default clipping region (the default clipping
        /// region is a null region).
        /// </summary>
        RGN_COPY = 5
    }
}