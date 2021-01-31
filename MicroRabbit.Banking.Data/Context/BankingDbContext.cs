using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banking.Domain;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Account> Accounts {get;set;}
    }
}
