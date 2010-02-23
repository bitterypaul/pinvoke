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
    /// Used to initialize the find replace dialog box
    /// </summary>
    [Flags]
    public enum FindReplaceFlag : uint
    {
        /// <summary>
        /// If set in a FINDMSGSTRING message, indicates that the dialog box is
        /// closing. When you receive a message with this flag set, the dialog box
        /// handle returned by the FindText or ReplaceText function is no longer valid
        /// </summary>
        FR_DIALOGTERM = 64,
        /// <summary>
        /// If set, the Down button of the direction radio buttons in a Find dialog box is
        /// selected indicating that you should search from the current location to the end
        /// of the document. If not set, the Up button is selected so you should search to the 
        /// beginning of the document. You can set this flag to initialize the dialog box. If set
        /// in a FINDMSGSTRING message, indicates the user's selection
        /// </summary>
        FR_DOWN = 1,
        /// <summary>
        /// Enables the hook function specified in the lpfnHook member. This flag is used only to 
        /// initialize the dialog box.
        /// </summary>
        FR_ENABLEHOOK = 256,
        /// <summary>
        /// Indicates that the hInstance and lpTemplateName members specify a dialog box template to
        /// use in place of the default template. This flag is used only to initialize the dialog box
        /// </summary>
        FR_ENABLETEMPLATE = 512,
        /// <summary>
        /// Indicates that the hInstance member identifies a data block that contains a preloaded 
        /// dialog box template. The system ignores the lpTemplateName member if this flag is specified
        /// </summary>
        FR_ENABLETEMPLATEHANDLE = 8192,
        /// <summary>
        /// If set in a FINDMSGSTRING message, indicates that the user clicked the Find Next button in a
        /// Find or Replace dialog box. The lpstrFindWhat member specifies the string to search for.
        /// </summary>
        FR_FINDNEXT = 8,
        /// <summary>
        /// If set when initializing a Find dialog box, hides the search direction radio buttons
        /// </summary>
        FR_HIDEUPDOWN = 16384,
        /// <summary>
        /// If set when initializing a Find or Replace dialog box, hides the Match Case check box
        /// </summary>
        FR_HIDEMATCHCASE = 32768,
        /// <summary>
        /// If set when initializing a Find or Replace dialog box, hides the Match Whole Word Only check box.
        /// </summary>
        FR_HIDEWHOLEWORD = 65536,
        /// <summary>
        /// If set, the Match Case check box is selected indicating that the search should be case-sensitive.
        /// If not set, the check box is unselected so the search should be case-insensitive. You can set 
        /// this flag to initialize the dialog box. If set in a FINDMSGSTRING message, indicates the user's
        /// selection.
        /// </summary>
        FR_MATCHCASE = 4,
        /// <summary>
        /// If set when initializing a Find or Replace dialog box, disables the Match Case check box
        /// </summary>
        FR_NOMATCHCASE = 2048,
        /// <summary>
        /// If set when initializing a Find dialog box, disables the search direction radio buttons.
        /// </summary>
        FR_NOUPDOWN = 1024,
        /// <summary>
        /// If set when initializing a Find or Replace dialog box, disables the Whole Word check box.
        /// </summary>
        FR_NOWHOLEWORD = 4096,
        /// <summary>
        /// If set in a FINDMSGSTRING message, indicates that the user clicked the Replace button in 
        /// a Replace dialog box. The lpstrFindWhat member specifies the string to be replaced and the
        /// lpstrReplaceWith member specifies the replacement string
        /// </summary>
        FR_REPLACE = 16,
        /// <summary>
        /// If set in a FINDMSGSTRING message, indicates that the user clicked the Replace All button
        /// in a Replace dialog box. The lpstrFindWhat member specifies the string to be replaced and 
        /// the lpstrReplaceWith member specifies the replacement string.
        /// </summary>
        FR_REPLACEALL = 32,
        /// <summary>
        /// Causes the dialog box to display the Help button. The hwndOwner member must specify the window
        /// to receive the HELPMSGSTRING registered messages that the dialog box sends when the user clicks
        /// the Help button
        /// </summary>
        FR_SHOWHELP = 128,
        /// <summary>
        /// If set, the Match Whole Word Only check box is selected indicating that you should search only
        /// for whole words that match the search string. If not set, the check box is unselected so you 
        /// should also search for word fragments that match the search string. You can set this flag to 
        /// initialize the dialog box. If set in a FINDMSGSTRING message, indicates the user's selection
        /// </summary>
        FR_WHOLEWORD = 2
    }
}