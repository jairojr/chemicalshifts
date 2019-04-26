using AutoMapper;
using ChemicalShifts.API.ViewModel;
using ChemicalShifts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChemicalShifts.API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToViewModelMappings";

        private Action<IMapperConfigurationExpression> _expression { get; set; }

        public Action<IMapperConfigurationExpression> Expression
        {
            get
            {
                return this._expression;
            }
        }
        public DomainToViewModelMappingProfile()
        {
            _expression = (cfg =>
            {
                cfg.CreateMap<User, UserViewModel>();
            });
        }
    }
}
