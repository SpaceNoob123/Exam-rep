using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plant_catalog.Models;

namespace Plant_catalog.Data
{
    public class PlantCatalogContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }

        public PlantCatalogContext() : base("Server=(local)\\SQLEXPRESS; Initial Catalog = Examwpf_db; Integrated Security=true")
        {
        }
    }
}
