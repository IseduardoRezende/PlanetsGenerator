using PlanetsGenerator.Entities;
using PlanetsGenerator.Enums.Inhabitants;
using PlanetsGenerator.Interfaces;

namespace PlanetsGenerator.Builders
{
    public class RationalInhabitantBuilder : InhabitantBuilder, IRationalInhabitantBuilder
    {
        private RationalInhabitant _rationalInhabitant = new();

        public IRationalInhabitantBuilder BuildSocietiesStatus(params SocietyStatus[] societiesStatus)
        {
            _rationalInhabitant.SocietiesStatus = societiesStatus;
            return this;
        }

        public override Inhabitant GetInhabitant()
        {
            _rationalInhabitant.Name = _inhabitant.Name;
            _rationalInhabitant.Characteristics = _inhabitant.Characteristics;
            return _rationalInhabitant;
        }
    }
}
