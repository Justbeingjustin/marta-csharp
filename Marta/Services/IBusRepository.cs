using Marta.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marta.Services
{
    public interface IBusRepository
    {
        Task<List<Bus>> GetBusesAsync();

        Task<List<Bus>> GetBusByRouteAsync(long route);
    }
}