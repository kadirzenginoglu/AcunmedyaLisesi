using AcunmedyaLisesi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeniAcunmedyaLisesi.Models.Models
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
