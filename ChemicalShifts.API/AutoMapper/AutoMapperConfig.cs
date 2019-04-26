using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChemicalShifts.API.AutoMapper
{
    public class AutoMapperConfig
    {
        private IMapper _mapper;

        public IMapper Mapper
        {
            get
            {
                return this._mapper;
            }
        }

        public AutoMapperConfig()
        {
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<DomainToViewModelMappingProfile>();
                c.AddProfile<ViewModelToDomainMappingProfile>();
            });

            this._mapper = config.CreateMapper();
        }
    }
}
