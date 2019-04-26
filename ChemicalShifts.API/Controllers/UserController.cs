using AutoMapper;
using ChemicalShifts.API.Controllers;
using ChemicalShifts.Domain.Entities;
using ChemicalShifts.Infra.Data.Root;
using ChemicalShifts.Services.Services;
using ChemicalShifts.Services.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

[Produces("application/json")]
[Route("api/Usuario")]
public class UserController : BaseController
{
    private BaseService<User> _service;

    public UserController(BaseContext baseContext, IMapper mapper, IConfiguration iConfiguration) : base(baseContext, mapper, iConfiguration)
    {
        _service = new BaseService<User>(baseContext);
    }

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

    public IActionResult Get(int id)
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