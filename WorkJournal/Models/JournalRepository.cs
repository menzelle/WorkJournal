using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkJournal.Models
{
    public class JournalRepository : IJournalEntryRepository
    {
        private readonly AppDbContext _appDbContext;

        public JournalRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddEntry(JournalEntry journalEntry)
        {
            _appDbContext.JournalEntries.Add(journalEntry);
            _appDbContext.SaveChanges();
            
        }

        public IEnumerable<JournalEntry> GetAllEntries()
        {
            return _appDbContext.JournalEntries;       
        }

        public JournalEntry GetEntryById(int entryId)
        {
            return _appDbContext.JournalEntries.FirstOrDefault(p => p.JournalEntryId == entryId);
        }
    }
}
