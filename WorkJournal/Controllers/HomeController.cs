using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkJournal.Models;
using WorkJournal.ViewModel;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkJournal.Controllers
{
    public class HomeController : Controller
    {

        private readonly IJournalEntryRepository _journalEntryRepository;

        public HomeController(IJournalEntryRepository journalEntryRepository)
        {
            _journalEntryRepository = journalEntryRepository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var entries = _journalEntryRepository.GetAllEntries().OrderBy(e => e.MainTasks);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Menzelle's Daily Work Journal",
                Entries = entries.ToList()
            };

            

            return View(homeViewModel);
        }

        public IActionResult Entry()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Entry(JournalEntry journalEntry)
        {
            _journalEntryRepository.AddEntry(journalEntry);
            return View();
        }
    }
}
