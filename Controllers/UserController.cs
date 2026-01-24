using Microsoft.AspNetCore.Mvc;
using MicrosoftAzure_Study.Models;
using MicrosoftAzure_Study.Services;
using System.Security.Cryptography.X509Certificates;

namespace MicrosoftAzure_Study.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{

    private readonly UserService _service;


    public UserController(UserService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _service.GetById(id);

        if (user is null)
            return NotFound();

        return Ok(user);
    }

    [HttpPost]
    public IActionResult Create(User user)
    {
        var createUser = _service.Add(user);

        return CreatedAtAction(
            nameof(GetById),
            new { id = createUser.Id },
            createUser
            );
    }
}