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
    /// Indicates the field that changed for pJobFields member in PRINTER_NOTIFY_OPTIONS_TYPE structure
    /// </summary>
    [Flags]
    internal enum JobNotifyField : short
    {
        /// <summary>
        /// Name of the printer for which the job is spooled.
        /// </summary>
        JOB_NOTIFY_FIELD_PRINTER_NAME = 0x00,
        /// <summary>
        /// Name of the machine that created the print job.
        /// </summary>
        JOB_NOTIFY_FIELD_MACHINE_NAME = 0x01,
        /// <summary>
        /// Port(s) used to transmit data to the printer. If a printer is connected to more than one
        /// port, the names of the ports are separated by commas (for example, "LPT1:,LPT2:,LPT3:").
        /// </summary>
        JOB_NOTIFY_FIELD_PORT_NAME = 0x02,
        /// <summary>
        /// Name of the user who sent the print job.
        /// </summary>
        JOB_NOTIFY_FIELD_USER_NAME = 0x03,
        /// <summary>
        /// Name of the user who should be notified when the job has been printed or when an error
        /// occurs while printing the job. 
        /// </summary>
        JOB_NOTIFY_FIELD_NOTIFY_NAME = 0x04,
        /// <summary>
        /// Type of data used to record the print job. 
        /// </summary>
        JOB_NOTIFY_FIELD_DATATYPE = 0x05,
        /// <summary>
        /// Name of the print processor to be used to print the job
        /// </summary>
        JOB_NOTIFY_FIELD_PRINT_PROCESSOR = 0x06,
        /// <summary>
        /// Print-processor parameters
        /// </summary>
        JOB_NOTIFY_FIELD_PARAMETERS = 0x07,
        /// <summary>
        /// Name of the printer driver that should be used to process the print job
        /// </summary>
        JOB_NOTIFY_FIELD_DRIVER_NAME = 0x08,
        /// <summary>
        ///  DEVMODE structure that contains device-initialization and environment data for the printer driver
        /// </summary>
        JOB_NOTIFY_FIELD_DEVMODE = 0x09,
        /// <summary>
        /// Job status
        /// </summary>
        JOB_NOTIFY_FIELD_STATUS = 0x0A,
        /// <summary>
        /// Status of the print job
        /// </summary>
        JOB_NOTIFY_FIELD_STATUS_STRING = 0x0B,
        /// <summary>
        ///  Not supported
        /// </summary>
        JOB_NOTIFY_FIELD_SECURITY_DESCRIPTOR = 0x0C,
        /// <summary>
        /// Name of the print job
        /// </summary>
        JOB_NOTIFY_FIELD_DOCUMENT = 0x0D,
        /// <summary>
        /// Job priority
        /// </summary>
        JOB_NOTIFY_FIELD_PRIORITY = 0x0E,
        /// <summary>
        /// Position in the print queue
        /// </summary>
        JOB_NOTIFY_FIELD_POSITION = 0x0F,
        /// <summary>
        /// Time when the job was submitted.
        /// </summary>
        JOB_NOTIFY_FIELD_SUBMITTED = 0x10,
        /// <summary>
        /// Earliest time that the job can be printed. 
        /// (This value is specified in minutes elapsed since 12:00 A.M.) 
        /// </summary>
        JOB_NOTIFY_FIELD_START_TIME = 0x11,
        /// <summary>
        /// Latest time that the job can be printed. 
        /// (This value is specified in minutes elapsed since 12:00 A.M.) 
        /// </summary>
        JOB_NOTIFY_FIELD_UNTIL_TIME = 0x12,
        /// <summary>
        /// Total time, in seconds, that has elapsed since the job began printing
        /// </summary>
        JOB_NOTIFY_FIELD_TIME = 0x13,
        /// <summary>
        /// Size, in pages, of the job.
        /// </summary>
        JOB_NOTIFY_FIELD_TOTAL_PAGES = 0x14,
        /// <summary>
        /// Number of pages that have printed
        /// </summary>
        JOB_NOTIFY_FIELD_PAGES_PRINTED = 0x15,
        /// <summary>
        /// Size, in bytes, of the job
        /// </summary>
        JOB_NOTIFY_FIELD_TOTAL_BYTES = 0x16,
        /// <summary>
        /// Number of bytes that have been printed on this job. For this field, 
        /// the change notification object is signaled when bytes are sent to the printer.
        /// </summary>
        JOB_NOTIFY_FIELD_BYTES_PRINTED = 0x17
    }
}