using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Library.Grisaitis.RNLibraryGrisaitis
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNLibraryGrisaitisModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNLibraryGrisaitisModule"/>.
        /// </summary>
        internal RNLibraryGrisaitisModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNLibraryGrisaitis";
            }
        }
    }
}
