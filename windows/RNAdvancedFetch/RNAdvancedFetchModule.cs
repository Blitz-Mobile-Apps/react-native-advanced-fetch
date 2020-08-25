using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Advanced.Fetch.RNAdvancedFetch
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAdvancedFetchModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAdvancedFetchModule"/>.
        /// </summary>
        internal RNAdvancedFetchModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAdvancedFetch";
            }
        }
    }
}
