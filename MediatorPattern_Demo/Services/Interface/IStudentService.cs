using MediatorPattern_Demo.ViewModels.Request;

namespace MediatorPattern_Demo.Services.Interface
{
    public interface IStudentService
    {
        string AddStudent(StudentViewModel studentViewModel);
    }
}
