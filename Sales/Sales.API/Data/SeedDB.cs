﻿using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Estados Unidos" });
                _context.Countries.Add(new Country { Name = "Chile" });
                _context.Countries.Add(new Country { Name = "Venezuela" });
                _context.Countries.Add(new Country { Name = "Marruecos" });
                _context.Countries.Add(new Country { Name = "Bolivia" });
            }

            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Ciclismo" });
                _context.Categories.Add(new Category { Name = "Natacion" });
                _context.Categories.Add(new Category { Name = "Lectura" });
                _context.Categories.Add(new Category { Name = "Patinaje" });
            }

            await _context.SaveChangesAsync();
        }
    }
}
