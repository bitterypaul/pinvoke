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
    /// Specifies the type of the selected font when ChooseFont returns
    /// </summary>
    [Flags]
    public enum FontType : ushort
    {
        /// <summary>
        /// The font weight is bold. This information is duplicated in the lfWeight
        /// member of the LOGFONT structure and is equivalent to FW_BOLD.
        /// </summary>
        BOLD_FONTTYPE = 256,
        /// <summary>
        /// The italic font attribute is set. This information is duplicated in the
        /// lfItalic member of the LOGFONT structure.
        /// </summary>
        ITALIC_FONTTYPE = 512,
        /// <summary>
        /// The font is a printer font.
        /// </summary>
        PRINTER_FONTTYPE = 16384,
        /// <summary>
        /// The font weight is normal. This information is duplicated in the lfWeight
        /// member of the LOGFONT structure and is equivalent to FW_REGULAR.
        /// </summary>
        REGULAR_FONTTYPE = 1024,
        /// <summary>
        /// The font is a screen font.
        /// </summary>
        SCREEN_FONTTYPE = 8192,
        /// <summary>
        /// The font is simulated by the graphics device interface (GDI).
        /// </summary>
        SIMULATED_FONTTYPE = 32768
    }
}