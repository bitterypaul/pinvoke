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
    /// Indicates the printer changes that occurred to cause the most recent notification
    /// </summary>
    [Flags]
    public enum PrinterChangeStatus
    {
        /// <summary>
        /// A form was added to the server.
        /// </summary>
        PRINTER_CHANGE_ADD_FORM = 65536,
        /// <summary>
        /// A print job was sent to the printer.
        /// </summary>
        PRINTER_CHANGE_ADD_JOB = 256,
        /// <summary>
        /// A port or monitor was added to the server.
        /// </summary>
        PRINTER_CHANGE_ADD_PORT = 1048576,
        /// <summary>
        /// A print processor was added to the server.
        /// </summary>
        PRINTER_CHANGE_PRINT_PROCESSOR = 117440512,
        /// <summary>
        /// A printer was added to the server.
        /// </summary>
        PRINTER_CHANGE_ADD_PRINTER = 1,
        /// <summary>
        /// A printer driver was added to the server.
        /// </summary>
        PRINTER_CHANGE_ADD_PRINTER_DRIVER = 268435456,
        /// <summary>
        /// A port was configured on the server.
        /// </summary>
        PRINTER_CHANGE_CONFIGURE_PORT = 2097152,
        /// <summary>
        /// A form was deleted from the server.
        /// </summary>
        PRINTER_CHANGE_DELETE_FORM = 262144,
        /// <summary>
        /// A job was deleted.
        /// </summary>
        PRINTER_CHANGE_DELETE_JOB = 1024,
        /// <summary>
        /// A port or monitor was deleted from the server.
        /// </summary>
        PRINTER_CHANGE_DELETE_PORT = 4194304,
        /// <summary>
        /// A print processor was deleted from the server.
        /// </summary>
        PRINTER_CHANGE_DELETE_PRINT_PROCESSOR = 67108864,
        /// <summary>
        /// A printer was deleted.
        /// </summary>
        PRINTER_CHANGE_DELETE_PRINTER = 4,
        /// <summary>
        /// A printer driver was deleted from the server.
        /// </summary>
        PRINTER_CHANGE_DELETE_PRINTER_DRIVER = 1073741824,
        /// <summary>
        /// A printer connection has failed.
        /// </summary>
        PRINTER_CHANGE_FAILED_CONNECTION_PRINTER = 8,
        /// <summary>
        /// A form was set on the server.
        /// </summary>
        PRINTER_CHANGE_SET_FORM = 131072,
        /// <summary>
        /// A job was set.
        /// </summary>
        PRINTER_CHANGE_SET_JOB = 512,
        /// <summary>
        /// A printer was set.
        /// </summary>
        PRINTER_CHANGE_SET_PRINTER = 2,
        /// <summary>
        /// A printer driver was set.
        /// </summary>
        PRINTER_CHANGE_PRINTER_DRIVER = 1879048192,
        /// <summary>
        /// Job data was written.
        /// </summary>
        PRINTER_CHANGE_WRITE_JOB = 2048,
        /// <summary>
        /// The job timed out. 
        /// </summary>
        PRINTER_CHANGE_TIMEOUT = -2147483648,
        /// <summary>
        /// Everything was changes
        /// </summary>
        PRINTER_CHANGE_ALL = 2004353023,
        /// <summary>
        /// Job was changed
        /// </summary>
        PRINTER_CHANGE_JOB = 65280,
        /// <summary>
        /// Form has been changed
        /// </summary>
        PRINTER_CHANGE_FORM = 458752,
        /// <summary>
        /// Port has been changed
        /// </summary>
        PRINTER_CHANGE_PORT = 7340032,
        /// <summary>
        /// Printer has been changed
        /// </summary>
        PRINTER_CHANGE_PRINTER = 255,
        /// <summary>
        /// Printer driver was set
        /// </summary>
        PRINTER_CHANGE_SET_PRINTER_DRIVER = 536870912,
        /// <summary>
        /// A Print processor was added
        /// </summary>
        PRINTER_CHANGE_ADD_PRINT_PROCESSOR = 16777216,
    }
}