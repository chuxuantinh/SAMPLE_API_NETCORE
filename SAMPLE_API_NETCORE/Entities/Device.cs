using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class Device
    {
        public Device()
        {
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            RepairDetails = new HashSet<RepairDetail>();
        }

        public int DeviceId { get; set; }
        public string? DeviceCode { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceModel { get; set; }
        public int? TypeOfDevice { get; set; }
        public int? ParentId { get; set; }
        public string? Configuration { get; set; }
        public double? Price { get; set; }
        public string? PurchaseContract { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? Guarantee { get; set; }
        public int? UserId { get; set; }
        public string? Notes { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? Status { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusRepair { get; set; }
        public string? NewCode { get; set; }
        public string? DeviceNameEnglish { get; set; }
        public string? DeviceSeria { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? Qty { get; set; }
        public bool? TrainingUser { get; set; }

        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public virtual ICollection<RepairDetail> RepairDetails { get; set; }
    }
}
