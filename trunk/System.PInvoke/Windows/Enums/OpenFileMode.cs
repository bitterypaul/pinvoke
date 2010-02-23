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
    /// The action to be taken while opening a file
    /// </summary>
    [Flags]
    public enum OpenFileMode : ushort
    {
        /// <summary>
        /// Opens the file for reading only
        /// </summary>
        OF_READ = 0,
        /// <summary>
        /// Opens the file and then closes it to test for a file's existence
        /// </summary>
        OF_EXIST = 16384,
        /// <summary>
        /// Fills the OFSTRUCT structure but carries out no other action
        /// </summary>
        OF_PARSE = 256,
        /// <summary>
        /// Opens the file for writing only
        /// </summary>
        OF_WRITE = 1,
        /// <summary>
        /// Ignored. Use the OF_PROMPT style to display a dialog box containing a Cancel button
        /// </summary>
        [Obsolete("Provided only for compatibility with 16-bit Windows")] OF_CANCEL = 2048,
        /// <summary>
        /// Directs LZOpenFile to create a new file. If the file already exists, it is truncated to zero length
        /// </summary>
        OF_CREATE = 4096,
        /// <summary>
        /// Deletes the file
        /// </summary>
        OF_DELETE = 512,
        /// <summary>
        /// Displays a dialog box if the requested file does not exist. The dialog box informs the user 
        /// that the system cannot find the file, and it contains Retry and Cancel buttons. Clicking the 
        /// Cancel button directs LZOpenFile to return a file not found error message
        /// </summary>
        OF_PROMPT = 8192,
        /// <summary>
        /// Opens the file using information in the reopen buffer
        /// </summary>
        OF_REOPEN = 32768,
        /// <summary>
        /// Verifies that the date and time of a file are the same as when it was opened previously.
        /// This is useful as an extra check for read-only files
        /// </summary>
        OF_VERIFY = 1024,
        /// <summary>
        /// Opens the file for reading and writing
        /// </summary>
        OF_READWRITE = 2,
        /// <summary>
        /// For MS-DOS–based file systems, opens a file with compatibility mode, allows any process on a 
        /// specified computer to open the file any number of times
        /// </summary>
        OF_SHARE_COMPAT = 0,
        /// <summary>
        /// Opens the file without denying other processes read or write access to the file. LZOpenFile 
        /// fails if the file has been opened in compatibility mode by any other process
        /// </summary>
        OF_SHARE_DENY_NONE = 64,
        /// <summary>
        /// Opens the file and denies other processes read access to the file. LZOpenFile fails if the 
        /// file has been opened in compatibility mode or has been opened for read access by any other process
        /// </summary>
        OF_SHARE_DENY_READ = 48,
        /// <summary>
        /// Opens the file in exclusive mode, denying other processes both read and write access to the file.
        /// LZOpenFile fails if the file has been opened in any other mode for read or write access, even by 
        /// the current process
        /// </summary>
        OF_SHARE_EXCLUSIVE = 16,
        /// <summary>
        /// Opens a file and denies write access to other processes
        /// </summary>
        OF_SHARE_DENY_WRITE = 32
    }
}