using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Entity
{
    public class Blog: BaseEntity
    { 
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Image { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
