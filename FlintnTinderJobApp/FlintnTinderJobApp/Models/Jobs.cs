using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlintnTinderJobApp.Models
{
    public class Jobs
    {
        public string Client { get; set; }
        public int JobNumber { get; set; }
        public string JobName { get; set; }
        public DateTime Due { get; set; }
        public string Status { get; set; }
    }
    public class JobObject
    {
        public List<Jobs> jobs { get; set; }
        
    }
}