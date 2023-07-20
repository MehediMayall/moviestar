using Microsoft.AspNetCore.Mvc;

namespace MovieStar.Controllers
{
    public class UserController: BaseController
    {
        private readonly IUserService service;
        public UserController(IUserService service)
        {
            this.service = service;
        }

        public async Task<ActionResult<ResponseDto>> RegisterUser(UserAddDto NewUser)
        {
            try
            { 
                if(!ModelState.IsValid) throw new Exception("Please enter username and password");
                return getResponse(await this.service.RegisterUser(NewUser));
            }catch(Exception ex){ return getResponse(ex);}
        }
    }
}