using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class PurchaseOrderLineChemical
    {
        public int PurchaseOrderLineChemId { get; set; }
        public double Amount { get; set; }
        public string? Description { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountPercentage { get; set; }
        public double Price { get; set; }
        public int ChemicalId { get; set; }
        public int PurchaseOrderId { get; set; }
        public double Quantity { get; set; }
        public double SubTotal { get; set; }
        public double TaxAmount { get; set; }
        public double TaxPercentage { get; set; }
        public double Total { get; set; }

        public virtual Chemical Chemical { get; set; } = null!;
        public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;
    }
}
