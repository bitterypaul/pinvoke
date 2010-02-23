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
    /// Selects the duplex or double-sided printing mode
    /// </summary>
    [Flags]
    public enum PrinterDuplexMode : short
    {
        /// <summary>
        /// Normal (nonduplex) printing.
        /// </summary>
        DMDUP_SIMPLEX = 1,
        /// <summary>
        /// Short-edge binding, that is, the long edge of the page is horizontal. 
        /// </summary>
        DMDUP_HORIZONTAL = 3,
        /// <summary>
        /// Long-edge binding, that is, the long edge of the page is vertical.
        /// </summary>
        DMDUP_VERTICAL = 2
    }
}