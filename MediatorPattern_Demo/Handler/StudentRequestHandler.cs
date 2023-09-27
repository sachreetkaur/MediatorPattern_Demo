using MediatorPattern_Demo.Services.Interface;
using MediatorPattern_Demo.ViewModels.Response;
using MediatR;

namespace MediatorPattern_Demo.Handler
{
    public class StudentRequestHandler : IRequestHandler<StudentRequest, ResponseStudentViewModel>
    {
        private readonly IStudentService _studentService;
        public StudentRequestHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public Task<ResponseStudentViewModel> Handle(StudentRequest request, CancellationToken cancellationToken)
        {
            string test=_studentService.AddStudent(request);

            return Task.FromResult(new ResponseStudentViewModel { Response = test });
        }
    }
}
