using Marta.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marta.Services
{
    public interface IBusRepository
    {
        List<Bus> GetBuses();

        List<Bus> GetBusesByRoute(long route);

        Task<List<Bus>> GetBusesAsync();

        Task<List<Bus>> GetBusesByRouteAsync(long route);
    }
}