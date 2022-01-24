using System.Collections.Generic;
using System.Threading.Tasks;
using Rovers.API.Domain.Models;

namespace Rovers.API.Domain.Services 
{
    public interface IRoverService
    {
        Task<IEnumerable<Rover>> ListAsync();
        Task<Rover> GetRoverAsync(int roverId);
    }
}