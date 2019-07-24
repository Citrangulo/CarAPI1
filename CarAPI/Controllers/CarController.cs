using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CarAPI.Domain;
using CarAPI.Repository.Interfaces;
using CarAPI.Domain.Entities;
using CarAPI.Services;
using CarAPI.Services.Interfaces;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarServices _carServices;
        private readonly ILogger<CarController> _logger;
        public CarController(ICarServices carServices, ILogger<CarController> logger)
        {
            _carServices =  carServices;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            try
            {
                _logger.LogInformation("Received get request");

                return Ok(_carServices.List());
            }
            catch(Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("{key}")]
        public ActionResult<Car> Get([FromRoute] Guid key)
        {
            try
            {
                _logger.LogInformation("Received get request");

                return Ok(_carServices.FindByKey(key));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] Car car)
        {
            try
            {
                _logger.LogInformation("Received get request");
                if (ModelState.IsValid)
                {
                    _carServices.Add(car);

                    return Ok("Success");
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}
