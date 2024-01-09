using NutNull.DemoProject.Debugging;

namespace NutNull.DemoProject
{
    public class DemoProjectConsts
    {
        public const string LocalizationSourceName = "DemoProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "b4e0a2fc937847b0b7d4dc0c76807e8c";
    }
}
