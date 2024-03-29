namespace MovieStar.Repositories;

public class UserRepository
{
    private readonly CharacterContext dbContext;
    public UserRepository(CharacterContext dbContext)  
    {
        this.dbContext = dbContext;
    }

    public async Task<User> getUserByID(int id){
        return await dbContext.Users.Include(c=> c.Characters).FirstOrDefaultAsync(u => u.Id == id);
        // return await dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    
    public async Task<User> getUserByEmail(string Email){
        return await dbContext.Users.FirstOrDefaultAsync(u => u.Email == Email);
    }        
    
    public async Task<User> save(User user){
        await dbContext.Users.AddAsync(user);
        await dbContext.SaveChangesAsync();
        return user;
    }

}
