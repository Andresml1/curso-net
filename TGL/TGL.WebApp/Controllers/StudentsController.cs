using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TGL.WebApp.Data;
using TGL.WebApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TGL.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        public StudentStore StudentStore { get; set; }
        public StudentsController(StudentStore studentStore)
        {
            StudentStore = studentStore;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            var students = StudentStore.GetStudents();
            return Ok(students);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var student = StudentStore.GetStudents();
            return Ok(student);
        }

        // POST api/<controller>  ---->Agregar
        [HttpPost]
        public IActionResult Post([FromBody]Student student)
        {
            StudentStore.AddStudent(student);
            return Ok();
        }

        // PUT api/<controller>/5 ---> Actualizacion
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]Student student)
        {
            StudentStore.EditStudent(student);
            return Ok();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            StudentStore.DeleteStudent(id);
            return Ok();
        }
    }
}
