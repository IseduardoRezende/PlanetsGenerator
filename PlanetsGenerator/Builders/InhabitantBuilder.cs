﻿using PlanetsGenerator.Entities;
using PlanetsGenerator.Enums.Inhabitants;
using PlanetsGenerator.Interfaces;

namespace PlanetsGenerator.Builders
{
    public class InhabitantBuilder : IInhabitantBuilder
    {
        protected readonly Inhabitant _inhabitant = new();        

        public IInhabitantBuilder BuildCharacteristics(params Characteristic[] characteristics)
        {
            _inhabitant.Characteristics = characteristics;
            return this;
        }

        public IInhabitantBuilder BuildName(string name)
        {
            _inhabitant.Name = name;
            return this;
        }        

        public virtual Inhabitant GetInhabitant()
        {
            return _inhabitant;
        }
    }
}
