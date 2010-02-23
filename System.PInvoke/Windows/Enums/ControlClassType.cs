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
    /// The set of bit flags that indicate which common control classes will be loaded from the comctl32 DLL
    /// </summary>
    [Flags]
    public enum ControlClassType : uint
    {
        /// <summary>
        /// Load animate control class. 
        /// </summary>
        ICC_ANIMATE_CLASS = 128,
        /// <summary>
        /// Load toolbar, status bar, trackbar, and ToolTip control classes
        /// </summary>
        ICC_BAR_CLASSES = 4,
        /// <summary>
        /// Load rebar control class
        /// </summary>
        ICC_COOL_CLASSES = 1024,
        /// <summary>
        /// Load date and time picker control class
        /// </summary>
        ICC_DATE_CLASSES = 256,
        /// <summary>
        /// Load hot key control class
        /// </summary>
        ICC_HOTKEY_CLASS = 64,
        /// <summary>
        /// Load IP address class
        /// </summary>
        ICC_INTERNET_CLASSES = 2048,
        /// <summary>
        /// Load a hyperlink control class
        /// </summary>
        ICC_LINK_CLASS = 32768,
        /// <summary>
        /// Load list-view and header control classes
        /// </summary>
        ICC_LISTVIEW_CLASSES = 1,
        /// <summary>
        /// Load a native font control class
        /// </summary>
        ICC_NATIVEFNTCTL_CLASS = 8192,
        /// <summary>
        /// Load pager control class
        /// </summary>
        ICC_PAGESCROLLER_CLASS = 4096,
        /// <summary>
        /// Load progress bar control class
        /// </summary>
        ICC_PROGRESS_CLASS = 32,
        /// <summary>
        /// Load one of the intrinsic User32 control classes. 
        /// The user controls include button, edit, static, listbox, combobox, and scrollbar
        /// </summary>
        ICC_STANDARD_CLASSES = 16384,
        /// <summary>
        /// Load tab and ToolTip control classes
        /// </summary>
        ICC_TAB_CLASSES = 8,
        /// <summary>
        /// Load tree-view and ToolTip control classes
        /// </summary>
        ICC_TREEVIEW_CLASSES = 2,
        /// <summary>
        /// Load up-down control class
        /// </summary>
        ICC_UPDOWN_CLASS = 16,
        /// <summary>
        /// Load ComboBoxEx class
        /// </summary>
        ICC_USEREX_CLASSES = 512,
        /// <summary>
        /// Load animate control, header, hot key, list-view, progress bar, status bar, tab, 
        /// ToolTip, toolbar, trackbar, tree-view, and up-down control classes
        /// </summary>
        ICC_WIN95_CLASSES = 255
    }
}