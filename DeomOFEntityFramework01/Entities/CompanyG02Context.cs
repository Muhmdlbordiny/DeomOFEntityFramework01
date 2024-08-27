using DeomOFEntityFramework01.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOFEntityFramework01.Entities
{
    internal class CompanyG02Context:DbContext
    {
        public CompanyG02Context():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
           => optionsBuilder.UseSqlServer("Server=.;Database=CompanyG02;Trusted_Connection = True;TrustServerCertificate = True");
        
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());

            //modelBuilder.Entity<Employee>(E =>
            //{
                //E.HasKey(E => E.EmpId);

                //E.
                //      Property(E => E.EmpId).
                //             UseIdentityColumn(1, 1);

                //                E    .Property(E => E.Name)
                //                    .HasColumnType("varchar")
                //                    .HasMaxLength(50)
                //                    .HasDefaultValue("Aya");

                //                       E  .Property(E => E.Salary)
                //                        .HasColumnType("money");
                //                   E      //.Property("Address")
                //                         .Property(nameof(Employee.Address))
                //                         .HasMaxLength(50)
                //                         .HasDefaultValue("Cairo");


            //});

            //modelBuilder.Entity<Employee>().HasKey(E=>E.EmpId);
            //modelBuilder.Entity<Employee>().
            //             Property(E=>E.EmpId).
            //             UseIdentityColumn(1,1);

            //modelBuilder.Entity<Employee>()
            //                    .Property(E => E.Name)
            //                    .HasColumnType("varchar")
            //                    .HasMaxLength(50)
            //                    .HasDefaultValue("Aya");
            //modelBuilder.Entity<Employee>()
            //                        .Property(E => E.Salary)
            //                        .HasColumnType("money");
            //modelBuilder.Entity<Employee>()
            //                         //.Property("Address")
            //                         .Property(nameof(Employee.Address))
            //                         .HasMaxLength(50)
            //                         .HasDefaultValue("Cairo");


        }


    }
}
