using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test12321.Models
{
    public class Note
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ChangeDate { get; set; }

    }
}
