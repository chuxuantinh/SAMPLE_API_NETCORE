using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class Chemical
    {
        public Chemical()
        {
            PurchaseOrderLineChemicals = new HashSet<PurchaseOrderLineChemical>();
        }

        public int ChemicalId { get; set; }
        public string? ChemicalName { get; set; }
        public string? Specifications { get; set; }
        public double? Price { get; set; }
        public int? SupplierId { get; set; }
        public string? Notes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? Status { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? Qty { get; set; }
        public string? Origin { get; set; }

        public virtual ICollection<PurchaseOrderLineChemical> PurchaseOrderLineChemicals { get; set; }
    }
}
