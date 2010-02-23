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
    /// Specifies the standard paper sizes.
    /// </summary>
    [Flags]
    public enum PaperSize : short
    {
        // ReSharper disable InconsistentNaming
        /// <summary>
        /// Letter, 8 1/2- by 11-inches
        /// </summary>
        DMPAPER_LETTER = 1,
        /// <summary>
        /// Legal, 8 1/2- by 14-inches
        /// </summary>
        DMPAPER_LEGAL = 5,
        /// <summary>
        /// 9- by 11-inch sheet
        /// </summary>
        DMPAPER_9X11 = 44,
        /// <summary>
        /// 10- by 11-inch sheet
        /// </summary>
        DMPAPER_10X11 = 45,
        /// <summary>
        /// 10- by 14-inch sheet
        /// </summary>
        DMPAPER_10X14 = 16,
        /// <summary>
        /// 15- by 11-inch sheet
        /// </summary>
        DMPAPER_15X11 = 46,
        /// <summary>
        /// 11- by 17-inch sheet
        /// </summary>
        DMPAPER_11X17 = 17,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: 12- by 11-inch sheet
        /// </summary>
        DMPAPER_12X11 = 90,
        /// <summary>
        /// A2 sheet, 420 x 594-millimeters
        /// </summary>
        DMPAPER_A2 = 66,
        /// <summary>
        /// A3 sheet, 297- by 420-millimeters
        /// </summary>
        DMPAPER_A3 = 8,
        /// <summary>
        /// A3 Extra 322 x 445-millimeters
        /// </summary>
        DMPAPER_A3_EXTRA = 63,
        /// <summary>
        /// A3 Extra Transverse 322 x 445-millimeters
        /// </summary>
        DMPAPER_A3_EXTRA_TRANSVERSE = 68,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: A3 rotated sheet, 420- by 297-millimeters
        /// </summary>
        DMPAPER_A3_ROTATED = 76,
        /// <summary>
        /// A3 Transverse 297 x 420-millimeters
        /// </summary>
        DMPAPER_A3_TRANSVERSE = 67,
        /// <summary>
        /// A4 sheet, 210- by 297-millimeters
        /// </summary>
        DMPAPER_A4 = 9,
        /// <summary>
        /// A4 sheet, 9.27 x 12.69 inches
        /// </summary>
        DMPAPER_A4_EXTRA = 53,
        /// <summary>
        /// A4 Plus 210 x 330-millimeters
        /// </summary>
        DMPAPER_A4_PLUS = 60,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: A4 rotated sheet, 297- by 210-millimeters
        /// </summary>
        DMPAPER_A4_ROTATED = 77,
        /// <summary>
        /// A4 small sheet, 210- by 297-millimeters
        /// </summary>
        DMPAPER_A4SMALL = 10,
        /// <summary>
        /// A4 Transverse 210 x 297 millimeters
        /// </summary>
        DMPAPER_A4_TRANSVERSE = 55,
        /// <summary>
        /// A5 sheet, 148- by 210-millimeters
        /// </summary>
        DMPAPER_A5 = 11,
        /// <summary>
        /// A5 Extra 174 x 235-millimeters
        /// </summary>
        DMPAPER_A5_EXTRA = 64,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: A5 rotated sheet, 210- by 148-millimeters
        /// </summary>
        DMPAPER_A5_ROTATED = 78,
        /// <summary>
        /// A5 Transverse 148 x 210-millimeters
        /// </summary>
        DMPAPER_A5_TRANSVERSE = 61,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: A6 sheet, 105- by 148-millimeters
        /// </summary>
        DMPAPER_A6 = 70,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: A6 rotated sheet, 148- by 105-millimeters
        /// </summary>
        DMPAPER_A6_ROTATED = 83,
        /// <summary>
        /// SuperA/A4 227 x 356 -millimeters
        /// </summary>
        DMPAPER_A_PLUS = 57,
        /// <summary>
        /// B4 sheet, 250- by 354-millimeters
        /// </summary>
        DMPAPER_B4 = 12,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: B4 (JIS) rotated sheet, 364- by 257-millimeters
        /// </summary>
        DMPAPER_B4_JIS_ROTATED = 79,
        /// <summary>
        /// B5 sheet, 182- by 257-millimeter paper
        /// </summary>
        DMPAPER_B5 = 13,
        /// <summary>
        /// B5 (ISO) Extra 201 x 276-millimeters
        /// </summary>
        DMPAPER_B5_EXTRA = 65,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: B5 (JIS) transverse sheet, 182- by 257-millimeters
        /// </summary>
        DMPAPER_B5_TRANSVERSE = 62,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: B5 (JIS) rotated sheet, 257- by 182-millimeters
        /// </summary>
        DMPAPER_B5_JIS_ROTATED = 80,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: B6 (JIS) sheet, 128- by 182-millimeters
        /// </summary>
        DMPAPER_B6_JIS = 88,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: B6 (JIS) rotated sheet, 182- by 128-millimeters
        /// </summary>
        DMPAPER_B6_JIS_ROTATED = 89,
        /// <summary>
        /// SuperB/A3 305 x 487-millimeters
        /// </summary>
        DMPAPER_B_PLUS = 58,
        /// <summary>
        /// C Sheet, 17- by 22-inches
        /// </summary>
        DMPAPER_CSHEET = 24,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Double Japanese Postcard, 200- by 148-millimeters 
        /// </summary>
        DMPAPER_DBL_JAPANESE_POSTCARD = 69,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Double Japanese Postcard Rotated, 148- by 200-millimeters 
        /// </summary>
        DMPAPER_DBL_JAPANESE_POSTCARD_ROTATED = 82,
        /// <summary>
        /// D Sheet, 22- by 34-inches
        /// </summary>
        DMPAPER_DSHEET = 25,
        /// <summary>
        /// #9 Envelope, 3 7/8- by 8 7/8-inches
        /// </summary>
        DMPAPER_ENV_9 = 19,
        /// <summary>
        /// #10 Envelope, 4 1/8- by 9 1/2-inches
        /// </summary>
        DMPAPER_ENV_10 = 20,
        /// <summary>
        /// #11 Envelope, 4 1/2- by 10 3/8-inches
        /// </summary>
        DMPAPER_ENV_11 = 21,
        /// <summary>
        /// #12 Envelope, 4 3/4- by 11-inches
        /// </summary>
        DMPAPER_ENV_12 = 22,
        /// <summary>
        /// #14 Envelope, 5- by 11 1/2-inches
        /// </summary>
        DMPAPER_ENV_14 = 23,
        /// <summary>
        /// C5 Envelope, 162- by 229-millimeters
        /// </summary>
        DMPAPER_ENV_C5 = 28,
        /// <summary>
        /// C3 Envelope, 324- by 458-millimeters
        /// </summary>
        DMPAPER_ENV_C3 = 29,
        /// <summary>
        /// C4 Envelope, 229- by 324-millimeters
        /// </summary>
        DMPAPER_ENV_C4 = 30,
        /// <summary>
        /// C6 Envelope, 114- by 162-millimeters
        /// </summary>
        DMPAPER_ENV_C6 = 31,
        /// <summary>
        /// C65 Envelope, 114- by 229-millimeters
        /// </summary>
        DMPAPER_ENV_C65 = 32,
        /// <summary>
        /// B4 Envelope, 250- by 353-millimeters
        /// </summary>
        DMPAPER_ENV_B4 = 33,
        /// <summary>
        /// B5 Envelope, 176- by 250-millimeters
        /// </summary>
        DMPAPER_ENV_B5 = 34,
        /// <summary>
        /// B6 Envelope, 176- by 125-millimeters
        /// </summary>
        DMPAPER_ENV_B6 = 35,
        /// <summary>
        /// DL Envelope, 110- by 220-millimeters
        /// </summary>
        DMPAPER_ENV_DL = 27,
        /// <summary>
        /// Envelope Invite 220 x 220 mm
        /// </summary>
        DMPAPER_ENV_INVITE = 47,
        /// <summary>
        /// Italy Envelope, 110- by 230-millimeters
        /// </summary>
        DMPAPER_ENV_ITALY = 36,
        /// <summary>
        /// Monarch Envelope, 3 7/8- by 7 1/2-inches
        /// </summary>
        DMPAPER_ENV_MONARCH = 37,
        /// <summary>
        /// 6 3/4 Envelope, 3 5/8- by 6 1/2-inches
        /// </summary>
        DMPAPER_ENV_PERSONAL = 38,
        /// <summary>
        /// E Sheet, 34- by 44-inches
        /// </summary>
        DMPAPER_ESHEET = 26,
        /// <summary>
        /// Executive, 7 1/4- by 10 1/2-inches
        /// </summary>
        DMPAPER_EXECUTIVE = 7,
        /// <summary>
        /// US Std Fanfold, 14 7/8- by 11-inches
        /// </summary>
        DMPAPER_FANFOLD_US = 39,
        /// <summary>
        /// German Std Fanfold, 8 1/2- by 12-inches
        /// </summary>
        DMPAPER_FANFOLD_STD_GERMAN = 40,
        /// <summary>
        /// German Legal Fanfold, 8 - by 13-inches
        /// </summary>
        DMPAPER_FANFOLD_LGL_GERMAN = 41,
        /// <summary>
        /// Folio, 8 1/2- by 13-inch paper
        /// </summary>
        DMPAPER_FOLIO = 14,
        /// <summary>
        /// B4 (ISO) 250- by 353-millimeters paper
        /// </summary>
        DMPAPER_ISO_B4 = 42,
        /// <summary>
        /// Japanese Postcard, 100- by 148-millimeters 
        /// </summary>
        DMPAPER_JAPANESE_POSTCARD = 43,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Postcard Rotated, 148- by 100-millimeters 
        /// </summary>
        DMPAPER_JAPANESE_POSTCARD_ROTATED = 81,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope Chou #3
        /// </summary>
        DMPAPER_JENV_CHOU3 = 73,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope Chou #3 Rotated
        /// </summary>
        DMPAPER_JENV_CHOU3_ROTATED = 86,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope Chou #4
        /// </summary>
        DMPAPER_JENV_CHOU4 = 74,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope Chou #4 Rotated
        /// </summary>
        DMPAPER_JENV_CHOU4_ROTATED = 87,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope Kaku #2
        /// </summary>
        DMPAPER_JENV_KAKU2 = 71,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope Kaku #2 Rotated
        /// </summary>
        DMPAPER_JENV_KAKU2_ROTATED = 84,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope Kaku #3
        /// </summary>
        DMPAPER_JENV_KAKU3 = 72,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope Kaku #3 Rotated
        /// </summary>
        DMPAPER_JENV_KAKU3_ROTATED = 85,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope You #4
        /// </summary>
        DMPAPER_JENV_YOU4 = 91,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: Japanese Envelope You #4 Rotated
        /// </summary>
        DMPAPER_JENV_YOU4_ROTATED = 92,
        /// <summary>
        /// Windows 2000/XP: DMPAPER_PENV_10_ROTATED
        /// </summary>
        DMPAPER_LAST = 118,
        /// <summary>
        /// Ledger, 17- by 11-inches
        /// </summary>
        DMPAPER_LEDGER = 4,
        /// <summary>
        /// Legal Extra 9 1/2 x 15 inches. 
        /// </summary>
        DMPAPER_LEGAL_EXTRA = 51,
        /// <summary>
        /// Letter Extra 9 1/2 x 12 inches. 
        /// </summary>
        DMPAPER_LETTER_EXTRA = 50,
        /// <summary>
        /// Letter Extra Transverse 9 1/2 x 12 inches.
        /// </summary>
        DMPAPER_LETTER_EXTRA_TRANSVERSE = 56,
        /// <summary>
        /// Letter Rotated 11 by 8 1/2 inches 
        /// </summary>
        DMPAPER_LETTER_ROTATED = 75,
        /// <summary>
        /// Letter Small, 8 1/2- by 11-inches
        /// </summary>
        DMPAPER_LETTERSMALL = 2,
        /// <summary>
        /// Letter Transverse 8 1/2 x 11-inches
        /// </summary>
        DMPAPER_LETTER_TRANSVERSE = 54,
        /// <summary>
        /// Note, 8 1/2- by 11-inches
        /// </summary>
        DMPAPER_NOTE = 18,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC 16K, 146- by 215-millimeters
        /// </summary>
        DMPAPER_P16K = 93,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC 16K Rotated, 215- by 146-millimeters
        /// </summary>
        DMPAPER_P16K_ROTATED = 106,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC 32K, 97- by 151-millimeters
        /// </summary>
        DMPAPER_P32K = 94,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC 32K Rotated, 151- by 97-millimeters 
        /// </summary>
        DMPAPER_P32K_ROTATED = 107,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC 32K(Big) 97- by 151-millimeters
        /// </summary>
        DMPAPER_P32KBIG = 95,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC 32K(Big) Rotated, 151- by 97-millimeters
        /// </summary>
        DMPAPER_P32KBIG_ROTATED = 108,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #1, 102- by 165-millimeters
        /// </summary>
        DMPAPER_PENV_1 = 96,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #1 Rotated, 165- by 102-millimeters
        /// </summary>
        DMPAPER_PENV_1_ROTATED = 109,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #2, 102- by 176-millimeters
        /// </summary>
        DMPAPER_PENV_2 = 97,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #2 Rotated, 176- by 102-millimeters 
        /// </summary>
        DMPAPER_PENV_2_ROTATED = 110,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #3, 125- by 176-millimeters
        /// </summary>
        DMPAPER_PENV_3 = 98,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #3 Rotated, 176- by 125-millimeters
        /// </summary>
        DMPAPER_PENV_3_ROTATED = 111,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #4, 110- by 208-millimeters
        /// </summary>
        DMPAPER_PENV_4 = 99,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #4 Rotated, 208- by 110-millimeters
        /// </summary>
        DMPAPER_PENV_4_ROTATED = 112,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #5, 110- by 220-millimeters
        /// </summary>
        DMPAPER_PENV_5 = 100,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #5 Rotated, 220- by 110-millimeters
        /// </summary>
        DMPAPER_PENV_5_ROTATED = 113,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #6, 120- by 230-millimeters
        /// </summary>
        DMPAPER_PENV_6 = 101,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #6 Rotated, 230- by 120-millimeters
        /// </summary>
        DMPAPER_PENV_6_ROTATED = 114,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #7, 160- by 230-millimeters
        /// </summary>
        DMPAPER_PENV_7 = 102,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #7 Rotated, 230- by 160-millimeters
        /// </summary>
        DMPAPER_PENV_7_ROTATED = 115,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #8, 120- by 309-millimeters
        /// </summary>
        DMPAPER_PENV_8 = 103,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #8 Rotated, 309- by 120-millimeters
        /// </summary>
        DMPAPER_PENV_8_ROTATED = 116,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #9, 229- by 324-millimeters
        /// </summary>
        DMPAPER_PENV_9 = 104,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #9 Rotated, 324- by 229-millimeters
        /// </summary>
        DMPAPER_PENV_9_ROTATED = 117,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #10, 324- by 458-millimeters
        /// </summary>
        DMPAPER_PENV_10 = 105,
        /// <summary>
        /// Windows 98/Me, Windows NT 4.0 and later: PRC Envelope #10 Rotated, 458- by 324-millimeters
        /// </summary>
        DMPAPER_PENV_10_ROTATED = 118,
        /// <summary>
        /// Quarto, 215- by 275-millimeter paper
        /// </summary>
        DMPAPER_QUARTO = 15,
        /// <summary>
        /// Statement, 5 1/2- by 8 1/2-inches
        /// </summary>
        DMPAPER_STATEMENT = 6,
        /// <summary>
        /// Tabloid, 11- by 17-inches
        /// </summary>
        DMPAPER_TABLOID = 3,
        /// <summary>
        /// Tabloid, 11.69 x 18-inches
        /// </summary>
        DMPAPER_TABLOID_EXTRA = 52
        // ReSharper restore InconsistentNaming
    }
}