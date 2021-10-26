using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace armcoordination_api.Entities
{
    public class child
    {
        [Key]
        public int id { get; set; }
        public string names { get; set; }
        public bool is_deleted { get; set; }
        public string relationship { get; set; }
        public string last_name { get; set; }
    }
}
