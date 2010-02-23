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
    /// Determines the flags for CopyImage operation
    /// </summary>
    [Flags]
    public enum ImageCopyOperation : uint
    {
        /// <summary>
        /// Deletes the original image after creating the copy
        /// </summary>
        LR_COPYDELETEORG = 0x0008,
        /// <summary>
        /// Tries to reload an icon or cursor resource from the 
        /// original resource file rather than simply copying the 
        /// current image. This is useful for creating a different-sized
        /// copy when the resource file contains multiple sizes of the 
        /// resource. Without this flag, CopyImage function stretches the original
        /// image to the new size. If this flag is set, CopyImage uses the
        /// size in the resource file closest to the desired size. This will
        /// succeed only if hImage parameter was loaded by LoadIcon or LoadCursor, or
        /// by LoadImage with the LR_SHARED flag
        /// </summary>
        LR_COPYFROMRESOURCE = 0x4000,
        /// <summary>
        /// Returns the original hImage if it satisfies the criteria for the 
        /// copy—that is, correct dimensions and color depth—in which case 
        /// the LR_COPYDELETEORG flag is ignored. If this flag is not specified,
        /// a new object is always created
        /// </summary>
        LR_COPYRETURNORG = 0x0004,
        /// <summary>
        /// If this is set and a new bitmap is created, the bitmap is created 
        /// as a device-independent bitmap (DIB) section. Otherwise, the bitmap
        /// image is created as a device-dependent bitmap. This flag is only 
        /// valid if type is parameter ImageCopyOption.IMAGE_BITMAP
        /// </summary>
        LR_CREATEDIBSECTION = 0x2000,
        /// <summary>
        /// Uses the width or height specified by the system metric values for 
        /// cursors or icons, if the cxDesired or cyDesired values are set to zero.
        /// If this flag is not specified and cxDesired and cyDesired parameters are set to 
        /// zero, the function uses the actual resource size. If the resource 
        /// contains multiple images, the function uses the size of the first image
        /// </summary>
        LR_DEFAULTSIZE = 0x0040,
        /// <summary>
        /// Creates a new monochrome image
        /// </summary>
        LR_MONOCHROME = 0x0001
    }
}