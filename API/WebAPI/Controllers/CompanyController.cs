﻿using Application.Company.Commands.CheckIdentityCompany;
using Application.Company.Queries.GetAllCompany;
using Application.Company.Querries.GetDriverFromCompany;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAllCompanies")]
        public async Task<IActionResult> GetAllCompanies()
        {
            var request = new GetAllCompanyQuery();
            return Ok(await _mediator.Send(request));
        }
        [HttpGet("GetAllDriversFromCompany")]
        public async Task<IActionResult> GetDriverFromCompany([FromBody] GetDriverFromCompanyQuery query)
        {
            return Ok(await _mediator.Send(query));
        }
        [HttpPost("CheckIdentityCompany")]
        public async Task<IActionResult> CheckIdentityCompany([FromBody] CheckIdentityCompanyRequest request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
