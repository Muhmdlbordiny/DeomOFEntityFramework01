using DeomOFEntityFramework01.Entities;

namespace DeomOFEntityFramework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CompanyG02Context dbcontext = new CompanyG02Context();
          var Result =   dbcontext.Employees.Where(E => E.EmpId == 1).FirstOrDefault(); // Remote Sql
        }
    }
}
