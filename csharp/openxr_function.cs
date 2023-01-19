// This file is auto-generated
using System.Runtime.InteropServices;
using System;

namespace fn.OpenXR.Common
{
    public sealed class OpenXRAPI
    {
        private static readonly OpenXRAPI instance = new OpenXRAPI();

        private ulong xrInstance = null;
        public ulong XrInstance
        {
            get { return xrInstance; }
            set { xrInstance = value; }
        }

        private ulong xrSession = null;
        public ulong XrSession
        {
            get { return xrSession; }
            set { xrInstance = value; }
        }

        static OpenXRAPI() { }

        private OpenXRAPI() { }

        public static OpenXRAPI call
        {
            get
            {
                return instance;
            }
        }

        // OpenXR Methods
        public delegate XrResult xrCreateHandTrackerEXTDelegate(
            XrSession session,
            ref XrHandTrackerCreateInfoEXT createInfo,
            out XrHandTrackerEXT handTracker);
        xrCreateHandTrackerEXTDelegate xrCreateHandTrackerEXT;

        public void HookGetOpenXRFunc(XrGetInstanceProcAddrDelegate xrGetInstanceProcAddr)
        {
            /// xrCreateHandTrackerEXT
            if (xrGetInstanceProcAddr(xrInstance, "xrCreateHandTrackerEXT", out funcPtr) == XrResult.XR_SUCCESS)
            {
                if (funcPtr != IntPtr.Zero)
                {
                    xrCreateHandTrackerEXT = Marshal.GetDelegateForFunctionPointer(funcPtr, typeof(xrCreateHandTrackerEXTDelegate))
                        as xrCreateHandTrackerEXTDelegate;
                }
            }
        }
    }
}