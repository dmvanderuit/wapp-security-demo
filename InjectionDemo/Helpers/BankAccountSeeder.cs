using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InjectionDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace InjectionDemo.Helpers
{
    public static class BankAccountSeeder
    {
        public static void CleanAndSeed(InjectDatabaseContext context)
        {
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE [BankAccounts]");
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Questions]");
            
            var accountList = new List<BankAccount>();
            
            for (var i = 0; i < 20; i++)
            {
                var balance = (float) new Random().Next(1500, 55000);
                var account = new BankAccount
                {
                    AccountNumber = $"00{i + 1}",
                    Balance = balance
                };
                accountList.Add(account);
            }

            context.BankAccounts.AddRange(accountList);
            context.SaveChanges();
        }
    }
}