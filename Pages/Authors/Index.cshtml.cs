using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Vlad_Lab2.Data;
using Pop_Vlad_Lab2.Models;

namespace Pop_Vlad_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Pop_Vlad_Lab2.Data.Pop_Vlad_Lab2Context _context;

        public IndexModel(Pop_Vlad_Lab2.Data.Pop_Vlad_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
