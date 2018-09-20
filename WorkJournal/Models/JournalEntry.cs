using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkJournal.Models
{
   
    public class JournalEntry
    {
        
        public int JournalEntryId { get; set; }
        public DateTime Date {
            get
            {
                return DateTime.Now;
            }
            set{}
            
        }
        public string MainTasks { get; set; }
        public string InterruptTasks { get; set; }
        public string Notes { get; set; }
        public string QuestionsForMentor { get; set; }
    }
}
