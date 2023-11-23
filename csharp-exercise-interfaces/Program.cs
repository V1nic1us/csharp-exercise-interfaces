using System;
using System.Globalization;
using csharp_exercise_interfaces.Entities;
using csharp_exercise_interfaces.Services;

namespace csharp_exercise_interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            var number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            var date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            var value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            var installments = int.Parse(Console.ReadLine());

            var contract = new Contract(number, date, value);
            var contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, installments);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            foreach (var installment in contract.Installments)
            {
                installment.PayInstallment();
            }
        }
    }
}