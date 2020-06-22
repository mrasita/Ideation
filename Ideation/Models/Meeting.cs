using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ideation.Models
{

    public enum Status
    {
        [Display(Name = "Ongoing")] ONGOING,
        [Display(Name = "Scheduled")] SCHEDULED,
        [Display(Name = "Finished")] FINISHED,
        [Display(Name = "Cancelled")] CANCELLED
    }
    public class Meeting
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public User Owner { get; set; }

    }
}