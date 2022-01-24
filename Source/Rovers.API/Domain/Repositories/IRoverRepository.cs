using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rovers.API.Domain.Models;

namespace Rovers.API.Domain.Repositories
{
    public interface IRoverRepository
    {
        Task<IEnumerable<Rover>> ListAsync();
        Task<Rover> GetRoverAsync(int roverId);
    }
}