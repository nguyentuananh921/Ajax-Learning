using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebMVC.Models;

namespace WebMVC.Data
{
    public class TransactionDbContext : IdentityDbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options)
            : base(options)
        {
        }
        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
