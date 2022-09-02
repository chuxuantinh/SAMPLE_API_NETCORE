using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class Department
    {
        public int DepaartmentId { get; set; }
        public string? DepaartmentName { get; set; }
        public string? DepaartmentSymbol { get; set; }
        public int? DepaartmentManager { get; set; }
        public string? Address { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? Status { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
