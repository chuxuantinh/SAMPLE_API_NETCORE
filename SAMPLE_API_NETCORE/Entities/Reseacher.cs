using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class Reseacher
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Organization { get; set; }
        public decimal? Phone { get; set; }
    }
}
