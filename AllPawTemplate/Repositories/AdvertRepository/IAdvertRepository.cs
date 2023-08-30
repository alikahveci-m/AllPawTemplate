using AllPawTemplate.Dtos;

namespace AllPawTemplate.Repositories.AdvertRepository
{
    public interface IAdvertRepository
    {
        Task<List<Advert>> GetAllAdvertAsync();
    }
}
