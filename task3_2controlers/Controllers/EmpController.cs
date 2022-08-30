using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task3_2controlers.Model;
using task3_2controlers.repo;

namespace task3_2controlers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        public IEmployeInterface __empService;


        public EmpController(IEmployeInterface empService)
        {
            __empService = empService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(__empService);
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {

            return Ok(__empService.GetbyId(id));

        }


        [HttpPost]
        public IActionResult Addcompany(employe employes)
        {
            
            return Ok(__empService.Addemploye(employes));
        }
        [HttpPut]
        public IActionResult updateemploye(employe request)

        {

            return Ok(__empService.updatecompany(request));


        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {


            return Ok(__empService.Delete(id));
        }
    }





}
    

