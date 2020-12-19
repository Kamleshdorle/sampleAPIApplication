using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleAPIApplication.Model;
using SampleAPIApplication.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SampleAPIApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestRepository _testRepository;

        public TestController(ILogger<TestController> logger, ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        [HttpGet("ValidateString")]
        public async Task<TestModel> ValidateString(string inputString)
        {
            return await _testRepository.ValidateAlphabates(inputString);
        }
    }
}
