using MediatorPattern_Demo.Handler;
using MediatorPattern_Demo.ViewModels.Request;
using MediatorPattern_Demo.ViewModels.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorPattern_Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<string> AddStudent(StudentRequest studentViewModel)
        {
            ResponseStudentViewModel s =await _mediator.Send(studentViewModel);

            return "sdhdfjdgjdjfgdjgf";
        }

    }
}
