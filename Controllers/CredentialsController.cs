using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI.Controllers
{
    // Indica que é um controller de API
    [ApiController]
    [Route("[controller]")]
    public class CredentialsController : ControllerBase
    {
        // Endpoint GET: /Credentials?username=Datto
        [HttpGet]
        public IActionResult Get([FromQuery] string username)
        {
            // Validação simples da entrada
            if (string.IsNullOrWhiteSpace(username))
            {
                return BadRequest(new { Error = "O username é obrigatório!" });
            }

            // Chama função auxiliar para validar usuário
            var user = ValidarUsuario(username);

            // Retorna o objeto como JSON
            return Ok(user);
        }

        // Função auxiliar que decide se o usuário é válido
        private UserValidoParaAccess ValidarUsuario(string username)
        {
            // Exemplo de validação com if
            if (username.ToLower() == "datto")
            {
                return new UserValidoParaAccess
                {
                    Username = username,
                    Role = "Admin",
                    IsValid = true
                };
            }

            // Caso usuário não seja válido
            return new UserValidoParaAccess
            {
                Username = username,
                Role = "None",
                IsValid = false
            };
        }
    }

    // Modelo de usuário retornado
    public class UserValidoParaAccess
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public bool IsValid { get; set; }
    }
}
