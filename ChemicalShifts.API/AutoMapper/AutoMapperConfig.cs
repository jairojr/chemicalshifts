using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChemicalShifts.API.AutoMapper
{
    /// <summary>
    /// 
    /// </summary>
    public class AutoMapperConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public IMapper Mapper { get; }

        /// <summary>
        /// 
        /// </summary>
        public AutoMapperConfig()
        {
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<DomainToViewModelMappingProfile>();
                c.AddProfile<ViewModelToDomainMappingProfile>();
            });

            this.Mapper = config.CreateMapper();
        }
    }
}
