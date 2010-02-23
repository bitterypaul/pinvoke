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
using System.Runtime.InteropServices;
using System.Text;

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signature of Clipboard APIs
    /// </summary>
    public class Clipboard
    {
        /// <summary>
        /// Places the given window in the system-maintained clipboard format listener list
        /// </summary>
        /// <param name="hwnd">Handle to the window to place in the clipboard format listener list</param>
        /// <returns>Returns true if successful, false otherwise</returns>
        public static bool AddClipboardFormatListener([In] IntPtr hwnd)
        {
            var hostVersion = new OperatingSystemVersion();
            if (hostVersion.OSVersion == OSVersion.Vista)
            {
                return Native.AddClipboardFormatListener(hwnd);
            }
            throw new PlatformNotSupportedException("Windows platform not supported.\nVista or higher is required");
        }

        /// <summary>
        /// Retrieves the currently supported Clipboard formats
        /// </summary>
        /// <param name="lpuiFormats">When this function returns, contains a pointer to an array of ClipboardFormat
        /// that identify clipboard formats</param>
        /// <param name="cFormats">Specifies the number of entries in the array pointed to by lpuiFormats</param>
        /// <param name="pcFormatsOut">When this function returns, contains a pointer to the actual number of clipboard 
        /// formats in the array pointed to by lpuiFormats.</param>
        /// <returns>Returns true if successful; otherwise, false</returns>
        public static bool GetUpdatedClipboardFormats([Out] out IntPtr lpuiFormats, [In] uint cFormats,
                                                      [Out] out IntPtr pcFormatsOut)
        {
            var hostVersion = new OperatingSystemVersion();
            if (hostVersion.OSVersion == OSVersion.Vista)
            {
                return Native.GetUpdatedClipboardFormats(out lpuiFormats, cFormats, out pcFormatsOut);
            }
            throw new PlatformNotSupportedException("Windows platform not supported.\nVista or higher is required");
        }

        /// <summary>
        /// The CloseClipboard function closes the clipboard
        /// </summary>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool CloseClipboard()
        {
            return Native.CloseClipboard();
        }

        /// <summary>
        /// The EmptyClipboard function empties the clipboard and frees handles to data in the clipboard. The function
        /// then assigns ownership of the clipboard to the window that currently has the clipboard open
        /// </summary>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool EmptyClipboard()
        {
            return Native.EmptyClipboard();
        }

        /// <summary>
        /// The GetClipboardData function retrieves data from the clipboard in a specified format. 
        /// The clipboard must have been opened previously.
        /// </summary>
        /// <param name="uFormat">Specifies a clipboard format.</param>
        /// <returns>If the function succeeds, the return value is the handle to a clipboard object 
        /// in the specified format. If the function fails, the return value is null.
        /// </returns>
        public static IntPtr GetClipboardData(ClipboardFormat uFormat)
        {
            return Native.GetClipboardData(uFormat);
        }

        /// <summary>
        /// The SetClipboardData function places data on the clipboard in a specified clipboard format.
        /// The window must be the current clipboard owner, and the application must have called the 
        /// OpenClipboard function. (When responding to the WindowsMessage.WM_RENDERFORMAT and WindowsMessage.WM_RENDERALLFORMATS messages,
        /// the clipboard owner must not call OpenClipboard before calling SetClipboardData.)
        /// </summary>
        /// <param name="uFormat">Specifies a clipboard format. This parameter can be a registered format or any of the standard clipboard formats.</param>
        /// <param name="hMem">Handle to the data in the specified format. This parameter can be null, indicating that the window provides data in the 
        /// specified clipboard format (renders the format) upon request. If a window delays rendering, it must process the WindowsMessage.WM_RENDERFORMAT and 
        /// WindowsMessage.WM_RENDERALLFORMATS messages. </param>
        /// <returns>If the function succeeds, the return value is the handle to the data. If the function fails, the return value is null
        /// </returns>
        public static IntPtr SetClipboardData(ClipboardFormat uFormat, [In] IntPtr hMem)
        {
            return Native.SetClipboardData(uFormat, hMem);
        }

        /// <summary>
        /// The IsClipboardFormatAvailable function determines whether 
        /// the clipboard contains data in the specified format
        /// </summary>
        /// <param name="format">Specifies a standard or registered clipboard format</param>
        /// <returns>If the clipboard format is available, the return value is true, else false</returns>
        public static bool IsClipboardFormatAvailable(ClipboardFormat format)
        {
            return Native.IsClipboardFormatAvailable(format);
        }

        /// <summary>
        /// The OpenClipboard function opens the clipboard for examination and prevents
        /// other applications from modifying the clipboard content
        /// </summary>
        /// <param name="hWndNewOwner">Handle to the window to be associated with the open clipboard.
        /// If this parameter is null, the open clipboard is associated with the current task. 
        /// </param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool OpenClipboard([In] IntPtr hWndNewOwner)
        {
            return Native.OpenClipboard(hWndNewOwner);
        }

        /// <summary>
        /// The GetClipboardViewer function retrieves the handle to the first window 
        /// in the clipboard viewer chain
        /// </summary>
        /// <returns>If the function succeeds, the return value is the handle to the first
        /// window in the clipboard viewer chain. If there is no clipboard viewer, the return 
        /// value is null </returns>
        public static IntPtr GetClipboardViewer()
        {
            return Native.GetClipboardViewer();
        }

        /// <summary>
        /// The SetClipboardViewer function adds the specified window to the chain of clipboard viewers.
        /// Clipboard viewer windows receive a WindowsMessage.WM_DRAWCLIPBOARD message whenever the content of the 
        /// clipboard changes
        /// </summary>
        /// <param name="hWndNewViewer">Handle to the window to be added to the clipboard chain</param>
        /// <returns>If the function succeeds, the return value identifies the next window in the clipboard
        /// viewer chain. If an error occurs or there are no other windows in the clipboard viewer chain, 
        /// the return value is null</returns>
        public static IntPtr SetClipboardViewer([In] IntPtr hWndNewViewer)
        {
            return Native.SetClipboardViewer(hWndNewViewer);
        }

        /// <summary>
        /// The ChangeClipboardChain function removes a specified window from the chain of clipboard viewers
        /// </summary>
        /// <param name="hWndRemove">Handle to the window to be removed from the chain. The handle must have been
        /// passed to the SetClipboardViewer </param>
        /// <param name="hWndNewNext">Handle to the window that follows the hWndRemove window in the clipboard viewer chain.
        /// (This is the handle returned by SetClipboardViewer, unless the sequence was changed in response to a WindowsMessage.WM_CHANGECBCHAIN message.) </param>
        /// <returns>The return value indicates the result of passing the WindowsMessage.WM_CHANGECBCHAIN message to the windows in the 
        /// clipboard viewer chain. Because a window in the chain typically returns false when it processes WindowsMessage.WM_CHANGECBCHAIN, 
        /// the return value from ChangeClipboardChain is typically false. If there is only one window in the chain, the return value is typically true.</returns>
        public static bool ChangeClipboardChain([In] IntPtr hWndRemove, [In] IntPtr hWndNewNext)
        {
            return Native.ChangeClipboardChain(hWndRemove, hWndNewNext);
        }

        /// <summary>
        /// The CountClipboardFormats function retrieves the number of different data formats currently on the clipboard.
        /// </summary>
        /// <returns>If the function succeeds, the return value is the number of different data formats currently on the
        /// clipboard. If the function fails, the return value is zero </returns>
        public static int CountClipboardFormats()
        {
            return Native.CountClipboardFormats();
        }

        /// <summary>
        /// The GetClipboardFormatName function retrieves from the clipboard the name of the specified registered format.
        /// The function copies the name to the specified buffer. 
        /// </summary>
        /// <param name="format">Specifies the type of format to be retrieved</param>
        /// <param name="lpszFormatName">Buffer that is to receive the format name</param>
        /// <param name="cchMaxCount">Specifies the maximum length, in TCHARs, of the string to be copied to the buffer. 
        /// If the name exceeds this limit, it is truncated. For the ANSI version of the function, this is the number of bytes.
        /// For the wide-character (Unicode) version, this is the number of characters.</param>
        /// <returns></returns>
        public static int GetClipboardFormatName(ClipboardFormat format, [Out] StringBuilder lpszFormatName,
                                                 int cchMaxCount)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.GetClipboardFormatNameW(format, lpszFormatName, cchMaxCount) : Native.GetClipboardFormatNameA(format, lpszFormatName, cchMaxCount);
        }

        /// <summary>
        /// The GetClipboardOwner function retrieves the window handle of the current owner of the clipboard
        /// </summary>
        /// <returns>If the function succeeds, the return value is the handle to the window that owns the clipboard.
        /// If the clipboard is not owned, the return value is null</returns>
        public static IntPtr GetClipboardOwner()
        {
            return Native.GetClipboardOwner();
        }

        /// <summary>
        /// The GetClipboardSequenceNumber function retrieves the clipboard sequence number for the current window station
        /// </summary>
        /// <returns>The return value is the clipboard sequence number. If you do not have WINSTA_ACCESSCLIPBOARD access to 
        /// the window station, the function returns zero.</returns>
        public static uint GetClipboardSequenceNumber()
        {
            return Native.GetClipboardSequenceNumber();
        }

        /// <summary>
        /// The GetOpenClipboardWindow function retrieves the handle to the window that currently has the clipboard open
        /// </summary>
        /// <returns>If the function succeeds, the return value is the handle to the window that has the clipboard open.
        /// If no window has the clipboard open, the return value is null</returns>
        public static IntPtr GetOpenClipboardWindow()
        {
            return Native.GetOpenClipboardWindow();
        }

        /// <summary>
        /// The GetPriorityClipboardFormat function retrieves the first available clipboard format in the specified list
        /// </summary>
        /// <param name="paFormatPriorityList">Array of clipboard formats, in priority order</param>
        /// <param name="cFormats">Specifies the number of entries in the paFormatPriorityList array. This value must
        /// not be greater than the number of entries in the list</param>
        /// <returns>If the function succeeds, the return value is the first clipboard format in the list for which data
        /// is available. If the clipboard is empty, the return value is null. If the clipboard contains data, but not 
        /// in any of the specified formats, the return value is –1.</returns>
        public static int GetPriorityClipboardFormat(ClipboardFormat[] paFormatPriorityList, int cFormats)
        {
            return Native.GetPriorityClipboardFormat(paFormatPriorityList, cFormats);
        }

        /// <summary>
        /// The RegisterClipboardFormat function registers a new clipboard format. This format can then be used as a valid clipboard format
        /// </summary>
        /// <param name="lpszFormat">Pointer to a null-terminated string that names the new format.</param>
        /// <returns>If the function succeeds, the return value identifies the registered clipboard format. 
        /// If the function fails, the return value is zero </returns>
        public static uint RegisterClipboardFormat([In] string lpszFormat)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.RegisterClipboardFormatW(lpszFormat) : Native.RegisterClipboardFormatA(lpszFormat);
        }

        /// <summary>
        /// Removes the given window from the system-maintained clipboard format listener list
        /// </summary>
        /// <param name="hwnd">Handle to the window to remove from the clipboard format listener list</param>
        /// <returns>Returns true if successful, false otherwise</returns>
        public static bool RemoveClipboardFormatListener([In] IntPtr hwnd)
        {
            return Native.RemoveClipboardFormatListener(hwnd);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("user32.dll", EntryPoint = "AddClipboardFormatListener", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AddClipboardFormatListener([In] IntPtr hwnd);

            [DllImport("user32.dll", EntryPoint = "GetUpdatedClipboardFormats", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetUpdatedClipboardFormats([Out] out IntPtr lpuiFormats, [In] uint cFormats,
                                                                 [Out] out IntPtr pcFormatsOut);

            [DllImport("user32.dll", EntryPoint = "CloseClipboard", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool CloseClipboard();

            [DllImport("user32.dll", EntryPoint = "EmptyClipboard", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool EmptyClipboard();

            [DllImport("user32.dll", EntryPoint = "GetClipboardData", SetLastError = true)]
            public static extern IntPtr GetClipboardData(ClipboardFormat uFormat);

            [DllImport("user32.dll", EntryPoint = "SetClipboardData", SetLastError = true)]
            public static extern IntPtr SetClipboardData(ClipboardFormat uFormat, [In] IntPtr hMem);

            [DllImport("user32.dll", EntryPoint = "IsClipboardFormatAvailable", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool IsClipboardFormatAvailable(ClipboardFormat format);

            [DllImport("user32.dll", EntryPoint = "OpenClipboard", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool OpenClipboard([In] IntPtr hWndNewOwner);

            [DllImport("user32.dll", EntryPoint = "GetClipboardViewer", SetLastError = true)]
            public static extern IntPtr GetClipboardViewer();

            [DllImport("user32.dll", EntryPoint = "SetClipboardViewer", SetLastError = true)]
            public static extern IntPtr SetClipboardViewer([In] IntPtr hWndNewViewer);

            [DllImport("user32.dll", EntryPoint = "ChangeClipboardChain", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool ChangeClipboardChain([In] IntPtr hWndRemove, [In] IntPtr hWndNewNext);

            [DllImport("user32.dll", EntryPoint = "CountClipboardFormats", SetLastError = true)]
            public static extern int CountClipboardFormats();

            [DllImport("user32.dll", EntryPoint = "GetClipboardFormatNameA", SetLastError = true)]
            public static extern int GetClipboardFormatNameA(ClipboardFormat format,
                                                             [Out] [MarshalAs(UnmanagedType.LPStr)] StringBuilder
                                                                 lpszFormatName, int cchMaxCount);

            [DllImport("user32.dll", EntryPoint = "GetClipboardFormatNameW", SetLastError = true)]
            public static extern int GetClipboardFormatNameW(ClipboardFormat format,
                                                             [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder
                                                                 lpszFormatName, int cchMaxCount);

            [DllImport("user32.dll", EntryPoint = "GetClipboardOwner", SetLastError = true)]
            public static extern IntPtr GetClipboardOwner();

            [DllImport("user32.dll", EntryPoint = "GetClipboardSequenceNumber", SetLastError = true)]
            public static extern uint GetClipboardSequenceNumber();

            [DllImport("user32.dll", EntryPoint = "GetOpenClipboardWindow", SetLastError = true)]
            public static extern IntPtr GetOpenClipboardWindow();

            [DllImport("user32.dll", EntryPoint = "GetPriorityClipboardFormat", SetLastError = true)]
            public static extern int GetPriorityClipboardFormat(
                [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4, SizeParamIndex = 1)] ClipboardFormat[] paFormatPriorityList, int cFormats);

            [DllImport("user32.dll", EntryPoint = "RegisterClipboardFormatA", SetLastError = true)]
            public static extern uint RegisterClipboardFormatA([In] [MarshalAs(UnmanagedType.LPStr)] string lpszFormat);

            [DllImport("user32.dll", EntryPoint = "RegisterClipboardFormatW", SetLastError = true)]
            public static extern uint RegisterClipboardFormatW([In] [MarshalAs(UnmanagedType.LPWStr)] string lpszFormat);

            [DllImport("user32.dll", EntryPoint = "RemoveClipboardFormatListener", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool RemoveClipboardFormatListener([In] IntPtr hwnd);
        }

        #endregion
    }
}