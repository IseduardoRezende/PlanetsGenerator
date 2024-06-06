using PlanetsGenerator.Enums.Inhabitants;

namespace PlanetsGenerator.Interfaces
{
    public interface IRationalInhabitantBuilder : IInhabitantBuilder
    {
        IRationalInhabitantBuilder BuildSocietiesStatus(params SocietyStatus[] societiesStatus);
    }
}
