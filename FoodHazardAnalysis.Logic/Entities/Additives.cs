using System;
using System.Collections.Generic;

namespace FoodHazardAnalysis.Logic.Entities
{
    public partial class Additives
    {
        public Additives()
        {
            ProductAdditives = new HashSet<ProductAdditives>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Origin { get; set; }
        public string Category { get; set; }
        public string Danger { get; set; }

        public virtual ICollection<ProductAdditives> ProductAdditives { get; set; }
    }
}
