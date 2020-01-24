﻿using Microsoft.EntityFrameworkCore;

namespace Web_API.Models
{
    public class LoanContext : DbContext
    {
        public LoanContext(DbContextOptions<LoanContext> options)
            : base(options)
        {
        }

        public DbSet<LoanItem> LoanItems { get; set; }
    }
}
