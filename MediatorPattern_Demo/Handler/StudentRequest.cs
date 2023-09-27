using MediatorPattern_Demo.ViewModels.Request;
using MediatorPattern_Demo.ViewModels.Response;
using MediatR;

namespace MediatorPattern_Demo.Handler
{
    public class StudentRequest : StudentViewModel, IRequest<ResponseStudentViewModel>
    {

    }
}
