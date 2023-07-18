namespace MovieStar.Services
{
    public class CharacterService: ICharacterService
    {
        CharacterContext context;

        public CharacterService(CharacterContext context)
        {
            this.context = context;
        }

        public async Task<List<Character>> getAll()
        {
            return await this.context.Characters.ToListAsync();
        }
    }
}