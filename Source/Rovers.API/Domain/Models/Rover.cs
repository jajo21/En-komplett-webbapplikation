namespace Rovers.API.Domain.Models 
{
    public class Rover
    {
        public int RoverId { get; set; }
        public string Name { get; set; }
        public string NasaURL { get; set; }
        public string History { get; set; }
        public double Weight { get; set; }
        public int Cameras { get; set; }
    }
}