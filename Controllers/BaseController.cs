
using Microsoft.AspNetCore.Mvc;

namespace MovieStar.Controllers
{

    public abstract class BaseController : Controller
    {

        protected ActionResult<ResponseDto> getResponse(object Data)
        {
            return new ResponseDto(){ Message = "", Data = Data };
        }
    }

}