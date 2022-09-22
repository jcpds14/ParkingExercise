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
            Console.WriteLine("\nVeículo adicionado com sucesso!\n");
        }
        public void RemoveVehicle()
        {
            Console.Write("Digite a placa do veículo que está saindo: ");

            string vehiclePlate = Console.ReadLine();

            if (vehicles.Any(x => x.ToUpper() == vehiclePlate.ToUpper()))
            {
                Console.WriteLine("Quantas horas este veículo permaneceu no estacionamento?");

                int hoursInParking = 0;
                decimal fullPrice = 0;

                hoursInParking = int.Parse(Console.ReadLine());
                fullPrice = initialPrice + hoursPrice * hoursInParking;

                vehicles.Remove(vehiclePlate);

                Console.WriteLine($"Veículo removido com sucesso, preço total: {fullPrice}");
            }
            else
            {
                Console.Write(
                    "Desculpe, este veículo não está estaacionado aqui. Verifique se digitou a placa corretamente"
                );
            }
        }
        
    }
}