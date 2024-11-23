using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLightIntro.Data
{
    public class Purchase
    {
        // Denna klass representerar en tabell (Entity) i vår databas!
        public int Id { get; set; }
        public string? Product { get; set; }
        public decimal Price { get; set; }
    }
}
