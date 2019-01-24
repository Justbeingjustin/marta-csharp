using Marta.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marta.Services
{
    public interface ITrainRepository
    {
        Task<List<Train>> GetTrainsAsync();

        List<Train> GetTrains();
    }
}