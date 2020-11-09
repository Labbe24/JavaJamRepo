using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JavaJamMVC.Models
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Applicant> Applicants { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }
    }
}
