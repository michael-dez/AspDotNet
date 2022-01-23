using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ITSY.Models
{
    public class Ticket
    {
        
        public int Id { get; set; }
        
        [Display(Name = "Subject")]
        public string Subject { get; set; }
        
        [Display(Name = "Priority")]
        public PriorityOptions Priority { get; set; }
        
        [Display(Name = "Issue Type")]
        public IssueTypeOptions IssueType { get; set; }
        
        [Display(Name = "Open Date")]
        [DataType(DataType.Date)]
        public DateTime OpenDate { get; set; }
        
        [Display(Name = "Close Date")]
        [DataType(DataType.Date)]
        public DateTime? CloseDate { get; set; }
        
        [Display(Name = "Description")]
        public string Description { get; set; }
        
        [Display(Name = "Status")]
        public StatusOptions Status { get; set; }
        

        //public User TicketCreator { get; set; }
        //public User AssignedTo { get; set; }
        //public Worklog Worklog { get; set; }
        //public Comment Comments { get; set; }


        public enum PriorityOptions
        {
            Low,
            Medium,
            High,
            Critical
        }
        public enum IssueTypeOptions
        {
            Bug,
            Feature,
            Other
        }
        public enum StatusOptions
        {
            Open,
            Closed
        }

    }

}
