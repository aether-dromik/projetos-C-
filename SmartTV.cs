using ConsoleApp1;

public class SmartTv : ILigavel,IConectar
{
    
    public void conectarWIFI()
    {
        Console.WriteLine("conectando no wifi");
    }
    public void DesconectarWIFI()
    {
        Console.WriteLine("desconectando do wifi");
    }

    public void Ligar()
    {
        Console.WriteLine("ligando TV");
    }
    public void Desligar()
    {
        Console.WriteLine("Desligando a TV");
    }
}