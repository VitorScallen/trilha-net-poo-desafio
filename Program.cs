using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Teste com o iPhone
        Smartphone iphone = new Iphone("123456789", "iPhone 13", "111222333444555", 128);
        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Teste com o Nokia
        Smartphone nokia = new Nokia("987654321", "Nokia Lumia", "555444333222111", 64);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Telegram");
    }
}
