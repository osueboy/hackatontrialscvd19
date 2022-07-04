using Domain.Dtos.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicalTrialsController : ControllerBase
    {
        private readonly IClinicalTrialUploaderService _uploader;


        public ClinicalTrialsController(IClinicalTrialUploaderService uploader)
        {
            _uploader = uploader;
        }




        [HttpPost("")]
        public async Task<IActionResult> Post([FromForm] UploadTrialsFileRequest request)
        {
            _ = await _uploader.UploadFile(request);
            return Ok();
        }

        [HttpPost("search")]
        public async Task<IActionResult> Post([FromBody] GetTrialsRequest request)
        {
            var response = await _uploader.Get(request);
            return Ok(response);
        }
    }
}
