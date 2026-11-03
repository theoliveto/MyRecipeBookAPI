using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Application.UseCases.User.Register;

namespace MyRecipeBook.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Register(
        [FromBody] RequestRegisterUserAccountJson request, [FromServices] IRegisterUserAccountUseCase useCase)
    {
        await useCase.Execute(request);

        return Ok();
    }
}
