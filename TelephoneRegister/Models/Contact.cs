using System;
using System.Collections.Generic;

namespace TelephoneRegister.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
