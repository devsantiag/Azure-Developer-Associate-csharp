using Microsoft.AspNetCore.Mvc;
using MicrosoftAzure_Study.Models;
using MicrosoftAzure_Study.Services;

namespace MicrosoftAzure_Study.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserCredentialsController : ControllerBase
{

    private readonly UserCredentialsServices _service;

    public UserCredentialsController(UserCredentialsServices service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var userCredentials = _service.GetById(id);
        if (userCredentials is null)
            return NotFound();
        return Ok(userCredentials);
    }
}