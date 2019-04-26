using AutoMapper;
using ChemicalShifts.API.ViewModel;
using ChemicalShifts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChemicalShifts.API.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, User>();
        }
    }
}
