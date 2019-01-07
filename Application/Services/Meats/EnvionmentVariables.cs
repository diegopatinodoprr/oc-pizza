using System;
namespace MeatsApi
{
    public static class EnvionmentVariables
    {
        public const string MeatsDatabaseLastRetryInSeconds = "MEATS_DATABASE_LAST_RETRY_IN_SECONDS";
        public const string MeatsDatabaseConnectionString = "MEATS_DATABASE";
        public const string MigrationMeatsDatabaseConnectionString = "MEATS_DATABASE_MIGRATION";
    }
}
