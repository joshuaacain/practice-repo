﻿using NutNull.Ojt.Debugging;

namespace NutNull.Ojt
{
    public class OjtConsts
    {
        public const string LocalizationSourceName = "Ojt";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ede656dc68824b53bf3bc0f2cca3d43d";
    }
}
