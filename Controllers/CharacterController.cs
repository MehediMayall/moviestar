
using Microsoft.AspNetCore.Mvc;

namespace MovieStar.Controllers
{
    public class CharacterController: BaseController
    {

        private ICharacterService service;

        public CharacterController(ICharacterService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("api/test")]
        public async Task<ActionResult<ResponseDto>> apiTest()
        {
            return getResponse("API Works");
        }

        [HttpGet]
        [Route("api/character/all")]
        public async Task<ActionResult<ResponseDto>> getAll()
        {
            return getResponse(await this.service.getAll());
        }
    }
}