using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? PassWord { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Department { get; set; }
        public string? Position { get; set; }
        public int? RoleId { get; set; }
        public int? Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string? GroupId { get; set; }
        public string? UserType { get; set; }
    }
}
