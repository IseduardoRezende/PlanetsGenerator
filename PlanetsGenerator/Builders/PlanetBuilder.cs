using PlanetsGenerator.Entities;
using PlanetsGenerator.Enums.Planets;
using PlanetsGenerator.Interfaces;

namespace PlanetsGenerator.Builders
{
    public class PlanetBuilder : IPlanetBuilder
    {
        private readonly Planet _planet = new();

        public IPlanetBuilder BuildAtmosphericPressure(double atmosphericPressure)
        {
            _planet.AtmosphericPressure = atmosphericPressure;
            return this;
        }

        public IPlanetBuilder BuildAvgTemperature(double avgTemperature)
        {
            _planet.AvgTemperature = avgTemperature;
            return this;
        }

        public IPlanetBuilder BuildClassification(Classification classification)
        {
            _planet.Classification = classification;
            return this;
        }

        public IPlanetBuilder BuildInhabitant(Inhabitant inhabitant)
        {
            _planet.Inhabitant = inhabitant;
            return this;
        }

        public IPlanetBuilder BuildMainColor(ConsoleColor mainColor)
        {
            _planet.MainColor = mainColor;
            return this;
        }

        public IPlanetBuilder BuildName(string name)
        {
            _planet.Name = name;
            return this;
        }      

        public Planet GetPlanet()
        {
            return _planet;
        }
    }
}
