using BlazorQuiz.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorQuiz.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PeopleController : ControllerBase
    {
        private static People people = new People()
        {
			TotalPeopleCount = 789
		};


        private readonly ILogger<PeopleController> _logger;

		public PeopleController(ILogger<PeopleController> logger)
		{
			_logger = logger;			
		}

		[HttpGet]
		public People Get()
		{
			people.YourIpAddr = Request.HttpContext.Connection.RemoteIpAddress.ToString();
			people.TotalPeopleCount++;
			return people;
		}
	}
}
