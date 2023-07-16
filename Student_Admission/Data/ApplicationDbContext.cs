using Microsoft.EntityFrameworkCore;
using Student_Admission.Models;

namespace Student_Admission.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AdmissionForm> AdmissionForms { get; set; }
    }
}
