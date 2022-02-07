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
			TotalPeopleCount = 0
		};


        private readonly ILogger<PeopleController> _logger;

		public PeopleController(ILogger<PeopleController> logger)
		{
			_logger = logger;			
		}

		[HttpGet]
		public People Get()
		{
			try
			{
				string number = System.IO.File.ReadAllText("people.txt");
				people.TotalPeopleCount = int.Parse(number);

			}
			catch (Exception e)
			{
				people.TotalPeopleCount = 789;
			}

			people.YourIpAddr = Request.HttpContext.Connection.RemoteIpAddress.ToString();
			people.TotalPeopleCount++;
			

			// 텍스트 파일에 모든 데이타 한꺼번에 쓰기
			System.IO.File.WriteAllText("people.txt", people.TotalPeopleCount.ToString());

			return people;
		}
	}
}
