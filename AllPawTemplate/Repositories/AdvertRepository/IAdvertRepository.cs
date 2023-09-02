using AllPawTemplate.Enitities;

namespace AllPawTemplate.Repositories.AdvertRepository
{
    public interface IAdvertRepository
    {
        void UpdateViewCount(int advertId);
        Task<List<Advert>> GetAllAdvertAsync();
        Task<Advert> GetAdvertByIdAsync(int advertId);
        Task<List<Advert>> GetUserAdvertsByIdAsync(int userId);
        Task<List<Advert>> GetAllAdvertAfterFilterAsync(List<int> filters);
    }
}
