using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string ToDo { get; set; }
        public DateTime Group { get; set; }
    }
}
