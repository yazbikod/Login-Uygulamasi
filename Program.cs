internal class Program
{
    private static void Main(string[] args)
    {
        int hak = 3;

        while (true)
        {
            Console.WriteLine("Kullanıcı adınız : ");
            string kul_adi = Console.ReadLine();

            Console.WriteLine("Şifreniz : ");
            string sifre = Console.ReadLine();

            if (kul_adi == "enes" && sifre == "1453")
            {
                Console.WriteLine("Başarılı bir şekilde giriş yaptınız");
                Console.WriteLine("***********************************");
                break;
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre yanlış, tekrar deneyiniz. ");
                Console.WriteLine();
                if (hak > 0)
                {
                    hak -= 1;
                }
                if (hak == 0)
                {
                    Console.WriteLine("Giriş hakkınız dolmuştur");
                    break;
                }

            }
        }
    }
}