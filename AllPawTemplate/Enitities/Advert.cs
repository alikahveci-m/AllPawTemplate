namespace AllPawTemplate.Enitities
{
    public class Advert
    {
        public int AdvertId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public int Year { get; set; }
        public bool Active { get; set; }
        public bool Vitrine { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? AdvertPhoto { get; set; }
        public string? Gender { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
