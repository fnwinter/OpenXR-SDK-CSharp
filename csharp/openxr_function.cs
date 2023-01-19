// This file is auto-generated

namespace fn.OpenXR.Common
{
    public sealed class OpenXRAPI
    {
        private static readonly OpenXRAPI instance = new OpenXRAPI();

        private XrInstance xrInstance = null;
        private XrSession xrSession = null;

        static OpenXRAPI()
        {
        }

        private OpenXRAPI()
        {
        }

        public static OpenXRAPI call
        {
            get
            {
                return instance;
            }
        }

        ///
        // Methods
        ///
    }
}