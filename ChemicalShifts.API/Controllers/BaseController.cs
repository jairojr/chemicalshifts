using AutoMapper;
using ChemicalShifts.Infra.Data.Root;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace ChemicalShifts.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        /// <summary>
        /// BaseContext
        /// </summary>
        public BaseContext _baseContext { get; set; }

        public IMapper _mapper { get; set; }

        /// <summary>
        /// IConfiguration
        /// </summary>
        public IConfiguration _iConfiguration { get; set; }

        public BaseController(BaseContext baseContext, IMapper mapper, IConfiguration iConfiguration)
        {
            _baseContext = baseContext;
            _mapper = mapper;
            _iConfiguration = iConfiguration;
        }
    }
}