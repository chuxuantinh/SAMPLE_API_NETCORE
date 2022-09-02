using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class LabTest
    {
        public int TestId { get; set; }
        public string? SubjectId { get; set; }
        public byte[]? TestName { get; set; }
    }
}
