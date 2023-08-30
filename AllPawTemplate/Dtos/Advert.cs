namespace AllPawTemplate.Dtos
{
    public class Advert
    {
        public int AdvertId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? AdvertPhoto { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
