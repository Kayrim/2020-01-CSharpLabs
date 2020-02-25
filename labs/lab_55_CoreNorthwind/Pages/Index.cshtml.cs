using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using lab_55_CoreNorthwind.Model;

namespace lab_55_CoreNorthwind.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ConnectionDBClass _db;

        public IndexModel(ConnectionDBClass db)
        {
            _db = db;
        }

        public IEnumerable<CustomersClass> getRecords { get; set; }
        public async Task OnGet()
        {
            getRecords = await _db.Customers.ToListAsync();
        }
    }
}
