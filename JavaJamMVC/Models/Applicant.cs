using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavaJamMVC.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Experience { get; set; }
    }
}
