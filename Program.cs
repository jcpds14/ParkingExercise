using DesaafioEstacionamentoJean.Models;

//apply encoding for UTF8 to display accentuation
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal hoursPrice = 0;

Console.Write("Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial: ");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.Write("Agora digite o preço por hora: ");
hoursPrice = Convert.ToDecimal(Console.ReadLine());

// Instantiates the parking class, with values obtained previously
Parking pa = new Parking(initialPrice, hoursPrice);

string option = string.Empty;
bool displayMenu = true;

while (displayMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            pa.AddVehicle();
            break;

        case "2":
            pa.RemoveVehicle();
            break;

        case "3":
            pa.ListOfVehicles();
            break;
        
        case "4":
            displayMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
