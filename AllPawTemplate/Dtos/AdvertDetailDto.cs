namespace AllPawTemplate.Dtos
{
    public class AdvertDetailDto
    {
        public int AdvertId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public int Year { get; set; }
        public int ViewCount { get; set; }
        public bool Active { get; set; }
        public bool Vitrine { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AdvertPhoto { get; set; }
        public string Gender { get; set; }
        public string CategoryName { get; set; }
        public string FormattedPrice { get; set; }
        public List<string> SubImages { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
