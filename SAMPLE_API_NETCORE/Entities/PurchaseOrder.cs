using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderLineChemicals = new HashSet<PurchaseOrderLineChemical>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
        }

        public int PurchaseOrderId { get; set; }
        public double Amount { get; set; }
        public int BranchId { get; set; }
        public int CurrencyId { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }
        public double Discount { get; set; }
        public double Freight { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public string? PurchaseOrderName { get; set; }
        public int PurchaseTypeId { get; set; }
        public string? Remarks { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; } = null!;
        public virtual ICollection<PurchaseOrderLineChemical> PurchaseOrderLineChemicals { get; set; }
        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
    }
}
