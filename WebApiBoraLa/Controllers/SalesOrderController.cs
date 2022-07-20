using ApplicationServicesSO.Data;
using ApplicationServicesSO.Data.Dtos;
using ApplicationServicesSO.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationServicesSO.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SalesOrderController : ControllerBase
    {

        private ApplicationContext _context;
        private IMapper _mapper;

        public SalesOrderController(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("~/SalesOrder/{orderNumber}/{materialNumber}")]
        public IActionResult SalesOrder(string orderNumber, string materialNumber)
        {
            if ((orderNumber != null) && (materialNumber != null))
            {
                return Ok((from t in _context.SalesOrder
                           where t.PlanGoodsIssueDate.Equals("00000000") || t.PlanGoodsIssueDate != null
                           where t.OrderStatus.ToUpper().Equals("ABERTO")
                           where t.OrderNumber.Equals(orderNumber)
                           where t.MaterialNumber.Equals(materialNumber)
                           select t).ToArray());
            }
            return BadRequest();

        }
    }

}
