using PlanetsGenerator.Enums.Inhabitants;

namespace PlanetsGenerator.Entities
{
    public class Inhabitant
    {
        private const double SuccessRationalityRate = 0.95;

        private readonly double _chanceToBeRational = Random.Shared.NextDouble();
        
        private SocietyStatus[] _societiesStatus = Array.Empty<SocietyStatus>();     

        public string Name { get; set; } = string.Empty;

        public BeingType BeingType { get { return GetBeingType(); } }

        public SocietyStatus[] SocietiesStatus
        {
            get
            {
                return _societiesStatus;
            }
            set
            {                               
                if (BeingType is BeingType.Irrational)
                {
                    _societiesStatus = Array.Empty<SocietyStatus>();
                }
                else
                {
                    _societiesStatus = value;
                }                
            }
        }

        public Characteristic[] Characteristics { get; set; } = Array.Empty<Characteristic>();        

        private BeingType GetBeingType()
        {
            return _chanceToBeRational >= SuccessRationalityRate ? BeingType.Rational : BeingType.Irrational; 
        }

        public override string ToString()
        {
            return "\nInhabitant Details:\n" +
                   $"Name: {Name}\n" +
                   $"Being Type: {BeingType}\n" +
                   $"Societies Status: {string.Join(", ", SocietiesStatus)}\n" +
                   $"Characteristics: {string.Join(", ", Characteristics)}\n";
        }
    }
}
