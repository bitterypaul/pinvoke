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
    /// Indicates the field that changed for pPrinterFields member in PRINTER_NOTIFY_OPTIONS_TYPE structure
    /// </summary>
    [Flags]
    internal enum PrinterNotifyField : short
    {
        /// <summary>
        /// Not supported.
        /// </summary>
        PRINTER_NOTIFY_FIELD_SERVER_NAME = 0x00,
        /// <summary>
        /// Name of the printer
        /// </summary>
        PRINTER_NOTIFY_FIELD_PRINTER_NAME = 0x01,
        /// <summary>
        /// Sharepoint for the printer.
        /// </summary>
        PRINTER_NOTIFY_FIELD_SHARE_NAME = 0x02,
        /// <summary>
        /// Name of the port that the print jobs will be printed to. 
        /// If "Printer Pooling" is selected, this is a comma separated list of ports.
        /// </summary>
        PRINTER_NOTIFY_FIELD_PORT_NAME = 0x03,
        /// <summary>
        /// Name of the printer's driver.
        /// </summary>
        PRINTER_NOTIFY_FIELD_DRIVER_NAME = 0x04,
        /// <summary>
        /// New comment string, which is typically a brief description of the printer.
        /// </summary>
        PRINTER_NOTIFY_FIELD_COMMENT = 0x05,
        /// <summary>
        /// New physical location of the printer (for example, "Bldg. 38, Room 1164").
        /// </summary>
        PRINTER_NOTIFY_FIELD_LOCATION = 0x06,
        /// <summary>
        /// DEVMODE structure that defines default printer data such as the paper orientation and the resolution
        /// </summary>
        PRINTER_NOTIFY_FIELD_DEVMODE = 0x07,
        /// <summary>
        /// name of the file used to create the separator page. 
        /// This page is used to separate print jobs sent to the printer. 
        /// </summary>
        PRINTER_NOTIFY_FIELD_SEPFILE = 0x08,
        /// <summary>
        /// Name of the print processor used by the printer.
        /// </summary>
        PRINTER_NOTIFY_FIELD_PRINT_PROCESSOR = 0x09,
        /// <summary>
        /// Default print-processor parameters.
        /// </summary>
        PRINTER_NOTIFY_FIELD_PARAMETERS = 0x0A,
        /// <summary>
        /// Data type used to record the print job. 
        /// </summary>
        PRINTER_NOTIFY_FIELD_DATATYPE = 0x0B,
        /// <summary>
        /// SECURITY_DESCRIPTOR structure for the printer. 
        /// The pointer may be null if there is no security descriptor
        /// </summary>
        PRINTER_NOTIFY_FIELD_SECURITY_DESCRIPTOR = 0x0C,
        /// <summary>
        /// Printer attributes
        /// </summary>
        PRINTER_NOTIFY_FIELD_ATTRIBUTES = 0x0D,
        /// <summary>
        /// Priority value that the spooler uses to route print jobs
        /// </summary>
        PRINTER_NOTIFY_FIELD_PRIORITY = 0x0E,
        /// <summary>
        /// Default priority value assigned to each print job
        /// </summary>
        PRINTER_NOTIFY_FIELD_DEFAULT_PRIORITY = 0x0F,
        /// <summary>
        /// Earliest time at which the printer will print a job. 
        /// (This value is specified in minutes elapsed since 12:00 A.M.) 
        /// </summary>
        PRINTER_NOTIFY_FIELD_START_TIME = 0x10,
        /// <summary>
        /// Latest time at which the printer will print a job. 
        /// (This value is specified in minutes elapsed since 12:00 A.M.) 
        /// </summary>
        PRINTER_NOTIFY_FIELD_UNTIL_TIME = 0x11,
        /// <summary>
        /// The printer status
        /// </summary>
        PRINTER_NOTIFY_FIELD_STATUS = 0x12,
        /// <summary>
        /// Not supported
        /// </summary>
        PRINTER_NOTIFY_FIELD_STATUS_STRING = 0x13,
        /// <summary>
        /// Number of print jobs that have been queued for the printer. 
        /// </summary>
        PRINTER_NOTIFY_FIELD_CJOBS = 0x14,
        /// <summary>
        /// Average number of pages per minute that have been printed on the printer.
        /// </summary>
        PRINTER_NOTIFY_FIELD_AVERAGE_PPM = 0x15,
        /// <summary>
        /// Not supported
        /// </summary>
        PRINTER_NOTIFY_FIELD_TOTAL_PAGES = 0x16,
        /// <summary>
        /// Not supported
        /// </summary>
        PRINTER_NOTIFY_FIELD_PAGES_PRINTED = 0x17,
        /// <summary>
        /// Not supported
        /// </summary>
        PRINTER_NOTIFY_FIELD_TOTAL_BYTES = 0x18,
        /// <summary>
        /// Not supported
        /// </summary>
        PRINTER_NOTIFY_FIELD_BYTES_PRINTED = 0x19,
        /// <summary>
        /// This is set if the object GUID changes
        /// </summary>
        PRINTER_NOTIFY_FIELD_OBJECT_GUID = 0x1A,
        /// <summary>
        /// This is set if the printer connection is renamed
        /// </summary>
        PRINTER_NOTIFY_FIELD_FRIENDLY_NAME = 0x1B
    }
}