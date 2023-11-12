using Microsoft.EntityFrameworkCore;
using System;

namespace OpenAiApi.Database
{
    public interface IMyDbContextFactory<out T> where T : DbContext
    {
        T CreateDbContext(string connectionString);
    }

    public sealed class MyDbContextFactory<T> : IMyDbContextFactory<T> where T : DbContext
    {
        public T CreateDbContext(string connectionString)
        {
            var options = new DbContextOptionsBuilder<MyDbContext>();
            options.UseNpgsql(connectionString, b => b.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery))
                   .EnableDetailedErrors()
                   .EnableSensitiveDataLogging()
                   .UseSnakeCaseNamingConvention()
                   .EnableServiceProviderCaching();

            return Activator.CreateInstance(typeof(T), options.Options) as T;
        }
    }
}
