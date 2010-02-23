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
    /// Error codes that LZCopy can return upon failure
    /// </summary>
    [Flags]
    public enum LZErrorCode
    {
        /// <summary>
        /// The handle identifying the source file is not valid. The file cannot be read
        /// </summary>
        LZERROR_BADINHANDLE = -1,
        /// <summary>
        /// The handle identifying the destination file is not valid. The file cannot be written
        /// </summary>
        LZERROR_BADOUTHANDLE = -2,
        /// <summary>
        /// The maximum number of open compressed files has been exceeded or local memory cannot be allocated
        /// </summary>
        LZERROR_GLOBALLOC = -5,
        /// <summary>
        /// The LZ file handle cannot be locked down
        /// </summary>
        LZERROR_GLOBLOCK = -6,
        /// <summary>
        /// The source file format is not valid
        /// </summary>
        LZERROR_READ = -3,
        /// <summary>
        /// There is insufficient space for the output file
        /// </summary>
        LZERROR_WRITE = -4,
        /// <summary>
        /// One of the input parameters is not valid
        /// </summary>
        LZERROR_BADVALUE = -7,
        /// <summary>
        /// The file is compressed with an unrecognized compression algorithm
        /// </summary>
        LZERROR_UNKNOWNALG = -8
    }
}