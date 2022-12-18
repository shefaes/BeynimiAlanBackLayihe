using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class Layoutservices: ILayoutservices
    {
        private readonly AppDbContext _context;
        public Layoutservices(AppDbContext context)
        {
            _context = context;
        }


        public async Task<Dictionary<string, string>> GetSettingsAsync()
        {
            return await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
        }

    }
}
