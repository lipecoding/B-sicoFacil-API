using BásicoFacil.API.DTO.Request;
using BásicoFacil.API.DTO.Response;
using BásicoFacil.API.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BásicoFacil.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly IDataService _dataService;

        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost]
        public async Task<ActionResult<AddDataResponse>> AddData(AddDataRequest request)
        {
            if (request == null)
            {
                return BadRequest("Sem informação.");
            }

            var response = await _dataService.AddData(request);

            return Ok(response);
        }
        [HttpGet]
        public async Task<ActionResult<GetDataResponse>> GetData() 
        { 
            return Ok(_dataService.GetData());
        }
    }
}
