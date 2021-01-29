using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakAndRead.Models
{
 
        public class AppUser : IdentityUser
        {
        
       
        public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime BirthDate { get; set; }
            public string EnteredBy { get; set; }

        }
    }


