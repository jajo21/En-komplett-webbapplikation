using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rovers.API.Domain.Models;
using Rovers.API.Domain.Services;
using Rovers.API.Resources;

namespace Rovers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoversController : Controller
    {
        private readonly IRoverService _roverService;
        private readonly IMapper _mapper;

        public RoversController(IRoverService roverService, IMapper mapper)
        {
            _roverService = roverService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoverResource>>> GetAllRovers()
        {
            var rovers = await _roverService.GetAllRoversAsync();
            return Ok(_mapper.Map<IEnumerable<Rover>, IEnumerable<RoverResource>>(rovers));
        }

        [HttpGet("{roverId}")]
        public async Task<ActionResult<RoverResource>> GetRover(int roverId)
        {
            var rover = await _roverService.GetRoverAsync(roverId);

            if(rover == null) return NotFound();
            
            return _mapper.Map<Rover, RoverResource>(rover);
        }
    }
}