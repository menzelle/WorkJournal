using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkJournal.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        //The following DbSets are the tables that I want the database to create
        public DbSet<JournalEntry> JournalEntries { get; set; }
    }
}
