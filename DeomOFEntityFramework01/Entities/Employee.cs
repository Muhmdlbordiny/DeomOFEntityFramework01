using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeomOFEntityFramework01.Entities
{
    //EF core support 4 ways for mapping classes to database(table, view,   Function)
    //1. By Convension (Default Behaviour)
    //2. By DataAnnotation (Set of Attributes => Data Vaildation)
    //3.FluentApi -- > override on ModelCreation
    //4. class configration
    ///plain old clr object
    ///POCO Class
    //internal class Employee
    //{
    //    public int Id { get; set; } // public Numeric property Named as "Id"    -> PK[use identity]
    //    public string Name { get; set; }// Ref Type : Allow Null [Optional] -> nvarchar(Max)
    //    public double Salary {  get; set; }// float valuetype:Not Allow Null [Required]
    //    public int? Age { get; set; } // Nullable<int> :Allow Null [Optional]
    //}
    //DataAnnotation

    //[Table("Employees",Schema ="dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int EmpId { get; set; }
    //    [Required]
    //    [Column(TypeName ="varchar(50)")]
    //    [MaxLength(50)]
    //    [StringLength(50,MinimumLength =10)]
    //    public string? Name { get; set; }
    //    [Column(TypeName ="money")]
    //    [Required]

    //    public double Salary { get; set; }
    //    [Required]
    //    [Range(18,60)]

    //    public int? Age { get; set; }
    //    [Required]
    //    [Phone]
    //    public string Phone {  get; set; }
    //    [StringLength(50,MinimumLength =10,ErrorMessage ="Plz Must be Character More than 10")]
    //   public string Address {  get; set; }
    //    [EmailAddress]
    //    public string Email {  get; set; }
    //    [NotMapped]
    //    public double totalSalary {  get; set; }
    //}


  
    internal class Employee
    {
        
        public int EmpId { get; set; }
        
        public string? Name { get; set; }
        

        public double Salary { get; set; }
        

        public int? Age { get; set; }
       
        public string Phone { get; set; }
        public string Address { get; set; }
        
        public string Email { get; set; }
        public double totalSalary { get; set; }
    }
}
