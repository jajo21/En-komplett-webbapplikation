using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rovers.API.Domain.Models;
using Rovers.API.Domain.Persistence.Contexts;
using Rovers.API.Domain.Repositories;

namespace Rovers.API.Persistence.Repositories
{
    public class RoverRepository : BaseRepository, IRoverRepository
    {
        public RoverRepository(AppDbContext context) : base(context)
        {
            
        }
        public async Task<IEnumerable<Rover>> GetAllRoversAsync()
        {
            return await _context.Rovers.ToListAsync();
        }
        public async Task<Rover> GetRoverAsync(int roverId)
        {
            IQueryable<Rover> query = _context.Rovers.Where(r => r.RoverId == roverId);

            return await query.FirstOrDefaultAsync();
        }
    }
}