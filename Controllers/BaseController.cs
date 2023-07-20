
using Microsoft.AspNetCore.Mvc;

namespace MovieStar.Controllers
{

    public abstract class BaseController : Controller
    {

        protected ActionResult<ResponseDto> getResponse(object Data)
        {
            return Ok(new ResponseDto(){ Status="OK", Message = "", Data = Data });
        }
        protected ActionResult<ResponseDto> getResponse(Exception exception)
        {
            return BadRequest( new ResponseDto(){ Status = "ERROR", Message = getErrorDetails(exception), Data = null });
        }

        private string getErrorDetails(Exception exception)
        {
            if (exception == null) return "";
            string Message = string.Empty;
            if(exception.Message!=null) Message+= exception.Message;
            if(exception.InnerException!=null && exception.InnerException.Message!=null) Message+= exception.InnerException.Message;
            return Message;
        }
    }

}