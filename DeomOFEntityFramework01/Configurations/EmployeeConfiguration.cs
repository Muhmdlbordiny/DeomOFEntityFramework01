using DeomOFEntityFramework01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOFEntityFramework01.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(E => E.EmpId);
            builder.
                 Property(E => E.EmpId).
                        UseIdentityColumn(1, 1);


            builder.Property(E => E.Name)
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .HasDefaultValue("Aya");
            
            builder.Property(E => E.Salary)
                 .HasColumnType("money");
                  //.Property("Address")
                  builder.Property(nameof(Employee.Address))
                  .HasMaxLength(50)
                  .HasDefaultValue("Cairo");

        }
    }
}
