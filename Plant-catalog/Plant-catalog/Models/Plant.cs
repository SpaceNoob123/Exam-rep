using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plant_catalog.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string Description { get; set; }
        public string PositiveProperties { get; set; }
        public string NegativeProperties { get; set; }
        public string GrowthRegion { get; set; }
    }
}
