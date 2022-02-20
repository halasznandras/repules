using repules.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace repules.Models
{
    public class SeedData
    {
        public static void Inicializalas(IServiceProvider serviceProvider)
        {
            AppDbContext db = new AppDbContext(ServiceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());
            if (!db.Pilotak.Any())
            {
                var sorok = File.ReadAllLines(@"C:\temp\pilotak.csv").Skip(1);
                foreach (var sor in sorok)
                {
                    db.Pilotak.Add(new pilotak(sor));
                }
                db.SaveChanges();
            }
        }
    }
}
