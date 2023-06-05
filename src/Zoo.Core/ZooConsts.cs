using Zoo.Debugging;

namespace Zoo
{
    public class ZooConsts
    {
        public const string LocalizationSourceName = "Zoo";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9c771ecb240d420abe8155051c1dca42";
    }
}
