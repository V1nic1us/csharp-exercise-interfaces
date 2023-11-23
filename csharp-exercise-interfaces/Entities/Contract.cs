using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_exercise_interfaces.Services;

namespace csharp_exercise_interfaces.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public List<IInstallment> Installments { get; set; }

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
            Installments = new List<IInstallment>();
        }

        public void AddInstallment(IInstallment installment)
        {
            Installments.Add(installment);
        }
    }
}
