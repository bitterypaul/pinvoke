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
    /// A set of bit flags that you can use to initialize the Color dialog box.
    /// When the dialog box returns, it sets these flags to indicate the user's input
    /// </summary>
    [Flags]
    public enum ChooseColorInput : uint
    {
        /// <summary>
        /// Causes the dialog box to display all available colors in the set of basic colors
        /// </summary>
        CC_ANYCOLOR = 256,
        /// <summary>
        /// Enables the hook procedure specified in the lpfnHook member of the CHOOSECOLOR* structure.
        /// This flag is used only to initialize the dialog box
        /// </summary>
        CC_ENABLEHOOK = 16,
        /// <summary>
        /// Indicates that the hInstance and lpTemplateName members of the CHOOSECOLOR* structure specify
        /// a dialog box template to use in place of the default template. This flag is used only to 
        /// initialize the dialog box.
        /// </summary>
        CC_ENABLETEMPLATE = 32,
        /// <summary>
        /// Indicates that the hInstance member identifies a data block that contains a preloaded dialog 
        /// box template. The system ignores the lpTemplateName member of the CHOOSECOLOR* structure if 
        /// this flag is specified. This flag is used only to initialize the dialog box
        /// </summary>
        CC_ENABLETEMPLATEHANDLE = 64,
        /// <summary>
        /// Causes the dialog box to display the additional controls that allow the user to create custom
        /// colors. If this flag is not set, the user must click the Define Custom Color button to display
        /// the custom color controls.
        /// </summary>
        CC_FULLOPEN = 2,
        /// <summary>
        /// Disables the Define Custom Color button.
        /// </summary>
        CC_PREVENTFULLOPEN = 4,
        /// <summary>
        /// Causes the dialog box to use the color specified in the rgbResult member of the CHOOSECOLOR* structure 
        /// as the initial color selection.
        /// </summary>
        CC_RGBINIT = 1,
        /// <summary>
        /// Causes the dialog box to display the Help button. The hwndOwner member of the CHOOSECOLOR* structure 
        /// must specify the window to receive the CommonDialog.HELPMSGSTRING registered messages that the dialog box sends 
        /// when the user clicks the Help button
        /// </summary>
        CC_SHOWHELP = 8,
        /// <summary>
        /// Causes the dialog box to display only solid colors in the set of basic colors.
        /// </summary>
        CC_SOLIDCOLOR = 128
    }
}