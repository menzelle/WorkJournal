using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkJournal.Models;

namespace WorkJournal.ViewModel
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        
        
        public List<JournalEntry> Entries { get; set; }
      
    }
}
