using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkJournal.Models
{
   public interface IJournalEntryRepository
    {
        IEnumerable<JournalEntry> GetAllEntries();
        JournalEntry GetEntryById(int entryId);
        void AddEntry(JournalEntry journalEntry);
    }
}
