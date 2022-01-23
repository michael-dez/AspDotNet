using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITSY.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public DateTime Timestamp { get; set; }
        //public User User { get; set; }

    }
}
