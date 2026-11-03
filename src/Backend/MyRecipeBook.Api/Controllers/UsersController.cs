using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Application.UseCases.User.Register;

namespace MyRecipeBook.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult Register(
        [FromBody] RequestRegisterUserAccountJson request, [FromServices] IRegisterUserAccountUseCase useCase)
    {
        useCase.Execute(request);

        return Created();
    }
}
