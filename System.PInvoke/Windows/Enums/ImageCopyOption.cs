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
    /// Creates a new image (icon, cursor, or bitmap) and copies the
    /// attributes of the specified image to the new one. If necessary, 
    /// the function stretches the bits to fit the desired size of the new image
    /// </summary>
    [Flags]
    public enum ImageCopyOption : uint
    {
        /// <summary>
        /// Copies a bitmap
        /// </summary>
        IMAGE_BITMAP = 0,
        /// <summary>
        /// Copies a cursor
        /// </summary>
        IMAGE_CURSOR = 2,
        /// <summary>
        /// Copies an icon
        /// </summary>
        IMAGE_ICON = 1
    }
}