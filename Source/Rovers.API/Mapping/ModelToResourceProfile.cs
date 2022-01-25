using AutoMapper;
using Rovers.API.Domain.Models;
using Rovers.API.Resources;

namespace Rovers.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Rover, RoverResource>();
        }
    }
}