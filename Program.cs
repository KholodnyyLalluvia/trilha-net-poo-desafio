using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando iPhone:");
        Smartphone iphone = new Iphone("123456", "iPhone 14", "111111111111111", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando Nokia:");
        Smartphone nokia = new Nokia("654321", "Nokia Tijolão", "222222222222222", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}
