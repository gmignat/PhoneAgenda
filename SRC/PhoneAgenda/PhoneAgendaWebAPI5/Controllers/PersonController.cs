using DataFillWebAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneAgendaWebAPI5.Controllers
{
	//[Route("api/[controller]/[action]")]
	[Route("api/[controller]")]
	[ApiController]
	public class PersonController : ControllerBase
	{
		PersonRepository personRepository = new PersonRepository();

		[HttpGet]
		public Person[] GetAllPersons()
		{
			
			return personRepository.GetAllPersons();
		}

		//[HttpDelete("{id}")]
		[HttpDelete]
		public bool DeletePerson(long id)
		{
			return personRepository.DeletePerson(id);
		}
	}
}
