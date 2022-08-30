using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using task3_2controlers.Model;
using task3_2controlers.repo;

namespace task3_2controlers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompController : ControllerBase
    {
        public ICompanyInterface _compService;

        public CompController(ICompanyInterface compService)
        {
            _compService = compService;
        }


        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_compService);
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {

            return Ok(_compService.Getbyid(id));

        }


        [HttpPost]
        public IActionResult Addcompany(companys company)

        {
            
            return Ok(_compService.Addcompany(company));
        }
        [HttpPut]
        public IActionResult updatecompany(companys request)

        {

            return Ok(_compService.updatecompany(request));

        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok(_compService.Delete(id));
        }
    }





}






