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
    /// Type of return values of many multi-media functions
    /// </summary>
    [Flags]
    public enum MMResult : uint
    {
        /// <summary>
        /// Specified device identifier is out of range.
        /// </summary>
        MMSYSERR_BADDEVICEID = 2,
        /// <summary>
        /// Returns when no error in retrieving data
        /// </summary>
        MMSYSERR_NOERROR = 0
    }
}