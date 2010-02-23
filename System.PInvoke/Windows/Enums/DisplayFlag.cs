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
    /// Specifies the device's display mode
    /// </summary>
    [Flags]
    public enum DisplayFlag : uint
    {
        /// <summary>
        /// Specifies that the display is a noncolor device. If this flag is not set, color is assumed.
        /// </summary>
        DM_GRAYSCALE = 1,
        /// <summary>
        /// Specifies that the display mode is interlaced. If the flag is not set, noninterlaced is assumed. 
        /// </summary>
        DM_INTERLACED = 2
    }
}