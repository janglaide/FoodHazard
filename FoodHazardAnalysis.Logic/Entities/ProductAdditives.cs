using System;
using System.Collections.Generic;

namespace FoodHazardAnalysis.Logic.Entities
{
    public partial class ProductAdditives
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? EadditiveId { get; set; }

        public virtual Additives Eadditive { get; set; }
        public virtual Products Product { get; set; }
    }
}
