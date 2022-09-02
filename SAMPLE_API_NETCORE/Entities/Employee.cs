using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class Employee
    {
        public string? IdEmp { get; set; }
        public string? Fullname { get; set; }
        public DateTime? Birthday { get; set; }
        public string? AddressCurrent { get; set; }
    }
}
