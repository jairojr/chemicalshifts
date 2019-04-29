using AutoMapper;
using ChemicalShifts.API.ViewModel;
using ChemicalShifts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChemicalShifts.API.AutoMapper
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public override string ProfileName => "DomainToViewModelMappings";

        /// <summary>
        /// 
        /// </summary>
        private Action<IMapperConfigurationExpression> _expression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Action<IMapperConfigurationExpression> Expression
        {
            get
            {
                return this._expression;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DomainToViewModelMappingProfile()
        {
            _expression = (cfg =>
            {
                cfg.CreateMap<User, UserViewModel>();
            });
        }
    }
}
