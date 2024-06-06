// See https://aka.ms/new-console-template for more information
using PlanetsGenerator.Services.Planets;
/* Others Importings for example:
using PlanetsGenerator.Builders;
using PlanetsGenerator.Enums.Inhabitants;
using PlanetsGenerator.Enums.Planets;
*/

Console.WriteLine("Hello, World!");

new PlanetService().GenerateNewPlanet();

/* creating a new obj for code example

var planet = new PlanetBuilder()
            .BuildName("Earth")
            .BuildAvgTemperature(15)
            .BuildAtmosphericPressure(1.0)
            .BuildClassification(Classification.Rocky)
            .BuildMainColor(ConsoleColor.DarkBlue)
            .BuildInhabitant(new RationalInhabitantBuilder()
                             .BuildSocietiesStatus(SocietyStatus.Technological, SocietyStatus.Agricultural)
                             .BuildName("Human Being")
                             .BuildCharacteristics(Characteristic.Creatives, Characteristic.Curious)
                             .GetInhabitant())
            .GetPlanet();

Console.WriteLine(planet);

*/