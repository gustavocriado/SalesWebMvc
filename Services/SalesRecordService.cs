using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var Result = from obj in _context.SalesRecords select obj;
            if (minDate.HasValue)
            {
                Result = Result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                Result = Result.Where(x => x.Date <= maxDate.Value);
            }
            return await Result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }

    }
}
