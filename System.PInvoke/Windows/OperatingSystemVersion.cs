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
using System.Globalization;
using System.PInvoke.Windows.Enums;
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows
{
    public class OperatingSystemVersion : OSVersionInfo
    {
        public OperatingSystemVersion()
        {
            var osVersionInfo = new OsVersionInfo();

            if (!UseOSVersionInfoEx(osVersionInfo))
                InitOsVersionInfo(osVersionInfo);
            else
                InitOsVersionInfoEx();
        }

        private static bool UseOSVersionInfoEx(OsVersionInfo info)
        {
            var b = NativeMethods.GetVersionEx(info);

            if (!b)
            {
                var error = Marshal.GetLastWin32Error();

                throw new InvalidOperationException(
                    "Failed to get OSVersionInfo. Error = 0x" +
                    error.ToString("8X", CultureInfo.CurrentCulture));
            }

            if (info.MajorVersion < 4) return false;
            if (info.MajorVersion > 4) return true;

            if (info.MinorVersion < 0) return false;
            if (info.MinorVersion > 0) return true;

            return info.CSDVersion == "Service Pack 6";
        }

        private void InitOsVersionInfo(OsVersionInfo info)
        {
            OSPlatformId = GetOSPlatformId(info.PlatformId);

            OSMajorVersion = info.MajorVersion;
            OSMinorVersion = info.MinorVersion;
            BuildNumber = info.BuildNumber;
            OSCSDVersion = info.CSDVersion;
        }

        private void InitOsVersionInfoEx()
        {
            var info = new OSVersionInfoEx();

            var b = NativeMethods.GetVersionEx(info);

            if (!b)
            {
                var error = Marshal.GetLastWin32Error();

                throw new InvalidOperationException(
                    "Failed to get OSVersionInfoEx. Error = 0x" +
                    error.ToString("8X", CultureInfo.CurrentCulture));
            }

            OSPlatformId = GetOSPlatformId(info.PlatformId);

            OSMajorVersion = info.MajorVersion;
            OSMinorVersion = info.MinorVersion;
            BuildNumber = info.BuildNumber;
            OSCSDVersion = info.CSDVersion;

            OSSuiteFlags = GetOSSuiteFlags(info.SuiteMask);
            OSProductType = GetOSProductType(info.ProductType);

            OSServicePackMajor = info.ServicePackMajor;
            OSServicePackMinor = info.ServicePackMinor;
            OSReserved = info.Reserved;

            ExtendedPropertiesAreSet = true;
        }

        private static OSPlatformId GetOSPlatformId(int platformId)
        {
            switch (platformId)
            {
                case VerPlatformId.Win32S:
                    return OSPlatformId.Win32S;
                case VerPlatformId.Win32Windows:
                    return OSPlatformId.Win32Windows;
                case VerPlatformId.Win32NT:
                    return OSPlatformId.Win32NT;
                case VerPlatformId.WinCE:
                    return OSPlatformId.WinCE;

                default:
                    throw new InvalidOperationException("Invalid PlatformId: " + platformId);
            }
        }

        private static OSSuites GetOSSuiteFlags(UInt16 suiteMask)
        {
            return (OSSuites) suiteMask;
        }

        private static OSProductType GetOSProductType(byte productType)
        {
            switch (productType)
            {
                case VerProductType.VER_NT_WORKSTATION:
                    return OSProductType.Workstation;
                case VerProductType.VER_NT_DOMAIN_CONTROLLER:
                    return OSProductType.DomainController;
                case VerProductType.VER_NT_SERVER:
                    return OSProductType.Server;

                default:
                    throw new InvalidOperationException("Invalid ProductType: " + productType);
            }
        }

        #region Nested type: NativeMethods

        private class NativeMethods
        {
            private NativeMethods()
            {
            }

            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern bool GetVersionEx
                (
                [In, Out] OsVersionInfo osVersionInfo
                );

            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern bool GetVersionEx
                (
                [In, Out] OSVersionInfoEx osVersionInfoEx
                );
        }

        #endregion

        #region Nested type: OSVERSIONINFO

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class OsVersionInfo
        {
            public int MajorVersion;
            public int MinorVersion;
            public int BuildNumber;
            public int PlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)] public string CSDVersion;

            public OsVersionInfo()
            {
                Marshal.SizeOf(this);
                StopTheCompilerComplaining();
            }


            private void StopTheCompilerComplaining()
            {
                MajorVersion = 0;
                MinorVersion = 0;
                BuildNumber = 0;
                PlatformId = 0;
                CSDVersion = String.Empty;
            }
        }

        #endregion

        #region Nested type: OSVERSIONINFOEX

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class OSVersionInfoEx
        {
            public int MajorVersion;
            public int MinorVersion;
            public int BuildNumber;
            public int PlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)] public string CSDVersion;
            public Int16 ServicePackMajor;
            public Int16 ServicePackMinor;
            public UInt16 SuiteMask;
            public byte ProductType;
            public byte Reserved;

            public OSVersionInfoEx()
            {
                Marshal.SizeOf(this);
                StopTheCompilerComplaining();
            }


            private void StopTheCompilerComplaining()
            {
                MajorVersion = 0;
                MinorVersion = 0;
                BuildNumber = 0;
                PlatformId = 0;
                CSDVersion = String.Empty;
                ServicePackMajor = 0;
                ServicePackMinor = 0;
                SuiteMask = 0;
                ProductType = 0;
                Reserved = 0;
            }
        }

        #endregion

        #region Nested type: VerPlatformId

// ReSharper disable ClassNeverInstantiated.Local
        private class VerPlatformId
// ReSharper restore ClassNeverInstantiated.Local
        {
            public const Int32 Win32NT = 2;
// ReSharper disable MemberHidesStaticFromOuterClass
            public const Int32 Win32S = 0;
            public const Int32 Win32Windows = 1;
            public const Int32 WinCE = 3;
// ReSharper restore MemberHidesStaticFromOuterClass

            private VerPlatformId()
            {
            }
        }

        #endregion

        #region Nested type: VerProductType

        private class VerProductType
        {
            public const byte VER_NT_DOMAIN_CONTROLLER = 0x00000002;
            public const byte VER_NT_SERVER = 0x00000003;
            public const byte VER_NT_WORKSTATION = 0x00000001;

            private VerProductType()
            {
            }
        }

        #endregion

        #region Nested type: VerSuiteMask

/*
        private class VerSuiteMask
        {
            public const UInt32 VER_SERVER_NT = 0x80000000;
            public const UInt16 VER_SUITE_BACKOFFICE = 0x00000004;
            public const UInt16 VER_SUITE_BLADE = 0x00000400;
            public const UInt16 VER_SUITE_COMMUNICATIONS = 0x00000008;
            public const UInt16 VER_SUITE_DATACENTER = 0x00000080;
            public const UInt16 VER_SUITE_EMBEDDED_RESTRICTED = 0x00000800;
            public const UInt16 VER_SUITE_EMBEDDEDNT = 0x00000040;
            public const UInt16 VER_SUITE_ENTERPRISE = 0x00000002;
            public const UInt16 VER_SUITE_PERSONAL = 0x00000200;
            public const UInt16 VER_SUITE_SINGLEUSERTS = 0x00000100;
            public const UInt16 VER_SUITE_SMALLBUSINESS = 0x00000001;
            public const UInt16 VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;
            public const UInt16 VER_SUITE_TERMINAL = 0x00000010;
            public const UInt32 VER_WORKSTATION_NT = 0x40000000;

            private VerSuiteMask()
            {
            }
        }
*/

        #endregion
    }
}