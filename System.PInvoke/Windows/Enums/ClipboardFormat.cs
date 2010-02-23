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
    /// The clipboard formats defined by the system are called standard clipboard formats
    /// </summary>
    [Flags]
    public enum ClipboardFormat : uint
    {
        /// <summary>
        /// A handle to a bitmap (HBITMAP).
        /// </summary>
        CF_BITMAP = 2,
        /// <summary>
        /// A memory object containing a BITMAPINFO structure followed by the bitmap bits.
        /// </summary>
        CF_DIB = 8,
        /// <summary>
        /// Windows 2000/XP: A memory object containing a BITMAPV5HEADER structure 
        /// followed by the bitmap color space information and the bitmap bits.
        /// </summary>
        CF_DIBV5 = 17,
        /// <summary>
        /// Software Arts' Data Interchange Format
        /// </summary>
        CF_DIF = 5,
        /// <summary>
        /// Bitmap display format associated with a private format.
        /// </summary>
        CF_DSPBITMAP = 130,
        /// <summary>
        /// Enhanced metafile display format associated with a private format.
        /// </summary>
        CF_DSPENHMETAFILE = 142,
        /// <summary>
        /// Metafile-picture display format associated with a private format.
        /// </summary>
        CF_DSPMETAFILEPICT = 131,
        /// <summary>
        /// Text display format associated with a private format.
        /// </summary>
        CF_DSPTEXT = 129,
        /// <summary>
        /// A handle to an enhanced metafile (HENHMETAFILE).
        /// </summary>
        CF_ENHMETAFILE = 14,
        /// <summary>
        /// Range of integer values for application-defined Microsoft Windows Graphics Device Interface (GDI)
        /// object clipboard formats. Handles associated with clipboard formats in this range are not 
        /// automatically deleted using the GlobalFree function when the clipboard is emptied.
        /// </summary>
        CF_GDIOBJFIRST = 768,
        /// <summary>
        /// Range of integer values for application-defined Microsoft Windows Graphics Device Interface (GDI)
        /// object clipboard formats. Handles associated with clipboard formats in this range are not 
        /// automatically deleted using the GlobalFree function when the clipboard is emptied.
        /// </summary>
        CF_GDIOBJLAST = 1023,
        /// <summary>
        /// A handle to type HDROP that identifies a list of files. An application can retrieve information 
        /// about the files by passing the handle to the DragQueryFile functions.
        /// </summary>
        CF_HDROP = 15,
        /// <summary>
        /// The data is a handle to the locale identifier associated with text in the clipboard. When you close
        /// the clipboard, if it contains CF_TEXT data but no CF_LOCALE data, the system automatically sets the
        /// CF_LOCALE format to the current input language. You can use the CF_LOCALE format to associate a 
        /// different locale with the clipboard text.
        /// </summary>
        CF_LOCALE = 16,
        /// <summary>
        /// Handle to a metafile picture format as defined by the METAFILEPICT structure.
        /// </summary>
        CF_METAFILEPICT = 3,
        /// <summary>
        /// Text format containing characters in the OEM character set. Each line ends with a carriage return/linefeed
        /// (CR-LF) combination. A null character signals the end of the data.
        /// </summary>
        CF_OEMTEXT = 7,
        /// <summary>
        /// Owner-display format. The clipboard owner must display and update the clipboard viewer window, and receive 
        /// the WindowsMessage.WM_ASKCBFORMATNAME, WindowsMessage.WM_HSCROLLCLIPBOARD, WindowsMessage.WM_PAINTCLIPBOARD, WindowsMessage.WM_SIZECLIPBOARD,
        /// and WindowsMessage.WM_VSCROLLCLIPBOARD messages.
        /// </summary>
        CF_OWNERDISPLAY = 128,
        /// <summary>
        /// Handle to a color palette. Whenever an application places data in the clipboard that depends on or assumes a color palette,
        /// it should place the palette on the clipboard as well.
        /// </summary>
        CF_PALETTE = 9,
        /// <summary>
        /// Data for the pen extensions to the Microsoft Windows for Pen Computing.
        /// </summary>
        CF_PENDATA = 10,
        /// <summary>
        /// Range of integer values for private clipboard formats. Handles associated with 
        /// private clipboard formats are not freed automatically; the clipboard owner must 
        /// free such handles, typically in response to the WindowsMessage.WM_DESTROYCLIPBOARD message.
        /// </summary>
        CF_PRIVATEFIRST = 512,
        /// <summary>
        /// Range of integer values for private clipboard formats. Handles associated with 
        /// private clipboard formats are not freed automatically; the clipboard owner must 
        /// free such handles, typically in response to the WindowsMessage.WM_DESTROYCLIPBOARD message.
        /// </summary>
        CF_PRIVATELAST = 767,
        /// <summary>
        /// Represents audio data more complex than can be represented in a CF_WAVE standard wave format.
        /// </summary>
        CF_RIFF = 11,
        /// <summary>
        /// Microsoft Symbolic Link (SYLK) format.
        /// </summary>
        CF_SYLK = 4,
        /// <summary>
        /// Text format. Each line ends with a carriage return/linefeed (CR-LF) combination. 
        /// A null character signals the end of the data. Use this format for ANSI text.
        /// </summary>
        CF_TEXT = 1,
        /// <summary>
        /// Represents audio data in one of the standard wave formats, 
        /// such as 11 kHz or 22 kHz Pulse Code Modulation (PCM).
        /// </summary>
        CF_WAVE = 12,
        /// <summary>
        /// Tagged-image file format.
        /// </summary>
        CF_TIFF = 6,
        /// <summary>
        /// Windows NT/2000/XP: Unicode text format. Each line ends with a carriage return/linefeed 
        /// (CR-LF) combination. A null character signals the end of the data.
        /// </summary>
        CF_UNICODETEXT = 13,
    }
}