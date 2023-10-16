using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Forgot
    {
        public string Email { get; set; }
        public DTO_Forgot() { }
        public DTO_Forgot(string Email) { this.Email = Email; }
    }
}
