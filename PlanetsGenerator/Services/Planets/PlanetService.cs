using PlanetsGenerator.Entities;

namespace PlanetsGenerator.Services.Planets
{
    public class PlanetService
    {
        private readonly Planet _planet;

        public PlanetService()
        {
            _planet = new PlanetRandomizer().GetPlanet();
        }

        public void GenerateNewPlanet()
        {
            PlanetDesigner.Draw(color: _planet.MainColor);
            Console.WriteLine(_planet);
        }
    }
}
