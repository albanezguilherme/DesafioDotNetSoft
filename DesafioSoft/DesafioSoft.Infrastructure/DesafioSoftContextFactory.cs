using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoft.Infrastructure
{
    public class DesafioSoftContextFactory : IDesignTimeDbContextFactory<DesafioSoftContext>
    {
        public DesafioSoftContext CreateDbContext(string[] args)
        {
            string environment = "Development";

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .Build();

            var builder = new DbContextOptionsBuilder<DesafioSoftContext>();

            var connectionString = configuration.GetConnectionString("dbConnection");
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("The connection string was not set " +
                "in the 'EFCORETOOLSDB' environment variable.");
            builder.UseSqlServer(connectionString);

            return new DesafioSoftContext(builder.Options);
        }
    }
}
