namespace MovieStar.Services
{
    public interface ICharacterService
    {
        Task<List<CharacterDto>> getAll();
    }
}