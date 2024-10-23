using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Data.Models.Identity
{
    public class PMSUser : IdentityUser
    {
        public string FullUserName { get; set; }

        public string PositionId { get; set; }
        
        public string Position { get; set; }
    }
}
