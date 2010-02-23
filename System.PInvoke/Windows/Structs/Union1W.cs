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
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows.Structs
{
    /// <summary>
    /// Anonymous union
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct Union1W
    {
        /// <summary>
        /// Anonymous inner structure. See members for details
        /// </summary>
        [FieldOffset(0)] public InnerStruct1W Struct1;

        /// <summary>
        /// Anonymous inner structure. See members for details
        /// </summary>
        [FieldOffset(0)] public InnerStruct2W Struct2;
    }
}