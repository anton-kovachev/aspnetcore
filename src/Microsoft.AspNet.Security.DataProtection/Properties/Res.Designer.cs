// <auto-generated />
namespace Microsoft.AspNet.Security.DataProtection
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Res
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNet.Security.DataProtection.Res", typeof(Res).GetTypeInfo().Assembly);

        /// <summary>
        /// Argument cannot be null or empty.
        /// </summary>
        internal static string Common_NullOrEmpty
        {
            get { return GetString("Common_NullOrEmpty"); }
        }

        /// <summary>
        /// Argument cannot be null or empty.
        /// </summary>
        internal static string FormatCommon_NullOrEmpty()
        {
            return GetString("Common_NullOrEmpty");
        }

        /// <summary>
        /// The master key is too short. It must be at least {0} bytes in length.
        /// </summary>
        internal static string DataProtectorFactory_MasterKeyTooShort
        {
            get { return GetString("DataProtectorFactory_MasterKeyTooShort"); }
        }

        /// <summary>
        /// The master key is too short. It must be at least {0} bytes in length.
        /// </summary>
        internal static string FormatDataProtectorFactory_MasterKeyTooShort(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DataProtectorFactory_MasterKeyTooShort"), p0);
        }

        /// <summary>
        /// The data to decrypt is invalid.
        /// </summary>
        internal static string DataProtectorImpl_BadEncryptedData
        {
            get { return GetString("DataProtectorImpl_BadEncryptedData"); }
        }

        /// <summary>
        /// The data to decrypt is invalid.
        /// </summary>
        internal static string FormatDataProtectorImpl_BadEncryptedData()
        {
            return GetString("DataProtectorImpl_BadEncryptedData");
        }

        /// <summary>
        /// Couldn't protect data. Perhaps the user profile isn't loaded?
        /// </summary>
        internal static string DpapiDataProtectorImpl_ProfileNotLoaded
        {
            get { return GetString("DpapiDataProtectorImpl_ProfileNotLoaded"); }
        }

        /// <summary>
        /// Couldn't protect data. Perhaps the user profile isn't loaded?
        /// </summary>
        internal static string FormatDpapiDataProtectorImpl_ProfileNotLoaded()
        {
            return GetString("DpapiDataProtectorImpl_ProfileNotLoaded");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);
    
            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
