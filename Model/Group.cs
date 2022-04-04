using System;
using System.Collections.Generic;
using System.Text;
using Tourism.Model;

namespace Tourism
{
    public class Group : BaseEntity
    {
        public string ToDo { get; set; }
        public string Users { get; set; }
        public string Department { get; set; }
    }
}
