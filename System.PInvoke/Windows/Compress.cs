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
using System.PInvoke.Windows.Enums;
using System.PInvoke.Windows.Structs;
using System.Runtime.InteropServices;
using System.Text;

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains the PInvoke signature of handling file compressed by Lempel-Ziv algorithm 
    /// </summary>
    public class Compress
    {
        [Obsolete(
            "Supported only for backward compatibility with the 16-bit Windows API. Replaced by the LZCopy function.",
            false)]
        public static int CopyLZFile(int param0, int param1)
        {
            return Native.CopyLZFile(param0, param1);
        }

        /// <summary>
        /// Retrieves the original name of a compressed file, if the file was compressed by
        /// the Lempel-Ziv algorithm
        /// </summary>
        /// <param name="lpszSource">The name of the compressed file.</param>
        /// <param name="lpszBuffer">A pointer to a buffer that receives the original name 
        /// of the compressed file.</param>
        /// <returns>If the function succeeds, the return value is 1.
        /// If the function fails, the return value is LZERROR_BADVALUE. There is no extended error
        /// information for this function; DO NOT call GetLastError</returns>
        /// <remarks>Note  GetExpandedName calls neither SetLastError nor SetLastErrorEx; thus, its failure
        /// does not affect a thread's last-error code</remarks>
        public static int GetExpandedName(StringBuilder lpszSource, StringBuilder lpszBuffer)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.GetExpandedNameW(lpszSource, lpszBuffer) : Native.GetExpandedNameA(lpszSource, lpszBuffer);
        }

        /// <summary>
        /// Closes a file that was opened by using the LZOpenFile function
        /// </summary>
        /// <param name="hFile">A handle to the file to be closed</param>
        /// <remarks>The handle identifying the file must be retrieved by calling the LZOpenFile function.
        /// If the handle is retrieved by calling the CreateFile or OpenFile function, an error occurs.
        /// If the file has been compressed by the Lempel-Ziv algorithm and opened by using LZOpenFile, LZClose 
        /// frees any global heap space that was allocated to expand the file.
        /// </remarks>
        public static void LZClose(int hFile)
        {
            Native.LZClose(hFile);
        }

        /// <summary>
        /// Copies a source file to a destination file. If the source file has been compressed by the 
        /// Lempel-Ziv algorithm, this function creates a decompressed destination file. If the source file
        /// is not compressed, this function duplicates the original file
        /// </summary>
        /// <param name="hfSource">A handle to the source file</param>
        /// <param name="hfDest">A handle to the destination file</param>
        /// <returns>If the function succeeds, the return value specifies the size, in bytes, of the destination file.
        /// If the function fails, the return value is an LZERROR_* code. These codes have values less than zero, use
        /// LZError enum to map the error code. There is no extended error information for this function;
        /// DO NOT call GetLastError
        /// </returns>
        /// <remarks>LZCopy calls neither SetLastError nor SetLastErrorEx; thus, its failure does not affect
        /// a thread's last-error code.</remarks>
        public static int LZCopy(int hfSource, int hfDest)
        {
            return Native.LZCopy(hfSource, hfDest);
        }

        /// <summary>
        /// Creates, opens, reopens, or deletes the specified file
        /// </summary>
        /// <param name="lpFileName">The name of the file</param>
        /// <param name="lpReOpenBuf">A pointer to the OFSTRUCT structure that is to receive information about the
        /// file when the file is first opened. The structure can be used in subsequent calls to the LZOpenFile 
        /// function to see the open file</param>
        /// <param name="wStyle">The action to be taken</param>
        /// <returns>If the function succeeds and the value specified by the wStyle parameter is not OF_READ, the
        /// return value is a handle identifying the file. If the file is compressed and opened with wStyle set to
        /// OF_READ, the return value is a special file handle</returns>
        /// <remarks>If the function fails, the return value is an LZERROR_* code. Use the LZError enum to map the error code.
        /// These codes have values less than zero. There is no extended error information for this function;
        /// DO NOT call GetLastError.</remarks>
        public static int LZOpenFile(StringBuilder lpFileName, ref OFStruct lpReOpenBuf, OpenFileMode wStyle)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.LZOpenFileW(lpFileName, ref lpReOpenBuf, wStyle) : Native.LZOpenFileA(lpFileName, ref lpReOpenBuf, wStyle);
        }

        /// <summary>
        /// Allocates memory for the internal data structures required to decompress files,
        /// and then creates and initializes them
        /// </summary>
        /// <param name="hfSource">A handle to the file</param>
        /// <returns>If the function succeeds, the return value is a new LZ file handle.
        /// If the function fails, the return value is an LZERROR_* code. Use LZError enum 
        /// to map the error code. These codes have values less than zero. Note that LZInit
        /// calls neither SetLastError nor SetLastErrorEx; thus, its failure does not affect 
        /// a thread's last-error code.</returns>
        /// <remarks>There is no extended error information for this function; DO NOT call GetLastError.
        /// A maximum of 16 compressed files can be open at any given time.</remarks>
        public static int LZInit(int hfSource)
        {
            return Native.LZInit(hfSource);
        }

        /// <summary>
        /// Reads (at most) the specified number of bytes from a file and copies them into a buffer
        /// </summary>
        /// <param name="hFile">A handle to the file</param>
        /// <param name="lpBuffer">A pointer to a buffer that receives the bytes read from the file.
        /// Ensure that this buffer is larger than cbRead</param>
        /// <param name="cbRead">The count of bytes to be read</param>
        /// <returns>If the function succeeds, the return value specifies the number of bytes read.
        /// If the function fails, the return value is an LZERROR_* code. These codes have values 
        /// less than zero, use LZError enum to map the error code</returns>
        /// <remarks>LZRead calls neither SetLastError nor SetLastErrorEx; thus, 
        /// its failure does not affect a thread's last-error code.
        /// Thus, DO NOT call GetLastError</remarks>
        public static int LZRead(int hFile, StringBuilder lpBuffer, int cbRead)
        {
            return Native.LZRead(hFile, lpBuffer, cbRead);
        }

        /// <summary>
        /// Moves a file pointer the specified number of bytes from a starting position
        /// </summary>
        /// <param name="hFile">A handle to the file</param>
        /// <param name="lOffset">The number of bytes by which to move the file pointer</param>
        /// <param name="iOrigin">The starting position of the pointer</param>
        /// <returns>If the function succeeds, the return value specifies the offset from the beginning of
        /// the file to the new pointer position.
        /// If the function fails, the return value is an LZERROR_* code. These codes have values less than
        /// zero, use LZError enum to map the error.</returns>
        /// <remarks>LZSeek calls neither SetLastError nor SetLastErrorEx; thus, its failure does not 
        /// affect a thread's last-error code. Thus, DO NOT call GetLastError</remarks>
        public static int LZSeek(int hFile, int lOffset, int iOrigin)
        {
            return Native.LZSeek(hFile, lOffset, iOrigin);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("Lz32.dll", EntryPoint = "CopyLZFile", SetLastError = true)]
            public static extern int CopyLZFile(int param0, int param1);

            [DllImport("Lz32.dll", EntryPoint = "GetExpandedNameA")]
            public static extern int GetExpandedNameA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0,
                                                      [MarshalAs(UnmanagedType.LPStr)] StringBuilder param1);

            [DllImport("Lz32.dll", EntryPoint = "GetExpandedNameW")]
            public static extern int GetExpandedNameW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0,
                                                      [MarshalAs(UnmanagedType.LPWStr)] StringBuilder param1);

            [DllImport("Lz32.dll", EntryPoint = "LZClose", SetLastError = true)]
            public static extern void LZClose(int param0);

            [DllImport("Lz32.dll", EntryPoint = "LZCopy")]
            public static extern int LZCopy(int param0, int param1);

            [DllImport("Lz32.dll", EntryPoint = "LZOpenFileA")]
            public static extern int LZOpenFileA([MarshalAs(UnmanagedType.LPStr)] StringBuilder param0,
                                                 ref OFStruct param1, OpenFileMode param2);

            [DllImport("Lz32.dll", EntryPoint = "LZOpenFileW")]
            public static extern int LZOpenFileW([MarshalAs(UnmanagedType.LPWStr)] StringBuilder param0,
                                                 ref OFStruct param1, OpenFileMode param2);

            [DllImport("Lz32.dll", EntryPoint = "LZInit")]
            public static extern int LZInit(int param0);

            [DllImport("Lz32.dll", EntryPoint = "LZRead")]
            public static extern int LZRead(int param0, [MarshalAs(UnmanagedType.LPStr)] StringBuilder param1,
                                            int param2);

            [DllImport("Lz32.dll", EntryPoint = "LZSeek")]
            public static extern int LZSeek(int param0, int param1, int param2);
        }

        #endregion
    }
}