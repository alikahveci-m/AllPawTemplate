namespace AllPawTemplate.Dtos
{
    public class FilterDto
    {
        public List<string> Breeds { get; set; } // Seçilen türlerin listesi
        public PriceRange PriceRange { get; set; } // Fiyat aralığı
        public List<string> Ages { get; set; } // Seçilen yaş aralıklarının listesi
        public string SellerType { get; set; } // Satıcı türü (Sahibinden veya Petshop)
    }

    public class PriceRange
    {
        public decimal Min { get; set; } // Minimum fiyat
        public decimal Max { get; set; } // Maksimum fiyat
    }
}