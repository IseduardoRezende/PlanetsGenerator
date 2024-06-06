using PlanetsGenerator.Enums.Inhabitants;

namespace PlanetsGenerator.Entities
{
    public class Inhabitant
    {
        private const double FailureRationalityRate = 0.70;

        private readonly double _chanceToBeRational = Random.Shared.NextDouble();
        
        public string Name { get; set; } = string.Empty;

        public BeingType BeingType { get { return GetBeingType(); } }
       
        public Characteristic[] Characteristics { get; set; } = Array.Empty<Characteristic>();        

        private BeingType GetBeingType()
        {
            return _chanceToBeRational >= FailureRationalityRate 
                ? BeingType.Rational 
                : BeingType.Irrational; 
        }

        public override string ToString()
        {
            return "\nInhabitant Details:\n" +
                   $"Name: {Name}\n" +
                   $"Being Type: {BeingType}\n" +
                   $"Characteristics: {string.Join(", ", Characteristics)}\n";
        }
    }
}
