using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace hqh.project.EntityFrameCore.DbMigration.EntityFrameCore
{
    /// <summary>
    /// 上下文工厂类
    /// </summary>
    public class MigrationsDbContextFactory : IDesignTimeDbContextFactory<HqhProjectDbContext>
    {
        public HqhProjectDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<HqhProjectDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new HqhProjectDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
