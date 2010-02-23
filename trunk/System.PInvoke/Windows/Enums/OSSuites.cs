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
    public enum OSSuites
    {
        None = 0,
        SmallBusiness = 0x00000001,
        Enterprise = 0x00000002,
        BackOffice = 0x00000004,
        Communications = 0x00000008,
        Terminal = 0x00000010,
        SmallBusinessRestricted = 0x00000020,
        EmbeddedNT = 0x00000040,
        Datacenter = 0x00000080,
        SingleUserTS = 0x00000100,
        Personal = 0x00000200,
        Blade = 0x00000400,
        EmbeddedRestricted = 0x00000800,
    }
}