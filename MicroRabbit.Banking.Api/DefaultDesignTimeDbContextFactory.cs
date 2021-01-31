using MicroRabbit.Banking.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace MicroRabbit.Banking.Data
{
    public class DefaultDesignTimeDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {

            string path = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                                .SetBasePath(path);
            var config = builder.Build();
            var connectionString = "Server=LAPTOP-P7AO1VS1;Database=BankingDB;Trusted_Connection=True;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<BankingDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new BankingDbContext(optionsBuilder.Options);
        }
    }
}
