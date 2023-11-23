using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_exercise_interfaces.Services;

namespace csharp_exercise_interfaces.Entities
{
    internal class Installment: IInstallment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public void PayInstallment()
        {
            Console.WriteLine($"Installment due date: {DueDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Installment amount: {Amount.ToString("F2")}");
        }
    }
}
