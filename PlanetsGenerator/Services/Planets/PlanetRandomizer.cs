using PlanetsGenerator.Builders;
using PlanetsGenerator.Entities;
using PlanetsGenerator.Enums.Inhabitants;
using PlanetsGenerator.Enums.Planets;

namespace PlanetsGenerator.Services.Planets
{
    public class PlanetRandomizer : Randomizer
    {
        private const int MaxTemperature = 2000;

        private const int MinTemperature = -2000;

        private const int MinAtmosphericPressure = 0;

        private const int MaxAtmosphericPressure = 3000;

        private static readonly string[] _planetsNames =
        {
            "Aurora Prime", "Zephyr 9", "Nebulae Haven", "Celestia Alpha", "Verdantia", "Quasar Nexus", "Lumina Terra",
            "Galacta Majoris", "Stellaris Sigma", "Elysium Minor", "Serenity Haven", "Orion's Belt", "Nova Eden", 
            "Asteria Prime", "Nebulon Nexus", "Solstice Sphere", "Vortexia", "Cosmic Oasis", "Astralis Borealis", "Mirage Delta"
        };

        private static readonly string[] _inhabitantsNames =
        {
            "Nexarians", "Aurorans", "Zephyrites", "Celestians", "Verdantians", "Quasarians", "Luminarians", "Galactans", "Stellarians",
            "Elysians", "Serenites", "Orions", "Novans", "Asterians", "Nebulans", "Solarians", "Vortexians", "Cosmics", "Astralians",
            "Miragians"
        };

        public Planet GetPlanet()
        {
            return new PlanetBuilder()
                   .BuildName(GetRandomItem(_planetsNames))
                   .BuildMainColor(GetRandomItem(Enum.GetValues<ConsoleColor>()))
                   .BuildClassification(GetRandomItem(Enum.GetValues<Classification>()))
                   .BuildAvgTemperature(_random.Next(MinTemperature, MaxTemperature + 1))
                   .BuildAtmosphericPressure(_random.Next(MinAtmosphericPressure, MaxAtmosphericPressure + 1))
                   .BuildInhabitant(new RationalInhabitantBuilder()
                                    .BuildSocietiesStatus(GetRandomItems(Enum.GetValues<SocietyStatus>()))
                                    .BuildCharacteristics(GetRandomItems(Enum.GetValues<Characteristic>()))
                                    .BuildName(GetRandomItem(_inhabitantsNames))
                                    .GetInhabitant())
                   .GetPlanet();
        }
    }
}
