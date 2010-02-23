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
    /// The type of context for which Help is requested
    /// </summary>
    [Flags]
    public enum HelpContext
    {
        /// <summary>
        /// Help requested for a menu item.
        /// </summary>
        HELPINFO_MENUITEM = 2,
        /// <summary>
        /// Help requested for a control or window.
        /// </summary>
        HELPINFO_WINDOW = 1
    }
}