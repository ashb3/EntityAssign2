using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : Base
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
    }
}
