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
using System.PInvoke.Windows.Structs;
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows
{
    public class CommonControl
    {
        /// <summary>
        /// Registers specific common control classes from the common control DLL
        /// </summary>
        /// <param name="iccex">A pointer to an INITCOMMONCONTROLSEX structure that contains information 
        /// specifying which control classes will be registered</param>
        /// <returns>Returns true if successful, or false otherwise</returns>
        public static bool InitCommonControlsEx(ref InitCommonControlsEx iccex)
        {
            return Native.InitCommonControlsEx(ref iccex);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("comctl32.dll", EntryPoint = "InitCommonControlsEx",
                CallingConvention = CallingConvention.StdCall, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool InitCommonControlsEx(ref InitCommonControlsEx iccex);
        }

        #endregion
    }
}