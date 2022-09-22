using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesaafioEstacionamentoJean.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal hoursPrice = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal hoursPrice)
        {
            this.initialPrice = initialPrice;
            this.hoursPrice = hoursPrice;
        }
        public void AddVehicle()
        {
            Console.Write("Digite a placa do veículo: ");
            vehicles.Add(Console.ReadLine());
            Console.WriteLine("Veículo adicionado com sucesso!");
        }
    }
}