using PlanetsGenerator.Entities;
using PlanetsGenerator.Enums.Planets;

namespace PlanetsGenerator.Interfaces
{
    public interface IPlanetBuilder
    {
        IPlanetBuilder BuildName(string name);

        IPlanetBuilder BuildAvgTemperature(double avgTemperature);

        IPlanetBuilder BuildAtmosphericPressure(double atmosphericPressure);

        IPlanetBuilder BuildClassification(Classification classification);

        IPlanetBuilder BuildMainColor(ConsoleColor mainColor);

        IPlanetBuilder BuildInhabitant(Inhabitant inhabitant);

        Planet GetPlanet();
    }
}
