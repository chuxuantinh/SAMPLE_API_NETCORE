using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class Subject
    {
        public string SubjectId { get; set; } = null!;
        public string? SubjectName { get; set; }
        public int? Credits { get; set; }
        public int? DepartmentId { get; set; }
    }
}
