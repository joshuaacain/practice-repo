using NutNull.Practice.Debugging;

namespace NutNull.Practice
{
    public class PracticeConsts
    {
        public const string LocalizationSourceName = "Practice";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d86a8bf4e39543e4a0ba406b7a8ee9e4";
    }
}
