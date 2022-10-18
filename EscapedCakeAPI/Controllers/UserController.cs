using BLL.EscapedCake.Entities;
using BLL.EscapedCake.Services;
using EscapedCakeAPI.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EscapedCakeAPI.Controllers
{
   
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly BUserService _userService;

        public UserController(ILogger logger, BUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpPost("UserRegister")]
        public IActionResult AddUser([FromBody] AddUserForm form)
        {
            _logger.LogInformation("Créer un compte");

            try
            {
                _userService.Adduser(new BUser(form.FirstName, form.LastName, form.Email, form.Passwd,form.Phone));
                return NoContent();
            }
            catch (Exception ex)
            {
#if DEBUG
                return BadRequest(new { Message = ex.Message });
#else
                return BadRequest(new { Message = "Quelque chose n'a pas fonctionné lors de l'enregistrement... Contactez l'administrateur du site" });
#endif
            }
        }

        [HttpPost("Login")]
        public IActionResult AuthUser([FromBody]AuthUserForm form)
        {
            _logger.LogInformation("Se connecter");
            try
            {
                BUser? user = _userService.AuthUser(form.Email, form.Passwd);
                return user is null ? BadRequest(new { Message = "Email ou mot de passe incorrect" }) : Ok(user);
            }
            catch (Exception ex)
            {

                return BadRequest(new {Message = ex.Message});
            }

        }


    }

}
