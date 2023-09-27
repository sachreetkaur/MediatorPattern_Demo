using MediatorPattern_Demo.Services.Interface;
using MediatorPattern_Demo.ViewModels.Request;

namespace MediatorPattern_Demo.Services.Implementation
{
    public class StudentService : IStudentService
    {
        public string AddStudent(StudentViewModel studentViewModel)
        {
            //student record saved
            Console.WriteLine("student record saved");
            return "SAved Successully";
        }
    }
}
