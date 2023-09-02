using System.Globalization;

namespace AllPawTemplate.Extensions
{
    public static class DateTimeExtension
    {
        public static string ToCustomDateString(this DateTime date)
        {
            string[] monthNames = new string[]
            {
            "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
            "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"
            };

            string formattedDate = date.ToString("d.MM.yyyy HH:mm:ss");

            if (DateTime.TryParseExact(formattedDate, "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                return $"{parsedDate.Day} {monthNames[parsedDate.Month - 1]} {parsedDate.Year}";
            }

            return formattedDate;
        }
    }
}
