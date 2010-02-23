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
    /// The filter conditions that satisfy a change notification wait
    /// </summary>
    [Flags]
    public enum FileNotifyChange : uint
    {
        /// <summary>
        /// Any file name change in the watched directory or subtree causes a
        /// change notification wait operation to return. Changes include renaming,
        /// creating, or deleting a file name
        /// </summary>
        FILE_NOTIFY_CHANGE_FILE_NAME = 0x00000001,
        /// <summary>
        /// Any directory-name change in the watched directory or subtree causes a 
        /// change notification wait operation to return. Changes include creating 
        /// or deleting a directory
        /// </summary>
        FILE_NOTIFY_CHANGE_DIR_NAME = 0x00000002,
        /// <summary>
        /// Any attribute change in the watched directory or subtree causes a change
        /// notification wait operation to return
        /// </summary>
        FILE_NOTIFY_CHANGE_ATTRIBUTES = 0x00000004,
        /// <summary>
        /// Any file-size change in the watched directory or subtree causes a change
        /// notification wait operation to return. The operating system detects a change 
        /// in file size only when the file is written to the disk. For operating systems 
        /// that use extensive caching, detection occurs only when the cache is sufficiently flushed
        /// </summary>
        FILE_NOTIFY_CHANGE_SIZE = 0x00000008,
        /// <summary>
        /// Any change to the last write-time of files in the watched directory or subtree causes a 
        /// change notification wait operation to return. The operating system detects a change to 
        /// the last write-time only when the file is written to the disk. For operating systems 
        /// that use extensive caching, detection occurs only when the cache is sufficiently flushed
        /// </summary>
        FILE_NOTIFY_CHANGE_LAST_WRITE = 0x00000010,
        /// <summary>
        /// Any security-descriptor change in the watched directory or subtree causes a change notification
        /// wait operation to return
        /// </summary>
        FILE_NOTIFY_CHANGE_SECURITY = 0x00000100
    }
}