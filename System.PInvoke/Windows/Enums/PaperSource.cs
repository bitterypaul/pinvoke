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
    /// Specifies the paper source
    /// </summary>
    [Flags]
    public enum PaperSource : short
    {
        DMBIN_AUTO = 7,
        DMBIN_CASSETTE = 14,
        DMBIN_ENVELOPE = 5,
        DMBIN_ENVMANUAL = 6,
        DMBIN_FIRST = 1,
        DMBIN_FORMSOURCE = 15,
        DMBIN_LARGECAPACITY = 11,
        DMBIN_LARGEFMT = 10,
        DMBIN_LAST = 15,
        DMBIN_LOWER = 2,
        DMBIN_MANUAL = 4,
        DMBIN_MIDDLE = 3,
        DMBIN_ONLYONE = 1,
        DMBIN_TRACTOR = 8,
        DMBIN_SMALLFMT = 9,
        DMBIN_UPPER = 1
    }
}