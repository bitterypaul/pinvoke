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
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct LogFontA
    {
        /// LONG->int
        public int lfHeight;

        /// LONG->int
        public int lfWidth;

        /// LONG->int
        public int lfEscapement;

        /// LONG->int
        public int lfOrientation;

        /// LONG->int
        public int lfWeight;

        /// BYTE->unsigned char
        public byte lfItalic;

        /// BYTE->unsigned char
        public byte lfUnderline;

        /// BYTE->unsigned char
        public byte lfStrikeOut;

        /// BYTE->unsigned char
        public byte lfCharSet;

        /// BYTE->unsigned char
        public byte lfOutPrecision;

        /// BYTE->unsigned char
        public byte lfClipPrecision;

        /// BYTE->unsigned char
        public byte lfQuality;

        /// BYTE->unsigned char
        public byte lfPitchAndFamily;

        /// CHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string lfFaceName;
    }
}