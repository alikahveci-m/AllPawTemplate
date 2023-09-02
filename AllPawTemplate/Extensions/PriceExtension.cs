namespace AllPawTemplate.Extensions
{
    public static class PriceExtension
    {
        public static string FormatAsPrice(this decimal value)
        {
            return value.ToString("N").Replace(",00", "");
        }
    }
}
