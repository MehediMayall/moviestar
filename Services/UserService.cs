using MovieStar.Library;
using MovieStar.Repositories;

namespace MovieStar.Services
{
    public class UserService: IUserService
    {
        private readonly CharacterContext context;
        private readonly IMapper mapper;
        private readonly UserRepository repo;
        private readonly IConfiguration config;

        public UserService(CharacterContext context, IMapper mapper, IConfiguration config)
        {
            this.context = context;
            this.mapper = mapper;
            this.repo = new UserRepository(context);
            this.config = config;
        }


        public async Task<UserDto> RegisterUser(UserAddDto NewUser)
        {
            // Checking if user already exists
            if(await this.repo.getUserByEmail(NewUser.Email) !=null) throw new Exception($"An user already exist with this email id -> {NewUser.Email}. Please select different email."); 

             User newUser =  this.mapper.Map<User>(NewUser);
             
             new Security().createPasswordHash(NewUser.Password, out byte[]PasswordHash, out byte[] PasswordSalt );
             newUser.PasswordSalt = PasswordSalt;
             newUser.PasswordHash = PasswordHash;

             return this.mapper.Map<UserDto>( await this.repo.save(newUser));
        }

        public async Task<LoginResponseDto> AuthenticateUser(LoginDto loginDto)
        {
            User user = await this.repo.getUserByEmail(loginDto.Email);
            // Checking if user already exists
            if( user ==null) throw new Exception($"User email does not exists. Please enter a valid email");

            if(!new Security().validatePasswordHash(loginDto.Password, user.PasswordSalt, user.PasswordHash)){
                throw new Exception("Invalid user email or password.");
            } 

            var token = new Security().createToken(user, this.config.GetSection("AppKey").Value.ToString());

            return new LoginResponseDto{
                token = token,
                user = this.mapper.Map<UserDto>(user),
            };
        }

    }
}