using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rovers.API.Domain.Models;
using Rovers.API.Domain.Services;

namespace Rovers.API.Controllers
{
    [Route("api/[controller]")]
    public class RoversController : ControllerBase
    {
        private readonly IRoverService _roverService;

        public RoversController(IRoverService roverService)
        {
            _roverService = roverService;
        }

        [HttpGet]
        public async Task<IEnumerable<Rover>> GetAllAsync()
        {
            var rovers = await _roverService.ListAsync();
            return rovers;
        }

        [HttpGet("{roverId}")]
        public async Task<Rover> GetRoverById(int roverId)
        {
            var rover = await _roverService.GetRoverAsync(roverId);
            return rover;
        }
    }
}