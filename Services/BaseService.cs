using System.Security.Claims;

namespace MovieStar.Services
{
    public class BaseService
    {
        private IHttpContextAccessor httpContext { get; }
        public SessionUserDto sessionUser;

        public BaseService(IHttpContextAccessor httpContext)
        {
            this.httpContext = httpContext;
            this.sessionUser =  new SessionUserDto();

            if(this.httpContext.HttpContext.User != null) 
            {
                var claims = this.httpContext.HttpContext.User.Claims;
                this.sessionUser = new SessionUserDto{
                    Id = int.Parse(claims.FirstOrDefault(c=> c.Type == ClaimTypes.NameIdentifier).Value),
                    Email = claims.FirstOrDefault(c=> c.Type == ClaimTypes.Name).Value
                }; 
            }
        }

    }
}