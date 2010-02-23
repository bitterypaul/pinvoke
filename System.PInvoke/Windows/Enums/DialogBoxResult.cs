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
    /// Dialog Box Command IDs
    /// </summary>
    [Flags]
    public enum DialogBoxResult : uint
    {
        /// <summary>
        /// Dialogbox result is OK 
        /// </summary>
        IDOK = 1,
        /// <summary>
        /// Dialogbox result is Cancel 
        /// </summary>
        IDCANCEL = 2,
        /// <summary>
        /// Dialogbox result is Abort 
        /// </summary>
        IDABORT = 3,
        /// <summary>
        /// Dialogbox result is Retry 
        /// </summary>
        IDRETRY = 4,
        /// <summary>
        /// Dialogbox result is Ignore 
        /// </summary>
        IDIGNORE = 5,
        /// <summary>
        /// Dialogbox result is Yes 
        /// </summary>
        IDYES = 6,
        /// <summary>
        /// Dialogbox result is No 
        /// </summary>
        IDNO = 7,
        /// <summary>
        /// Dialogbox result is Close
        /// </summary>
        IDCLOSE = 8,
        /// <summary>
        /// Dialogbox result is Help
        /// </summary>
        IDHELP = 9,
        /// <summary>
        /// Dialogbox result is Try again
        /// </summary>
        IDTRYAGAIN = 10,
        /// <summary>
        /// Dialogbox result is Continue
        /// </summary>
        IDCONTINUE = 11
    }
}