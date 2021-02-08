using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace MicroRabbit.Transfer.Api
{
    public class TransferDesignTimeDbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDbContext CreateDbContext(string[] args)
        {

            string path = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                                .SetBasePath(path);
            var config = builder.Build();
            var connectionString = "Server=LAPTOP-P7AO1VS1;Database=TransferDB;Trusted_Connection=True;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<TransferDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new TransferDbContext(optionsBuilder.Options);
        }
    }
}
