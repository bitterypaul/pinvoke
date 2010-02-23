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

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signature of handling operating system's change notification signal
    /// </summary>
    public class ChangeNotification
    {
        /// <summary>
        /// Stops change notification handle monitoring
        /// </summary>
        /// <param name="hChangeHandle">A handle to a change notification handle created by the FindFirstChangeNotification function</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        /// <remarks>After the FindCloseChangeNotification function is called, the handle specified by the hChangeHandle parameter
        /// cannot be used in subsequent calls to either the FindNextChangeNotification or FindCloseChangeNotification function</remarks>
        public static bool FindCloseChangeNotification([In] IntPtr hChangeHandle)
        {
            return Native.FindCloseChangeNotification(hChangeHandle);
        }

        /// <summary>
        /// Creates a change notification handle and sets up initial change notification filter conditions. A wait on a notification handle 
        /// succeeds when a change matching the filter conditions occurs in the specified directory or subtree. The function does not report
        /// changes to the specified directory itself.
        /// This function does not indicate the change that satisfied the wait condition. To retrieve information about the specific change 
        /// as part of the notification, use the ReadDirectoryChangesW function
        /// </summary>
        /// <param name="lpPathName">The path of the directory to be watched</param>
        /// <param name="bWatchSubtree">If this parameter is true, the function monitors the directory tree rooted at the specified directory;
        /// if it is false, it monitors only the specified directory</param>
        /// <param name="dwNotifyFilter">The filter conditions that satisfy a change notification wait</param>
        /// <returns>If the function succeeds, the return value is a handle to a find change notification object</returns>
        public static IntPtr FindFirstChangeNotification([In] string lpPathName, bool bWatchSubtree,
                                                         FileNotifyChange dwNotifyFilter)
        {
            return Environment.OSVersion.Platform >= PlatformID.Win32NT ? Native.FindFirstChangeNotificationW(lpPathName, bWatchSubtree, dwNotifyFilter) : Native.FindFirstChangeNotificationA(lpPathName, bWatchSubtree, dwNotifyFilter);
        }

        /// <summary>
        /// Requests that the operating system signal a change notification handle the next time it detects an appropriate change
        /// </summary>
        /// <param name="hChangeHandle">A handle to a change notification handle created by the FindFirstChangeNotification function</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool FindNextChangeNotification([In] IntPtr hChangeHandle)
        {
            return Native.FindNextChangeNotification(hChangeHandle);
        }

        /// <summary>
        /// The FindNextPrinterChangeNotification function retrieves information about the most recent change notification for a 
        /// change notification object associated with a printer or print server. Call this function when a wait operation on the
        /// change notification object is satisfied.
        /// The function also resets the change notification object to the not-signaled state. You can then use the object in another
        /// wait operation to continue monitoring the printer or print server. The operating system will set the object to the signaled 
        /// state the next time one of a specified set of changes occurs to the printer or print server. The FindFirstPrinterChangeNotification
        /// function creates the change notification object and specifies the set of changes to be monitored
        /// </summary>
        /// <param name="hChange">Handle to a change notification object associated with a printer or print server. You obtain such a handle by
        /// calling the FindFirstPrinterChangeNotification function. The operating system sets this change notification object 
        /// to the signaled state when it detects one of the changes specified in the object's change notification filter</param>
        /// <param name="pdwChange">A variable whose bits are set to indicate the changes that occurred to cause the most recent 
        /// notification. The bit flags that might be set correspond to those specified in the fdwFlags parameter of the 
        /// FindFirstPrinterChangeNotification call</param>
        /// <param name="pPrinterNotifyOptions">A PRINTER_NOTIFY_OPTIONS structure. Set the Flags member of this structure to PRINTER_NOTIFY_OPTIONS_REFRESH,
        /// to cause the function to return the current data for all monitored printer information fields. The function ignores all other members of the structure. This parameter can be null</param>
        /// <param name="ppPrinterNotifyInfo">Pointer to a pointer variable that receives a pointer to a system-allocated, read-only buffer. 
        /// Call the FreePrinterNotifyInfo function to free the buffer when you are finished with it. This parameter can be null if no information is required</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool FindNextPrinterChangeNotification([In] IntPtr hChange, out PrinterChangeStatus pdwChange,
                                                             [In] PrinterNotifyOptions pPrinterNotifyOptions,
                                                             ref IntPtr ppPrinterNotifyInfo)
        {
            return Native.FindNextPrinterChangeNotification(hChange, out pdwChange, ppPrinterNotifyInfo,
                                                            ref ppPrinterNotifyInfo);
        }

        /// <summary>
        /// The FindNextPrinterChangeNotification function retrieves information about the most recent change notification for a 
        /// change notification object associated with a printer or print server. Call this function when a wait operation on the
        /// change notification object is satisfied.
        /// The function also resets the change notification object to the not-signaled state. You can then use the object in another
        /// wait operation to continue monitoring the printer or print server. The operating system will set the object to the signaled 
        /// state the next time one of a specified set of changes occurs to the printer or print server. The FindFirstPrinterChangeNotification
        /// function creates the change notification object and specifies the set of changes to be monitored
        /// </summary>
        /// <param name="hChange">Handle to a change notification object associated with a printer or print server. You obtain such a handle by
        /// calling the FindFirstPrinterChangeNotification function. The operating system sets this change notification object 
        /// to the signaled state when it detects one of the changes specified in the object's change notification filter</param>
        /// <param name="pdwChange">A variable whose bits are set to indicate the changes that occurred to cause the most recent 
        /// notification. The bit flags that might be set correspond to those specified in the fdwFlags parameter of the 
        /// FindFirstPrinterChangeNotification call</param>
        /// <param name="pPrinterNotifyOptions">Pointer to a PRINTER_NOTIFY_OPTIONS structure. Set the Flags member of this structure to PRINTER_NOTIFY_OPTIONS_REFRESH,
        /// to cause the function to return the current data for all monitored printer information fields. The function ignores all other members of the structure. This parameter can be null</param>
        /// <param name="ppPrinterNotifyInfo">Pointer to a pointer variable that receives a pointer to a system-allocated, read-only buffer. 
        /// Call the FreePrinterNotifyInfo function to free the buffer when you are finished with it. This parameter can be null if no information is required</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool FindNextPrinterChangeNotification([In] IntPtr hChange, out PrinterChangeStatus pdwChange,
                                                             IntPtr pPrinterNotifyOptions,
                                                             ref IntPtr ppPrinterNotifyInfo)
        {
            return Native.FindNextPrinterChangeNotification(hChange, out pdwChange, pPrinterNotifyOptions,
                                                            ref ppPrinterNotifyInfo);
        }

        /// <summary>
        /// The FindFirstPrinterChangeNotification function creates a change notification object and 
        /// returns a handle to the object. You can then use this handle in a call to one of the wait 
        /// functions to monitor changes to the printer or print server. 
        /// The FindFirstPrinterChangeNotification call specifies the type of changes to be monitored.
        /// You can specify a set of conditions to monitor for changes, a set of printer information 
        /// fields to monitor, or both
        /// </summary>
        /// <param name="hPrinter">Handle to the printer or print server that you want to monitor. Use the 
        /// OpenPrinter or AddPrinter function to retrieve a printer handle</param>
        /// <param name="fdwFlags">Specify the conditions that will cause the change notification object to 
        /// enter a signaled state. A change notification occurs when one or more of the specified conditions
        /// are met. The fdwFlags parameter can be zero if pPrinterNotifyOptions is non-null</param>
        /// <param name="fdwOptions">Reserved; must be zero</param>
        /// <param name="pPrinterNotifyOptions">A PRINTER_NOTIFY_OPTIONS structure. The pTypes member of this structure
        /// is an array of one or more PRINTER_NOTIFY_OPTIONS_TYPE structures, each of which specifies a printer information field to monitor.
        /// A change notification occurs when one or more of the specified fields changes. When a change occurs, the 
        /// FindNextPrinterChangeNotification function can retrieve the new printer information. This parameter can be null if fdwFlags is nonzero</param>
        /// <returns>If the function succeeds, the return value is a handle to a change notification object associated with the specified printer or print server,
        /// If the function fails, the return value is invalid handle.</returns>
        public static IntPtr FindFirstPrinterChangeNotification([In] IntPtr hPrinter, PrinterChangeStatus fdwFlags,
                                                                uint fdwOptions,
                                                                [MarshalAs(UnmanagedType.LPStruct)] PrinterNotifyOptions pPrinterNotifyOptions)
        {
            return Native.FindFirstPrinterChangeNotification(hPrinter, fdwFlags, fdwOptions, pPrinterNotifyOptions);
        }

        /// <summary>
        /// The FindFirstPrinterChangeNotification function creates a change notification object and 
        /// returns a handle to the object. You can then use this handle in a call to one of the wait 
        /// functions to monitor changes to the printer or print server. 
        /// The FindFirstPrinterChangeNotification call specifies the type of changes to be monitored.
        /// You can specify a set of conditions to monitor for changes, a set of printer information 
        /// fields to monitor, or both
        /// </summary>
        /// <param name="hPrinter">Handle to the printer or print server that you want to monitor. Use the 
        /// OpenPrinter or AddPrinter function to retrieve a printer handle</param>
        /// <param name="fdwFlags">Specify the conditions that will cause the change notification object to 
        /// enter a signaled state. A change notification occurs when one or more of the specified conditions
        /// are met. The fdwFlags parameter can be zero if pPrinterNotifyOptions is non-null</param>
        /// <param name="fdwOptions">Reserved; must be zero</param>
        /// <param name="pPrinterNotifyOptions">Pointer to a PRINTER_NOTIFY_OPTIONS structure. The pTypes member of this structure
        /// is an array of one or more PRINTER_NOTIFY_OPTIONS_TYPE structures, each of which specifies a printer information field to monitor.
        /// A change notification occurs when one or more of the specified fields changes. When a change occurs, the 
        /// FindNextPrinterChangeNotification function can retrieve the new printer information. This parameter can be null if fdwFlags is nonzero</param>
        /// <returns>If the function succeeds, the return value is a handle to a change notification object associated with the specified printer or print server,
        /// If the function fails, the return value is invalid handle.</returns>
        public static IntPtr FindFirstPrinterChangeNotification([In] IntPtr hPrinter, PrinterChangeStatus fdwFlags,
                                                                uint fdwOptions, [In] IntPtr pPrinterNotifyOptions)
        {
            return Native.FindFirstPrinterChangeNotification(hPrinter, fdwFlags, fdwOptions, pPrinterNotifyOptions);
        }

        /// <summary>
        /// The FindClosePrinterChangeNotification function closes a change notification object created by calling the FindFirstPrinterChangeNotification
        /// function. The printer or print server associated with the change notification object will no longer be monitored by that object
        /// </summary>
        /// <param name="hChange">Handle to the change notification object to be closed. This is a handle created by calling the FindFirstPrinterChangeNotification function</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool FindClosePrinterChangeNotification([In] IntPtr hChange)
        {
            return Native.FindCloseChangeNotification(hChange);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("kernel32.dll", EntryPoint = "FindCloseChangeNotification", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FindCloseChangeNotification([In] IntPtr hChangeHandle);

            [DllImport("kernel32.dll", EntryPoint = "FindFirstChangeNotificationA", SetLastError = true)]
            public static extern IntPtr FindFirstChangeNotificationA(
                [In] [MarshalAs(UnmanagedType.LPStr)] string lpPathName,
                [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, FileNotifyChange dwNotifyFilter);

            [DllImport("kernel32.dll", EntryPoint = "FindFirstChangeNotificationW", SetLastError = true)]
            public static extern IntPtr FindFirstChangeNotificationW(
                [In] [MarshalAs(UnmanagedType.LPWStr)] string lpPathName,
                [MarshalAs(UnmanagedType.Bool)] bool bWatchSubtree, FileNotifyChange dwNotifyFilter);

            [DllImport("kernel32.dll", EntryPoint = "FindNextChangeNotification", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FindNextChangeNotification([In] IntPtr hChangeHandle);

            [DllImport("winspool.drv", EntryPoint = "FindNextPrinterChangeNotification",
                CallingConvention = CallingConvention.StdCall, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FindNextPrinterChangeNotification([In] IntPtr hChange,
                                                                        out PrinterChangeStatus pdwChange,
                                                                        [In] PrinterNotifyOptions
                                                                            pPrinterNotifyOptions,
                                                                        ref IntPtr ppPrinterNotifyInfo);

            [DllImport("winspool.drv", EntryPoint = "FindNextPrinterChangeNotification",
                SetLastError = true, CharSet = CharSet.Auto, ExactSpelling = true,
                CallingConvention = CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FindNextPrinterChangeNotification([In] IntPtr hChange,
                                                                        out PrinterChangeStatus pdwChange,
                                                                        IntPtr pPrinterNotifyOptions,
                                                                        ref IntPtr ppPrinterNotifyInfo);

            [DllImport("winspool.drv", EntryPoint = "FindFirstPrinterChangeNotification",
                CallingConvention = CallingConvention.StdCall, SetLastError = true)]
            public static extern IntPtr FindFirstPrinterChangeNotification([In] IntPtr hPrinter,
                                                                           PrinterChangeStatus fdwFlags, uint fdwOptions,
                                                                           [MarshalAs(UnmanagedType.LPStruct)] PrinterNotifyOptions
                                                                               pPrinterNotifyOptions);

            [DllImport("winspool.drv", EntryPoint = "FindFirstPrinterChangeNotification",
                CallingConvention = CallingConvention.StdCall, SetLastError = true)]
            public static extern IntPtr FindFirstPrinterChangeNotification([In] IntPtr hPrinter,
                                                                           PrinterChangeStatus fdwFlags, uint fdwOptions,
                                                                           [In] IntPtr pPrinterNotifyOptions);

            [DllImport("winspool.drv", EntryPoint = "FindClosePrinterChangeNotification", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool FindClosePrinterChangeNotification([In] IntPtr hChange);
        }

        #endregion
    }
}