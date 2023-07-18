
using Microsoft.AspNetCore.Mvc;

namespace MovieStar.Controllers
{
    public class CharacterController: BaseController
    {

        public CharacterController()
        {
            
        }

        [HttpGet]
        [Route("api/test")]
        public async Task<ActionResult<ResponseDto>> apiTest()
        {
            return getResponse("API Works");
        }
    }
}