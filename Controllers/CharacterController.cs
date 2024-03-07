using Microsoft.AspNetCore.Mvc;
using Rpg___Fiap.Models;
namespace Rpg___Fiap.Models
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character Knight = new Character();
        [HttpGet]
        public ActionResult<Character> get()
        {
            return BadRequest(Knight);
        }
    }
}
