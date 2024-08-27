using AssignmentEFCore01.Context;
using AssignmentEFCore01.Entites;

namespace AssignmentEFCore01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataLayerContext context = new DataLayerContext();
            //context.Students.Add(new Student()
            //{ Id = 10, FName = "moha", LName = "ahmed", Address = "cairo", DeptId = 2 });
            //context.SaveChanges();
        }
    }
}
