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
    /// Specifies outcome of the print dialog
    /// </summary>
    [Flags]
    public enum PrintResultAction : uint
    {
        /// <summary>
        /// The user clicked the Apply button and later clicked the Cancel button. This indicates 
        /// that the user wants to apply the changes made in the property sheet, but does not want 
        /// to print yet. The PRINTDLGEX structure contains the information specified by the user at 
        /// the time the Apply button was clicked.
        /// </summary>
        PD_RESULT_APPLY = 2,
        /// <summary>
        /// The user clicked the Cancel button. The information in the PRINTDLGEX structure is unchanged.
        /// </summary>
        PD_RESULT_CANCEL = 0,
        /// <summary>
        /// The user clicked the Print button. The PRINTDLGEX structure contains the information specified by the user
        /// </summary>
        PD_RESULT_PRINT = 1
    }
}