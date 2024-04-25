using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;
using Microsoft.AspNetCore.Authorization;


namespace FamilyPromiseApp.Pages.Persons
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public IndexModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;
        public IList<Case> Case { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Person != null)
            {
                Person = await _context.Person.ToListAsync();
            }

            if (_context.Case != null)
            {
                Case = await _context.Case.ToListAsync();
            }
        }

        public Case getCaseFromPerson(int id)
        {
            var person = _context.Person.FirstOrDefault(c => c.ID == id);
            var caseID = person.Case.ID;
            var selCase = _context.Case.FirstOrDefault(c => c.ID == caseID);
            Console.WriteLine("Case ID: " + selCase.ID);
            return selCase;

        }

        public Person getPersonFromCase(int id)
        {
            var selCase = _context.Case.FirstOrDefault(c => c.ID == id);
            var selCaseID = selCase.ID;
            ///var personID = selCase.Person.ID;
            var person = _context.Person.FirstOrDefault(p => p.Case.ID == selCaseID);
            Console.WriteLine("Person ID: " + person.ID);
            return person;
        }
    }
}