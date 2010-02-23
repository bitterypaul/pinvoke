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

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// The PRINTER_NOTIFY_OPTIONS_TYPE structure specifies the set of printer or job information fields to be
    /// monitored by a printer change notification object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class PrinterNotifyOptionsType
    {
        /// <summary>
        /// Specifies the type to watch is printer
        /// </summary>
        public short wPrinterType;

        /// <summary>
        /// Reserved
        /// </summary>
        public short wPrinterReserved0;

        /// <summary>
        /// Reserved
        /// </summary>
        public int dwPrinterReserved1;

        /// <summary>
        /// Reserved
        /// </summary>
        public int dwPrinterReserved2;

        /// <summary>
        /// Specifies the number of elements in the pPrinterFields array
        /// </summary>
        public int PrinterFieldCount;

        /// <summary>
        /// Pointer to an array of values. Each element of the array specifies a 
        /// printer information field of interest.
        /// </summary>
        public IntPtr pPrinterFields;

        /// <summary>
        /// Specifies the type to watch is job
        /// </summary>
        public short wJobType;

        /// <summary>
        /// Reserved
        /// </summary>
        public short wJobReserved0;

        /// <summary>
        /// Reserved
        /// </summary>
        public int dwJobReserved1;

        /// <summary>
        /// Reserved
        /// </summary>
        public int dwJobReserved2;

        /// <summary>
        /// Specifies the number of elements in the pJobFields array
        /// </summary>
        public int JobFieldCount;

        /// <summary>
        /// Pointer to an array of values. Each element of the array specifies a 
        /// job information field of interest.
        /// </summary>
        public IntPtr pJobFields;

        /// <summary>
        /// Instantiate a PRINTER_NOTIFY_OPTIONS_TYPE object
        /// </summary>
        public PrinterNotifyOptionsType()
        {
            wPrinterType = 0;
            PrinterFieldCount = 20;
            pPrinterFields = Marshal.AllocCoTaskMem(42);

            Marshal.WriteInt16(pPrinterFields, 0, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_PRINTER_NAME);
            Marshal.WriteInt16(pPrinterFields, 2, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_SHARE_NAME);
            Marshal.WriteInt16(pPrinterFields, 4, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_PORT_NAME);
            Marshal.WriteInt16(pPrinterFields, 6, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_DRIVER_NAME);
            Marshal.WriteInt16(pPrinterFields, 8, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_COMMENT);
            Marshal.WriteInt16(pPrinterFields, 10, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_LOCATION);
            Marshal.WriteInt16(pPrinterFields, 12, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_DEVMODE);
            Marshal.WriteInt16(pPrinterFields, 14, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_SEPFILE);
            Marshal.WriteInt16(pPrinterFields, 16, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_PRINT_PROCESSOR);
            Marshal.WriteInt16(pPrinterFields, 18, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_PARAMETERS);
            Marshal.WriteInt16(pPrinterFields, 20, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_DATATYPE);
            Marshal.WriteInt16(pPrinterFields, 22, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_SECURITY_DESCRIPTOR);
            Marshal.WriteInt16(pPrinterFields, 24, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_ATTRIBUTES);
            Marshal.WriteInt16(pPrinterFields, 26, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_PRIORITY);
            Marshal.WriteInt16(pPrinterFields, 28, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_DEFAULT_PRIORITY);
            Marshal.WriteInt16(pPrinterFields, 30, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_START_TIME);
            Marshal.WriteInt16(pPrinterFields, 32, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_UNTIL_TIME);
            Marshal.WriteInt16(pPrinterFields, 34, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_STATUS);
            //PrinterNotifyType.STATUS_STRING //not supported
            Marshal.WriteInt16(pPrinterFields, 36, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_CJOBS);
            //Marshal.WriteInt16(this.pPrinterFields, 38, (short)PrinterNotifyType.AVERAGE_PPM);
            //PrinterNotifyType.TOTAL_PAGES //not supported
            //PrinterNotifyType.PAGES_PRINTED //not supported
            //PrinterNotifyType.TOTAL_BYTES //not supported
            Marshal.WriteInt16(pPrinterFields, 38, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_BYTES_PRINTED);
            //not supported
            Marshal.WriteInt16(pPrinterFields, 40, (short) PrinterNotifyField.PRINTER_NOTIFY_FIELD_OBJECT_GUID);


            wJobType = 1;
            JobFieldCount = 22;
            pJobFields = Marshal.AllocCoTaskMem(46);
            Marshal.WriteInt16(pJobFields, 0, (short) JobNotifyField.JOB_NOTIFY_FIELD_PRINTER_NAME);
            Marshal.WriteInt16(pJobFields, 2, (short) JobNotifyField.JOB_NOTIFY_FIELD_MACHINE_NAME);
            Marshal.WriteInt16(pJobFields, 4, (short) JobNotifyField.JOB_NOTIFY_FIELD_PORT_NAME);
            Marshal.WriteInt16(pJobFields, 6, (short) JobNotifyField.JOB_NOTIFY_FIELD_USER_NAME);
            Marshal.WriteInt16(pJobFields, 8, (short) JobNotifyField.JOB_NOTIFY_FIELD_NOTIFY_NAME);
            Marshal.WriteInt16(pJobFields, 10, (short) JobNotifyField.JOB_NOTIFY_FIELD_DATATYPE);
            Marshal.WriteInt16(pJobFields, 12, (short) JobNotifyField.JOB_NOTIFY_FIELD_PRINT_PROCESSOR);
            Marshal.WriteInt16(pJobFields, 14, (short) JobNotifyField.JOB_NOTIFY_FIELD_PARAMETERS);
            Marshal.WriteInt16(pJobFields, 16, (short) JobNotifyField.JOB_NOTIFY_FIELD_DRIVER_NAME);
            Marshal.WriteInt16(pJobFields, 18, (short) JobNotifyField.JOB_NOTIFY_FIELD_DEVMODE);
            Marshal.WriteInt16(pJobFields, 20, (short) JobNotifyField.JOB_NOTIFY_FIELD_STATUS);
            Marshal.WriteInt16(pJobFields, 22, (short) JobNotifyField.JOB_NOTIFY_FIELD_STATUS_STRING);
            //JobNotifyField.SECURITY_DESCRIPTOR) //Not supported
            Marshal.WriteInt16(pJobFields, 24, (short) JobNotifyField.JOB_NOTIFY_FIELD_DOCUMENT);
            Marshal.WriteInt16(pJobFields, 26, (short) JobNotifyField.JOB_NOTIFY_FIELD_PRIORITY);
            Marshal.WriteInt16(pJobFields, 28, (short) JobNotifyField.JOB_NOTIFY_FIELD_POSITION);
            Marshal.WriteInt16(pJobFields, 30, (short) JobNotifyField.JOB_NOTIFY_FIELD_SUBMITTED);
            Marshal.WriteInt16(pJobFields, 32, (short) JobNotifyField.JOB_NOTIFY_FIELD_START_TIME);
            Marshal.WriteInt16(pJobFields, 34, (short) JobNotifyField.JOB_NOTIFY_FIELD_UNTIL_TIME);
            Marshal.WriteInt16(pJobFields, 36, (short) JobNotifyField.JOB_NOTIFY_FIELD_TIME);
            Marshal.WriteInt16(pJobFields, 38, (short) JobNotifyField.JOB_NOTIFY_FIELD_TOTAL_PAGES);
            Marshal.WriteInt16(pJobFields, 40, (short) JobNotifyField.JOB_NOTIFY_FIELD_PAGES_PRINTED);
            Marshal.WriteInt16(pJobFields, 42, (short) JobNotifyField.JOB_NOTIFY_FIELD_TOTAL_BYTES);
            Marshal.WriteInt16(pJobFields, 44, (short) JobNotifyField.JOB_NOTIFY_FIELD_BYTES_PRINTED);
        }


        ~PrinterNotifyOptionsType()
        {
            Marshal.FreeCoTaskMem(pJobFields);
            Marshal.FreeCoTaskMem(pPrinterFields);
        }
    }
}