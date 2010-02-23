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
    [Flags]
    public enum ChooseFontOption : uint
    {
        /// <summary>
        /// Causes the dialog box to display the Apply button. You should provide 
        /// a hook procedure to process WM_COMMAND messages for the Apply button. 
        /// The hook procedure can send the WM_CHOOSEFONT_GETLOGFONT message to the
        /// dialog box to retrieve the address of the structure that contains the 
        /// current selections for the font. 
        /// </summary>
        CF_APPLY = 512,
        /// <summary>
        /// This flag is obsolete. To limit font selections to all scripts except those
        /// that use the OEM or Symbol character sets, use CF_SCRIPTSONLY. To get the 
        /// original CF_ANSIONLY behavior, use CF_SELECTSCRIPT and specify ANSI_CHARSET
        /// in the lfCharSet member of the LOGFONT structure pointed to by lpLogFont.
        /// </summary>
        CF_ANSIONLY = 1024,
        /// <summary>
        /// Causes the dialog box to list the available printer and screen fonts. 
        /// The hDC member is a handle to the device context (or information context) 
        /// associated with the printer. This flag is a combination of the CF_SCREENFONTS
        /// and CF_PRINTERFONTS flags.
        /// </summary>
        CF_BOTH = CF_SCREENFONTS | CF_PRINTERFONTS,
        /// <summary>
        /// Specifies that ChooseFont should only enumerate and allow the selection of TrueType fonts.
        /// </summary>
        CF_TTONLY = 262144,
        /// <summary>
        /// Causes the dialog box to display the controls that allow the user to specify strikeout, 
        /// underline, and text color options. If this flag is set, you can use the rgbColors member 
        /// to specify the initial text color. You can use the lfStrikeOut and lfUnderline members of
        /// the structure pointed to by lpLogFont to specify the initial settings of the strikeout and
        /// underline check boxes. ChooseFont can use these members to return the user's selections.
        /// </summary>
        CF_EFFECTS = 256,
        /// <summary>
        /// Enables the hook procedure specified in the lpfnHook member of this structure.
        /// </summary>
        CF_ENABLEHOOK = 8,
        /// <summary>
        /// Indicates that the hInstance and lpTemplateName members specify a dialog box template to use
        /// in place of the default template.
        /// </summary>
        CF_ENABLETEMPLATE = 16,
        /// <summary>
        /// Indicates that the hInstance member identifies a data block that contains a preloaded dialog 
        /// box template. The system ignores the lpTemplateName member if this flag is specified.
        /// </summary>
        CF_ENABLETEMPLATEHANDLE = 32,
        /// <summary>
        /// Specifies that ChooseFont should select only fixed-pitch fonts.
        /// </summary>
        CF_FIXEDPITCHONLY = 16384,
        /// <summary>
        /// Specifies that ChooseFont should indicate an error condition if the user attempts to select a 
        /// font or style that does not exist.
        /// </summary>
        CF_FORCEFONTEXIST = 65536,
        /// <summary>
        /// Specifies that ChooseFont should use the structure pointed to by the lpLogFont member to
        /// initialize the dialog box controls.
        /// </summary>
        CF_INITTOLOGFONTSTRUCT = 64,
        /// <summary>
        /// Specifies that ChooseFont should select only font sizes within the range specified by the 
        /// nSizeMin and nSizeMax members.
        /// </summary>
        CF_LIMITSIZE = 8192,
        /// <summary>
        /// Same as the CF_NOVECTORFONTS flag.
        /// </summary>
        CF_NOOEMFONTS = 2048,
        /// <summary>
        /// When using a LOGFONT structure to initialize the dialog box controls, use this flag to 
        /// selectively prevent the dialog box from displaying an initial selection for the font name
        /// combo box. This is useful when there is no single font name that applies to the text selection.
        /// </summary>
        CF_NOFACESEL = 524288,
        /// <summary>
        /// Disables the Script combo box. When this flag is set, the lfCharSet member of the LOGFONT 
        /// structure is set to DEFAULT_CHARSET when ChooseFont returns. This flag is used only to initialize
        /// the dialog box.
        /// </summary>
        CF_NOSCRIPTSEL = 8388608,
        /// <summary>
        /// When using a LOGFONT structure to initialize the dialog box controls, use this flag to selectively
        /// prevent the dialog box from displaying an initial selection for the font style combo box. 
        /// This is useful when there is no single font style that applies to the text selection.
        /// </summary>
        CF_NOSTYLESEL = 1048576,
        /// <summary>
        /// When using a structure to initialize the dialog box controls, use this flag to selectively prevent
        /// the dialog box from displaying an initial selection for the font size combo box. This is useful 
        /// when there is no single font size that applies to the text selection. 
        /// </summary>
        CF_NOSIZESEL = 2097152,
        /// <summary>
        /// Specifies that ChooseFont should not allow graphics device interface (GDI) font simulations.
        /// </summary>
        CF_NOSIMULATIONS = 4096,
        /// <summary>
        /// Specifies that ChooseFont should not allow vector font selections.
        /// </summary>
        CF_NOVECTORFONTS = 2048,
        /// <summary>
        /// Causes the Font dialog box to list only horizontally oriented fonts.
        /// </summary>
        CF_NOVERTFONTS = 16777216,
        /// <summary>
        /// Causes the dialog box to list only the fonts supported by the printer associated with the 
        /// device context (or information context) identified by the hDC member.
        /// </summary>
        CF_PRINTERFONTS = 2,
        /// <summary>
        /// Specifies that ChooseFont should allow only the selection of scalable fonts. (Scalable fonts
        /// include vector fonts, scalable printer fonts, TrueType fonts, and fonts scaled by other 
        /// technologies.)
        /// </summary>
        CF_SCALABLEONLY = 131072,
        /// <summary>
        /// Causes the dialog box to list only the screen fonts supported by the system.
        /// </summary>
        CF_SCREENFONTS = 1,
        /// <summary>
        /// Specifies that ChooseFont should allow selection of fonts for all non-OEM and Symbol character
        /// sets, as well as the ANSI character set. This supersedes the CF_ANSIONLY value.
        /// </summary>
        CF_SCRIPTSONLY = 1024,
        /// <summary>
        /// When specified on input, only fonts with the character set identified in the lfCharSet member
        /// of the LOGFONT structure are displayed. The user will not be allowed to change the character 
        /// set specified in the Scripts combo box.
        /// </summary>
        CF_SELECTSCRIPT = 4194304,
        /// <summary>
        /// Causes the dialog box to display the Help button. The hwndOwner member must specify the window
        /// to receive the HELPMSGSTRING registered messages that the dialog box sends when the user clicks
        /// the Help button.
        /// </summary>
        CF_SHOWHELP = 4,
        /// <summary>
        /// Specifies that the lpszStyle member is a pointer to a buffer that contains style data that 
        /// ChooseFont should use to initialize the Font Style combo box. When the user closes the dialog box,
        /// ChooseFont copies style data for the user's selection to this buffer.
        /// </summary>
        CF_USESTYLE = 128,
        /// <summary>
        /// Specifies that ChooseFont should allow only the selection of fonts available on both the printer
        /// and the display. If this flag is specified, the CF_BOTH and CF_SCALABLEONLY flags should also be
        /// specified.
        /// </summary>
        CF_WYSIWYG = 32768
    }
}