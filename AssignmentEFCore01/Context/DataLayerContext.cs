using AssignmentEFCore01.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFCore01.Context
{
    internal class DataLayerContext:DbContext
    {
        public DataLayerContext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
           => optionsBuilder.UseSqlServer("Server=.;Database=DataLayer;Trusted_Connection = True;TrustServerCertificate = True");
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(S =>
            {
                S.HasKey(s => s.Id);
                S.Property(s => s.Id).UseIdentityColumn(10, 10);
                S.Property(s => s.FName)
                          .HasColumnType("varchar")
                          .HasMaxLength(50)
                          .IsRequired();
                S.Property(s=>s.LName)
                            .HasColumnType("varchar")
                          .HasMaxLength(50)
                          .IsRequired();
                S.Property(s => s.Address)
                            .HasColumnType("varchar")
                          .HasMaxLength(50);
                            
                          
            });
            modelBuilder.Entity<Department>(D =>
            {
                D.HasKey(d => d.Id);
                D.Property(d => d.Id).UseIdentityColumn(1, 1);
                D.Property(d => d.Name)
                          .HasColumnType("varchar")
                          .HasMaxLength(30)
                          .IsRequired();
                D.Property(d => d.HiringDate)
                          .HasColumnType("Date")
                          .HasDefaultValue("2024-5-5");

            });
            modelBuilder.Entity<Course>(C =>
            {
                C.HasKey(c => c.Id);
                C.Property(c=>c.Id).UseIdentityColumn(1, 1);
                C.Property(c => c.Name)
                          .HasColumnType("varchar")
                          .HasMaxLength(40)
                          .HasDefaultValue("Plz Enter Name");
                C.Property(c => c.Description)
                          .HasColumnType("varchar")
                          .HasMaxLength(60);


            });
            modelBuilder.Entity<Cour_Instructor>(Cs =>
            {
                Cs.HasKey(cs =>new { cs.Ins_Id ,cs.Cr_Id});
                Cs.Property(cs=>cs.Ins_Id).UseIdentityColumn(1, 1);
                Cs.Property(cs => cs.Evaulate)
                            .HasMaxLength(100)
                            .IsRequired();
            });
            modelBuilder.Entity<Topic>(T =>
            {
                T.HasKey(t => t.Id);
                T.Property(t=>t.Id).UseIdentityColumn(1, 1);
                T.Property(t => t.Name)
                           .HasColumnType("varchar")
                           .HasMaxLength(50)
                           .HasDefaultValue("Asp.NetCore");
            });
            modelBuilder.Entity<Instructor>(I =>
            {
                I.HasKey(i => i.Id);
                I.Property(i=>i.Id).UseIdentityColumn(4,4);
                I.Property(i => i.Name)
                          .HasColumnType("varchar")
                          .HasMaxLength(50)
                          .IsRequired();
                I.Property(I => I.Address)
                          .HasColumnType("varchar")
                          .HasMaxLength(50);
                I.Property(i => i.Bouns)
                        .HasColumnType("money");
                I.Property(i => i.Salary)
                       .HasColumnType("money")
                       .IsRequired();
                I.Property(i => i.HourRate)
                  .HasColumnType("money")
                 .HasMaxLength(200);


            });
            modelBuilder.Entity<StudentCourses>(Si =>
            {
                Si.HasKey(s =>new { s.Stud_Id,s.Cors_Id });
                Si.Property(s => s.Stud_Id).UseIdentityColumn(100, 100);
                Si.Property(s=>s.Grade)
                         .HasMaxLength(100)
                         .IsRequired();
            });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Cour_Instructor> cour_Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
    }
}
