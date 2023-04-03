using Application.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers;

[AllowAnonymous]
[ApiExplorerSettings(IgnoreApi = true)]
public class ErrorsController : ControllerBase
{
    [Route("error")]
    public IActionResult Error()
    {
        return GetErrorResultByException(HttpContext.Features.Get<IExceptionHandlerFeature>()!.Error);
    }

    private IActionResult GetErrorResultByException(Exception ex)
    {
        //check item not found exception
        if (ex!.GetType() == typeof(ItemNotFoundException))
        {
            return NotFound(ex.Message);
        }
        return StatusCode(500, ex.Message);
    }
}