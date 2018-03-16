using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BankingSystem.Models;

namespace BankingSystem.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("azure") { }

        public DbSet<Account> Accounts { get; set; }
    }
}