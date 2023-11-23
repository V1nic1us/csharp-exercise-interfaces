using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_interfaces.Services
{
    internal interface IContractService
    {
        void ProcessContract(Entities.Contract contract, int installments);
    }
}
