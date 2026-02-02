



using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
       SmartTv smartTv = new SmartTv();
        Console.WriteLine("OI SOU SUA SMART TV O QUE VOCÊ QUER FAZER HOJE");
        Console.WriteLine("0- SAIR | 1 - LIGAR TV | 2- DESLIGAR | 3 - CONECTAR WIFI | 4- DESCONECTAR ");
        while (true) 
        {
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                smartTv.Ligar();
            }
            else if (i == 0)
            {
                break;
            }
            else if (i == 2)
            {
                smartTv.Desligar();
            }
            else if(i == 3)
            {
                smartTv.conectarWIFI();
            }
            else if(i == 4)
            {
                smartTv.DesconectarWIFI();
            }     
        }
    }
}