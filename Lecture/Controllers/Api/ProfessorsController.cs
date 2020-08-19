﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lecture.Controllers.Api
{
    [Route("api/Professors")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        // GET: api/<ProfessorsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProfessorsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProfessorsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProfessorsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfessorsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
