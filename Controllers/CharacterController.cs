
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MovieStar.Controllers
{
    [Authorize]
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


        [HttpPost]
        [Route("api/character/save")]
        public async Task<ActionResult<ResponseDto>> save(CharacterAddDto NewCharacter)
        {
            try
            {
                return getResponse(await this.service.save(NewCharacter));
            }
            catch (System.Exception ex){ return getResponse(ex.Message); }
        }
    }
}