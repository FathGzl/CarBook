﻿using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarPricingWithCars")]
        public async Task<IActionResult> GetCarPricingWithCars()
        {
            var values = await _mediator.Send(new GetCarPricingWithCarsQuery());
            return Ok(values);
        }

        [HttpGet("GetCarPricingWithTimePeriods")]
        public async Task<IActionResult> GetCarPricingWithTimePeriods()
        {
            var values = await _mediator.Send(new GetCarPricingWithTimePeriodQuery());
            return Ok(values);
        }
    }
}