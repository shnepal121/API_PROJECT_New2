using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APIproject.Models
{
    public class usr_login
    {
        internal object user;
        internal object password;

        [Key]
        public string usr_id { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string education { get; set; }
    }
}
