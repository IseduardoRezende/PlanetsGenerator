using PlanetsGenerator.Entities;
using PlanetsGenerator.Enums.Inhabitants;

namespace PlanetsGenerator.Interfaces
{
    public interface IInhabitantBuilder
    {
        IInhabitantBuilder BuildName(string name);

        IInhabitantBuilder BuildSocietiesStatus(params SocietyStatus[] societiesStatus);

        IInhabitantBuilder BuildCharacteristics(params Characteristic[] characteristics);

        Inhabitant GetInhabitant();
    }
}
