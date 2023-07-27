using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MovieStar.Controllers;

[Authorize]
public class UserController: BaseController
{
    private readonly IUserService service;
    public UserController(IUserService service)
    {
        this.service = service;
    }

    [HttpPost]
    [Route("/api/user/save")]
    public async Task<ActionResult<ResponseDto>> RegisterUser(UserAddDto NewUser)
    {
        try
        { 
            if(!ModelState.IsValid) throw new Exception($"Please enter username and password.");
            return getResponse(await this.service.RegisterUser(NewUser));
        }   
        catch(Exception ex){ return getResponse(ex);}
    }
    
    [HttpPost]
    [Route("/api/user/login")]
    public async Task<ActionResult<ResponseDto>> login(LoginDto loginDto)
    {
        try
        { 
            if(!ModelState.IsValid) throw new Exception($"Please enter username and password.");
            return getResponse(await this.service.AuthenticateUser(loginDto));
        }   
        catch(Exception ex){ return getResponse(ex);}
    }
    
    [HttpGet]
    [Route("/api/user/detail/{id}")]
    public async Task<ActionResult<ResponseDto>> getUserDetail(int id)
    {
        try
        {           
            return getResponse(await service.GetUserDetail(id));
        }
        catch(Exception ex){ return getResponse(ex);}
    }
}
