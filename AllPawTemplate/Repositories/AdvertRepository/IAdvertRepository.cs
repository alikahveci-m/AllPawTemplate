using AllPawTemplate.Enitities;

namespace AllPawTemplate.Repositories.AdvertRepository
{
    public interface IAdvertRepository
    {
        Task<List<Advert>> GetAllAdvertAsync();
        Task<Advert> GetAdvertByIdAsync(int advertId);
    }
}
