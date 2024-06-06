using PlanetsGenerator.Enums.Inhabitants;

namespace PlanetsGenerator.Entities
{
    public class RationalInhabitant : Inhabitant
    {
        private SocietyStatus[] _societiesStatus = Array.Empty<SocietyStatus>();

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

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Societies Status: {string.Join(", ", SocietiesStatus)}\n";
        }
    }
}
