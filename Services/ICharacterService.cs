namespace MovieStar.Services
{
    public interface ICharacterService
    {
        Task<List<CharacterDto>> getAll();
        Task<CharacterDto> save(CharacterAddDto NewCharacter);
    }
}