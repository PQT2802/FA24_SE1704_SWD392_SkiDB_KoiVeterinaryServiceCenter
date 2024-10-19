using KVSC.Infrastructure.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KVSC.Infrastructure.DTOs.User
{
    public class UserList
    {
        public Extensions<UserData> Extensions { get; set; }
    }
    public class UserData
    {
        public List<User> Data { get; set; } = new List<User>();
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
    public class User : IPropertyNameProvider
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ProfilePictureUrl { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Role { get; set; } 
        public List<string> GetPropertyNames()
        {
            return new List<string> { nameof(FullName), nameof(Email), nameof(PhoneNumber), nameof(Address), nameof(DateOfBirth)};
        }
    }
}
