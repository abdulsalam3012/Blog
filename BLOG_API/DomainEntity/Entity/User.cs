using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Entity
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
