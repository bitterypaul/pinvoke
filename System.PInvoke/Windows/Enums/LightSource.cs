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
    /// Specifies the type of standard light source under which the image is viewed
    /// </summary>
    [Flags]
    public enum LightSource : ushort
    {
        /// <summary>
        /// Device's default. Standard used by output devices.
        /// </summary>
        ILLUMINANT_DEVICE_DEFAULT = 0,
        /// <summary>
        /// Tungsten lamp.
        /// </summary>
        ILLUMINANT_A = 1,
        /// <summary>
        /// Noon sunlight.
        /// </summary>
        ILLUMINANT_B = 2,
        /// <summary>
        /// NTSC daylight.
        /// </summary>
        ILLUMINANT_C = 3,
        /// <summary>
        /// Normal print.
        /// </summary>
        ILLUMINANT_D50 = 4,
        /// <summary>
        /// Bond paper print.
        /// </summary>
        ILLUMINANT_D55 = 5,
        /// <summary>
        /// Standard daylight. Standard for CRTs and pictures.
        /// </summary>
        ILLUMINANT_D65 = 6,
        /// <summary>
        /// Northern daylight.
        /// </summary>
        ILLUMINANT_D75 = 7,
        /// <summary>
        /// Cool white lamp.
        /// </summary>
        ILLUMINANT_F2 = 8,
        /// <summary>
        /// Tungsten lamp.
        /// </summary>
        ILLUMINANT_TUNGSTEN = 1,
        /// <summary>
        /// Noon sunlight.
        /// </summary>
        ILLUMINANT_DAYLIGHT = 3,
        /// <summary>
        /// Cool white lamp.
        /// </summary>
        ILLUMINANT_FLUORESCENT = 8,
        /// <summary>
        /// NTSC daylight.
        /// </summary>
        ILLUMINANT_NTSC = 3
    }
}