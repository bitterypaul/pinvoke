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
    /// set of flags that define the behavior of the dialog box. This can be zero or a combination of one or more of the following values.
    /// </summary>
    [Flags]
    public enum DialogBoxBehavior : uint
    {
        /// <summary>
        /// The + and - buttons are not displayed in the dialog box.
        /// </summary>
        DSBI_NOBUTTONS = 0x1,
        /// <summary>
        /// The lines that connect the objects in the dialog box are not displayed.
        /// </summary>
        DSBI_NOLINES = 0x2,
        /// <summary>
        /// The lines and buttons above the root objects are not displayed.
        /// </summary>
        DSBI_NOLINESATROOT = 0x4,
        /// <summary>
        /// Causes a check box to be placed next to each item in the tree.
        /// The user can use the mouse to select and clear this check box. 
        /// This currently has limited usage because there is no way to set
        /// or get the check state of an item.
        /// </summary>
        DSBI_CHECKBOXES = 0x100,
        /// <summary>
        /// The root object, specified by pszRoot of DSBROWSEINFO structure, is not displayed and the
        /// immediate child objects of the root are displayed at the root of
        /// the tree. This flag has no effect if pszRoot is null or if this 
        /// member contains DSBI_ENTIREDIRECTORY.
        /// </summary>
        DSBI_NOROOT = 0x10000,
        /// <summary>
        /// Include hidden objects in the dialog box.
        /// </summary>
        DSBI_INCLUDEHIDDEN = 0x20000,
        /// <summary>
        /// When the dialog box opens, the container specified
        /// in pszPath of DSBROWSEINFO structure will be visible and selected.
        /// </summary>
        DSBI_EXPANDONOPEN = 0x40000,
        /// <summary>
        /// Includes all the trusted domains to the server 
        /// specified in pszRoot of DSBROWSEINFO structure or, by default, the domain that 
        /// the user is logged in to.
        /// </summary>
        DSBI_ENTIREDIRECTORY = 0x90000,
        /// <summary>
        /// Indicates that the dwReturnFormat member of DSBROWSEINFO structure is valid. 
        /// If this flag is not set, the path format defaults to X.500.
        /// </summary>
        DSBI_RETURN_FORMAT = 0x100000,
        /// <summary>
        /// DSBROWSEINFO structure members pUserName and pPassword are used for the access credentials.
        /// Otherwise, if this member does not contain DSBI_SIMPLEAUTHENTICATE, 
        /// the dialog uses the security context of the calling thread.
        /// </summary>
        DSBI_HASCREDENTIALS = 0x200000,
        /// <summary>
        /// When determining if the object is displayed in the dialog box, 
        /// the treatAsLeaf display specifier is ignored.
        /// </summary>
        DSBI_IGNORETREATASLEAF = 0x400000,
        /// <summary>
        /// Indicates that secure authentication is not required when calling ADsOpenObject.
        /// </summary>
        DSBI_SIMPLEAUTHENTICATE = 0x800000,
        /// <summary>
        /// Indicates that the pszObjectClass and cchObjectClass of DSBROWSEINFO structure are valid and should be filled.
        /// </summary>
        DSBI_RETURNOBJECTCLASS = 0x1000000,
        /// <summary>
        /// Indicates that signing and sealing will not be used when 
        /// communicating with the directory service.
        /// </summary>
        DSBI_DONTSIGNSEAL = 0x2000000
    }
}