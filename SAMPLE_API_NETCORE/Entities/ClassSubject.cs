using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class ClassSubject
    {
        public string ClassSubjectId { get; set; } = null!;
        public string? SubjectId { get; set; }
        public string? ClassSubject1 { get; set; }
        public int? NumOfMem { get; set; }
        public string? TeacherName { get; set; }
        public string? Semester { get; set; }
    }
}
