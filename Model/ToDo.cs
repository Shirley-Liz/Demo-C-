using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Tourism.Model;

namespace Tourism
{
    public class ToDo : BaseEntity
    {
        
        public string Body { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
