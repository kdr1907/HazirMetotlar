using System; // DateTime sınıfını kullanabilmek için System kütüphanesini ekliyoruz.

public class TarihIslemleri // TarihIslemleri adında bir sınıf oluşturuyoruz.
{
    public static void Main(string[] args) // Programın başlangıç noktası olan Main metodunu tanımlıyoruz.
    {
        Console.WriteLine(DateTime.Now); // O anki tarih ve saati tam formatta ekrana yazdırır.
        Console.WriteLine(DateTime.Now.Date); // O anki tarihin sadece tarih kısmını (saat 00:00:00 olarak) ekrana yazdırır.

        Console.WriteLine(DateTime.Now.Day); // O anki tarihin gününü (1-31 arası) ekrana yazdırır.
        Console.WriteLine(DateTime.Now.Month); // O anki tarihin ayını (1-12 arası) ekrana yazdırır.

        Console.WriteLine(DateTime.Now.Year); // O anki tarihin yılını ekrana yazdırır.
        Console.WriteLine(DateTime.Now.Hour); // O anki saatin saat kısmını (0-23 arası) ekrana yazdırır.

        Console.WriteLine(DateTime.Now.Minute); // O anki saatin dakika kısmını (0-59 arası) ekrana yazdırır.
        Console.WriteLine(DateTime.Now.Second); // O anki saatin saniye kısmını (0-59 arası) ekrana yazdırır.

        Console.WriteLine(DateTime.Now.DayOfWeek); // O anki tarihin haftanın hangi günü olduğunu (örneğin, Pazartesi, Salı) ekrana yazdırır.
        Console.WriteLine(DateTime.Now.DayOfYear); // O anki tarihin yılın kaçıncı günü olduğunu (1-366 arası) ekrana yazdırır.

        Console.WriteLine(DateTime.Now.ToLongDateString()); // O anki tarihi uzun tarih formatında (örneğin, 15 Mart 2024 Cuma) ekrana yazdırır.
        Console.WriteLine(DateTime.Now.ToShortDateString()); // O anki tarihi kısa tarih formatında (örneğin, 15.03.2024) ekrana yazdırır.

        Console.WriteLine(DateTime.Now.ToLongTimeString()); // O anki saati uzun saat formatında (örneğin, 10:30:45) ekrana yazdırır.
        Console.WriteLine(DateTime.Now.ToShortTimeString()); // O anki saati kısa saat formatında (örneğin, 10:30) ekrana yazdırır.

        Console.WriteLine(DateTime.Now.AddDays(2)); // O anki tarihe 2 gün ekleyerek yeni tarih ve saati ekrana yazdırır.
        Console.WriteLine(DateTime.Now.AddHours(3)); // O anki saate 3 saat ekleyerek yeni tarih ve saati ekrana yazdırır.

        Console.WriteLine(DateTime.Now.AddSeconds(30)); // O anki saate 30 saniye ekleyerek yeni tarih ve saati ekrana yazdırır.
        Console.WriteLine(DateTime.Now.AddMonths(5)); // O anki tarihe 5 ay ekleyerek yeni tarih ve saati ekrana yazdırır.

        Console.WriteLine(DateTime.Now.AddYears(10)); // O anki tarihe 10 yıl ekleyerek yeni tarih ve saati ekrana yazdırır.
        Console.WriteLine(DateTime.Now.AddMilliseconds(50)); // O anki saate 50 milisaniye ekleyerek yeni tarih ve saati ekrana yazdırır.

        // Datetime Format (Tarih/Saat Biçimlendirme)
        Console.WriteLine(DateTime.Now.ToString("dd")); // Günün iki haneli sayısal gösterimi (örneğin, 24)
        Console.WriteLine(DateTime.Now.ToString("ddd")); // Haftanın gününün kısaltılmış metin gösterimi (örneğin, Sat)
        Console.WriteLine(DateTime.Now.ToString("dddd")); // Haftanın gününün tam metin gösterimi (örneğin, Saturday)
        
        Console.WriteLine(DateTime.Now.ToString("MM")); // Ayın iki haneli sayısal gösterimi (örneğin, 04)
        Console.WriteLine(DateTime.Now.ToString("MMM")); // Ayın kısaltılmış metin gösterimi (örneğin, Apr)
        Console.WriteLine(DateTime.Now.ToString("MMMM")); // Ayın tam metin gösterimi (örneğin, April)
        
        Console.WriteLine(DateTime.Now.ToString("yy")); // Yılın son iki hanesinin sayısal gösterimi (örneğin, 21)
        Console.WriteLine(DateTime.Now.ToString("yyyy")); // Yılın dört haneli sayısal gösterimi (örneğin, 2021)
        
        Console.WriteLine("****** Math Kütüphanesi *****"); // Konsola Math kütüphanesi başlığını yazdırır.
        
        // Math Kütüphanesi (Matematik Kütüphanesi)
        Console.WriteLine(Math.Abs(-25)); // -25'in mutlak değerini (25) konsola yazdırır.
        
        Console.WriteLine(Math.Sin(10)); // 10 radyanın sinüs değerini konsola yazdırır.
        Console.WriteLine(Math.Cos(10)); // 10 radyanın kosinüs değerini konsola yazdırır.
        Console.WriteLine(Math.Tan(10)); // 10 radyanın tanjant değerini konsola yazdırır.
        
        Console.WriteLine(Math.Ceiling(22.3)); // 22.3'ü yukarıya yuvarlayarak (23) konsola yazdırır.
        Console.WriteLine(Math.Round(22.3)); // 22.3'ü en yakın tam sayıya yuvarlayarak (22) konsola yazdırır.
        Console.WriteLine(Math.Round(22.7)); // 22.7'yi en yakın tam sayıya yuvarlayarak (23) konsola yazdırır.
        Console.WriteLine(Math.Floor(22.7)); // 22.7'yi aşağıya yuvarlayarak (22) konsola yazdırır.
        
        Console.WriteLine(Math.Max(2, 6)); // 2 ve 6'nın maksimumunu (6) konsola yazdırır.
        Console.WriteLine(Math.Min(2, 6)); // 2 ve 6'nın minimumunu (2) konsola yazdırır.
        
        Console.WriteLine(Math.Pow(3, 4)); // 3 üzeri 4'ü (81) konsola yazdırır.
        Console.WriteLine(Math.Sqrt(9)); // 9'un karekökünü (3) konsola yazdırır.
        
        Console.WriteLine(Math.Log(9)); // 9'un doğal logaritmasını (e tabanında) konsola yazdırır.
        Console.WriteLine(Math.Exp(3)); // e üzeri 3'ü konsola yazdırır.
        Console.WriteLine(Math.Log10(10)); // 10'un 10 tabanındaki logaritmasını (1) konsola yazdırır.
    }
}