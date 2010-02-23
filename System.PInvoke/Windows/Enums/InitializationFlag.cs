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
    /// Specifies whether certain members of the DEVMODE structure have been initialized
    /// </summary>
    [Flags]
    public enum InitializationFlag : uint
    {
        /// <summary>
        /// dmOrientation
        /// </summary>
        DM_ORIENTATION = 1,
        /// <summary>
        /// dmPaperSize
        /// </summary>
        DM_PAPERSIZE = 2,
        /// <summary>
        /// dmPaperLength
        /// </summary>
        DM_PAPERLENGTH = 4,
        /// <summary>
        /// dmPaperWidth
        /// </summary>
        DM_PAPERWIDTH = 8,
        /// <summary>
        /// dmScale
        /// </summary>
        DM_SCALE = 16,
        /// <summary>
        /// dmCopies
        /// </summary>
        DM_COPIES = 256,
        /// <summary>
        /// dmDefaultSource
        /// </summary>
        DM_DEFAULTSOURCE = 512,
        /// <summary>
        /// dmPrintQuality
        /// </summary>
        DM_PRINTQUALITY = 1024,
        /// <summary>
        /// dmPosition
        /// </summary>
        DM_POSITION = 32,
        /// <summary>
        /// dmDisplayOrientation
        /// </summary>
        DM_DISPLAYORIENTATION = 128,
        /// <summary>
        /// dmDisplayFixedOutput
        /// </summary>
        DM_DISPLAYFIXEDOUTPUT = 536870912,
        /// <summary>
        /// dmColor
        /// </summary>
        DM_COLOR = 2048,
        /// <summary>
        /// dmDuplex
        /// </summary>
        DM_DUPLEX = 4096,
        /// <summary>
        /// dmYResolution
        /// </summary>
        DM_YRESOLUTION = 8192,
        /// <summary>
        /// dmTTOption
        /// </summary>
        DM_TTOPTION = 16384,
        /// <summary>
        /// dmCollate
        /// </summary>
        DM_COLLATE = 32768,
        /// <summary>
        /// dmFormName
        /// </summary>
        DM_FORMNAME = 65536,
        /// <summary>
        /// dmLogPixels
        /// </summary>
        DM_LOGPIXELS = 131072,
        /// <summary>
        /// dmBitsPerPel
        /// </summary>
        DM_BITSPERPEL = 262144,
        /// <summary>
        /// dmPelsWidth
        /// </summary>
        DM_PELSWIDTH = 524288,
        /// <summary>
        /// dmPelsHeight
        /// </summary>
        DM_PELSHEIGHT = 1048576,
        /// <summary>
        /// dmDisplayFlags
        /// </summary>
        DM_DISPLAYFLAGS = 2097152,
        /// <summary>
        /// dmNup
        /// </summary>
        DM_NUP = 64,
        /// <summary>
        /// dmDisplayFrequency
        /// </summary>
        DM_DISPLAYFREQUENCY = 4194304,
        /// <summary>
        /// dmICMMethod
        /// </summary>
        DM_ICMMETHOD = 8388608,
        /// <summary>
        /// dmICMIntent
        /// </summary>
        DM_ICMINTENT = 16777216,
        /// <summary>
        /// dmMediaType
        /// </summary>
        DM_MEDIATYPE = 33554432,
        /// <summary>
        /// dmDitherType
        /// </summary>
        DM_DITHERTYPE = 67108864,
        /// <summary>
        /// Windows 2000/XP: dmPanningWidth
        /// </summary>
        DM_PANNINGWIDTH = 134217728,
        /// <summary>
        /// Windows 2000/XP: dmPanningHeight
        /// </summary>
        DM_PANNINGHEIGHT = 268435456
    }
}