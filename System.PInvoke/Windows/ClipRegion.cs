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
using System.PInvoke.Windows.Structs;
using System.Runtime.InteropServices;

namespace System.PInvoke.Windows
{
    /// <summary>
    /// Contains PInvoke signature of Clipping Region APIs
    /// </summary>
    public class ClipRegion
    {
        /// <summary>
        /// Constant for GetRandomRgn function
        /// </summary>
        public const int SYSRGN = 4;

        /// <summary>
        /// The GetClipRgn function retrieves a handle identifying the current 
        /// application-defined clipping region for the specified device context
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="hrgn">Handle to an existing region before the function is called. After the function returns, 
        /// this parameter is a handle to a copy of the current clipping region</param>
        /// <returns>If the function succeeds and there is no clipping region for the given device context, 
        /// the return value is zero. If the function succeeds and there is a clipping region for the given 
        /// device context, the return value is 1. If an error occurs, the return value is -1</returns>
        public static int GetClipRgn([In] IntPtr hdc, [In] IntPtr hrgn)
        {
            return Native.GetClipRgn(hdc, hrgn);
        }

        /// <summary>
        /// The IntersectClipRect function creates a new clipping region from the
        /// intersection of the current clipping region and the specified rectangle
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="left">Specifies the x-coordinate, in logical units, of the upper-left corner of the rectangle</param>
        /// <param name="top">Specifies the y-coordinate, in logical units, of the upper-left corner of the rectangle</param>
        /// <param name="right">Specifies the x-coordinate, in logical units, of the lower-right corner of the rectangle</param>
        /// <param name="bottom">Specifies the y-coordinate, in logical units, of the lower-right corner of the rectangle</param>
        /// <returns>The return value specifies the new clipping region's type</returns>
        public static ClippingRegionType IntersectClipRect([In] IntPtr hdc, int left, int top, int right, int bottom)
        {
            return Native.IntersectClipRect(hdc, left, top, right, bottom);
        }

        /// <summary>
        /// The OffsetClipRgn function moves the clipping region of a device context by the specified offsets
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="x">Specifies the number of logical units to move left or right</param>
        /// <param name="y">Specifies the number of logical units to move up or down</param>
        /// <returns>The return value specifies the new region's complexity</returns>
        public static ClippingRegionType OffsetClipRgn([In] IntPtr hdc, int x, int y)
        {
            return Native.OffsetClipRgn(hdc, x, y);
        }

        /// <summary>
        /// The SelectClipRgn function selects a region as the current clipping region for the specified device context
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="hrgn">Handle to the region to be selected</param>
        /// <returns>The return value specifies the region's complexity </returns>
        public static ClippingRegionType SelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn)
        {
            return Native.SelectClipRgn(hdc, hrgn);
        }

        /// <summary>
        /// The ExcludeClipRect function creates a new clipping region that consists 
        /// of the existing clipping region minus the specified rectangle
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="left">Specifies the x-coordinate, in logical units, 
        /// of the upper-left corner of the rectangle</param>
        /// <param name="top">Specifies the y-coordinate, in logical units, 
        /// of the upper-left corner of the rectangle</param>
        /// <param name="right">Specifies the x-coordinate, in logical units, 
        /// of the lower-right corner of the rectangle</param>
        /// <param name="bottom">Specifies the y-coordinate, in logical units,
        /// of the lower-right corner of the rectangle</param>
        /// <returns>The return value specifies the new clipping region's complexity</returns>
        /// <remarks>The lower and right edges of the specified rectangle are not excluded from the clipping region</remarks>
        public static ClippingRegionType ExcludeClipRect([In] IntPtr hdc, int left, int top, int right, int bottom)
        {
            return Native.ExcludeClipRect(hdc, left, top, right, bottom);
        }

        /// <summary>
        /// The ExtSelectClipRgn function combines the specified region with the 
        /// current clipping region using the specified mode
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="hrgn">Handle to the region to be selected. This handle can only be null when the 
        /// ClippingOperationMode.RGN_COPY mode is specified</param>
        /// <param name="mode">Specifies the operation to be performed. It must be one of the following values</param>
        /// <returns>The return value specifies the new clipping region's complexity</returns>
        public static ClippingRegionType ExtSelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn, ClippingOperationMode mode)
        {
            return Native.ExtSelectClipRgn(hdc, hrgn, mode);
        }

        /// <summary>
        /// The GetClipBox function retrieves the dimensions of the tightest bounding rectangle that can be drawn around the 
        /// current visible area on the device. The visible area is defined by the current clipping region or clip path, 
        /// as well as any overlapping windows
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="lprect">Pointer to a RECT structure that is to receive the rectangle
        /// dimensions, in logical units</param>
        /// <returns>If the function succeeds, the return value specifies the clipping box's complexity</returns>
        public static ClippingRegionType GetClipBox([In] IntPtr hdc, [Out] out Rect lprect)
        {
            return Native.GetClipBox(hdc, out lprect);
        }

        /// <summary>
        /// The GetMetaRgn function retrieves the current metaregion for the specified device context
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="hrgn">Handle to an existing region before the function is called. After the 
        /// function returns, this parameter is a handle to a copy of the current metaregion</param>
        /// <returns>If the function succeeds, the return value is nonzero, else zero</returns>
        public static int GetMetaRgn([In] IntPtr hdc, [In] IntPtr hrgn)
        {
            return Native.GetMetaRgn(hdc, hrgn);
        }

        /// <summary>
        /// The GetRandomRgn function copies the system clipping region of a specified device context to a specific region
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="hrgn">Handle to a region. Before the function is called, this identifies an existing region.
        /// After the function returns, this identifies a copy of the current system region. The old region identified
        /// by hrgn is overwritten</param>
        /// <param name="i">This parameter must be SYSRGN</param>
        /// <returns>If the function succeeds, the return value is 1. If the function fails, the return value is –1. 
        /// If the region to be retrieved is null, the return value is 0. If the function fails or the region to be 
        /// retrieved is null, hrgn is not initialized</returns>
        public static int GetRandomRgn([In] IntPtr hdc, [In] IntPtr hrgn, int i)
        {
            return Native.GetRandomRgn(hdc, hrgn, i);
        }

        /// <summary>
        /// The PtVisible function determines whether the specified point is within the clipping region of a device context
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="x">Specifies the x-coordinate, in logical units, of the point</param>
        /// <param name="y">Specifies the y-coordinate, in logical units, of the point</param>
        /// <returns>If the specified point is within the clipping region of the device context, the return value is 1.
        /// If the specified point is not within the clipping region of the device context, the return value is 0.
        /// If the hdc is not valid, the return value is -1
        /// </returns>
        public static int PtVisible([In] IntPtr hdc, int x, int y)
        {
            return Native.PtVisible(hdc, x, y);
        }

        /// <summary>
        /// The RectVisible function determines whether any part of the specified rectangle 
        /// lies within the clipping region of a device context
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <param name="lprect">Pointer to a RECT structure that contains the logical coordinates of the specified rectangle</param>
        /// <returns>If the current transform does not have a rotation and the rectangle lies within the clipping region, the return value is 1
        /// If the current transform does not have a rotation and the rectangle does not lie within the clipping region, the return value is 0
        /// If the current transform has a rotation and the rectangle lies within the clipping region, the return value is 2.
        /// If the current transform has a rotation and the rectangle does not lie within the clipping region, the return value is 1.
        /// All other return values are considered error codes. If the any parameter is not valid, the return value is undefined. 
        /// </returns>
        public static int RectVisible([In] IntPtr hdc, [In] ref Rect lprect)
        {
            return Native.RectVisible(hdc, ref lprect);
        }

        /// <summary>
        /// The SelectClipPath function selects the current path as a clipping region for a device context, combining the
        /// new region with any existing clipping region using the specified mode
        /// </summary>
        /// <param name="hdc">Handle to the device context of the path</param>
        /// <param name="mode">Specifies the way to use the path</param>
        /// <returns>If the function succeeds, the return value is true, else false</returns>
        public static bool SelectClipPath([In] IntPtr hdc, ClippingOperationMode mode)
        {
            return Native.SelectClipPath(hdc, mode);
        }

        /// <summary>
        /// The SetMetaRgn function intersects the current clipping region for the specified device context with the
        /// current metaregion and saves the combined region as the new metaregion for the specified device context.
        /// The clipping region is reset to a null region
        /// </summary>
        /// <param name="hdc">Handle to the device context</param>
        /// <returns>The return value specifies the new clipping region's complexity</returns>
        public static ClippingRegionType SetMetaRgn([In] IntPtr hdc)
        {
            return Native.SetMetaRgn(hdc);
        }

        #region Nested type: Native

        internal class Native
        {
            [DllImport("gdi32.dll", EntryPoint = "GetClipRgn", SetLastError = true)]
            public static extern int GetClipRgn([In] IntPtr hdc, [In] IntPtr hrgn);

            [DllImport("gdi32.dll", EntryPoint = "IntersectClipRect", SetLastError = true)]
            public static extern ClippingRegionType IntersectClipRect([In] IntPtr hdc, int left, int top, int right,
                                                                      int bottom);

            [DllImport("gdi32.dll", EntryPoint = "OffsetClipRgn", SetLastError = true)]
            public static extern ClippingRegionType OffsetClipRgn([In] IntPtr hdc, int x, int y);

            [DllImport("gdi32.dll", EntryPoint = "SelectClipRgn", SetLastError = true)]
            public static extern ClippingRegionType SelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn);

            [DllImport("gdi32.dll", EntryPoint = "ExcludeClipRect", SetLastError = true)]
            public static extern ClippingRegionType ExcludeClipRect([In] IntPtr hdc, int left, int top, int right,
                                                                    int bottom);

            [DllImport("gdi32.dll", EntryPoint = "ExtSelectClipRgn", SetLastError = true)]
            public static extern ClippingRegionType ExtSelectClipRgn([In] IntPtr hdc, [In] IntPtr hrgn,
                                                                     ClippingOperationMode mode);

            [DllImport("gdi32.dll", EntryPoint = "GetClipBox", SetLastError = true)]
            public static extern ClippingRegionType GetClipBox([In] IntPtr hdc, [Out] out Rect lprect);

            [DllImport("gdi32.dll", EntryPoint = "GetMetaRgn", SetLastError = true)]
            public static extern int GetMetaRgn([In] IntPtr hdc, [In] IntPtr hrgn);

            [DllImport("gdi32.dll", EntryPoint = "GetRandomRgn", SetLastError = true)]
            public static extern int GetRandomRgn([In] IntPtr hdc, [In] IntPtr hrgn, int i);

            [DllImport("gdi32.dll", EntryPoint = "PtVisible", SetLastError = true)]
            public static extern int PtVisible([In] IntPtr hdc, int x, int y);

            [DllImport("gdi32.dll", EntryPoint = "RectVisible", SetLastError = true)]
            public static extern int RectVisible([In] IntPtr hdc, [In] ref Rect lprect);

            [DllImport("gdi32.dll", EntryPoint = "SelectClipPath", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool SelectClipPath([In] IntPtr hdc, ClippingOperationMode mode);

            [DllImport("gdi32.dll", EntryPoint = "SetMetaRgn", SetLastError = true)]
            public static extern ClippingRegionType SetMetaRgn([In] IntPtr hdc);
        }

        #endregion
    }
}