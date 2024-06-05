// See https://aka.ms/new-console-template for more information
//using PlanetsGenerator.Builders;
//using PlanetsGenerator.Enums.Inhabitants;
//using PlanetsGenerator.Enums.Planets;
using PlanetsGenerator.Services.Planets;

Console.WriteLine("Hello, World!");

new PlanetService().GenerateNewPlanet();

//var planet = new PlanetBuilder()
//            .BuildName("Earth")
//            .BuildAvgTemperature(15)
//            .BuildAtmosphericPressure(1.0)
//            .BuildClassification(Classification.Rocky)
//            .BuildWeatherStatus(WeatherStatus.Great)
//            .BuildMainColor(ConsoleColor.DarkBlue)
//            .BuildInhabitant(new InhabitantBuilder()
//                             .BuildName("Human Being")
//                             .BuildBeingType(BeingType.Rational)
//                             .BuildCharacteristics(Characteristic.Creatives, Characteristic.Curious)
//                             .BuildSocietiesStatus(SocietyStatus.Technological, SocietyStatus.Agricultural)
//                             .GetInhabitant())
//            .GetPlanet();

//Console.WriteLine(planet);