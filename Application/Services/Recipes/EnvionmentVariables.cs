using System;
namespace Recipes
{
    public static class EnvionmentVariables
    {
        public const string RecipesDatabaseLastRetryInSeconds = "RECIPES_DATABASE_LAST_RETRY_IN_SECONDS";
        public const string RecipesDatabaseConnectionString = "RECIPES_DATABASE";
        public const string MigrationRecipesDatabaseConnectionString = "RECIPES_DATABASE_MIGRATION";
    }
}
