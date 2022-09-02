using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class LaboratoryLocation
    {
        public string LabId { get; set; } = null!;
        public string? LabName { get; set; }
        public string? Localtion { get; set; }
        public string? Notes { get; set; }
    }
}
