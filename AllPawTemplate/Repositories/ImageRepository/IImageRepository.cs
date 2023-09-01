using AllPawTemplate.Enitities;

namespace AllPawTemplate.Repositories.ImageRepository
{
    public interface IImageRepository
    {
        Task<List<Images>> GetImagesByAdvertIdAsync(int advertId);
    }
}
