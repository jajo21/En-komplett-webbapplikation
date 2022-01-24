using System.Collections.Generic;
using System.Threading.Tasks;
using Rovers.API.Domain.Models;
using Rovers.API.Domain.Repositories;
using Rovers.API.Domain.Services;

namespace Rovers.API.Services
{
    public class RoverService : IRoverService
    {
        private readonly IRoverRepository _roverRepository;
        public RoverService(IRoverRepository roverRepository)
        {
            _roverRepository = roverRepository;
        }
        public async Task<IEnumerable<Rover>> ListAsync()
        {
            return await _roverRepository.ListAsync();
        }
        public async Task<Rover> GetRoverAsync(int roverId)
        {
            return await _roverRepository.GetRoverAsync(roverId);
        }
    }
}