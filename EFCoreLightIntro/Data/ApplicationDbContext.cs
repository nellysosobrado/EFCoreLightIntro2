using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace EFCoreLightIntro.Data
{
    // Denna klass hjälper till att koppla ditt program till
    // en temporär databas och hantera Purchase-data.

    // Ärver från DbContext, vilket är en del av Entity Framework.
    // Det används för att hantera databaskopplingar och operationer
    // som att spara, hämta och uppdatera data.
    public class ApplicationDbContext : DbContext
    {
        // DbSet<Purchase> Purchases:
        // Detta är en "samling" som representerar en tabell i
        // databasen för att lagra och hämta data av typen Purchase.
        // Det betyder att du kan göra saker som att lägga till nya
        // köp eller hämta alla köp från databasen.
        public DbSet<Purchase> Purchases { get; set; }

        // OnConfiguring-metoden:
        // Här talar du om för Entity Framework hur databasen
        // ska konfigureras.
        // I det här fallet använder vi en in-memory database,
        // vilket innebär att databasen bara finns i RAM-minnet (tillfälligt)
        // och inte sparas på hårddisken.
        // Den används ofta för tester eller tillfälliga datalagringar.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
    }
}
