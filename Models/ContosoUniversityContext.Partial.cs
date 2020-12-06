using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    public partial class ContosoUniversityContext : DbContext
    {
        public virtual DbSet<DepartmentDropDown> DepartmentDropDown { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentDropDown>(entity =>
            {
                entity.HasNoKey();
            });
        }
    }
}
