namespace carRental;

class Program
{
    private static int rentalValue;

    static void Main(string[] args)
    {
        double valueDay = 180.00;
        Console.WriteLine("\n***************** Seja bem-vindx ao sistema de aluguel de carros! *****************");
        Console.WriteLine("\nPor gentileza, digite seu nome: ");
            string name = Console.ReadLine();
        Console.WriteLine("Agora, por gentileza, digite quantos dias você está com o carro alugado: ");
            int days = Convert.ToInt32(Console.ReadLine());

        double rentalValue = valueDay * days;

        Console.WriteLine($"{name}, você alugou um carro por {days} dias e o valor do aluguel é de R$: {rentalValue:f2}");
    }
}
