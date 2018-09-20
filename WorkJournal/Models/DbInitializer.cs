using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkJournal.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
           
            if (!context.JournalEntries.Any())
            {
                context.AddRange
                  (
                    
                     new JournalEntry
                     {
                         Date = DateTime.Now,
                         MainTasks = "The Main Tasks for your day would go here",
                         InterruptTasks = "Here, you would have some secondary or interrupt tasks",
                         Notes = "Any notes you recorded in your journal can be seen here",
                         QuestionsForMentor = "And lastly, the questions that you sent to your mentor would go here!"
                     }

                  );

                context.SaveChanges();
                  
            }
        }
    }
}
