using AutoMapper;
using ChemicalShifts.API.Controllers;
using ChemicalShifts.Domain.Entities;
using ChemicalShifts.Infra.Data.Root;
using ChemicalShifts.Services.Services;
using ChemicalShifts.Services.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

/// <summary>
/// 
/// </summary>
[Produces("application/json")]
[Route("api/Usuario")]
public class UserController : BaseController
{
    private BaseService<User> _service;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="baseContext"></param>
    /// <param name="mapper"></param>
    /// <param name="iConfiguration"></param>
    public UserController(BaseContext baseContext, IMapper mapper, IConfiguration iConfiguration) : base(baseContext, mapper, iConfiguration)
    {
        _service = new BaseService<User>(baseContext);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Post([FromBody] User item)
    {
        try
        {
            _service.Create<UserValidator>(item);

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
    public IActionResult Put([FromBody] User item)
    {
        try
        {
            _service.Update<UserValidator>(item);

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