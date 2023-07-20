namespace MovieStar.Repositories
{
    public class UserRepository
    {
        private readonly CharacterContext dbContext;
        public UserRepository(CharacterContext dbContext)  
        {
            this.dbContext = dbContext;
        }

        public async Task<User> FindByIdAsync(int id){
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        
        public async Task<User> getUserByUserName(string userName){
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Username == userName);
        }        
        
        public async Task<User> save(User user){
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
            return user;
        }

    }
}