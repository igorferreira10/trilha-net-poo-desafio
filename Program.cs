using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
    //Testando o Nokia
    Smartphone nokia = new Nokia("123456789", "Nokia 3310", "1111111111111", 64);
    nokia.ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("WhatsApp");

    Console.WriteLine();

    //Testando iPhone
    Smartphone iphone = new Iphone("987654321","iPhone 13", "2222222222222", 256 );
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("Instagram");
    }
}