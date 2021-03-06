using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Models
{
    public class BookAdmin
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime? Dataofloan { get; set; }
        public DateTime? Deadline { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}
