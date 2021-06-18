﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAPI.Controllers
{
    [ApiController]
    [Route("api/flats")]
    public class FlatController : Controller
    {
        // need to add dto
        [HttpPost]
        public ActionResult AddNewFlat()
        {
            return Ok();
        }

        [HttpGet]
        public ActionResult GetAllFlats()
        {
            return NoContent();
        }

        [HttpGet("free")]
        public ActionResult GetFreeFlats() 
        {
            return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleFlat([FromRoute]int id) {
            return NoContent();
        }

        [HttpPost("{flatId}/apply")]
        public ActionResult ApplyFlatForTenant([FromRoute]int flatId, [FromQuery]int tenantId, [FromQuery]string chosen) {
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveFlat([FromRoute]int id) {
            return Ok();
        }
}
}