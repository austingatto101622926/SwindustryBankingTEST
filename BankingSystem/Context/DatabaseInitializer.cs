using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankingSystem.Models;
using System.Data.Entity;

namespace BankingSystem.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //base.Seed(context);

            Account account = new Account
            {
                Balance = 0
            };
            context.Accounts.Add(account);
            context.SaveChanges();
        }
    }
}