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
using System.PInvoke.Windows.Enums;

namespace System.PInvoke.Windows
{
    public class OSVersionInfo : IComparable, ICloneable
    {
// ReSharper disable InconsistentNaming
        private static readonly OSVersionInfo _Vista = new OSVersionInfo(OSPlatformId.Win32NT, MajorVersionConst.Vista,
                                                                         MinorVersionConst.Vista, true);

        private static readonly OSVersionInfo _Win2000 = new OSVersionInfo(OSPlatformId.Win32NT,
                                                                           MajorVersionConst.Win2000,
                                                                           MinorVersionConst.Win2000, true);

        private static readonly OSVersionInfo _Win2003 = new OSVersionInfo(OSPlatformId.Win32NT,
                                                                           MajorVersionConst.Win2003,
                                                                           MinorVersionConst.Win2003, true);

        private static readonly OSVersionInfo _Win32s = new OSVersionInfo(OSPlatformId.Win32S, MajorVersionConst.Win32S,
                                                                          MinorVersionConst.Win32S, true);

        private static readonly OSVersionInfo _Win95 = new OSVersionInfo(OSPlatformId.Win32Windows,
                                                                         MajorVersionConst.Win95,
                                                                         MinorVersionConst.Win95, true);

        private static readonly OSVersionInfo _Win98 = new OSVersionInfo(OSPlatformId.Win32Windows,
                                                                         MajorVersionConst.Win98,
                                                                         MinorVersionConst.Win98, true);

        private static readonly OSVersionInfo _WinCE = new OSVersionInfo(OSPlatformId.WinCE, true);
        // TODO: WinCE version

        private static readonly OSVersionInfo _WinME = new OSVersionInfo(OSPlatformId.Win32Windows,
                                                                         MajorVersionConst.WinME,
                                                                         MinorVersionConst.WinME, true);

        private static readonly OSVersionInfo _WinNT351 = new OSVersionInfo(OSPlatformId.Win32NT,
                                                                            MajorVersionConst.WinNT351,
                                                                            MinorVersionConst.WinNT351, true);

        private static readonly OSVersionInfo _WinNT4 = new OSVersionInfo(OSPlatformId.Win32NT, MajorVersionConst.WinNT4,
                                                                          MinorVersionConst.WinNT4, true);

        private static readonly OSVersionInfo _WinXP = new OSVersionInfo(OSPlatformId.Win32NT, MajorVersionConst.WinXP,
                                                                         MinorVersionConst.WinXP, true);
// ReSharper restore InconsistentNaming

        private int _buildNumber = -1;
        private string _csdVersion = String.Empty;
        private int _majorVersion = -1;
        private int _minorVersion = -1;
        private OSPlatformId _osPlatformId;
        private OSProductType _osProductType;
        private OSSuites _osSuiteFlags;
        private byte _reserved;
        private Int16 _servicePackMajor = -1;
        private Int16 _servicePackMinor = -1;

        public OSVersionInfo()
        {
        }

        public OSVersionInfo(
            OSPlatformId osPlatformId)
        {
            _osPlatformId = osPlatformId;
        }

        public OSVersionInfo(
            OSPlatformId osPlatformId,
            bool locked)
        {
            _osPlatformId = osPlatformId;

            IsLocked = locked;
        }

        public OSVersionInfo(
            OSPlatformId osPlatformId,
            int majorVersion,
            int minorVersion)
        {
            _osPlatformId = osPlatformId;
            _majorVersion = majorVersion;
            _minorVersion = minorVersion;
        }

        public OSVersionInfo(
            OSPlatformId osPlatformId,
            int majorVersion,
            int minorVersion,
            bool locked)
        {
            _osPlatformId = osPlatformId;
            _majorVersion = majorVersion;
            _minorVersion = minorVersion;

            IsLocked = locked;
        }

        public OSVersionInfo(OSVersionInfo o)
        {
            CopyThis(o);
        }


        public static OSVersionInfo Win32S
        {
            get { return _Win32s; }
        }

        public static OSVersionInfo Win95
        {
            get { return _Win95; }
        }

        public static OSVersionInfo Win98
        {
            get { return _Win98; }
        }

        public static OSVersionInfo WinME
        {
            get { return _WinME; }
        }

        public static OSVersionInfo WinNT351
        {
            get { return _WinNT351; }
        }

        public static OSVersionInfo WinNT4
        {
            get { return _WinNT4; }
        }

        public static OSVersionInfo Win2000
        {
            get { return _Win2000; }
        }

        public static OSVersionInfo WinXP
        {
            get { return _WinXP; }
        }

        public static OSVersionInfo Win2003
        {
            get { return _Win2003; }
        }

        public static OSVersionInfo WinCE
        {
            get { return _WinCE; }
        }

        public static OSVersionInfo Vista
        {
            get { return _Vista; }
        }

        public OSPlatformId OSPlatformId
        {
            get { return _osPlatformId; }

            set
            {
                CheckLock("OSPlatformId");

                _osPlatformId = value;
            }
        }

        public int OSMajorVersion
        {
            get { return _majorVersion; }

            set
            {
                CheckLock("MajorVersion");

                _majorVersion = value;
            }
        }

        public int OSMinorVersion
        {
            get { return _minorVersion; }

            set
            {
                CheckLock("MinorVersion");

                _minorVersion = value;
            }
        }

        public int BuildNumber
        {
            get { return _buildNumber; }

            set
            {
                CheckLock("BuildNumber");

                _buildNumber = value;
            }
        }

        public string OSCSDVersion
        {
            get { return _csdVersion; }

            set
            {
                CheckLock("CSDVersion");

                _csdVersion = value;
            }
        }

        public OSSuites OSSuiteFlags
        {
            get
            {
                CheckExtendedProperty("OSSuiteFlags");

                return _osSuiteFlags;
            }

            set
            {
                CheckLock("OSSuiteFlags");

                _osSuiteFlags = value;
            }
        }

        public OSProductType OSProductType
        {
            get
            {
                CheckExtendedProperty("OSProductType");

                return _osProductType;
            }

            set
            {
                CheckLock("OSProductType");

                _osProductType = value;
            }
        }

        public Int16 OSServicePackMajor
        {
            get
            {
                CheckExtendedProperty("ServicePackMajor");

                return _servicePackMajor;
            }

            set
            {
                CheckLock("ServicePackMajor");

                _servicePackMajor = value;
            }
        }

        public Int16 OSServicePackMinor
        {
            get
            {
                CheckExtendedProperty("ServicePackMinor");

                return _servicePackMinor;
            }

            set
            {
                CheckLock("ServicePackMinor");

                _servicePackMinor = value;
            }
        }

        public byte OSReserved
        {
            get
            {
                CheckExtendedProperty("Reserved");

                return _reserved;
            }

            set
            {
                CheckLock("Reserved");

                _reserved = value;
            }
        }

        public int Platform
        {
            get { return (int) _osPlatformId; }
        }

        public int SuiteMask
        {
            get
            {
                CheckExtendedProperty("SuiteMask");

                return (int) _osSuiteFlags;
            }
        }

        public byte ProductType
        {
            get
            {
                CheckExtendedProperty("ProductType");

                return (byte) _osProductType;
            }
        }

        public Version Version
        {
            get
            {
                if (OSMajorVersion < 0 || OSMinorVersion < 0)
                    return new Version();

                return BuildNumber < 0 ? new Version(OSMajorVersion, OSMinorVersion) : new Version(OSMajorVersion, OSMinorVersion, BuildNumber);
            }
        }

        public string VersionString
        {
            get { return Version.ToString(); }
        }

        public string OSPlatformIdString
        {
            get
            {
                switch (OSPlatformId)
                {
                    case OSPlatformId.Win32S:
                        return "Windows 32s";
                    case OSPlatformId.Win32Windows:
                        return "Windows 32";
                    case OSPlatformId.Win32NT:
                        return "Windows NT";
                    case OSPlatformId.WinCE:
                        return "Windows CE";

                    default:
                        throw new InvalidOperationException("Invalid OSPlatformId: " + OSPlatformId);
                }
            }
        }

        public string OSSuiteString
        {
            get
            {
                var s = String.Empty;

                var flags = OSSuiteFlags;

                if (OSSuiteFlag(flags, OSSuites.SmallBusiness))
                    OSSuiteStringAdd(ref s, "Small Business");

                if (OSSuiteFlag(flags, OSSuites.Enterprise))
                    switch (OSVersion)
                    {
                        case OSVersion.WinNT4:
                            OSSuiteStringAdd(ref s, "Enterprise");
                            break;
                        case OSVersion.Win2000:
                            OSSuiteStringAdd(ref s, "Advanced");
                            break;
                        case OSVersion.Win2003:
                            OSSuiteStringAdd(ref s, "Enterprise");
                            break;
                    }

                if (OSSuiteFlag(flags, OSSuites.BackOffice))
                    OSSuiteStringAdd(ref s, "BackOffice");

                if (OSSuiteFlag(flags, OSSuites.Communications))
                    OSSuiteStringAdd(ref s, "Communications");

                if (OSSuiteFlag(flags, OSSuites.Terminal))
                    OSSuiteStringAdd(ref s, "Terminal Services");

                if (OSSuiteFlag(flags, OSSuites.SmallBusinessRestricted))
                    OSSuiteStringAdd(ref s, "Small Business Restricted");

                if (OSSuiteFlag(flags, OSSuites.EmbeddedNT))
                    OSSuiteStringAdd(ref s, "Embedded");

                if (OSSuiteFlag(flags, OSSuites.Datacenter))
                    OSSuiteStringAdd(ref s, "Datacenter");

                if (OSSuiteFlag(flags, OSSuites.Personal))
                    OSSuiteStringAdd(ref s, "Home Edition");

                if (OSSuiteFlag(flags, OSSuites.Blade))
                    OSSuiteStringAdd(ref s, "Web Edition");

                if (OSSuiteFlag(flags, OSSuites.EmbeddedRestricted))
                    OSSuiteStringAdd(ref s, "Embedded Restricted");

                return s;
            }
        }

        public string OSProductTypeString
        {
            get
            {
                switch (OSProductType)
                {
                    case OSProductType.Workstation:

                        switch (OSVersion)
                        {
                            case OSVersion.Win32S:
                                return String.Empty;
                            case OSVersion.Win95:
                                return String.Empty;
                            case OSVersion.Win98:
                                return String.Empty;
                            case OSVersion.WinME:
                                return String.Empty;
                            case OSVersion.WinNT351:
                                return String.Empty;
                            case OSVersion.WinNT4:
                                return "Workstation";
                            case OSVersion.Win2000:
                                return "Professional";
                            case OSVersion.WinXP:
                                return OSSuiteFlag(OSSuiteFlags, OSSuites.Personal) ? "Home Edition" : "Professional";
                            case OSVersion.Win2003:
                                return String.Empty;
                            case OSVersion.WinCE:
                                return String.Empty;
                            case OSVersion.Vista:
                                return String.Empty;
                            default:
                                throw new InvalidOperationException("Invalid OSVersion: " + OSVersion);
                        }

                    case OSProductType.DomainController:
                        {
                            var s = OSSuiteString;

                            if (s.Length > 0) s += " ";

                            return s + "Domain Controller";
                        }

                    case OSProductType.Server:
                        {
                            var s = OSSuiteString;

                            if (s.Length > 0) s += " ";

                            return s + "Server";
                        }

                    default:
                        throw new InvalidOperationException("Invalid OSProductType: " + OSProductType);
                }
            }
        }

        public OSVersion OSVersion
        {
            get
            {
                switch (OSPlatformId)
                {
                    case OSPlatformId.Win32S:
                        return OSVersion.Win32S;

                    case OSPlatformId.Win32Windows:

                        switch (OSMinorVersion)
                        {
                            case MinorVersionConst.Win95:
                                return OSVersion.Win95;
                            case MinorVersionConst.Win98:
                                return OSVersion.Win98;
                            case MinorVersionConst.WinME:
                                return OSVersion.WinME;

                            default:
                                throw new InvalidOperationException("Invalid Win32Windows MinorVersion: " +
                                                                    OSMinorVersion);
                        }

                    case OSPlatformId.Win32NT:

                        switch (OSMajorVersion)
                        {
                            case MajorVersionConst.WinNT351:
                                return OSVersion.WinNT351;
                            case MajorVersionConst.WinNT4:
                                return OSVersion.WinNT4;

                            case MajorVersionConst.WinNT5:

                                switch (OSMinorVersion)
                                {
                                    case MinorVersionConst.Win2000:
                                        return OSVersion.Win2000;
                                    case MinorVersionConst.WinXP:
                                        return OSVersion.WinXP;
                                    case MinorVersionConst.Win2003:
                                        return OSVersion.Win2003;

                                    default:
                                        throw new InvalidOperationException("Invalid Win32NT WinNT5 MinorVersion: " +
                                                                            OSMinorVersion);
                                }

                            case MajorVersionConst.Vista:
                                return OSVersion.Vista;

                            default:
                                throw new InvalidOperationException("Invalid Win32NT MajorVersion: " + OSMajorVersion);
                        }

                    case OSPlatformId.WinCE:
                        return OSVersion.WinCE;

                    default:
                        throw new InvalidOperationException("Invalid OSPlatformId: " + OSPlatformId);
                }
            }
        }

        public string OSVersionString
        {
            get
            {
                switch (OSVersion)
                {
                    case OSVersion.Win32S:
                        return "Windows 32s";
                    case OSVersion.Win95:
                        return "Windows 95";
                    case OSVersion.Win98:
                        return "Windows 98";
                    case OSVersion.WinME:
                        return "Windows ME";
                    case OSVersion.WinNT351:
                        return "Windows NT 3.51";
                    case OSVersion.WinNT4:
                        return "Windows NT 4";
                    case OSVersion.Win2000:
                        return "Windows 2000";
                    case OSVersion.WinXP:
                        return "Windows XP";
                    case OSVersion.Win2003:
                        return "Windows 2003";
                    case OSVersion.WinCE:
                        return "Windows CE";
                    case OSVersion.Vista:
                        return "Windows Vista";

                    default:
                        throw new InvalidOperationException("Invalid OSVersion: " + OSVersion);
                }
            }
        }


        public bool ExtendedPropertiesAreSet { get; set; }

        public bool IsLocked { get; private set; }

        #region ICloneable Members

        public virtual object Clone()
        {
            return CreateCopy();
        }

        #endregion

        #region IComparable Members

        public virtual int CompareTo(object o)
        {
            if (o == null) throw new InvalidOperationException("CompareTo( object o ): 'o' is null");

            var p = o as OSVersionInfo;
            if (p == null) throw new InvalidOperationException("CompareTo( object o ): 'o' is not an OSVersionInfo");

            if (this == p) return 0;
            if (this > p) return 1;
            return -1;
        }

        #endregion

        public static OSVersionInfo GetOSVersionInfo(OSVersion v)
        {
            switch (v)
            {
                case OSVersion.Win32S:
                    return Win32S;
                case OSVersion.Win95:
                    return Win95;
                case OSVersion.Win98:
                    return Win98;
                case OSVersion.WinME:
                    return WinME;
                case OSVersion.WinNT351:
                    return WinNT351;
                case OSVersion.WinNT4:
                    return WinNT4;
                case OSVersion.Win2000:
                    return Win2000;
                case OSVersion.WinXP:
                    return WinXP;
                case OSVersion.Win2003:
                    return Win2003;
                case OSVersion.WinCE:
                    return WinCE;
                case OSVersion.Vista:
                    return Vista;

                default:
                    throw new InvalidOperationException();
            }
        }

        public static bool OSSuiteFlag(OSSuites flags, OSSuites test)
        {
            return ((flags & test) > 0);
        }

        private static void OSSuiteStringAdd(ref string s, string suite)
        {
            if (s.Length > 0) s += ", ";

            s += suite;
        }

        public void Lock()
        {
            IsLocked = true;
        }

        private void CheckExtendedProperty(string property)
        {
            if (ExtendedPropertiesAreSet) return;

            throw new InvalidOperationException("'" + property + "' is not set");
        }

        private void CheckLock(string property)
        {
            if (!IsLocked) return;

            throw new InvalidOperationException("Cannot set '" + property + "' on locked instance");
        }

        public virtual void Copy(OSVersionInfo o)
        {
            CopyThis(o);
        }

        public virtual OSVersionInfo CreateCopy()
        {
            return new OSVersionInfo(this);
        }

        private void CopyThis(OSVersionInfo o)
        {
            // normal fields
            _osPlatformId = o._osPlatformId;

            _majorVersion = o._majorVersion;
            _minorVersion = o._minorVersion;
            _buildNumber = o._buildNumber;
            _csdVersion = o._csdVersion;

            // extended fields
            _osSuiteFlags = o._osSuiteFlags;
            _osProductType = o._osProductType;

            _servicePackMajor = o._servicePackMajor;
            _servicePackMinor = o._servicePackMinor;
            _reserved = o._reserved;

            // state fields
            IsLocked = false;
            ExtendedPropertiesAreSet = o.ExtendedPropertiesAreSet;
        }

        public override bool Equals(object o)
        {
            var p = o as OSVersionInfo;

            if (p != null) return (this == p);

            return base.Equals(o);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            var s = OSVersionString;

            if (ExtendedPropertiesAreSet) s += " " + OSProductTypeString;

            if (OSCSDVersion.Length > 0) s += " " + OSCSDVersion;

            s += " v" + VersionString;

            return s;
        }

        public static bool operator ==(OSVersionInfo o, OSVersionInfo p)
        {
            if (o.OSPlatformId != p.OSPlatformId) return false;

            if (o.OSMajorVersion < 0 || p.OSMajorVersion < 0) goto hell;
            if (o.OSMajorVersion != p.OSMajorVersion) return false;

            if (o.OSMinorVersion < 0 || p.OSMinorVersion < 0) goto hell;
            if (o.OSMinorVersion != p.OSMinorVersion) return false;

            if (o.BuildNumber < 0 || p.BuildNumber < 0) goto hell;
            if (o.BuildNumber != p.BuildNumber) return false;

            if ((!o.ExtendedPropertiesAreSet) || (!p.ExtendedPropertiesAreSet)) goto hell;

            if (o.OSServicePackMajor < 0 || p.OSServicePackMajor < 0) goto hell;
            if (o.OSServicePackMajor != p.OSServicePackMajor) return false;

            if (o.OSServicePackMinor < 0 || p.OSServicePackMinor < 0) goto hell;
            if (o.OSServicePackMinor != p.OSServicePackMinor) return false;

            hell:

            return true;
        }

        public static bool operator !=(OSVersionInfo o, OSVersionInfo p)
        {
            return !(o == p);
        }

        public static bool operator <(OSVersionInfo o, OSVersionInfo p)
        {
            if (o.OSPlatformId < p.OSPlatformId) return true;
            if (o.OSPlatformId > p.OSPlatformId) return false;

            if (o.OSMajorVersion < 0 || p.OSMajorVersion < 0) goto hell;
            if (o.OSMajorVersion < p.OSMajorVersion) return true;
            if (o.OSMajorVersion > p.OSMajorVersion) return false;

            if (o.OSMinorVersion < 0 || p.OSMinorVersion < 0) goto hell;
            if (o.OSMinorVersion < p.OSMinorVersion) return true;
            if (o.OSMinorVersion > p.OSMinorVersion) return false;

            if (o.BuildNumber < 0 || p.BuildNumber < 0) goto hell;
            if (o.BuildNumber < p.BuildNumber) return true;
            if (o.BuildNumber > p.BuildNumber) return false;

            if ((!o.ExtendedPropertiesAreSet) || (!p.ExtendedPropertiesAreSet)) goto hell;

            if (o.OSServicePackMajor < 0 || p.OSServicePackMajor < 0) goto hell;
            if (o.OSServicePackMajor < p.OSServicePackMajor) return true;
            if (o.OSServicePackMajor > p.OSServicePackMajor) return false;

            if (o.OSServicePackMinor < 0 || p.OSServicePackMinor < 0) goto hell;
            if (o.OSServicePackMinor < p.OSServicePackMinor) return true;
            if (o.OSServicePackMinor > p.OSServicePackMinor) return false;

            hell:

            return false;
        }

        public static bool operator >(OSVersionInfo o, OSVersionInfo p)
        {
            if (o.OSPlatformId < p.OSPlatformId) return false;
            if (o.OSPlatformId > p.OSPlatformId) return true;

            if (o.OSMajorVersion < 0 || p.OSMajorVersion < 0) goto hell;
            if (o.OSMajorVersion < p.OSMajorVersion) return false;
            if (o.OSMajorVersion > p.OSMajorVersion) return true;

            if (o.OSMinorVersion < 0 || p.OSMinorVersion < 0) goto hell;
            if (o.OSMinorVersion < p.OSMinorVersion) return false;
            if (o.OSMinorVersion > p.OSMinorVersion) return true;

            if (o.BuildNumber < 0 || p.BuildNumber < 0) goto hell;
            if (o.BuildNumber < p.BuildNumber) return false;
            if (o.BuildNumber > p.BuildNumber) return true;

            if ((!o.ExtendedPropertiesAreSet) || (!p.ExtendedPropertiesAreSet)) goto hell;

            if (o.OSServicePackMajor < 0 || p.OSServicePackMajor < 0) goto hell;
            if (o.OSServicePackMajor < p.OSServicePackMajor) return false;
            if (o.OSServicePackMajor > p.OSServicePackMajor) return true;

            if (o.OSServicePackMinor < 0 || p.OSServicePackMinor < 0) goto hell;
            if (o.OSServicePackMinor < p.OSServicePackMinor) return false;
            if (o.OSServicePackMinor > p.OSServicePackMinor) return true;

            hell:

            return false;
        }

        public static bool operator <=(OSVersionInfo o, OSVersionInfo p)
        {
            return (o < p || o == p);
        }

        public static bool operator >=(OSVersionInfo o, OSVersionInfo p)
        {
            return (o > p || o == p);
        }

        #region Nested type: MajorVersionConst

        private class MajorVersionConst
        {
// ReSharper disable MemberHidesStaticFromOuterClass
            public const int Vista = 6;
            public const int Win2000 = WinNT5;
            public const int Win2003 = WinNT5;
            public const int Win32S = 0; // TODO: check
            public const int Win95 = 4;
            public const int Win98 = 4;
            public const int WinME = 4;
            public const int WinNT351 = 3;
            public const int WinNT4 = 4;
            public const int WinNT5 = 5;
            public const int WinXP = WinNT5;
// ReSharper restore MemberHidesStaticFromOuterClass

            private MajorVersionConst()
            {
            }
        }

        #endregion

        #region Nested type: MinorVersionConst

        private class MinorVersionConst
        {
// ReSharper disable MemberHidesStaticFromOuterClass
            public const int Vista = 0;
            public const int Win2000 = 0;
            public const int Win2003 = 2;
            public const int Win32S = 0; // TODO: check
            public const int Win95 = 0;
            public const int Win98 = 10;
            public const int WinME = 90;
            public const int WinNT351 = 51;
            public const int WinNT4 = 0;
            public const int WinXP = 1;
// ReSharper restore MemberHidesStaticFromOuterClass

            private MinorVersionConst()
            {
            }
        }

        #endregion
    }
}