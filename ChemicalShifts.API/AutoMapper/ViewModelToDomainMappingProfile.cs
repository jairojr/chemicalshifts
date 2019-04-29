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
    public class ViewModelToDomainMappingProfile : Profile
    {

        /// <summary>
        /// 
        /// </summary>
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, User>();
        }
    }
}
