using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity.Shared.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Shortname { get; set; }
        public string Unit { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string IP { get; set; }
        public string CompName { get; set; }
        public int RoleId { get; set; }
        public UserRole UserRole { get; set; }      
    }
}
