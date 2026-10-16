namespace NESNE_YÖNELİMLİ_PROGLAMLAMA_UYGULAMA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool oduncteMi= false;
            if (oduncteMi)
            {
                Console.WriteLine("İşlem geçersiz ekipman şu an ödünç alınmış durumda.");
                return; 
            }
            Console.WriteLine("Ödünç almak istediğiniz gün sayısını giriniz:");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out int gun))
            {
                Console.WriteLine("Geçersiz giriş lütfen gün sayısı giriniz");
                return;
            }
            if (gun <1 || gun > 7 )
            {
                Console.WriteLine($"Geçersiz gün sayısı ({gun}).Ödünç süresi (1-7) arasında olmalıdır.");
                return;
            }
            Console.WriteLine("İşleminiz başarılı şekilde gerçekleştirilmişitir. Teşekkür ederiz:)");
            Console.ReadKey();

        }
    }
}
