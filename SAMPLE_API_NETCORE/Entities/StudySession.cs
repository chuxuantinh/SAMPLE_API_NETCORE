using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class StudySession
    {
        public int? TimeBegin { get; set; }
        public int? TimeEnd { get; set; }
        public DateTime? DateExperiment { get; set; }
    }
}
