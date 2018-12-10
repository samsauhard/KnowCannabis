using System;
using System.Collections.Generic;

namespace KnowCannabis.Models
{
    public partial class User
    {
        public User()
        {
            Cannabis = new HashSet<Cannabis>();
        }

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Cannabis> Cannabis { get; set; }
    }
}
