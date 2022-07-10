using System;
using System.Collections.Generic;

namespace DataFillWebAPI
{

	public class PersonRepository // nu mai zici clasa de actiuni crud ci repository
	{
		public Person[] GetAllPersons()
		{
			List<Person> list = new List<Person>();
			Person p = new Person();
			p.Name = "Popescu";
			p.Age = 52;
			p.Id = 1;

			list.Add(p);

			p = new Person();
			p.Name = "Ionescu";
			p.Age = 35;
			p.Id = 2;

			list.Add(p);

			return list.ToArray();
		}

		public bool DeletePerson(long id)
		{
			return true;
		}

	}
}
