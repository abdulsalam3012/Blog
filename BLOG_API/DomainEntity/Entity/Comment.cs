using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Entity
{
    public class Comment : BaseEntity
    {
        public int Id { get; set; } 
        public required string Content { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int BlogId { get; set; } 

        public Blog Blog { get; set; }
    }
}
