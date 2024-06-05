using PlanetsGenerator.Enums.Planets;
using PlanetsGenerator.Extensions;

namespace PlanetsGenerator.Entities
{
    public class Planet
    {
        private const int MaxLivableTemperature = 50;

        private const int MinLivableTemperature = -50;

        private const double MaxLivableAtmosphericPressure = 2.0;

        private const double MinLivableAtmosphericPressure = 0.2;

        private const double SuccessSurvivalRate = 0.90;

        private readonly double _chanceToLive = Random.Shared.NextDouble();

        private Inhabitant? _inhabitant;

        public string Name { get; set; } = string.Empty;

        public double AvgTemperature { get; set; }

        public double AtmosphericPressure { get; set; }

        public Classification Classification { get; set; }

        public WeatherStatusForHumans WeatherStatusForHumans { get { return GetWeatherStatusForHumans(); } }

        public ConsoleColor MainColor { get; set; }

        public Inhabitant? Inhabitant
        {
            get
            {
                return _inhabitant;
            }
            set
            {
                if (!Habitable)
                {
                    _inhabitant = null;
                }
                else
                {
                    _inhabitant = value;
                }
            }
        }

        public bool HabitableForHumans { get { return IsHabitableForHumans(); } }

        public bool Habitable { get { return IsHabitable(); } }

        private WeatherStatusForHumans GetWeatherStatusForHumans()
        {
            return AvgTemperature.IsBetween(MinLivableTemperature, MaxLivableTemperature) ? WeatherStatusForHumans.Great : WeatherStatusForHumans.Terrible;
        }

        private bool IsHabitable()
        {
            return _chanceToLive >= SuccessSurvivalRate && Classification is Classification.Rocky;
        }

        private bool IsHabitableForHumans()
        {
            return IsHabitable() &&
                   AvgTemperature.IsBetween(MinLivableTemperature, MaxLivableTemperature) &&
                   AtmosphericPressure.IsBetween(MinLivableAtmosphericPressure, MaxLivableAtmosphericPressure);
        }

        public override string ToString()
        {
            return "\nPlanet Details:\n" +
                   $"Name: {Name}\n" +
                   $"Avg Temperature: {AvgTemperature}\n" +
                   $"Atmospheric Pressure: {AtmosphericPressure}\n" +
                   $"Classification: {Classification}\n" +
                   $"Weather Status For Humans: {WeatherStatusForHumans}\n" +
                   $"Main Color: {MainColor}\n" +
                   $"Habitable For Humans: {HabitableForHumans}\n" +
                   $"Habitable: {Habitable}\n" +
                   $"{Inhabitant}";
        }
    }
}
