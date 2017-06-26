using AppGradeAcademica.Models;
using System.Data.Entity;

namespace AppGradeAcademica.Context
{
    public class GradeContext : DbContext
    {
        public DbSet<Grade> Gadres { get; set; }
    }
}