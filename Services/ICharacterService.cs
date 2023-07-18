namespace MovieStar.Services
{
    public interface ICharacterService
    {
        Task<List<Character>> getAll();
    }
}