using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ChemicalShifts.Domain.Entities;
using ChemicalShifts.Infra.Data.Root;
using ChemicalShifts.Services.Services;
using ChemicalShifts.Services.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ChemicalShifts.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    public class MonosaccharideUnitController : BaseController
    {
        private MonosaccharideUnitService _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseContext"></param>
        /// <param name="mapper"></param>
        /// <param name="iConfiguration"></param>
        public MonosaccharideUnitController(BaseContext baseContext, IMapper mapper, IConfiguration iConfiguration) : base(baseContext, mapper, iConfiguration)
        {
            _service = new MonosaccharideUnitService(baseContext);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] MonosaccharideUnit item)
        {
            try
            {
                _service.Create<MonosaccharideUnitValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put([FromBody] MonosaccharideUnit item)
        {
            try
            {
                _service.Update<MonosaccharideUnitValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(_service.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return new ObjectResult(_service.GetById(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}