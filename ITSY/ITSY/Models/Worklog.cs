using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITSY.Models
{
    public class Worklog
    {
        public int Id { get; set; }
        public string WorklogText { get; set; }
        public DateTime Timestamp { get; set; }
        //public User User { get; set; }
    }
}
