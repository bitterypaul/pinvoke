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
    /// True type font option for printer
    /// </summary>
    [Flags]
    public enum TrueTypeOption : short
    {
        /// <summary>
        /// Prints TrueType fonts as graphics. This is the default action for dot-matrix printers.
        /// </summary>
        DMTT_BITMAP = 1,
        /// <summary>
        /// Downloads TrueType fonts as soft fonts. This is the default action for Hewlett-Packard 
        /// printers that use Printer Control Language (PCL).
        /// </summary>
        DMTT_DOWNLOAD = 2,
        /// <summary>
        /// Window 95/98/Me, Windows NT 4.0 and later: Downloads TrueType fonts as outline soft fonts.
        /// </summary>
        DMTT_DOWNLOAD_OUTLINE = 4,
        /// <summary>
        /// Substitutes device fonts for TrueType fonts. This is the default action for PostScript printers.
        /// </summary>
        DMTT_SUBDEV = 3
    }
}